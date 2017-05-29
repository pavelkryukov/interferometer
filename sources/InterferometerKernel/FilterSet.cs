/*
 * Filter.cs
 * 
 * Павел Крюков, (C) 2011.
 */

using System.Linq;

namespace Interferometer
{
    /// <summary>
    /// Набор светофильтров
    /// </summary>
    public static class FilterSet
    {
        /// <summary>
        /// Хранилище фильтров.
        /// </summary>
        static private readonly System.Collections.Generic.List<Filter> FilterList = new System.Collections.Generic.List<Filter> { new Filter() };

        /// <summary>
        /// Указатель на выбранный фильтр.
        /// </summary>
        static private Filter _chosen = FilterList[0];

        /// <summary>
        /// Добавление фильтра с заданными параметрами
        /// </summary>
        /// <param name="l1">Первая граница</param>
        /// <param name="l2">Вторая граница (опционально)</param>
        static public void AddFilter(uint l1, uint l2)
        {
            FilterList.Add(l2 == 0 ? new Filter(l1) : new Filter(l1, l2));
        }

        /// <summary>
        /// Выделение фильтра по заданнному индексу
        /// </summary>
        /// <param name="index">Индекс</param>
        static public void ChooseFilter(int index)
        {
           if (FilterList.Count > 0)
           {
               _chosen = FilterList[index < 0 ? 0 : index];
           }
        }

        /// <summary>
        /// Удаление выделенного фильтра
        /// </summary>
        static public void DeleteFilter()
        {
            FilterList.Remove(_chosen);
        }

        /// <summary>
        /// Возврат выделенного фильтра
        /// </summary>
        /// <returns></returns>
        static internal Filter GetFilter()
        {
            return _chosen;
        }

        /// <summary>
        /// Список названий фильтров
        /// </summary>
        /// <returns></returns>
        static public System.Collections.Generic.List<string> GetList
        {
            get { return FilterList.Select(it => it.ToString()).ToList(); }
        }

        /// <summary>
        /// Возврат спектра выбранного фильтра
        /// </summary>
        /// <returns></returns>
        static public System.Drawing.Bitmap GetSpectrum
        {
            get { return _chosen.ToSpectrum(); }
        }
    }
}
