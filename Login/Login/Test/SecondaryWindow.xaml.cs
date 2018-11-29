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
using System.Windows.Shapes;
using Login.Test;

namespace Login
{
    /// <summary>
    /// Interaction logic for SecondaryWindow.xaml
    /// </summary>
    public partial class SecondaryWindow : Window, IInsertView
    {
        public SecondaryWindow()
        {
            InitializeComponent();
            Frame.Content = new View1(this);
        }

        public void InsertView(UserControl view)
        {
            Frame.NavigationService.Navigate(view);
        }
    }
}
