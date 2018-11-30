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
    /// Interaction logic for changePass_page.xaml
    /// </summary>
    public partial class changePass_page : UserControl
    {
        private changePass_inteface CHANGEPASSWORD;
        public changePass_page()
        {
            InitializeComponent();
        }
        public changePass_page(changePass_inteface CHANGEPASSWORD)
        {
            InitializeComponent();
            this.CHANGEPASSWORD = CHANGEPASSWORD;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (newPass.Password == newPass_again.Password)
            {
                if (currentPass.Password == this.CHANGEPASSWORD.getPass())
                {
                    this.CHANGEPASSWORD.changePassword(newPass.Password);
                    MessageBox.Show("changed successfuly.");
                    this.CHANGEPASSWORD.return_home();
                }
                else
                {
                    MessageBox.Show("current password is incorrect.");

                }
            }
            else
            {
                MessageBox.Show("new password doesn't match.");
            }
        }

        private void Back_OnClick(object sender, RoutedEventArgs e)
        {
            this.CHANGEPASSWORD.return_home();
        }
    }
}
