using System;
using System.Windows.Forms;

namespace StarWars
{
    /// <summary>Класс программы</summary>
    internal static class Program
    {
        /// <summary>Точка входа в программу</summary>
        [STAThread]
        private static void Main()
        {
            #region Активация стилей оформления пользовательского интерфейса для приложения Win-Forms
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            #endregion

            // Создаём главную форму
            StarWarsForm game_form = new StarWarsForm
            {
                Width = 1024,
                Height = 768,
                FormBorderStyle = FormBorderStyle.FixedSingle // Запрещаем ей менять свои размеры
            };
            
            Game.Load(game_form);  // Загрузка данных игровой логики
            Game.Init(game_form);  // Инициализация игровой логики

            game_form.Show();      // Показываем форму на экране

            //Game.Draw();         // Отрисовываем кадр

            Application.Run(game_form); // Запускаем процесс обработки очереди сообщений Windows
            
        }
    }
}
