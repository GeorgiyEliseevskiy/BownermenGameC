using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace BowmenGame
{
    // Класс, представляющий форму для проведения боя
    public partial class BattlefieldForm : Form
    {
        // Событие, срабатывающее при перезапуске игры
        public event EventHandler GameRebooted;

        // Флаг, указывающий на процесс перезапуска игры
        public bool IsGameRebooting { get; private set; } = false;

        // Экземпляр игрового движка
        public Engine Engine { get; private set; }

        // Коллекции клеток и строк для управления игровым полем
        public List<CellButton> Cells { get; private set; }
        public List<CellButton> UpperRow { get; private set; }
        public List<CellButton> DownRow { get; private set; }
        public List<(CellButton, CellButton)> Lines { get; private set; }

        // Текстовые константы для обозначения цветов команд
        private readonly string white = "БЕЛЫЕ";
        private readonly string black = "ЧЁРНЫЕ";

        // Конструктор формы BattlefieldForm
        public BattlefieldForm()
        {
            // Инициализация компонентов формы (сгенерировано средствами дизайнера)
            InitializeComponent1();

            // Инициализация коллекций строк и клеток
            LinesInit();
            UpperRowInit();
            DownRowInit();
            CreateCellsCollection();

            // Создание экземпляра игрового движка с передачей коллекций
            Engine = new Engine(Cells, UpperRow, DownRow, Lines);

            // Подписка на событие завершения игры и вывод победителя в MessageBox
            Engine.GameFinished += winner => {
                MessageBox.Show($"Победили {(winner.TeamColor == Engine.WhiteTeamColor ? white : black)}!");
                Engine.gameIsFinished = true;
            };
        }

        // Инициализация коллекции строк на игровом поле
        private void LinesInit()
        {
            Lines = new List<(CellButton, CellButton)>
            {
                // Здесь перечислены пары клеток, соединенных линиями (линии представлены с использованием координат клеток)
            };
        }

        // Создание коллекции клеток из элементов управления на форме
        private void CreateCellsCollection()
        {
            Cells = new List<CellButton>();
            foreach (var control in this.Controls)
                if (control is CellButton cell) Cells.Add(cell);
        }

        // Инициализация верхнего ряда клеток
        private void UpperRowInit() => UpperRow = new List<CellButton>
        {
            cell00, cell10, cell20, cell30, cell40
        };

        // Инициализация нижнего ряда клеток
        private void DownRowInit() => DownRow = new List<CellButton>
        {
            cell04, cell14, cell24, cell34, cell44
        };

        // Обработчик события отрисовки формы
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Создание объектов Graphics и Pen для отрисовки линий между клетками
            Graphics graphics = this.CreateGraphics();
            Pen pen = new Pen(Color.Gray, 6);

            // Вызов метода отрисовки линий
            DrawLines(graphics, pen, Lines);
        }

        // Метод для отрисовки линий между клетками
        private void DrawLines(Graphics graphics, Pen pen, List<(CellButton, CellButton)> lines)
        {
            foreach (var line in lines)
                graphics.DrawLine(pen,
                    line.Item1.Location.X + line.Item1.ClientSize.Width / 2f,
                    line.Item1.Location.Y + line.Item1.ClientSize.Height / 2f,
                    line.Item2.Location.X + line.Item2.ClientSize.Width / 2f,
                    line.Item2.Location.Y + line.Item2.ClientSize.Height / 2f
                );
        }

        // Обработчик нажатия на кнопку "Restart Game"
        private void ButtonRestartGame_Click(object sender, EventArgs e)
        {
            // Установка флага перезапуска игры
            IsGameRebooting = true;

            // Скрытие текущей формы
            this.Hide();

            // Вызов события перезапуска игры
            GameRebooted.Invoke(this, e);
        }

        // Метод, сгенерированный дизайнером для инициализации компонентов формы
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BattlefieldForm
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "BattlefieldForm";
            this.Load += new System.EventHandler(this.BattlefieldForm_Load);
            this.ResumeLayout(false);
        }

        // Метод, сгенерированный дизайнером, вызываемый при загрузке формы
        private void BattlefieldForm_Load(object sender, EventArgs e)
        {

        }
    }
}