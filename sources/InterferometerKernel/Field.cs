/*
 * Field.cs
 * 
 * Павел Крюков, (С) 2011.
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Interferometer
{
    /// <summary>
    /// Статический класс Field хранит всю информацию об объектах на рабочем поле,
    /// позволяет её редактировать и получать
    /// и возвращает интерференционную картину в заданной точке. 
    /// </summary>
    public static partial class Field
    {
        /// <summary>
        /// Хранилище источников
        /// </summary>
        private static readonly List<Source> Sources = new List<Source>();

        /// <summary>
        /// Список имён источников.
        /// </summary>
        public static List<string> SourcesList
        {
            get
            {
                return Sources.Count != 0 ? Sources.Select(it => it.ToString()).ToList() : new List<string>(0);
            }
        }

        /// <summary>
        /// Хранилище экранов
        /// </summary>
        private static readonly List<Screen> Screens = new List<Screen>();

        /// <summary>
        /// Указатель на область для рисования поля.
        /// </summary>
        private static System.Windows.Forms.PictureBox _pictureBox;
        public static System.Windows.Forms.PictureBox PictureBox
        {
            set { _pictureBox = value; }
        }

        /// <summary>
        ///  Отрисовывает поле в указанную область.
        /// </summary>
        static public void DrawField()
        {
            if (_pictureBox == null) return;
            var g = _pictureBox.CreateGraphics();
            g.Clear(System.Drawing.Color.Black);
            foreach (var screen in Screens)
            {
                g.DrawLine(new Pen(Brushes.Yellow), screen.X1, screen.Y1, screen.X2, screen.Y2);
            }
            foreach (var source in Sources)
            {
                for (var j = 0; j < 24; j+=6)
                {
                    g.DrawEllipse(new Pen(source.Turn ? Brushes.White : Brushes.Blue), source.X - j/2, source.Y-j/2, j, j);
                }
            }
        }


        /// <summary>
        ///  Возвращает интенсивность указанной волны в указанной точке
        /// </summary>
        /// <param name="x">x-координата</param>
        /// <param name="y">y-координата</param>
        /// <param name="l">длина волны в ангстремах</param>
        /// <returns>Интенсивность</returns>
        static private double Interferention(double x, double y, uint l)
        {
            // Произведём сложение колебаний от всех волновых компонент всех источников
            var result = new Oscillator(0,0);
            foreach (var source in Sources)
            {
                // Если источник выключен, он не рассматривается.
                if (!source.Turn) continue;

                // Определяем расстояние.
                var distance = Math.Sqrt((x - source.X)*(x - source.X) + (y - source.Y)*(y - source.Y));
                result = source.Waves.Where(wave => Math.Abs(l - wave.Length) <= wave.Delta).Aggregate(result, (current, wave) => current + wave.GetOscillator(distance));
            }
            return result.Intensivity;
        }

        /// <summary>
        ///  Возвращает цвет в указанной точки от указанной волны.
        /// </summary>
        /// <param name="x">x-координата</param>
        /// <param name="y">y-координата</param>
        /// <param name="l">длина волны в ангстремах</param>
        /// <returns></returns>        
        static internal Color InterferentionColor(double x, double y, uint l)
        {
            return new Color(l, Interferention(x, y, l));
        }

        /// <summary>
        /// Сохранение информации о поле в файл.
        /// </summary>
        /// <param name="destination">Поток назначения.</param>
        static public void Save(Stream destination)
        {
            var writer = new StreamWriter(destination);
            writer.WriteLine(Sources.Count);
            foreach (var source in Sources)
            {
                writer.WriteLine(source.Name);
                writer.WriteLine(source.X);
                writer.WriteLine(source.Y);
                writer.WriteLine(source.Turn.ToString());
                writer.WriteLine(source.Waves.Count);
                foreach (var wave in source.Waves)
                {
                    writer.WriteLine(wave.Length);
                    writer.WriteLine(wave.Delta);
                    writer.WriteLine(wave.Amplitude);
                    writer.WriteLine(wave.Phase);
                }
            }
            writer.WriteLine(Screens.Count);
            foreach (var screen in Screens)
            {
                writer.WriteLine(screen.Name);
                writer.WriteLine(screen.X1);
                writer.WriteLine(screen.Y1);
                writer.WriteLine(screen.X2);
                writer.WriteLine(screen.Y2);
            }
            writer.Flush();
            writer.Close();
        }

        /// <summary>
        /// Загрузка информации из файла
        /// </summary>
        /// <param name="stream">Загружаемый поток</param>
        static public void Load(Stream stream)
        {
            Sources.Clear();
            Screens.Clear();
            var reader = new StreamReader(stream);
            try
            {
                var sourcesCount = UInt32.Parse(reader.ReadLine());
                for (var i = 0; i < sourcesCount; i++)
                {
                    var source = new Source
                                     {
                                         Name = reader.ReadLine(),
                                         X = UInt32.Parse(reader.ReadLine()),
                                         Y = UInt32.Parse(reader.ReadLine()),
                                         Turn = Boolean.Parse(reader.ReadLine() ?? "true")
                                     };
                    var wavesCount = UInt32.Parse(reader.ReadLine());
                    for (var j = 0; j < wavesCount; j++)
                    {
                        source.Waves.Add(new Wave
                                             {
                                                 Length = UInt32.Parse(reader.ReadLine()),
                                                 Delta = UInt32.Parse(reader.ReadLine()),
                                                 Amplitude = UInt32.Parse(reader.ReadLine()),
                                                 Phase = UInt32.Parse(reader.ReadLine()),
                                             });
                    }
                    Sources.Add(source);
                }
                var screensCount = UInt32.Parse(reader.ReadLine());
                for (var i = 0; i < screensCount; i++)
                {
                    Screens.Add(new Screen
                                    {
                                        Name = reader.ReadLine(),
                                        X1 = UInt32.Parse(reader.ReadLine()),
                                        Y1 = UInt32.Parse(reader.ReadLine()),
                                        X2 = UInt32.Parse(reader.ReadLine()),
                                        Y2 = UInt32.Parse(reader.ReadLine())
                                    });
                }
                reader.Close();
            }
            catch (Exception)
            {
                throw new FormatException();
            }
        }
    }
}