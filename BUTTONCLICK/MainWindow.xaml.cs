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

namespace BUTTONCLICK
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Button btn = (Button)sender;

            //Console.WriteLine($"{btn.Name}, {btn.Content}, {btn.Tag}");
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            //Button btn = (Button)sender; // sender는 StackPanel이므로, StackPanel의 자식인 Button을 찾기 위해 sender를 Button으로 캐스팅합니다.
            Button btn = (Button) e.Source;


            Console.WriteLine($"{btn.Name}, {btn.Content}, {btn.Tag}");
        }
    }
}
