using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Sales.Properties;


namespace Sales
{

    using ItemsType = ObservableCollection<ResultT4>;

    /// <summary>
    /// one month sales data.
    /// </summary>
    class SalesMonthModel
    {

        private readonly SalesDataContext _dataContext = new SalesDataContext();


        /// <summary>
        /// sales data of previous month.
        /// </summary>
        private readonly SalesMonthModel _previousModel;



        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="month">this month</param>
        /// <param name="previousModel">data of last month</param>
        public SalesMonthModel(SalesDataContext dataContext, byte month, SalesMonthModel previousModel)
        {
            _resultItems.CollectionChanged += _resultItems_ColectionChanged;
            _dataContext = dataContext;
            _previousModel = previousModel;
            _month = month;
            Renew();
        }


        private readonly byte _month;
        /// <summary>
        /// month. no setter.
        /// </summary>
        public byte Month
        {
            get
            {
                return _month;
            }
        }


        /// <summary>
        /// planPrice. satic data. no private field. no setter.
        /// </summary>
        public int PlanPrice
        {
            get
            {
                return Settings.Default.PlanPraice;
            }
        }




        /// <summary>
        /// resultPrice. simply having getter and setter.
        /// </summary>
        public int ResultPrice{ get; set; }
        public int SubtractPrice
        {
            get
            {
                return ResultPrice - PlanPrice;
            }
        }




        /// <summary>
        /// total of subtractPrice. recursive.
        /// </summary>
        public int TotalPrice
        {
            get
            {
                int p = _previousModel == null ? 0 : _previousModel.TotalPrice;
                return p + SubtractPrice;

            }
        }



        /// <summary>
        /// alias of ObservableCollection<ResultT4>
        /// </summary>
        private readonly ItemsType _resultItems = new ItemsType();
        public ItemsType ResultItems
        {
            get
            {
                return _resultItems;
            }
        }



        /// <summary>
        /// get data from database with conditions
        /// </summary>
        public void Renew()
        {
            var q =
                from p in _dataContext.Results
                where
                    p.Date.Year == Years.Item &&
                    p.Date.Month == Month &&
                    p.SectionId == Sections.Item.Id
                select p;

            _resultItems.Clear();
            foreach(ResultT4 x in q)
            {
                _resultItems.Add(x);
            }
        }


        /// <summary>
        /// add new record to Results and database
        /// </summary>
        /// <param name="row"></param>
        public void Add(ResultT4 row)
        {
            _dataContext.Results.Add(row);
            _resultItems.Add(row);
        }


        /// <summary>
        /// remove record from Results and database
        /// </summary>
        /// <param name="row"></param>
        public void Remove(ResultT4 row)
        {
            _dataContext.Results.Remove(row);
            _resultItems.Remove(row);
        }

        /// <summary>
        /// fix the changed data
        /// </summary>
        public int SaveChanges()
        {
            return _dataContext.SaveChanges();
        }





        private void _resultItems_ColectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            var q =
                from p in _resultItems
                select p.Price;
            ResultPrice = q.Sum();
        }

    }

}
