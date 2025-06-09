using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


/*
 * Content Property
 * => Window는 Content 속성에 지정된 객체를 화면에 보여준다.
 */
public class MainWindow : System.Windows.Window
{
    public MainWindow()
    {
        //this.Content = "Hello";
        Button btn = new Button();
        btn.Content = "OK";
        this.Content = btn;
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

