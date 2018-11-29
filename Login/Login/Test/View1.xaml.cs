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
using Login.Test;

namespace Login
{
    /// <summary>
    /// Interaction logic for View1.xaml
    /// </summary>
    public partial class View1 : UserControl
    {
        private IInsertView iiInsertView;
        public View1()
        {
            InitializeComponent();
        }
        public View1(IInsertView iiInsertView)
        {
            InitializeComponent();
            this.iiInsertView = iiInsertView;

        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            iiInsertView.InsertView(new View2());
        }
    }
}
