/*
 * Color.cs
 * 
 * Павел Крюков, (C) 2011.
 */

namespace Interferometer
{
    /// <summary>
    /// Имплементация цветовой системы
    /// </summary>
    internal class Color
    {
        /// <summary>
        ///  Интенсивность цвета (от 0.0 до 1.0)
        /// </summary>
        private double _i;

        /// <summary>
        /// Цветовые компоненты (от 0.0 до 1.0)
        /// </summary>
        private double _r;
        private double _g;
        private double _b;

        /// <summary>
        ///  Проверка цвета на отсутствие.
        /// </summary>
        /// <returns>Если цвет пуст (чёрный), возвращает true</returns>
        public bool IsZero()
        {
            return (_i == 0);
        }

        /// <summary>
        /// Красная компонента, выраженная байтом.
        /// </summary>
        public byte R255
        {
            get { return (byte)(_r * 255 < 255 ? _r * 255 : 255); }
        }

        /// <summary>
        /// Зелёная компонента, выраженная байтом.
        /// </summary>
        public byte G255
        {
            get { return (byte)(_g * 255 < 255 ? _g * 255 : 255); }
        }

        /// <summary>
        /// Синяя компонента, выраженная байтом.
        /// </summary>
        public byte B255
        {
            get { return (byte)(_b * 255 < 255 ? _b * 255 : 255); }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="length">Длина волны в ангстремах</param>
        /// <param name="intensivity">Интенсивность</param>
        public Color(uint length, double intensivity)
        {
            double r = 0, g = 0, b = 0;
            if ((length >= 3800) && (length < 4400))
            {
                r = -(length - 4400.0) / (4400 - 3500);
                g = 0;
                b = 1;
            }
            if ((length >= 4400) && (length < 4900))
            {
                r = 0;
                g = (length - 4400.0) / (4900 - 4400);
                b = 1;
            }
            if ((length >= 4900) && (length < 5100))
            {
                r = 0;
                g = 1;
                b = -(length - 5100.0) / (5100 - 4900);
            }
            if ((length >= 5100) && (length < 5800))
            {
                r = (length - 5100.0) / (5800 - 5100);
                g = 1;
                b = 0;
            }
            if ((length >= 5800) && (length < 6450))
            {
                r = 1;
                g = -(length - 6450.0) / (6450 - 5800);
                b = 0;
            }
            if (length >= 6450)
            {
                r = 1;
                g = 0;
                b = 0;
            }

            double correction = 0;
            if (length >= 3800 && length < 4200)
            {
                correction = 0.3 + 0.7 * (length - 3500) / (4200 - 3500);
            }
            if ((length >= 4200) && (length <= 7000))
            {
                correction = 1.0;
            }
            if ((length > 7000) && (length <= 7800))
            {
                correction = 0.3 + 0.7 * (7800 - length) / (7800 - 7000);
            }

            _i = intensivity / Constants.MaxIntensivity;
            _r = r * correction;
            _g = g * correction;
            _b = b * correction;
        }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Color()
        {
            
        }

        /// <summary>
        /// Сложение цветов
        /// </summary>
        /// <param name="first">Исходный цвет</param>
        /// <param name="second">Накладываемый цвет</param>
        /// <returns>Сумма цветов</returns>
        static public Color operator+(Color first, Color second)
        {
            return new Color
                       {
                           _r = ((first._r * (1.0 - second._i) + second._r * second._i)),
                           _g = ((first._g * (1.0 - second._i) + second._g * second._i)),
                           _b = ((first._b * (1.0 - second._i) + second._b * second._i)),
                           _i = 0
                       };
        }

        /// <summary>
        /// Конвертирование в стандартный цветовой тип
        /// </summary>
        /// <returns></returns>
        public System.Drawing.Color ToPixel()
        {
            return System.Drawing.Color.FromArgb(R255, G255, B255);
        }
    }
}
