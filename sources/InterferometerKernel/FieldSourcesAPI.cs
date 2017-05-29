/*
 * FieldScreensAPI.cs
 * 
 * Павел Крюков, (С) 2011.
 */

using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;

namespace Interferometer
{
    static partial class Field
    {
        /// <summary>
        /// Указатель на выбранный источник
        /// </summary>
        private static Source _chosenSource;

        /// <summary>
        /// Выбор источника с заданным номером
        /// </summary>
        /// <param name="index">номер источника</param>
        public static void ChooseSource(Int32 index)
        {
            _chosenSource = Sources[index];
        }

        /// <summary>
        /// Сохраняет выделенный источник в заданный поток
        /// </summary>
        /// <param name="destination">Поток назначения</param>
        public static void SaveSource(Stream destination)
        {
            _chosenSource.Save(destination);
        }

        /// <summary>
        /// Добавляет источник и выделяет его.
        /// </summary>
        public static void AddSource()
        {
            var source = new Source();
            Sources.Add(source);
            _chosenSource = source;
            DrawField();
        }

        /// <summary>
        /// Загружает источник из потока и выделяет её.
        /// </summary>
        /// <param name="stream">Загружаемый поток.</param>
        public static void AddSource(Stream stream)
        {
            var source = new Source(stream);
            Sources.Add(source);
            _chosenSource = source;
            DrawField();
        }

        /// <summary>
        /// Удаляет выделенный источник
        /// </summary>
        public static void DeleteSource()
        {
            Sources.Remove(_chosenSource);
            if (Sources.Count != 0) _chosenSource = Sources[0];
            DrawField();
        }

        /// <summary>
        /// Настройка X-координаты выбранного источника.
        /// </summary>
        public static UInt32 InX
        {
            get { return _chosenSource.X; }
            set
            {
                _chosenSource.X = value;
                DrawField();
            }
        }

        /// <summary>
        /// Настройка Y-координаты выбранного источника.
        /// </summary>
        public static UInt32 InY
        {
            get { return _chosenSource.Y; }
            set
            {
                _chosenSource.Y = value;
                DrawField();
            }
        }

        /// <summary>
        /// Настройка имени выделенного источника.
        /// </summary>
        public static string InName
        {
            get { return _chosenSource.Name; }
            set { _chosenSource.Name = value; }
        }

        /// <summary>
        /// Настройка активности выделенного источника.
        /// </summary>
        public static bool InTurn
        {
            get { return _chosenSource.Turn; }
            set
            {
                _chosenSource.Turn = value;
                DrawField();
            }
        }

        /// <summary>
        /// Список волновых компонент выделенного источника.
        /// </summary>
        public static List<string> WavesList
        {
            get { return _chosenSource.WavesList; }
        }

        /// <summary>
        /// Спектр выделенного источника
        /// </summary>
        /// <returns></returns>
        public static System.Drawing.Bitmap SpectrumView
        {
            get
            {
                return _chosenSource.ToBitmap();
            }
        }

        /// <summary>
        /// Цвет выделенного источника
        /// </summary>
        /// <returns>Битмап 32x32 пиксела</returns>
        public static System.Drawing.Bitmap View()
        {
            var color = _chosenSource.Color().ToPixel();
            var result = new System.Drawing.Bitmap(32, 32, PixelFormat.Format24bppRgb);
            for (var i = 0; i < 32; i++)
                for (var j = 0; j < 32; j++)
                    result.SetPixel(i,j,color);
            return result;
        }
    }
}
