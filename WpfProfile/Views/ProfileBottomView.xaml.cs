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

namespace WpfProfile.Views
{
    /// <summary>
    /// ProfileBottomView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ProfileBottomView : UserControl
    {
        public static readonly DependencyProperty UserInfoProperty = DependencyProperty.Register("UserInfo", typeof(User), typeof(ProfileBottomView));
        public User UserInfo
        {
            get => (User)GetValue(UserInfoProperty);
            set => SetValue(UserInfoProperty, value);
        }

        public ProfileBottomView()
        {
            InitializeComponent();
        }
    }
}
