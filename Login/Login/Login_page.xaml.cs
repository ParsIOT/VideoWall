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
    /// Interaction logic for Login_page.xaml
    /// </summary>
    public partial class Login_page : Page
    {
        private  string username_admin = "admin";
        private  string password_admin = "admin";
        public Login_page()
        {
            InitializeComponent();
            this.NavigationService.Navigate(new Login_page());
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
            if (username.Text == getUsername() && password.Password == getPass())
            {
                MessageBox.Show("correct");
            }
            else MessageBox.Show("Incorrect !!!!");
        }
    }
}
