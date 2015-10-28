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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Screen : Window
    {
        public Screen()
        {
            InitializeComponent();
            PageSwitch.CurrentPage = this;
            PageSwitch.Change(new MainControl());
        }

        public void Navigate(UserControl page)
        {
            this.Content = page;
        }

        public void Navigate(UserControl page, object state)
        {
            this.Content = page;
            IPageChange s = page as IPageChange;
            if(s != null)
            {
                s.ActiveState(state);
            }
            else
            {
                throw new ArgumentException("Cannot switch page, " + page.Name.ToString());
            }
        }
    }
}
