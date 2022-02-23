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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFProfileJoin
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {

        public static readonly DependencyProperty UserInfoProperty = DependencyProperty.Register("UserInfo", typeof(User), typeof(MainWindow));

        public User UserInfo
        {
            get => (User)GetValue(UserInfoProperty);
            set => SetValue(UserInfoProperty, value);
        }

        public MainWindow()
        {
            InitializeComponent();
            
            UserInfo = new User
            {
                Building = "더존비즈온-솔루션사업부문-솔루션개발본부-개발1센터-솔루션개발1Unit-모바일Cell-멤버",
                Cake = "03월 22일",
                Com = "윈도우메신저개발",
                Fax = "0262335180",
                Tele = "0262335135",
                Name = "알감자",
                Id = "qudwns6122",
                Mess1 = "qudwns6122@douzone.com",
                Mess2 = "bj6122@naver.com",
                Book = "강원 춘천시 남산면 버들1길 130\n더존비즈온 본관 2층",
                Phone = "01076306122"
            };

            //this.DataContext = new User
            //{
            //    Building = "더존비즈온-솔루션사업부문-솔루션개발본부-개발1센터-솔루션개발1Unit-모바일Cell-멤버",
            //    Cake = "03월 22일",
            //    Com = "윈도우메신저개발",
            //    Fax = "0262335180",
            //    Tele = "0262335135",
            //    Name = "알감자",
            //    Id = "qudwns6122",
            //    Mess1 = "qudwns6122@douzone.com",
            //    Mess2 = "bj6122@naver.com",
            //    Book = "강원 춘천시 남산면 버들1길 130 \n 더존비즈온 본관 2층",
            //    Phone = "01076306122"
            //};
            // DataContext="{Binding ElementName=userInfo, Path=UserInfo}" Text="{Binding Com}" ---> Text="{Binding Com}"
        }
    }
}
