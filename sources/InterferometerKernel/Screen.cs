/*
 * Screen.cs
 * 
 * Павел Крюков, (С) 2011
 */

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

namespace Interferometer
{
    /// <summary>
    /// Наблюдательный экран
    /// </summary>
    internal class Screen
    {
        /// <summary>
        /// Высота изображений.
        /// </summary>
        private const Int32 Height = 100;

        /// <summary>
        /// Название экрана.
        /// </summary>
        public string Name = @"Unnamed";

        /// <summary>
        /// Название экрана (стандартный метод)
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
        
        // Координаты
        public UInt32 X1;
        public UInt32 X2;
        public UInt32 Y1;
        public UInt32 Y2;

        /// <summary>
        /// Буфер изображения экрана.
        /// </summary>
        private byte[] _resbyte;

        /// <summary>
        /// Указатель на использумый фильтр
        /// </summary>
        private Filter _filter;

        /// <summary>
        /// Вычислитель одной четвертой части изображения
        /// </summary>
        /// <param name="num">Номер вычислителя</param>
        /// <param name="resolution">Разрешение экрана</param>
        private void ResultThread(int num, int resolution)
        {
            // Вычисляем то разрешение, с которым придётся работать
            var resolutionOwn = resolution >> Threader.Power;

            // Кванты расстояния 
            var xq = (double)(X2 - X1) / resolution;
            var yq = (double)(Y2 - Y1) / resolution;

            // Выставляем начало анализа
            var x = X1 + num*xq*resolutionOwn;
            var y = Y1 + num*yq*resolutionOwn;

            // Выставляем начало записи в буферный массив
            var offset = 3*num*Height*resolutionOwn;

            // Пробегаем заданную часть экрана
            for (var i = 0; i < resolutionOwn; i++)
            {
                var color = new Color();
                // В каждой точке анализируем все пришедшие волны и складываем получившиеся цвета.
                for (var l = _filter.Length1; l <= _filter.Length2; l++)
                {
                    var colorL = Field.InterferentionColor(x, y, l);
                    if (!colorL.IsZero())
                    {
                        color += colorL;
                    }
                }
                // Заполняем строчку в изображении.
                for (var j = 0; j < Height; j++)
                {
                    _resbyte[offset++] = color.B255;
                    _resbyte[offset++] = color.G255;
                    _resbyte[offset++] = color.R255;
                }

                // Сдвигаем исследуемую точку.
                x += xq;
                y += yq;
            }
        }

        /// <summary>
        /// Получение изображения с экрана с заданным разрешением.
        /// </summary>
        /// <param name="resolution">Разрешение</param>
        /// <returns></returns>
        public Bitmap GetResult(int resolution)
        {
            // Определяем фильтр.
            _filter = FilterSet.GetFilter();

            // Определяем размер вычисляемого изображения.
            _resbyte = new byte[3 * Height * resolution];

            // Запускаем исполнение в нескольких потоков.
            var threads = new Thread[Threader.Cores];

            for (var i = 0; i < Threader.Cores; i++)
            {
                var i1 = i;
                threads[i] = new Thread(() => ResultThread(i1,resolution));
                threads[i].Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }

            // Трансформируем байтовый массив в картинку
            var bmp = new Bitmap(Height, resolution, PixelFormat.Format24bppRgb);
            var bmpData = bmp.LockBits(
                    new Rectangle(0, 0, bmp.Width, bmp.Height),
                    ImageLockMode.WriteOnly, bmp.PixelFormat);
            System.Runtime.InteropServices.Marshal.Copy(_resbyte, 0, bmpData.Scan0, _resbyte.Length);
            bmp.UnlockBits(bmpData);

            // Поворачиваем картинку
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            return bmp;
        }
    }
}
