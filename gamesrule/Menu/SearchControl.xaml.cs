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
    /// Interaction logic for SearchControl.xaml
    /// </summary>
    public partial class SearchControl : UserControl, IPageChange
    {
        
        public SearchControl()
        {
            InitializeComponent();
        }
        public SearchControl(string search)
        {
            InitializeComponent();
            Searching(search);
        }
        public void ActiveState(object state)
        {
            throw new NotImplementedException();
        }

        private void Searching(string input)
        {
            this.boxSearch.Text = input;
            List<Game> result = AppController.Search(input);
            labelResult.Content = result.Count.ToString();
            if (result.Count > 0)
            {
                AppController.GetList(result, ref listBoxResult);
            }

            boxSearch.Focus();
            boxSearch.SelectionStart = boxSearch.Text.Length;
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            PageSwitch.Change(new MainControl());
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && boxSearch.Text.Length > 0)
            {
                Searching(boxSearch.Text);
            }
        }

    }
}
