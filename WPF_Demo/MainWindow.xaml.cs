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

namespace WPF_Demo
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
  
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Outer Button Clicked");
        }

        private void Inner_Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Inner Button is Clicked");
        }
        private void secondEllipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Title = "Second Ellipse Key Down Called";
            MessageBox.Show("Second Ellipse is Clicked");
        }

        private void oneEllipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Title = "One Ellipse Key Down Called";
            //MessageBox.Show("One Ellipse is Clicked");
        }
    }
}
