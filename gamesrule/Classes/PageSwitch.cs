using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace gamesrule
{
    public static class PageSwitch
    {
        public static Screen CurrentPage;
        private static UserControl CurrentControl; 
        private static UserControl PrevControl;

        public static void Change(UserControl page)
        {
            if(CurrentControl == null)
            {
                CurrentControl = page;
                CurrentPage.Navigate(CurrentControl);
            }
            else
            {
                PrevControl = CurrentControl;
                CurrentControl = page;
                CurrentPage.Navigate(CurrentControl);
            }
        }

        public static void Backward()
        {
            if(PrevControl != null)
            {
                UserControl temp = CurrentControl;
                CurrentControl = PrevControl;
                PrevControl = temp;
                CurrentPage.Navigate(CurrentControl);
            }
        }

        public static void Change(UserControl page, object state)
        {
            if (CurrentControl == null)
            {
                CurrentControl = page;
                CurrentPage.Navigate(CurrentControl, state);
            }
            else
            {
                PrevControl = CurrentControl;
                CurrentControl = page;
                CurrentPage.Navigate(CurrentControl, state);
            }
        }
    }
}
