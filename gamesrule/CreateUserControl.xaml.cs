﻿using System;
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
    /// Interaction logic for CreateUserControl.xaml
    /// </summary>
    public partial class CreateUserControl : UserControl
    {
        public CreateUserControl()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            PageSwitch.Backward();
        }
    }
}
