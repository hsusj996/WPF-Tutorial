using System;
using System.Windows;
using System.Windows.Input;

public class MainWindow : System.Windows.Window
{
   public void Fn()
    {
        Console.WriteLine("Fn");
    }
}

public class App : System.Windows.Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        ((MainWindow)this.MainWindow).Fn();
    }

    protected override void OnExit(ExitEventArgs e)
    {
        base.OnExit(e);

        //((MainWindow)this.MainWindow).Fn();     // OnExit은 윈도우가 파괴 된 후 호출하기 때문에 MainWindow 인스턴스를 불러올 수 없다.

        Console.WriteLine($"{this.MainWindow == null}");
    }

    [STAThread]
    public static void Main()
    {
        App app = new App();
        MainWindow window = new MainWindow();
        app.Run(window);
    }
}

