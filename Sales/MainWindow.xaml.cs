using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sales
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //using (SalesDataContext db = new SalesDataContext())
            //{
                //try
                //{
                    //db.Results.Add(new ResultT4 {  Title = "F" });
                    //db.SaveChanges();


                //}
                //catch(System.Data.Entity.Validation.DbEntityValidationException e)
                //{
                //    Console.WriteLine("--------------------------");
                //    Console.WriteLine(e.EntityValidationErrors);
                //    Console.WriteLine("--------------------------");
                //}
            //}
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
