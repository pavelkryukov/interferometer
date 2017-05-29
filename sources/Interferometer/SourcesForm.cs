using System;
using System.Windows.Forms;
using Interferometer;

namespace sharpInterferometer
{
    public partial class SourcesForm : Form
    {
        public SourcesForm()
        {
            InitializeComponent();  
        }
        
        /// <summary>
        /// Диалоговое окно сохранения
        /// </summary>
        private static readonly OpenFileDialog OpenFileDialog = new OpenFileDialog
                                                                    {
                                                                        Filter =
                                                                            @"Spectrum files (*.spc)|*.spc|All files (*.*)|*.*",
                                                                        FilterIndex = 1,
                                                                        RestoreDirectory = true,
                                                                    };

        /// <summary>
        /// Диалоговое окно загрузки
        /// </summary>
        private static readonly SaveFileDialog SaveFileDialog = new SaveFileDialog
                                                                    {
                                                                        Filter =
                                                                            @"Spectrum files (*.spc)|*.spc",
                                                                        FilterIndex = 1,
                                                                        RestoreDirectory = true,
                                                                    };


        /// <summary>
        /// Перерисовка списка источников с сохранением выделения
        /// </summary>
        private void ListSourcesRedraw()
        {
            var buffer = listSources.SelectedIndex;
            listSources.Items.Clear();
            foreach (var it in Field.SourcesList)
            {
                listSources.Items.Add(it);
            }
            if (listSources.Items.Count > 0)
            {
                if (buffer == -1) buffer = 0;
                listSources.SelectedIndex = buffer < listSources.Items.Count ? buffer : buffer - 1;
                propertiesBox.Enabled = true;
            }
            else
            {
                propertiesBox.Enabled = false;
            }
        }

        /// <summary>
        /// Перерисовка списка волновых компонент.
        /// </summary>
        private void ListWavesRedraw()
        {
            var buffer = listWaves.SelectedIndex;
            listWaves.Items.Clear();
            foreach (var it in Field.WavesList)
            {
                listWaves.Items.Add(it);
            }
            if (listWaves.Items.Count > 0)
            {
                listWaves.SelectedIndex = buffer < listWaves.Items.Count ? buffer : buffer - 1;
                wavePropBox.Enabled = true;
            }
            else
            {
                wavePropBox.Enabled = false;
            }
        }

       
        /// <summary>
        /// Добавление источника с последующим выделением
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSourceButtonClick(object sender, EventArgs e)
        {
            Field.AddSource();
            ListSourcesRedraw();
            listSources.SelectedIndex = listSources.Items.Count - 1;
        }

        /// <summary>
        /// Загрузка источника из файла с добавлением
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadButtonClick(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() != DialogResult.OK) return;
            var stream = OpenFileDialog.OpenFile();
            try
            {
                Field.AddSource(stream);
            }
            catch (Exception)
            {
                MessageBox.Show(@"Invalid file format", @"File error");
            }
            stream.Close();
            ListSourcesRedraw();
            listSources.SelectedIndex = listSources.Items.Count - 1;
        }

        /// <summary>
        /// Сохранение выбранного источника в файл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void SaveButtonClick(object sender, EventArgs e)
        {
            if (SaveFileDialog.ShowDialog() != DialogResult.OK) return;
            var stream = SaveFileDialog.OpenFile();
            Field.SaveSource(stream);
            stream.Close();
        }
        
        /// <summary>
        /// Удаление выбранного источника
        /// Выделяется нулевой источник, если таковой есть
        /// или происходит вызов метода listSources_SelectedIndexChanged, если нет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButtonClick(object sender, EventArgs e)
        {
            Field.DeleteSource();
            ListSourcesRedraw();
            if (listSources.Items.Count > 0)
                listSources.SelectedIndex = 0;
            else
                ListSourcesSelectedIndexChanged(this, e);
        }

        /// <summary>
        /// Добавление волновой компоненты с последующим выделением
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWaveButtonClick(object sender, EventArgs e)
        {
            Field.AddWave();
            ListWavesRedraw();
            listWaves.SelectedIndex = listWaves.Items.Count - 1;
        }

        /// <summary>
        /// Удаление волновой компоненты.
        /// Подобно удалению источника.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteWaveButtonClick(object sender, EventArgs e)
        {
            Field.DeleteWave();
            ListWavesRedraw();
            if (listWaves.Items.Count > 0)
                listWaves.SelectedIndex = 0;
            else
                ListSourcesSelectedIndexChanged(this, e);
        }
        
