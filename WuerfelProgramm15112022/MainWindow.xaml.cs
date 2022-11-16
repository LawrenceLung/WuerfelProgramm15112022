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

namespace WuerfelProgramm15112022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int count4 = 0;
        static int count6 = 0;
        static int count8 = 0;
        static int count10 = 0;
        static int count12 = 0;
        static int count20 = 0;
        static int count100 = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            count4++;
            TextBlock1.Text = $"{count4}x";

        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            count6++;
            TextBlock2.Text = $"{count6}x";
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            count8++;
            TextBlock3.Text = $"{count8}x";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            count10++;
            TextBlock4.Text = $"{count10}x";
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            count12++;
            TextBlock5.Text = $"{count12}x";
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            count20++;
            TextBlock6.Text = $"{count20}x";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            count100++;
            TextBlock7.Text = $"{count100}x";
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EnterTaste_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
