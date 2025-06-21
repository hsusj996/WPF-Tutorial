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

namespace STYLE2
{
    /// <summary>
    /// Example3.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Example3 : Window
    {
        public Example3()
        {
            InitializeComponent();
        }

        private Brush highlightBrush = new SolidColorBrush(Colors.Yellow);
        private void element_MouseEnter(object sender, MouseEventArgs e)
        {
            Label lb = (Label)sender;
            lb.Background = highlightBrush;
        }
        private void element_MouseLeave(object sender, MouseEventArgs e)
        {
            Label lb = (Label)sender;
            lb.Background = null;
        }
    }
}