        /// <summary>
        /// Выставление имени источника.
        /// Список источников перерисовывается.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextTextChanged(object sender, EventArgs e)
        {
            Field.InName = nameText.Text;
            ListSourcesRedraw();
        }

        /// <summary>
        /// Настройка координаты X источника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void XTextTextChanged(object sender, EventArgs e)
        {
            try
            {
                Field.InX = UInt32.Parse(xText.Text);
            }
            catch (Exception)
            {
                xText.Text = "";
            }
        }

        /// <summary>
        /// Настройка координаты Y источника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void YTextTextChanged(object sender, EventArgs e)
        {
            try
            {
                Field.InY = UInt32.Parse(yText.Text);
            }
            catch (Exception)
            {
                yText.Text = "";
            }
        }

        /// <summary>
        /// Настройка включенности источника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TurnCheckCheckedChanged(object sender, EventArgs e)
        {
            Field.InTurn = turnCheck.Checked;
        }

        /// <summary>
        /// Настройка длины волны выделенной компоненты
        /// Перерисовывает список волн
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LengthTextTextChanged(object sender, EventArgs e)
        {
            try
            {
                Field.Length = UInt32.Parse(lengthText.Text);
                ListWavesRedraw();
                ShowSpectrum();
            }
            catch (Exception)
            {
                lengthText.Text = "";
            }
        }

        /// <summary>
        /// Настройка пропускания волновой компоненты
        /// Перерисовывает список волн
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeltaTextTextChanged(object sender, EventArgs e)
        {
            try
            {
                Field.Delta = UInt32.Parse(deltaText.Text);
                ListWavesRedraw();
                ShowSpectrum();
            }
            catch (Exception)
            {
                deltaText.Text = "";
            }
        }

        /// <summary>
        /// Настройка амплитуды волновой компоненты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AmpTextTextChanged(object sender, EventArgs e)
        {
            try
            {
                Field.Amplitude = UInt32.Parse(ampText.Text);
                ShowSpectrum();
            }
            catch (Exception)
            {
                ampText.Text = "";
            }
        }

        /// <summary>
        /// Настройка фазы волновой компоненты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PhaseTextTextChanged(object sender, EventArgs e)
        {
            try
            {
                Field.Phase = UInt32.Parse(phaseText.Text);
            }
            catch (Exception)
            {
                phaseText.Text = "";
            }
        }

        /// <summary>
        /// Перерисовка при переоткрытии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SourcesFormActivated(object sender, EventArgs e)
        {
            ListSourcesRedraw();
        }

        /// <summary>
        /// Показ спектра и цвета источника.
        /// </summary>
        private void ShowSpectrum()
        {
            spectrumBox.Image = Field.SpectrumView;
            viewBox.Image = Field.View();
        }

        /// <summary>
        /// Смена выделенного источника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListSourcesSelectedIndexChanged(object sender, EventArgs e)
        {
            if (listSources.Items.Count == 0)
            {
                propertiesBox.Enabled = false;
            }
            else
            {
                // Если есть источники, разрешить запись
                propertiesBox.Enabled = true;

                // Проброс в стат. класс
                Field.ChooseSource(listSources.SelectedIndex);

                // Обновление полей
                xText.Text = Field.InX.ToString();
                yText.Text = Field.InY.ToString();
                turnCheck.Checked = Field.InTurn;
                nameText.Text = Field.InName;

                // Загрузка волновых компонент
                listWaves.Items.Clear();
                foreach (var it in Field.WavesList)
                {
                    listWaves.Items.Add(it);
                }

                // Выделение первой волновой компоненты
                if (listWaves.Items.Count > 0)
                {
                    listWaves.SelectedIndex = 0;
                    wavePropBox.Enabled = true;
                }
                else
                {
                    wavePropBox.Enabled = false;
                }

                // Показ изображений
                ShowSpectrum();
            }
        }

        /// <summary>
        /// Смена выделения волновой компоненты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListWavesSelectedIndexChanged(object sender, EventArgs e)
        {
            if (listWaves.Items.Count == 0)
            {
                wavePropBox.Enabled = false;
            }
            else
            {
                // Если есть одна, разрешить редактирование
                wavePropBox.Enabled = true;
                
                // Проброс в стат.класс
                Field.ChooseWave(listWaves.SelectedIndex);
                
                // Загрузка информации
                lengthText.Text = Field.Length.ToString();
                deltaText.Text = Field.Delta.ToString();
                ampText.Text = Field.Amplitude.ToString();
                phaseText.Text = Field.Phase.ToString();
            }
        }

        /// <summary>
        /// Запрет закрытия окна.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SourcesFormFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }   
    }
}
