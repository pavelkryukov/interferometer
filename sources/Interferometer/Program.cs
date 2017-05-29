using System;
using System.Windows.Forms;

namespace sharpInterferometer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SourcesForm = new SourcesForm();
            ScreensForm = new ScreensForm();
            FilterForm = new FilterForm();
            AboutBox = new AboutBox();
            try
            {
                Application.Run(new MainForm());
            }
            catch (Exception e)
            {
                // Запрет падения приложения с необработанными ошибками
                MessageBox.Show(e.ToString(), @"Необработанная ошибка");
                return;
            }
        }

        /// <summary>
        /// Форма для работы с источниками
        /// </summary>
        public static SourcesForm SourcesForm;

        /// <summary>
        /// Форма для работы с экранами
        /// </summary>
        public static ScreensForm ScreensForm;

        /// <summary>
        /// Форма «О программе»
        /// </summary>
        public static AboutBox AboutBox;

        /// <summary>
        /// Форма для работы с фильтрами
        /// </summary>
        public static FilterForm FilterForm;
    }
}
