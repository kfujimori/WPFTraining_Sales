using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.TeamFoundation.MVVM;

namespace Sales
{
    /// <summary>
    /// this class is exising in another file(created as T4 file)
    /// </summary>
    partial class MainWindowViewModel : ModelBase
    {

        /// <summary>
        /// Year Property
        /// </summary>
        public short Year
        {
            get
            {
                return Years.Item;
            }
            set
            {
                if (Years.Item == value) return;
                Years.Item = value;
                RaisePropertyChanged("Year");
            }
        }

        /// <summary>
        /// Section Property
        /// </summary>
        public Section Section
        {
            get
            {
                return Sections.Item;
            }
            set
            {
                if (Sections.Item == value) return;
                Sections.Item = value;
                RaisePropertyChanged("Section");
            }
        }

        private SalesMonthModel _item;
        /// <summary>
        /// SalesMonthModel Property
        /// </summary>
        public SalesMonthModel Item
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

        /// <summary>
        /// SalesMonthModel array Property. only getter exists.
        /// </summary>
        public IEnumerable<SalesMonthModel> Items
        {
            get
            {
                return SalesModel.MonthModels;
            }
        }


        private ICommand _ListCommand;
        /// <summary>
        /// this is called when "一覧" button is clicked
        /// </summary>
        public ICommand ListCommand
        {
            get
            {
                if(_ListCommand == null)
                {
                    _ListCommand = new RelayCommand(
                            ExecuteListCommand, CanExecuteListCommand);
                }
                return _ListCommand;
            }
        }

        /// <summary>
        /// for listing data
        /// </summary>
        /// <param name="x"></param>
        private void ExecuteListCommand(object x)
        {
            //todo: not implemented(Sales.MainWindowViewModel.ExecuteListCommand())
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// check if the command ListCommand can be called.
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private bool CanExecuteListCommand(object x)
        {
            return Item != null;
        }




        /// <summary>
        /// this is called when "読み込み" button is clicked
        /// </summary>
        private void ExecuteReadCommand()
        {
            Renew();
        }

        /// <summary>
        /// this is called when "印刷" button is clicked
        /// </summary>
        private void ExecutePrintCommand()
        {
            //todo: not implemented(Sales.MainWindowViewModel.ExecutePrintCommand())
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// this is called when "インポート" button is clicked
        /// </summary>
        private void ExecuteImportCommand()
        {
            //todo: not implemented(Sales.MainWindowViewModel.ExecuteImportCommand())
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// this is called when "エクスポート" button is clicked
        /// </summary>
        private void ExecuteExportCommand()
        {
            //todo: not implemented(Sales.MainWindowViewModel.ExecuteExportCommand())
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// this is called when "ヘルプ" button is clicked
        /// </summary>
        private void ExecuteHelpCommand()
        {
            //todo: not implemented(Sales.MainWindowViewModel.ExecuteHelpCommand())
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// this is called when "バージョン情報" button is clicked
        /// </summary>
        private void ExecuteAboutCommand()
        {
            //todo: not implemented(Sales.MainWindowViewModel.ExecuteAboutCommand())
            throw new System.NotImplementedException();
        }


        /// <summary>
        /// method for calling Renew() of SalesModel.
        /// </summary>
        private void Renew()
        {
            Item = null;
            SalesModel.Renew();
            RaisePropertyChanged("Items");
        }

    }
}
