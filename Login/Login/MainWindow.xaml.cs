using System;
using MahApps.Metro.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
using MahApps.Metro;

namespace Login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow, login_inerface, changePass_inteface, home_interface
    {
        private  string username_admin = "admin";
        private  string password_admin = "admin";
        private bool is_logged_in = false;
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new login_page(this);
            
        }

        
        public string getPass()
        {
            return password_admin;
        }

        private int setPass(string pass)
        {
            password_admin = pass;
            return 1;
        }

        public string getUsername()
        {
            return username_admin;
        }

        private int setUsername(string username)
        {
            username_admin = username;
            return 1;
        }
    
public int check_login(string username, string password)
{
    //get username passwoerd from db
    if (username == getUsername() && password == getPass())
    {
        is_logged_in = true;
        Main.Content = new home_page(this);
        return 1;
    }
    else return 0;
}

public void changePassword(string password)
{
    
    setPass(password);
}

public void show_changePass_view()
{
    Main.Content=new changePass_page(this);
}


public void return_home()
{
    if (is_logged_in) Main.Content = new home_page(this);
}


public void logout()
{
    is_logged_in = false;
    Main.Content = new login_page(this);
}
    }
}
