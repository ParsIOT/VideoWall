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
    /// Interaction logic for home_page.xaml
    /// </summary>
    public partial class home_page : UserControl
    {
        private home_interface HOME;
        public home_page()
        {
            InitializeComponent();
        }
        public home_page(home_interface HOME)
        {
            InitializeComponent();
            this.HOME = HOME;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.HOME.show_changePass_view();
        }

        private void Logout_OnClick(object sender, RoutedEventArgs e)
        {
            this.HOME.logout();
        }
    }
}
