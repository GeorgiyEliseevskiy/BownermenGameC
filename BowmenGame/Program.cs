using System;
using System.Windows.Forms;
/*using static System.Net.Mime.MediaTypeNames;*/

namespace BowmenGame
{
    // Статический класс Program, содержащий точку входа в приложение
    static class Program
    {
        // Метод Main, являющийся точкой входа в приложение
        [STAThread]
        static void Main()
        {
            // Включение визуальных стилей приложения
            Application.EnableVisualStyles();

            // Установка совместимого с визуальными стилями отображения текста
            Application.SetCompatibleTextRenderingDefault(false);

            // Попытка запуска приложения с корневой формой (RootForm)
            try { Application.Run(new RootForm()); }
            // Обработка исключений, возникающих в процессе выполнения
            catch { }
        }
    }
}

