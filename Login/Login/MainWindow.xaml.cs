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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window,login_inerface
    {
        private  string username_admin = "admin";
        private  string password_admin = "admin";
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new login_page(this);
            
        }
    
public void check_login(string username, string password)
{
    //get username passwoerd from db
    if (username == username_admin && password == password_admin)
    {
        Main.Content=new home_page();
    }
}
}
}
