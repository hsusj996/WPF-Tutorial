using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Ex2Window.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex2Window : Window
    {
        //public List<Person> st = new List<Person>();
        public ObservableCollection<Person> st = new ObservableCollection<Person>();
        public Ex2Window()
        {
            InitializeComponent();

            st.Add(new Person { Name = "홍길동", Address = "서울시 강남구 역삼동 123-456" });
            st.Add(new Person { Name = "이순신", Address = "서울시 종로구 청운동 789-012" });

            listbox.ItemsSource = st;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            st[0].Name = "김유신";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            st.Add(new Person { Name = "강감찬", Address = "서울시 중구 명동 345-678" });
        }
    }
}
