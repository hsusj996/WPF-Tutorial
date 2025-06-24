﻿using System;
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

namespace ELEMENTBINDING
{
    /// <summary>
    /// Ex2Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex2Window : Window
    {
        public Ex2Window()
        {
            InitializeComponent();

            Binding b = new Binding();
            b.Source = slider;
            b.Path = new PropertyPath("Value");
            b.Mode = BindingMode.TwoWay;

            label.SetBinding(Label.FontSizeProperty, b);
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            label.FontSize = 30;
        }
    }
}
