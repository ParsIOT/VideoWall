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

namespace Login
{
    /// <summary>
    /// Interaction logic for login_page.xaml
    /// </summary>
    public partial class login_page : UserControl
    {
        private string username_admin = "admin";
        private string password_admin = "admin";
        private login_inerface LOGIN;

        public login_page()
        {
            InitializeComponent();
            DataContext = this;
        }

        public login_page(login_inerface LOGIN)
        {
            InitializeComponent();
            this.LOGIN = LOGIN;
            DataContext = this;
        }

        private string getPass()
        {
            return password_admin;

        }


        private int setPass(string pass)
        {
            password_admin = pass;
            return 1;
        }

        private string getUsername()
        {
            return username_admin;
        }

        private int setUsername(string username)
        {
            username_admin = username;
            return 1;
        }



        private void Close_OnClick(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Submit_OnClick(object sender, RoutedEventArgs e)
        {
            if (this.LOGIN.check_login(username.Text, password.Password) == 1)
            {
                //logged in successfully
            }
            else
            {
//                MessageBox.Show("رمز عبور یا نام کاربری اشتباه است");
                incorrect.Visibility = Visibility.Visible;
                password.BorderBrush =Brushes.Red ;
                username.BorderBrush = Brushes.Red;
            }

        }

        private void Password_OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            incorrect.Visibility = Visibility.Hidden;
            password.BorderBrush = Brushes.Black;
            username.BorderBrush = Brushes.Black;
        }

        private void Username_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            incorrect.Visibility = Visibility.Hidden;
            password.BorderBrush = Brushes.Black;
            username.BorderBrush = Brushes.Black;
        }
    }
}
