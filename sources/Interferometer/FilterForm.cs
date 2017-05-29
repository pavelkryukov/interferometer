/*
 * FilterForm.cs
 * 
 * Павел Крюков, (C) 2011.
 */

using System;
using System.Windows.Forms;
using Interferometer;

namespace sharpInterferometer
{
    /// <summary>
    /// Форма-интерфейс для FilterSet API.
    /// </summary>
    public partial class FilterForm : Form
    {
        /// <summary>
        /// Конструктор окна
        /// </summary>
        public FilterForm()
        {
            InitializeComponent();
            UpdateForm();
            listFilters.SelectedIndex = 0;
        }

        /// <summary>
        /// Перерисовка формы
        /// </summary>
        private void UpdateForm()
        {
            // Перерисовка листа фильтров
            listFilters.Items.Clear();
            foreach (var it in FilterSet.GetList)
            {
                listFilters.Items.Add(it);
            }

            if (listFilters.Items.Count == 0) return;

            // Если есть фильтры, рисуем спектры.
            spectrumBox.Image = FilterSet.GetSpectrum;
        }

        /// <summary>
        /// При изменении выбранного фильтра выбираем его в наборе и рисуем спектр
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListFiltersSelectedIndexChanged(object sender, EventArgs e)
        {
            FilterSet.ChooseFilter(listFilters.SelectedIndex);
            spectrumBox.Image = FilterSet.GetSpectrum;
        }

        /// <summary>
        /// Добавление фильтра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddFilterButtonClick(object sender, EventArgs e)
        {
            uint t1, t2;
            // Если поля введены неверно, они очищаются и добавления не происходит.
            try
            {
                t1 = UInt32.Parse(length1Box.Text);
            }
            catch (Exception)
            {
                length1Box.Text = "";
                return;
            }
            try
            {
                t2 = UInt32.Parse(length2Box.Text);
            }
            catch (Exception)
            {
                length2Box.Text = "";
                return;
            }

            // Проброс в статический класс.
            FilterSet.AddFilter(t1, t2);

            UpdateForm();

            // Выделяем созданный экран
            listFilters.SelectedIndex = listFilters.Items.Count - 1;
        }

        /// <summary>
        /// Удаление выбранного фильтра
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteFilterButtonClick(object sender, EventArgs e)
        {
            // Проброс в статкласс.
            FilterSet.DeleteFilter();

            UpdateForm();

            // Выбираем последний элемент
            FilterSet.ChooseFilter(listFilters.Items.Count - 1);
        }

        /// <summary>
        /// Скрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FilterFormFormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
   }
}
