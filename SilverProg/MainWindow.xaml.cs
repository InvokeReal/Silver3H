using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace SilverProg
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DB.Model1 db = new DB.Model1();
        public MainWindow()
        {
            InitializeComponent();
            db.Service.Load();
            lll.ItemsSource = db.Service.Local;
        }

        private void filtCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (filtCB.SelectedIndex)
            {

                case 0:
                    lll.ItemsSource = db.Service.Local;
                    break;
                case 1:
                    lll.ItemsSource = db.Service.Local.Where(x => x.Discount <= 0.05);
                    break;
                case 2:
                    lll.ItemsSource = db.Service.Local.Where(x => x.Discount >= 0.05 && x.Discount <=0.15);
                    break;
                case 3:
                    lll.ItemsSource = db.Service.Local.Where(x => x.Discount >= 0.15 && x.Discount <= 0.30);
                    break;
                case 4:
                    lll.ItemsSource = db.Service.Local.Where(x => x.Discount >= 0.30 && x.Discount <= 0.70);
                    break;
                case 5:
                    lll.ItemsSource = db.Service.Local.Where(x => x.Discount >= 0.70);
                    break;
                default:
                    break;


            }
            RowCount();
        }

        private void searchTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            lll.ItemsSource = db.Service.Local.Where(x => x.Title.ToLower().Contains(searchTB.Text.ToLower()) || x.Description.ToLower().Contains(searchTB.Text.ToLower()));
            RowCount();
        }

        private void sortCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(sortCB.SelectedIndex)
            {
                case 0:
                    lll.ItemsSource = db.Service.Local.OrderBy(x => x.Cost);
                    break;
                case 1:
                    lll.ItemsSource = db.Service.Local.OrderByDescending(x => x.Cost);
                    break;
            }
            RowCount();

        }
        public void RowCount()
        {
            rowCount.Text = $"Выведено {lll.Items.Count} записей из {db.Service.Local.Count}";
        }
    }
}
