using System;
using System.Windows.Forms;

namespace BowmenGame
{
    // Класс, представляющий корневую форму приложения
    public partial class RootForm : Form
    {
        // Поле, представляющее форму для проведения боя (экземпляр BattlefieldForm)
        private BattlefieldForm _battlefieldForm;

        // Конструктор класса RootForm
        public RootForm()
        {
            // Инициализация компонентов формы (сгенерировано средствами дизайнера)
            InitializeComponent();

            // Запуск игры при создании формы
            RunGame();
        }

        // Обработчик события закрытия формы BattlefieldForm
        private void BattlefieldForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Приведение отправителя события к типу BattlefieldForm
            var senderForm = sender as BattlefieldForm;

            // Проверка, не происходит ли перезапуск игры
            if (!senderForm.IsGameRebooting)
                this.Close();
        }

        // Обработчик события перезапуска игры
        private void OnGameRebooted(object sender, EventArgs e) => RunGame();

        // Метод для запуска игры
        private void RunGame()
        {
            // Скрытие текущей формы
            this.Hide();

            // Создание экземпляра формы для проведения боя
            _battlefieldForm = new BattlefieldForm();

            // Подписка на событие закрытия формы BattlefieldForm
            _battlefieldForm.FormClosed += BattlefieldForm_FormClosed;

            // Подписка на событие перезапуска игры
            _battlefieldForm.GameRebooted += OnGameRebooted;

            // Отображение формы для проведения боя в виде модального диалога
            _battlefieldForm.ShowDialog();
        }
    }
}