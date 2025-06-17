﻿using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
/*
 * UI using XAML
 */

public class MainWindow : System.Windows.Window
{
    protected void InitializeComponent()
    {
        Grid grid = null;
        using (FileStream fs = new FileStream("../../ex70.xaml", FileMode.Open))
        {
            grid = (Grid)XamlReader.Load(fs);
        }

        this.Content = grid;

        Button btn = (Button)grid.FindName("button1");
        btn.Click += Btn_Click;
    }

    private void Btn_Click(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("Button Clicked");
    }

    public MainWindow()
    {
        InitializeComponent();
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

