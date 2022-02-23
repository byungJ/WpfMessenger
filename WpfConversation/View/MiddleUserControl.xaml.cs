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

namespace WpfConversation.View
{
    /// <summary>
    /// MiddleUserControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MiddleUserControl : UserControl
    {
        public static readonly DependencyProperty MiddleUserInfoProperty = DependencyProperty.Register("MiddleUserInfo", typeof(User), typeof(MiddleUserControl));

        public User MiddleUserInfo
        {
            get => (User)GetValue(MiddleUserInfoProperty);
            set => SetValue(MiddleUserInfoProperty, value);
        }
        public MiddleUserControl()
        {
            InitializeComponent();
            //MiddleUserInfo = new User
            //{
            //    Name = "김병준",
            //    Position = "연구원",
            //    Contents = "안녕하세요. 신입사원 김병준입니다. 잘 부탁드립니다~"
            //};
            //this.DataContext = MiddleUserInfo;

        }
    }
}
