﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Sérieathon
{
    /// <summary>
    /// Interaction logic for UC_connexion.xaml
    /// </summary>
    public partial class UC_connexion : UserControl
    {
        public UC_connexion()
        {
            InitializeComponent();
        }

        private void Validation_click(object sender, RoutedEventArgs e)
        {
            Seriathon main_window = new Seriathon();
            main_window.Show();

            // close déprécié, a modifier par un manager
            // (App.Current as App).Accueil.Close();
        }
    }
}
