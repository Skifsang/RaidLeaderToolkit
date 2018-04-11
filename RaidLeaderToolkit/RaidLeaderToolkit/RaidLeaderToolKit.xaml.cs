using System;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;

namespace RaidLeaderToolkit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var json = new WebClient().DownloadString("Some url");
            
            TBV.Text = json;
        }
    }
}
