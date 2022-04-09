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
using System.Windows.Shapes;

namespace SilverProg
{
    /// <summary>
    /// Логика взаимодействия для Авторизация.xaml
    /// </summary>
    public partial class Авторизация : Window
    {
        DB.Model1 db = new DB.Model1();
        public Авторизация()
        {
            InitializeComponent();
            db.Users.Load();
            ViborLog.ItemsSource = db.Users.Local;
            

        }

        private void Voiti_Click(object sender, RoutedEventArgs e)
        {
            Auth(ViborLog.Text, Spispar.Password);
        }
        public bool Auth(string Vibor, string Spispar)
        {
            if (string.IsNullOrEmpty(Vibor) || string.IsNullOrEmpty(Spispar))
            {
                MessageBox.Show("Введите логин и пароль!");
                return false;
            }
            using (var db = new DB.Model1())
            {
                var user = db.Users.AsNoTracking().FirstOrDefault(u => u.Login == Vibor && u.Password == Spispar);
                if (user == null)
                {
                    MessageBox.Show("Пользователь с такими данными не найден!");
                    return false;
                }
                MainWindow window = new MainWindow();
                window.Show();
                return true;
            }

        }
    }
}
