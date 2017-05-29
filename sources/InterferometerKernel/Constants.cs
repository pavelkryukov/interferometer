/*
 * Constants.cs
 * 
 * Павел Крюков, (C) 2011.
 */

using System;

namespace Interferometer
{
    /// <summary>
    /// Статический класс для хранения физических констант.
    /// </summary>
    static internal class Constants
    {
        /// <summary>
        /// Скорость света (м/с)
        /// </summary>
        public const Int32 C = 300000000;

        /// <summary>
        /// Число Пи
        /// </summary>
        public const Double Pi = Math.PI;

        /// <summary>
        /// Удвоенное число Пи
        /// </summary>
        public const Double Pi2 = Math.PI*2;
        
        /// <summary>
        /// Коэффициент перевода длины волны в частоту.
        /// </summary>
        public const Double Pi2C = Pi2 * C;

        /// <summary>
        /// Коэффициент перевода метра в ангстрем
        /// </summary>
        public const Double Angstrem = 10000000000;

        /// <summary>
        /// Наибольшая длина волны, видимая глазом
        /// </summary>
        public const Int32 Infrared = 7800;

        /// <summary>
        /// Наименьшая длина волны, видимая глазом
        /// </summary>
        public const Int32 Ultraviolet = 3800;

        /// <summary>
        /// Длина видимого диапазона
        /// </summary>
        public const Int32 EyeWidth = Infrared - Ultraviolet;
        
        /// <summary>
        /// Полный угол в градусах
        /// </summary>
        public const Int16 Degrees = 360;

        /// <summary>
        /// Коэффициент перевода градусов в радианы
        /// </summary>
        public const Double DegToRad = Pi2/Degrees;

        /// <summary>
        /// Коэффициент перевода радианов в градусы
        /// </summary>
        public const Double RadToDeg = DegToRad/Pi2;

        /// <summary>
        /// Максимальная интенсивность цвета
        /// </summary>
        public const Double MaxIntensivity = 255.0 * 255.0;
        
        /// <summary>
        /// Коэффициент перевода пикселя в метры
        /// </summary>
        public const Double MeterInPixel = 0.001;
    }
}
