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

namespace Ex2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            grid.RowDefinitions.Add(new RowDefinition());
            grid.RowDefinitions.Add(new RowDefinition());

            button2.Click += Button2_Click;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button 2 Clicked!");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Button Clicked!");
        }
    }
}
