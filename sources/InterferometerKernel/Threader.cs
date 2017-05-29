/*
 * Threader.cs
 *
 * Павел Крюков, (C) 2011.
*/

namespace Interferometer
{     
    /// <summary>
    /// Information about thread number.
    /// </summary>
    static internal class Threader
    {
        public static readonly int Power;
        public static readonly int Cores;

        static Threader()
        {
            var processorCount = System.Environment.ProcessorCount;

            for (Power = 0; (Power < 8) && (processorCount > (1 << Power)); Power++)
            {
                
            }
            Cores = 1 << Power;
        }
    }
}