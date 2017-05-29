using System.Windows.Forms;

namespace sharpInterferometer
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Диалоговое окно сохранения
        /// </summary>
        private static readonly SaveFileDialog SaveFileDialog = new SaveFileDialog
                                                                    {
                                                                        Filter =
                                                                            @"Project file (*.intproj)|*.intproj",
                                                                        FilterIndex = 1,
                                                                        RestoreDirectory = true,
                                                                    };

        /// <summary>
        /// Диалоговое окно открытия
        /// </summary>
        private static readonly OpenFileDialog OpenFileDialog = new OpenFileDialog
                                                                    {
                                                                        Filter =
                                                                            @"Project file (*.intproj)|*.intproj|All files (*.*)|*.*",
                                                                        FilterIndex = 1,
                                                                        RestoreDirectory = true,
                                                                    };
        
        /// <summary>
        /// Конструктор, устанавливает указатель на область рисования классу Field
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Interferometer.Field.PictureBox = fieldView;
        }

        /// <summary>
        /// Показывает окно настройки источников.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void SourcesButtonClick(object sender, System.EventArgs e)
        {
            Program.SourcesForm.Show();
        }

        /// <summary>
        /// Показывает окно настройки экранов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void ScreensButtonClick(object sender, System.EventArgs e)
        {
            Program.ScreensForm.Show();
        }

        /// <summary>
        /// Показывает окно «О программе»
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void AboutButtonClick(object sender, System.EventArgs e)
        {
            Program.AboutBox.ShowDialog();
        }

        /// <summary>
        /// Сохраняет проект
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void SaveButtonClick(object sender, System.EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() != DialogResult.OK) return;
            var stream = SaveFileDialog.OpenFile();
            Interferometer.Field.Save(stream);
            stream.Close();
        }

        /// <summary>
        /// Открывает проект, прячет окна источников и экранов, перерисовывает рабочее поле
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void LoadButtonClick(object sender, System.EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() != DialogResult.OK) return;
            var stream = OpenFileDialog.OpenFile();
            try
            {
                Interferometer.Field.Load(stream);
            }
            catch (System.FormatException)
            {
                MessageBox.Show(@"Invalid file format",@"Error");
            }
            stream.Close();
            Program.SourcesForm.Hide();
            Program.ScreensForm.Hide();
            Interferometer.Field.DrawField();
        }

        /// <summary>
        /// Перерисовка рабочего поля при изменении размера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainFormResize(object sender, System.EventArgs e)
        {
            Interferometer.Field.PictureBox = fieldView;
            Interferometer.Field.DrawField();
        }
        
    }
}

