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

namespace RESOURCE
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //this.Resources["MyBrush"] = new SolidColorBrush(Colors.Yellow);
            InitializeComponent();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["MyBrush"] = new SolidColorBrush(Colors.Red);
        }
    }
}
