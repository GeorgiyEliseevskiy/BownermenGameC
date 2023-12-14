using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BowmenGame
{
    // Класс, представляющий пользовательский элемент управления - кнопку ячейки на игровом поле
    public class CellButton : Button
    {
        // Уникальный идентификатор ячейки
        public string Id { get; private set; }

        // Флаг, указывающий, была ли ячейка выбрана
        public bool IsChecked { get; set; } = false;

        // Список координат связанных ячеек
        public List<Point> LinkedCells { get; set; }

        // Ссылка на владельца (форму BattlefieldForm)
        private readonly BattlefieldForm _owner;

        // Конструктор класса CellButton
        public CellButton(string id, BattlefieldForm owner) : base()
        {
            // Инициализация идентификатора и владельца
            Id = id;
            _owner = owner;
        }

        // Метод для отрисовки кнопки в форме круга
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath grObject = new GraphicsPath();
            grObject.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(grObject);

            base.OnPaint(pevent);
        }

        // Обработчик события клика по кнопке
        protected override void OnClick(EventArgs e)
        {
            // Если эта ячейка не выбрана и одна из ячеек уже выбрана,
            // то игрок делает ход
            if (!IsChecked && _owner.Engine.oneOfTheBowmenIsChecked)
            {
                _owner.Engine.EnableAllCells();
                _owner.Engine.DisableReachableCells(this);
                _owner.Engine.EnableAllCells();
                _owner.Engine.DoStep(this);
                _owner.Engine.doStepAI(true);
                _owner.Engine.oneOfTheBowmenIsChecked = false;
            }
            // Если эта ячейка не выбрана,
            // то игрок нажал на пустую ячейку
            else if (!IsChecked)
            {
                // Если эта ячейка занята лучником игрока, который сейчас ходит,
                // то игрок выбрал лучника для хода
                if (this.BackColor == _owner.Engine.GamerData.TeamColor)
                {
                    this.BackgroundImage = Properties.Resources.BowmanIsChecked;
                    _owner.Engine.DisableUnreachableCells(this);
                    _owner.Engine.oneOfTheBowmenIsChecked = true;
                    IsChecked = true;
                }
            }
            // Если эта ячейка уже была выбрана,
            // то игрок передумал ходить этим лучником
            else if (IsChecked)
            {
                this.BackgroundImage = null;
                _owner.Engine.EnableAllCells();
                _owner.Engine.DisableReachableCells(this);
                _owner.Engine.EnableAllCells();

                _owner.Engine.oneOfTheBowmenIsChecked = false;
                IsChecked = false;
            }

            base.OnClick(e);
        }

        // Обработчик события отпускания кнопки мыши
        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
        }
    }
}
