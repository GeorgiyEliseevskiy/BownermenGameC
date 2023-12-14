using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BowmenGame
{
    // Класс, представляющий игровой движок
    public class Engine
    {
        // Экземпляр данных игрока
        public GamerData GamerData;

        // Коллекция кнопок целевого ряда
        public List<CellButton> GoalRow;

        // Событие, вызываемое при завершении игры
        public event Action<GamerData> GameFinished;

        // Флаг, указывающий на завершение игры
        public bool gameIsFinished = false;

        // Флаг, указывающий, что один из лучников выбран для хода
        public bool oneOfTheBowmenIsChecked = false;

        // Цвета команд
        public readonly Color WhiteTeamColor = Color.SandyBrown;
        public readonly Color BlackTeamColor = Color.FromArgb(128, 64, 0);

        // Экземпляры данных игроков
        private readonly GamerData _gamerWhite;
        private readonly GamerData _gamerBlack;

        // Коллекции клеток, верхнего и нижнего рядов, линий на игровом поле
        private readonly List<CellButton> _cells;
        private readonly List<CellButton> _upperRow;
        private readonly List<CellButton> _downRow;
        private readonly List<(CellButton, CellButton)> _lines;

        // Конструктор класса Engine
        public Engine(List<CellButton> cells, List<CellButton> upperRow, List<CellButton> downRow, List<(CellButton, CellButton)> lines)
        {
            _cells = cells;
            _upperRow = upperRow;
            _downRow = downRow;
            _lines = lines;

            // Создание данных для команд
            _gamerWhite = new GamerData
            {
                TeamColor = WhiteTeamColor,
                EnemyColor = BlackTeamColor
            };
            _gamerWhite.TeamDefeat += gamer =>
                GameFinished(GamerData.TeamColor == _gamerWhite.TeamColor ? _gamerBlack : _gamerWhite);

            _gamerBlack = new GamerData
            {
                TeamColor = BlackTeamColor,
                EnemyColor = WhiteTeamColor
            };
            _gamerBlack.TeamDefeat += gamer =>
                GameFinished(GamerData.TeamColor == _gamerWhite.TeamColor ? _gamerBlack : _gamerWhite);

            // Инициализация данных игрока
            GamerData = _gamerWhite;
            GoalRow = _upperRow;
        }

        // Включение доступности для всех ячеек
        public void EnableAllCells()
        {
            foreach (var cell in _cells)
                cell.Enabled = true;
        }

        // Отключение недоступных ячеек для перемещения лучника
        public void DisableUnreachableCells(CellButton sender)
        {
            foreach (var cell in _cells)
                if (cell.Id != sender.Id)
                    cell.Enabled = false;

            List<CellButton> accessibleCells = _lines
                .Where(x => x.Item1.Id == sender.Id || x.Item2.Id == sender.Id) // Отбираем линии, которые соединяются с выбранной ячейкой
                .Select(x => (x.Item1.Id == sender.Id) ? x.Item2 : x.Item1) // Находим ячейки, связанные с выбранной ячейкой
                .Where(x => x.BackColor == Color.White) // Выбираем только незанятые своими же лучниками ячейки
                .ToList();

            foreach (var cell in accessibleCells)
            {
                cell.Enabled = true;
                cell.BackColor = Color.Green;
            }
        }

        // Отключение доступных ячеек после перемещения лучника
        public void DisableReachableCells(CellButton sender)
        {
            foreach (var cell in _cells)
                if (cell.Id != sender.Id)
                    cell.Enabled = false;

            List<CellButton> accessibleCells = _lines
                .Select(x => x.Item2)
                .Where(x => x.BackColor == Color.Green)
                .ToList();

            foreach (var cell in accessibleCells)
            {
                cell.Enabled = false;
                cell.BackColor = Color.White;
            }
        }

        // Выполнение хода по выбранной ячейке
        public void DoStep(CellButton newPos)
        {
            EnableAllCells();
            ClearPastBowmanPosition();

            if (IsSuicideStep(newPos))
                DoSuicideStep();
            else
                DoPlainStep(newPos);
        }

        // Очистка предыдущей позиции лучника
        public void ClearPastBowmanPosition()
        {
            CellButton oldPos = null;
            foreach (var cell in _cells)
                if (cell.IsChecked) oldPos = cell;

            oldPos.BackgroundImage = null;
            oldPos.BackColor = Color.White;
            oldPos.IsChecked = false;
        }

        // Проверка на ход суицида (проигрышный ход)
        private bool IsSuicideStep(CellButton newPos)
        {
            CellButton nearestEnemyBowman = _lines
                .Where(x => x.Item1.Id == newPos.Id || x.Item2.Id == newPos.Id) // Отбираем линии, которые соединяются с выбранной ячейкой
                .Select(x => (x.Item1.Id == newPos.Id) ? x.Item2 : x.Item1) // Находим ячейки, которые связаны с выбранной ячейкой
                                                                            // Из них выбираем только те, что не находятся на вражеском GoalRow, так как те безобидны
                .Where(x => !(GoalRow == _upperRow ? _downRow : _upperRow).Contains(x))
                .FirstOrDefault(x => x.BackColor == GamerData.EnemyColor); // Если хотя бы одна ячейка имеет вражеский цвет, ход - самоубийственный

            return nearestEnemyBowman != null; // Если вернулся null, то лучник не вышел на линию огня противника
        }

        // Выполнение хода-суицида
        private void DoSuicideStep()
        {
            GamerData.AliveBowmenCount_Decrement();
            SwitchToAnotherPlayer(); // На одного живого лучника меньше
        }

        // Выполнение обычного хода
        private void DoPlainStep(CellButton newPos)
        {
            // Установка цвета фона для новой ячейки в цвет команды игрока (GamerData.TeamColor)
            newPos.BackColor = GamerData.TeamColor;

            // Проверка, находится ли новая ячейка в целевой строке (GoalRow)
            if (GoalRow.Contains(newPos))
            {
                // Попытка воскресить одного лучника после успешного выполнения хода в целевой строке
                TryReviveOneBowman();
            }

            // Переключение на другого игрока
            SwitchToAnotherPlayer();
        }

        // Попытка воскресить одного лучника
        private void TryReviveOneBowman()
        {
            // Определение строки, противоположной GoalRow
            var teamRow = (GoalRow == _upperRow) ? _downRow : _upperRow;

            // Перебор ячеек в определенной строке (teamRow)
            foreach (CellButton cell in teamRow)
            {
                // Если цвет фона ячейки белый
                if (cell.BackColor == Color.White)
                {
                    // Проверка на "суицид" и наличие свободных мест для лучников
                    if (!IsSuicideStep(cell) && GamerData.GetAliveBowmenCount() < GamerData.BowmenWinCount)
                    {
                        // Воскрешение лучника: изменение цвета фона, увеличение счетчика живых лучников
                        cell.BackColor = GamerData.TeamColor;
                        GamerData.AliveBowmenCount_Increment();
                        return;  // Завершение метода после успешного воскрешения
                    }
                }
            }

            // Проверка условия победы после попытки воскресить лучника
            CheckOnWinStatement();
        }


        // Метод для проверки условия победы
        private void CheckOnWinStatement()
        {
            int teammatesOnGoalRowCount = 0;

            // Перебор ячеек в целевой строке (GoalRow)
            foreach (CellButton cell in GoalRow)
            {
                // Увеличение счетчика, если цвет фона ячейки совпадает с цветом команды игрока (GamerData.TeamColor)
                if (cell.BackColor == GamerData.TeamColor)
                    teammatesOnGoalRowCount++;
            }

            // Обновление счетчика выживших лучников в GamerData
            GamerData.BowmenWinCount = GamerData.GetAliveBowmenCount();

            // Если количество союзников в целевой строке совпадает с количеством выживших лучников
            if (teammatesOnGoalRowCount == GamerData.BowmenWinCount)
            {
                // Завершение игры и передача данных об игроке, соответствующего условию победы
                GameFinished(GamerData);
            }
        }

        // Оценочная функция для хода ИИ
        int EvalFunc(CellButton newPos)
        {
            int val = 0;

            // Уменьшение оценки, если ход является "суицидом" (ведет к потере)
            if (IsSuicideStep(newPos))
                val -= 15;

            // Перебор каждой пары CellButton в _lines
            foreach ((CellButton, CellButton) pair in _lines)
            {
                // Если первая ячейка пары равна newPos
                if (pair.Item1 == newPos)
                {
                    val += 1;  // Увеличение оценки за наличие соединения

                    // Если вторая ячейка пары находится в целевой строке, увеличение оценки
                    if (GoalRow.Contains(pair.Item2))
                    {
                        val += 3;
                    }

                    // Уменьшение оценки, если вторая ячейка пары имеет определенный цвет фона
                    if (pair.Item2.BackColor == Color.FromArgb(128, 64, 0) || pair.Item2.BackColor == Color.SandyBrown)
                        val -= 1000;

                    // Увеличение оценки, если первая ячейка пары находится в целевой строке
                    if (GoalRow.Contains(pair.Item1))
                        val += 4;
                }
            }

            return val;  // Возврат общей оценки позиции
        }

        // Реализация алгоритма минимакса для хода ИИ
        private (CellButton, CellButton) MiniMax(bool side, int alpha, int beta)
        {
            // Инициализация переменных для отслеживания лучшего хода и оценочных баллов
            string tmpIdPar = "", tmpIdChild = "";
            int maxEval = -1000, minEval = 1000;
            int tmpEval;
            bool path = true;  // Индикатор выбранного пути в игровом дереве

            // Итерация по каждой паре CellButton в _lines
            foreach ((CellButton, CellButton) pair in _lines)
            {
                // Проверка, чей сейчас ход (side == true)
                if (side)
                {
                    // Оценка второй ячейки пары, если первая ячейка имеет определенный цвет фона
                    if (pair.Item1.BackColor == Color.FromArgb(128, 64, 0))
                    {
                        tmpEval = EvalFunc(pair.Item2);  // Оценка состояния игры
                        if (maxEval < tmpEval)
                        {
                            // Обновление лучшего хода и оценочного балла
                            maxEval = tmpEval;
                            tmpIdChild = pair.Item2.Id;
                            tmpIdPar = pair.Item1.Id;
                            path = true;  // Индикация выбранного пути в игровом дереве
                        }
                    }
                    // Оценка первой ячейки пары, если вторая ячейка имеет определенный цвет фона
                    if (pair.Item2.BackColor == Color.FromArgb(128, 64, 0))
                    {
                        tmpEval = EvalFunc(pair.Item1);  // Оценка состояния игры
                        if (maxEval < tmpEval)
                        {
                            // Обновление лучшего хода и оценочного балла
                            maxEval = tmpEval;
                            tmpIdChild = pair.Item1.Id;
                            tmpIdPar = pair.Item2.Id;
                            path = false;  // Индикация альтернативного пути в игровом дереве
                        }
                    }

                    // Обновление значений alpha и beta для обрезки
                    if (alpha < maxEval)
                        alpha = maxEval;
                    if (beta <= alpha)
                        break;  // Обрезка beta: прекращение поиска ветви, если она не обещает успеха
                }
                else  // Если сейчас ход оппонента
                {
                    // Аналогичная логика для оценки и обновления лучшего хода и балла для оппонента
                    if (pair.Item1.BackColor == Color.SandyBrown)
                    {
                        tmpEval = 0 - EvalFunc(pair.Item2);  // Инверсия оценки для оппонента
                        if (minEval > tmpEval)
                        {
                            minEval = tmpEval;
                            tmpIdChild = pair.Item2.Id;
                            tmpIdPar = pair.Item1.Id;
                            path = true;
                        }
                    }
                    if (pair.Item2.BackColor == Color.SandyBrown)
                    {
                        tmpEval = 0 - EvalFunc(pair.Item1);
                        if (minEval > tmpEval)
                        {
                            minEval = tmpEval;
                            tmpIdChild = pair.Item1.Id;
                            tmpIdPar = pair.Item2.Id;
                            path = false;
                        }
                    }

                    // Обновление значений alpha и beta для обрезки
                    if (beta > minEval)
                        beta = minEval;
                    if (beta <= alpha)
                        break;  // Обрезка alpha: прекращение поиска ветви, если она не обещает успеха
                }
            }

            // Поиск и возврат выбранного хода на основе выявленного пути
            foreach ((CellButton, CellButton) pair in _lines)
            {
                if (path)
                {
                    if (pair.Item1.Id == tmpIdPar && pair.Item2.Id == tmpIdChild)
                    {
                        return (pair.Item1, pair.Item2);
                    }
                }
                else
                {
                    if (pair.Item2.Id == tmpIdPar && pair.Item1.Id == tmpIdChild)
                    {
                        return (pair.Item2, pair.Item1);
                    }
                }
            }

            // Возврат null, если ход не найден (в хорошей реализации игры не должно дойти до этой точки)
            return (null, null);
        }


        // Переключение на другого игрока
        private void SwitchToAnotherPlayer()
        {
            GamerData = (GamerData.TeamColor == _gamerWhite.TeamColor) ? _gamerBlack : _gamerWhite;
            GoalRow = (GoalRow == _upperRow) ? _downRow : _upperRow;
        }
    }
}
