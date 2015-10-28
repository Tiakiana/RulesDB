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
    /// Interaction logic for MainControl.xaml
    /// </summary>
    public partial class MainControl : UserControl, IPageChange
    {
        public MainControl()
        {
            InitializeComponent();
            AppController.GenerateRandomGame(true);
            GetNewList();
        }
        public void ActiveState(object state)
        {
            throw new NotImplementedException();
        }

        private void GetNewList()
        {
            AppController.GetList(Database.Games, ref listBoxNewGame);
        }

        private void boxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && this.boxSearch.Text.Length > 0)
            {
                PageSwitch.Change(new SearchControl(this.boxSearch.Text));
            }
        }

        private void listBoxNewGame_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(this.listBoxNewGame.SelectedIndex != -1 && Database.Games.ElementAt(this.listBoxNewGame.SelectedIndex) != null)
            {
                PageSwitch.Change(new GameControl(Database.Games.ElementAt(this.listBoxNewGame.SelectedIndex)));
            }
        }

        private void buttonAddGame_Click(object sender, RoutedEventArgs e)
        {
            PageSwitch.Change(new AddControl());
        }

        private void buttonMenu_Click(object sender, RoutedEventArgs e)
        {
            PageSwitch.Change(new MenuControl());
        }
    }
}
