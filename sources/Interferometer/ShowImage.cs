/*
 * ShowImage.cs
 * 
 * Впервые использована в проекте MIPT ImageCompare.
 * Павел Крюков, (С) 2010-2011.
 */

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace sharpInterferometer
{
   /// <summary>
   /// Форма показа заданного изображения.
   /// Имеется возможность сохранить в bmp формате
   /// </summary>
    public sealed partial class ShowImage : Form
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="what">Изображение для показа</param>
        /// <param name="title">Название изображения</param>
        public ShowImage(Image what, string title)
        {
            InitializeComponent();
            picture.Image = what;
            Text = string.Format("{0} (click to save image)", title);
        }

        /// <summary>
        /// Сохранение картинки по клику.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureClick(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog
                                      {
                                          Filter = @"*.bmp (bitmap)|*.bmp",
                                          FilterIndex = 1,
                                          RestoreDirectory = true
                                      };

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            var myStream = saveFileDialog1.OpenFile();
            picture.Image.Save(myStream, ImageFormat.Bmp);
            myStream.Close();
        }
    }
}
