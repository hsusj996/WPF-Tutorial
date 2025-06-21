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

namespace STYLE1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Style style = new Style();
            style.Setters.Add(new Setter(Control.ForegroundProperty,
                            new SolidColorBrush(Colors.White)));
            style.Setters.Add(new Setter(Control.BackgroundProperty,
                            new SolidColorBrush(Colors.Red)));
            style.Setters.Add(new Setter(Control.FontSizeProperty,
                            (Double)30));
            this.Resources["redstyle"] = style;
            InitializeComponent();

            button2.Style = style;
        }
    }
}
