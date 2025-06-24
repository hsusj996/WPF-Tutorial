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
    /// Ex3Window.xaml에 대한 상호 작용 논리
    /// </summary>

    public partial class Ex3Window : Window
    {
        public ObservableCollection<Person> st = new ObservableCollection<Person>();
        public Ex3Window()
        {
            InitializeComponent();

            st.Add(new Person { Name = "홍길동", Address = "서울시 강남구 역삼동 123-456" });
            st.Add(new Person { Name = "이순신", Address = "서울시 종로구 청운동 789-012" });
            st.Add(new Person { Name = "강감찬", Address = "서울시 중구 명동 345-678" });
            st.Add(new Person { Name = "김유신", Address = "서울시 강서구 화곡동 901-234" });

            listview.ItemsSource = st;
        }
    }
}
