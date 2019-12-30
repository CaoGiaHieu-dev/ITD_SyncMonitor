
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace ITD_SyncMonitor
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

        List<connectchecker> list = new List<connectchecker>();


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }
        public class connectchecker
        {
            public string name { get; set; }
            public string IpAddress { get; set; }
            public string LanetoServerState { get; set; }
            public string ServerToLaneState { get; set; }
            public string OnlineState { get; set; }
            public string LastActiveDate { get; set; }
            public string LastOnlineDate { get; set; }
        }

        private void txt_StationIP_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //if (!char.IsDigit(e.Text, e.Text.Length - 1))
            //    e.Handled = true;
        }
        private void txt_LaneIP_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            //if (!char.IsDigit(e.Text, e.Text.Length - 1))
            //    e.Handled = true;
        }

        private void btn_add_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btn_connectStation_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btn_ConnectLane_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
