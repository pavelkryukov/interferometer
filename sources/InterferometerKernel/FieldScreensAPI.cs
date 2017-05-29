/*
 * FieldScreensAPI.cs
 * 
 * Павел Крюков, (С) 2011.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Interferometer
{
    public static partial class Field
    {
        /// <summary>
        /// Выделенный экран
        /// </summary>
        private static Screen _chosenScreen;

        /// <summary>
        /// Добавляет новый экран в эксперимент и выделяет его
        /// </summary>
        public static void AddScreen()
        {
            var screen = new Screen();
            Screens.Add(screen);
            _chosenScreen = screen;
            DrawField();
        }

        /// <summary>
        /// Выделяет экран с заданным номером
        /// </summary>
        /// <param name="index">номер экрана</param>
        public static void ChooseScreen(Int32 index)
        {
            _chosenScreen = Screens[index];
        }

        /// <summary>
        /// Удаляет выделенный экран
        /// </summary>
        public static void DeleteScreen()
        {
            Screens.Remove(_chosenScreen);
            DrawField();
        }

        /// <summary>
        /// Настройка X1-координаты выделенного экрана
        /// </summary>
        public static UInt32 OutX1
        {
            get { return _chosenScreen.X1; }
            set
            {
                _chosenScreen.X1 = value;
                DrawField();
            }
        }

        /// <summary>
        /// Настройка X2-координаты выделенного экрана
        /// </summary>
        public static UInt32 OutX2
        {
            get { return _chosenScreen.X2; }
            set
            {
                _chosenScreen.X2 = value;
                DrawField();
            }
        }


        /// <summary>
        /// Настройка Y1-координаты выделенного экрана
        /// </summary>
        public static UInt32 OutY1
        {
            get { return _chosenScreen.Y1; }
            set
            {
                _chosenScreen.Y1 = value;
                DrawField();
            }
        }


        /// <summary>
        /// Настройка Y2-координаты выделенного экрана
        /// </summary>
        public static UInt32 OutY2
        {
            get { return _chosenScreen.Y2; }
            set
            {
                _chosenScreen.Y2 = value;
                DrawField();
            }
        }

        /// <summary>
        /// Настройка имени выделенного экрана
        /// </summary>
        public static string OutName
        {
            get { return _chosenScreen.Name; }
            set { _chosenScreen.Name = value; }

        }

        /// <summary>
        /// Список названий экранов.
        /// </summary>
        public static List<string> ScreenList
        {
            get 
            {
                return Screens.Count != 0 ? Screens.Select(it => it.ToString()).ToList() : new List<string>(0);
            }
        }

        /// <summary>
        ///  Возвращает изображение на выбранном экране
        /// </summary>
        /// <param name="resolution">Разрешение экрана</param>
        /// <returns></returns>
        public static System.Drawing.Bitmap ScreenView(int resolution)
        {
            return _chosenScreen.GetResult(resolution);
        }
    }
}