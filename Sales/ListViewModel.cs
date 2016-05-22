using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

namespace Sales
{
    partial class ListViewModel : ModelBase
    {
        private SalesMonthModel _model;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="monthModel"></param>
        private ListViewModel (SalesMonthModel monthModel)
        {
            _model = monthModel;
        }

        public Action CloseDialogBox { get; set; }
        public Action ShowDialogBox { get; set; }
        public Func<string, bool> ShowYesNoDialogBox { get; set; }

        public short Year
        {
            get
            {
                return Years.Item;
            }
        }

        public byte Month
        {
            get
            {
                return _model.Month;
            }
        }

        public string Section
        {
            get
            {
                return Sections.Item.Title;
            }
        }

        public int TotalPrice
        {
            get
            {
                return _model.ResultPrice;
            }
        }

        private ResultT4 _item;
        public ResultT4 Item
        {
            get
            {
                return _item;
            }
            set
            {
                if (_item == value) return;
                _item = value;
                RaisePropertyChanged("Item");
            }
        }

        public ObservableCollection<ResultT4> Items
        {
            get
            {
                return _model.ResultItems;
            }
        }

        private void ExecuteRenewCommand()
        {
            Renew();
        }

        private void ExecuteAppendCommand()
        {
            //todo: not implemented(Sales.ListViewModel.ExecuteAppendCommand())
            throw new System.NotImplementedException();
        }

        private void ExecuteUpdateCommand(object x)
        {
            //todo: not implemented(Sales.ListViewModel.ExecuteUpdateCommand())
            throw new System.NotImplementedException();
        }

        private bool CanExecuteUpdateCommand(object x)
        {
            return Item != null;
        }

        private void ExecuteDeleteCommand(object x)
        {
            if (!ShowYesNoDialogBox("削除してもいいですか？")) return;

            ResultT4 model = Item;
            Item = null;
            _model.Remove(model);
            _model.SaveChanges();
        }

        private bool CanExecuteDeleteCommand(object x)
        {
            return Item != null;
        }

        private void ExecuteCloseCommand()
        {
            CloseDialogBox();
        }

        public void Renew()
        {
            Item = null;
            _model.Renew();
            RaisePropertyChanged("TotalPrice");
        }

        static public void ShowDialog(SalesMonthModel month)
        {
            ListViewModel vm = new ListViewModel(month);
            ListView v = new ListView();
            v.DataContext = vm;
            vm.ShowDialogBox();
        }

    }
}
