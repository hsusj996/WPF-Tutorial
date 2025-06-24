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
using System.Windows.Shapes;

namespace ELEMENTBINDING
{
    /// <summary>
    /// Ex1Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex1Window : Window
    {
        public Ex1Window()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            label.FontSize = 30;
            slider.Value = 30;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            label.FontSize = slider.Value;
        }
    }
}
