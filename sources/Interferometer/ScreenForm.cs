/*
 * ScreenForm.cs
 * 
 * Павел Крюков, (C) 2011
 */

using System;
using System.Windows.Forms;
using Interferometer;

namespace sharpInterferometer
{
    /// <summary>
    /// Форма-интерфейс для FieldScreensAPI
    /// </summary>
    public partial class ScreensForm : Form
    {
        public ScreensForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Определение разрешения по радиокнопкам
        /// </summary>
        private int Resolution
        {
            get
            {
                return radio500.Checked
                           ? 500
                           : radio1000.Checked
                                 ? 1000
                                 : radio2000.Checked
                                       ? 2000
                                       : radio5000.Checked
                                             ? 5000
                                             : radio10000.Checked
                                                   ? 10000
                                                   : 20000;

            }
        }
       
        /// <summary>
        /// Перерисовка списка экранов с сохранением выделения.
        /// </summary>
        private void UpdateScreensList()
        {
            var buffer = listScreens.SelectedIndex;
            listScreens.Items.Clear();
            foreach (var it in Field.ScreenList)
            {
                listScreens.Items.Add(it);
            }

            // Разрешает редактирование свойств, если есть источники.
            propertiesBox.Enabled = (listScreens.Items.Count != 0);

            // Если при перерисовке есть элементы списка, а фокус не установлен, перерисовываем
            if ((listScreens.Items.Count > 0) && (buffer == -1))
                buffer = 0;

            // Восстанавливаем выделение.
            listScreens.SelectedIndex = buffer < (listScreens.Items.Count - 1) ? buffer : (listScreens.Items.Count - 1);
        }

        /// <summary>
        /// Изменение выбранного источника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListScreensSelectedIndexChanged(object sender, EventArgs e)
        {
            Field.ChooseScreen(listScreens.SelectedIndex);
            x1Text.Text = Field.OutX1.ToString();
            y1Text.Text = Field.OutY1.ToString();
            x2Text.Text = Field.OutX2.ToString();
            y2Text.Text = Field.OutY2.ToString();
            nameText.Text = Field.OutName;
        }

        /// <summary>
        /// Добавление источника с последующим выделением
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddScreenButtonClick(object sender, EventArgs e)
        {
            Field.AddScreen();
            UpdateScreensList();
            
            // Выделяем созданный экран
            listScreens.SelectedIndex = listScreens.Items.Count - 1;
        }
        
        /// <summary>
        /// Удаление выбранного источника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButtonClick(object sender, EventArgs e)
        {
            Field.DeleteScreen();
            UpdateScreensList();
        }

        /// <summary>
        /// Редактирование имени
        /// Вызывает перерисовку списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameTextTextChanged(object sender, EventArgs e)
        {
            Field.OutName = nameText.Text;
            UpdateScreensList();
        }

        /// <summary>
        /// Редактирование координаты X1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void X1TextTextChanged(object sender, EventArgs e)
        {
            try
            {
                Field.OutX1 = UInt32.Parse(x1Text.Text);
            }
            catch (Exception)
            {
                x1Text.Text = "";
            }
        }
        
        /// <summary>
        /// Редактирование координаты Y1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Y1TextTextChanged(object sender, EventArgs e)
        {
            try
            {
                Field.OutY1 = UInt32.Parse(y1Text.Text);
            }
            catch (Exception)
            {
                y1Text.Text = "";
            }
        }

        /// <summary>
        /// Редактирование координаты X2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void X2TextTextChanged(object sender, EventArgs e)
        {
            try
            {
                Field.OutX2 = UInt32.Parse(x2Text.Text);
            }
            catch (Exception)
            {
                x2Text.Text = "";
            }
        }

        /// <summary>
        /// Редактирование координаты Y2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Y2TextTextChanged(object sender, EventArgs e)
        {
            try
            {
                Field.OutY2 = UInt32.Parse(y2Text.Text);
            }
            catch (Exception)
            {
                y2Text.Text = "";
            }
        }

        /// <summary>
        /// Вызов формы отображения изображения и показ в нём интерференции на выбранном экране
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSeeClick(object sender, EventArgs e)
        {
            new ShowImage(Field.ScreenView(Resolution), @"Screen").Show();
        }

        /// <summary>
        /// Показ формы для настройки источников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void FilterButtonClick(object sender, EventArgs e)
        {
            Program.FilterForm.ShowDialog();
        }

        /// <summary>
        /// Перерисовка формы на открытии
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScreensFormActivated(object sender, EventArgs e)
        {
            UpdateScreensList();
        }

        /// <summary>
        /// Запрет закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScreensFormFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
