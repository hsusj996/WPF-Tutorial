using System;
using System.Windows;
using System.Windows.Input;

public class MainWindow : System.Windows.Window
{
    public MainWindow()
    {

    }
}

public class App : System.Windows.Application
{
    [STAThread]
    public static void Main()
    {
        App app = new App();
        MainWindow window = new MainWindow();
        app.Run(window);
    }
}

