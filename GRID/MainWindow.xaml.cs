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

namespace GRID
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Grid.SetRow(button1, 1);
            Grid.SetColumn(button1, 0);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Button button = grid.Children.Cast<Button>().FirstOrDefault(
                btn => Grid.GetRow(btn) == 1 && Grid.GetColumn(btn) == 0);

            if (button == null) { 
                MessageBox.Show("해당 위치에 버튼이 없습니다.");
            }
            else
            {
                Grid.SetRow(button, 0);
                Grid.SetColumn(button, 0);
            }
        }
    }
}
