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
    /// MiddleMyUserControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MiddleMyUserControl : UserControl
    {
        public static readonly DependencyProperty MyProperty = DependencyProperty.Register("My", typeof(User), typeof(MiddleMyUserControl));


        public MiddleMyUserControl()
        {
            InitializeComponent();
            //My = new User
            //{
            //    Contents = "안녕하세요,,,,만나서 반갑습니다,,,,앞으로 잘 부탁드려요 후후후후후후"
            //};
            //this.DataContext = My;
            //if (ContentType.Emoticon == ???) {
            //    emoticon.Visibility = Visibility.Visible;
            //} else {
            //    text.Visibility = Visibility.Visible;
            //}
          
        }

        public User My
        {
            get => (User)GetValue(MyProperty);
            set => SetValue(MyProperty,value);
        }
    }
}
