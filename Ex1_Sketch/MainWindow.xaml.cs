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

namespace Ex1_Sketch
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //canvas.Background = new SolidColorBrush(Colors.LightGray);
        }

        private Point ptFrom;

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {

            if(e.LeftButton != MouseButtonState.Pressed)
                return;

            Point ptTo = e.GetPosition(this);

            Line line = new Line();
            line.Stroke = new SolidColorBrush(Colors.Red);

            line.X1 = ptFrom.X;
            line.Y1 = ptFrom.Y;
            line.X2 = ptTo.X;
            line.Y2 = ptTo.Y;

            canvas.Children.Add(line);

            ptFrom = ptTo;
        }

        private void canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ptFrom = e.GetPosition(this);
        }
    }
}
