﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace heal_n_fun
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class loginas : Page
    {
        public loginas()
        {
            this.InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(loginoptions), null);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msg = new MessageDialog("First select your login mode & try again.");
            msg.ShowAsync();
            textBox.Text = "";
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msg = new MessageDialog("First select your login mode & try again.");
            msg.ShowAsync();
            textBox.Text = "";
        }

       
    }
}