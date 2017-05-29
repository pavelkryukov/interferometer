/*
 * FieldScreensAPI.cs
 *
 * Павел Крюков, (С) 2011.
 */

using System;

namespace Interferometer
{
    static partial class Field
    {
        /// <summary>
        /// Выделенная волновая компонента в источнике
        /// </summary>
        private static Wave _chosenWave;

        /// <summary>
        /// Выделение волновой компоненты с заданным номером в выделенном источнике
        /// </summary>
        /// <param name="index"></param>
        public static void ChooseWave(Int32 index)
        {
            _chosenWave = _chosenSource.Waves[index < 0 ? 0 : index];
        }

        /// <summary>
        /// Добавление волновой компоненты с её последующим выделением.
        /// </summary>
        public static void AddWave()
        {
            var wave = new Wave();
            _chosenSource.Waves.Add(wave);
            _chosenWave = wave;
        }

        /// <summary>
        /// Удаление выделенной волновой компоненты
        /// </summary>
        public static void DeleteWave()
        {
            _chosenSource.Waves.Remove(_chosenWave);
        }

        /// <summary>
        /// Настройка длины выбранной волны
        /// </summary>
        public static UInt32 Length
        {
            get { return _chosenWave.Length; }
            set { _chosenWave.Length = value; }
        }

        /// <summary>
        /// Настройка пропускания выбранной волны
        /// </summary>
        public static UInt32 Delta
        {
            get { return _chosenWave.Delta; }
            set { _chosenWave.Delta = value; }
        }

        /// <summary>
        /// Настройка амплитуды выбранной волны
        /// </summary>
        public static UInt32 Amplitude
        {
            get { return _chosenWave.Amplitude; }
            set { _chosenWave.Amplitude = value; }
        }

        /// <summary>
        /// Настройка фазы выбранной волны
        /// </summary>
        public static UInt32 Phase
        {
            get { return _chosenWave.Phase; }
            set { _chosenWave.Phase = value; }
        }
    }
}