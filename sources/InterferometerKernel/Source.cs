/*
 * Source.cs
 * 
 * Павел Крюков, (С) 2011
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace Interferometer
{
    /// <summary>
    /// Световой источник
    /// </summary>
    internal class Source
    {
        /// <summary>
        ///  Список волновых компонент источника (т.е. спектр)
        /// </summary>
        public List<Wave> Waves = new List<Wave>();

        /// <summary>
        /// Вывод волновых компонент текстовым списком.
        /// </summary>
        public List<string> WavesList
        {
            get
            {
                return Waves.Count > 0 ? Waves.Select(it => it.ToString()).ToList() : new List<string>(0);
            }
        }

        /// <summary>
        /// X-координата
        /// </summary>
        public UInt32 X;

        /// <summary>
        /// Y-координата
        /// </summary>
        public UInt32 Y;

        /// <summary>
        /// Имя
        /// </summary>
        public String Name = @"Unnamed";

        /// <summary>
        /// Вывод имени источника
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
        
        /// <summary>
        /// Включение/выключение
        /// </summary>
        public bool Turn;

        public Source()
        {
            
        }

        /// <summary>
        /// Конструктор из потока
        /// </summary>
        /// <param name="source">Поток</param>
        public Source(Stream source)
        {
            var reader = new StreamReader(source);
            Name = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                var buffer = new Wave
                                 {
                                     Length = UInt32.Parse(reader.ReadLine()),
                                     Delta = UInt32.Parse(reader.ReadLine()),
                                     Amplitude = UInt32.Parse(reader.ReadLine()),
                                     Phase = UInt32.Parse(reader.ReadLine())
                                 };
                Waves.Add(buffer);
            }
        }

        /// <summary>
        /// Сохранение в поток.
        /// </summary>
        /// <param name="destination"></param>
        public void Save(Stream destination)
        {
            destination.Write(new UTF8Encoding(true).GetBytes(Name), 0, Name.Length);
            foreach (var buffer in
                Waves.Select(it => String.Format("\n{0}\n{1}\n{2}\n{3}", it.Length, it.Delta, it.Amplitude, it.Phase)))
            {
                destination.Write(new UTF8Encoding(true).GetBytes(buffer), 0, buffer.Length);
            }
        }

        /// <summary>
        /// Вывод спектра
        /// </summary>
        /// <returns></returns>
        public Bitmap ToBitmap()
        {
            var result = new Bitmap(2*Constants.EyeWidth, 255);
            foreach (var it in Waves)
            {
                // Перебор по каждой волновой компоненте
                var start = it.Length - it.Delta/2 - 1 - Constants.Ultraviolet;
                start = start < 0 ? 0 : start;
                
                var finish = it.Length + it.Delta/2 + 1 - Constants.Ultraviolet;
                finish = finish > Constants.EyeWidth ? Constants.EyeWidth : finish;

                var height = it.Amplitude;
                for (var i = start; i < finish; i++)
                {
                    // Рисуется прямоугольник шириной, пропорциональной пропусканию компоненты
                    for (var j = 0; j < height; j++)
                    {
                        // и высотой, пропорциональной интенсивности.
                        var color = new Color(i + Constants.Ultraviolet,1).ToPixel();
                        result.SetPixel((int)(2 * i), j, color);
                        result.SetPixel((int) (2*i + 1), j, color);
                    }
                }
            }
            result.RotateFlip(RotateFlipType.Rotate180FlipNone);
            return result;
        }

        /// <summary>
        /// Вывод цвета источника (видимого глазом).
        /// </summary>
        /// <returns></returns>
        public Color Color()
        {
            var result = new Color();
            for (uint l = Constants.Ultraviolet; l < Constants.Infrared; l++)
            {
                var l1 = l;
                result = Waves.Where(wave => Math.Abs(l1 - wave.Length) <= wave.Delta).Aggregate(result, (current, wave) => current + new Color(l1, wave.Amplitude*wave.Amplitude));
            }
            return result;
        }
    }
}
