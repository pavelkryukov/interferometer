/*
 * Wave.cs
 * 
 * Павел Крюков, (С) 2011
 */

using System;

namespace Interferometer
{
    /// <summary>
    /// Световая волна.
    /// </summary>
    internal class Wave
    {
        /// <summary>
        /// Длина волны в ангстремах. 
        /// </summary>
        private UInt32 _length;

        /// <summary>
        /// Настройка длины
        /// Длина ограничена константами, описанными в классе Constants.
        /// </summary>
        public UInt32 Length
        {
            set
            {
                if (value > Constants.Infrared)
                {
                    _length = Constants.Infrared;
                }
                else
                {
                    _length = value < Constants.Ultraviolet ? Constants.Ultraviolet : value;
                }
                Vector = Constants.Pi2 * Constants.Angstrem / _length;
            }
            get { return _length; }
        }
        public double Vector;

        /// <summary>
        /// Амплитуда (в условных единицах)
        /// </summary>
        private UInt32 _amplitude;

        /// <summary>
        /// Настройка амплитуды
        /// Амплитуда ограничена 255.
        /// </summary>
        public UInt32 Amplitude
        {
            set 
            {
                _amplitude = value > 255 ? 255 : value;
            }
            get { return _amplitude; }
        }

        /// <summary>
        /// Пропускание волны
        /// </summary>
        private UInt32 _delta;

        /// <summary>
        /// Настройка пропускания волны
        /// Пропускание волны ограничено 100 ангстремами.
        /// </summary>
        public UInt32 Delta
        {
            set { _delta = value > 1000 ? 1000 : value; }
            get { return _delta; }
        }

        /// <summary>
        /// Фаза волны (в градусах)
        /// </summary>
        private UInt32 _phase;

        /// <summary>
        /// Настройка фазы волны (в градусах)
        /// Приведение по остатку 360 производится автоматически.
        /// </summary>
        public UInt32 Phase
        {
            set { _phase = (uint)(value % Constants.Degrees); }
            get { return _phase; }

        }

        /// <summary>
        /// Вывод инфо
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("{0} ± {1}", _length, _delta/2);
        }

        /// <summary>
        /// Возврат электромагнитного колебания
        /// </summary>
        /// <param name="distance">Расстояние (в пикселях)</param>
        /// <returns></returns>
        public Oscillator GetOscillator(double distance)
        {
            return new Oscillator(Phase*Constants.DegToRad + Vector*distance*Constants.MeterInPixel, Amplitude);
        }
    }
}
