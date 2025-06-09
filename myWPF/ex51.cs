using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;


/*
 * 윈도우에 한 개의 버튼이 아닌 여러 개의 자식 컨트롤을 보여주고 싶다면?
 * -> Layout Control을 사용해야 한다.
 */
public class MainWindow : System.Windows.Window
{
    public MainWindow()
    {
        BitmapImage bitmap = new BitmapImage();
        bitmap.BeginInit();
        bitmap.UriSource = new Uri("C:\\Users\\tpwls\\Documents\\myWPF\\myWPF\\myWPF\\test.jpg");
        bitmap.EndInit();

        Image img = new Image();
        img.Source = bitmap;
        img.Stretch = System.Windows.Media.Stretch.Fill;    // Window 크기에 맞게 이미지를 Stretch
        this.Content = img;
    }
}

public class App : System.Windows.Application
{
    [STAThread]
    public static void Main()
    {
        App app = new App();
        MainWindow win = new MainWindow();
        app.Run(win);
    }
}
