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
    /// Interaction logic for GameControl.xaml
    /// </summary>
    public partial class GameControl : UserControl, IPageChange
    {
        public GameControl()
        {
            InitializeComponent();
        }
        public GameControl(Game data)
        {
            InitializeComponent();
            User author = Database.Users.Find(x => x.ID == data.UserID);
            this.labelAuthor.Content = author.Name;
            this.labelGame.Content = data.Name;
            this.boxDescription.Text = data.Description;
            this.boxRequirement.Text = data.Requirement;
            this.labelType.Content = data.Type == Game.Category.Drink ? "Drink game" : "Child game";
        }

        public void ActiveState(object state)
        {
            throw new NotImplementedException();
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            PageSwitch.Backward();
        }
    }
}
