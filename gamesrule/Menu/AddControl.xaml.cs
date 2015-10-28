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

namespace gamesrule
{
    /// <summary>
    /// Interaction logic for AddControl.xaml
    /// </summary>
    public partial class AddControl : UserControl, IPageChange
    {
        public AddControl()
        {
            InitializeComponent();
        }
        public void ActiveState(object state)
        {
            throw new NotImplementedException();
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
