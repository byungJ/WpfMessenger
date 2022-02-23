using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// ProfileMiddleView.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ProfileMiddleView : UserControl
    {
        public static readonly DependencyProperty UserInfoOfMiddleProperty = DependencyProperty.Register("UserInfoOfMiddle", typeof(User), typeof(ProfileMiddleView));
        public User UserInfoOfMiddle
        {
            get => (User)GetValue(UserInfoOfMiddleProperty);
            set => SetValue(UserInfoOfMiddleProperty, value);
        }


        public ProfileMiddleView()
        {
            InitializeComponent();
        }

        //public class UserListColl1 : ObservableCollection<User> { }
    }
}