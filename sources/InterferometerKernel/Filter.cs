/*
 * Filter.cs
 *
 * Павел Крюков, (C) 2011.
 */

namespace Interferometer
{
    /// <summary>
    /// Светофильтр
    /// </summary>
    internal class Filter
    {
        /// <summary>
        /// Меньшая граница фильтрования
        /// </summary>
        public readonly uint Length1;

        /// <summary>
        /// Большая граница фильтрования
        /// </summary>
        public readonly uint Length2;

        /// <summary>
        /// Конструктор по умолчанию (полностью прозрачный фильтр)
        /// </summary>
        public Filter()
        {
            Length2 = Constants.Infrared;
            Length1 = Constants.Ultraviolet;
        }

        /// <summary>
        /// Конструктор монохроматического фильтра.
        /// В случае неподходящей длины волны создает фильтр на 5000 А.
        /// </summary>
        /// <param name="l">длина волны</param>
        public Filter(uint l)
        {
            if ((l < Constants.Infrared) && (l > Constants.Ultraviolet))
            {
                Length1 = l;
                Length2 = l;
            }
            else
            {
                Length1 = 5000;
                Length2 = 5000;
            }
        }

        /// <summary>
        /// Конструктор фильтра с заданным диапазоном
        /// </summary>
        /// <param name="l1">Первая граница диапазона</param>
        /// <param name="l2">Вторая граница диапазона</param>
        public Filter(uint l1, uint l2)
        {
            Length1 = l2 < l1 ? l2 : l1;
            Length2 = l2 < l1 ? l1 : l2;
            Length2 = Length2 > Constants.Infrared ? Constants.Infrared : Length2;
            Length1 = Length1 < Constants.Ultraviolet ? Constants.Ultraviolet : Length1;
        }

        /// <summary>
        /// Название фильтра.
        /// Для монохромата выводит длину волны.
        /// Для диапазонного фильтра выводит границы через дефис.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Length1 == Length2 ? Length2.ToString() : string.Format("{0} - {1}", Length1, Length2);
        }

        /// <summary>
        /// Выводит изображение пропускаемого спектра.
        /// </summary>
        /// <returns></returns>
        public System.Drawing.Bitmap ToSpectrum()
        {
            var result = new System.Drawing.Bitmap(Constants.EyeWidth, 32);
            for (var l = Length1; l < Length2; l++)
            {
                var color = new Color(l, 1).ToPixel();
                for (var j = 0; j < 32; j++)
                {
                    result.SetPixel((int)l - Constants.Ultraviolet, j, color);
                }
            }
            return result;
        }
    }
}
