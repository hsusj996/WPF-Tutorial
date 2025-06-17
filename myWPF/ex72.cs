using System;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;

public class MainWindow : System.Windows.Window
{
    protected override void OnMouseDown(MouseButtonEventArgs e)
    {
        base.OnMouseDown(e);
        Console.WriteLine("MouseDown");
    }
}

public class App : System.Windows.Application
{
    [STAThread]
    public static void Main()
    {
        App app = new App();
        //MainWindow window = new MainWindow();

        MainWindow win = null;
        using (FileStream fs = new FileStream("../../ex72.xaml", FileMode.Open))
        {
            win = (MainWindow)XamlReader.Load(fs);
        }
        app.Run(win);
    }
}

