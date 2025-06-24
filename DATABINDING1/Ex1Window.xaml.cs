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

namespace DATABINDING1
{
    /// <summary>
    /// Ex1Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex1Window : Window
    {
        public Person person; 
        public Ex1Window()
        {
            InitializeComponent();

            person = new Person();
            person.Name = "홍길동";
            person.Address = "서울시 강남구 역삼동 123-456";

            stackpanel.DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            person.Name = "이순신";
            person.Address = "서울시 종로구 청운동 789-012";
        }
    }
}
