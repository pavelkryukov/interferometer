/*
 * Color.cs
 * 
 * Павел Крюков, (C) 2011.
 */

using System;

namespace Interferometer
{
    /// <summary>
    /// Колебательный процесс (без указания частоты)
    /// </summary>
    internal class Oscillator
    {
        /// <summary>
        /// Фаза
        /// </summary>
        private readonly double _p;
        
        /// <summary>
        /// Амплитуда
        /// </summary>
        private readonly double _a;

        /// <summary>
        /// Интенсивность (вне оптического контекста — энергия)
        /// </summary>
        public double Intensivity
        {
            get { return _a*_a; }
        }

        /// <summary>
        /// Конструктор колебания
        /// </summary>
        /// <param name="phase">Фаза (в радианах)</param>
        /// <param name="amplitude">Амплитуда</param>
        public Oscillator(double phase, double amplitude)
        {
            _p = phase;
            _a = amplitude;
        }

        /// <summary>
        /// Сложение колебаний путём векторного сложения.
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        static public Oscillator operator+(Oscillator first, Oscillator second)
        {
            // Косинус угла между векторами
            var cos = Math.Cos(first._p - second._p);

            // Амплитуда находится из теоремы косинусов
            var a = Math.Sqrt((first._a)*(first._a) + (second._a)*(second._a) +
                              2*(first._a)*(second._a)*cos);

            // Фаза 
            var p = Math.Asin(Math.Sin(second._p - first._p)*(second._a)/a) - first._p;
            return new Oscillator(Double.IsNaN(p) ? 0 : p, a);
        }
    }
}
