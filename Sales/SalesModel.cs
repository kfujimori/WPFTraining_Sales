using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Sales
{
    using ItemsType = ObservableCollection<SalesMonthModel>;

    /// <summary>
    /// this class has many "SalesMonthModel"
    /// </summary>
    static class SalesModel
    {
        /// <summary>
        /// for database access
        /// </summary>
        private static SalesDataContext _dataContext = new SalesDataContext();

        /// <summary>
        /// alias of ObservableCollection<SalesMonthModel>
        /// </summary>
        private static readonly ItemsType _monthItems = new ItemsType();


        /// <summary>
        /// one month sales data.
        /// </summary>
        public static ItemsType MonthModels
        {
            get
            {
                return _monthItems;
            }
        }


        /// <summary>
        /// Initiarize 12 months data.
        /// </summary>
        public static void Renew()
        {
            _monthItems.Clear();
            SalesMonthModel prev = null;  // there is no data for first month(january)
            for (byte month = 1; month <= 12; month++)
            {
                SalesMonthModel item = new SalesMonthModel(_dataContext, month, prev);
                _monthItems.Add(item);
                prev = item; // set the modified "item" data for previous month sales data of next month.
            }
        }



    }
}
