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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfConversation.View;

namespace WpfConversation
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        //private static readonly DependencyProperty Userinfoproperty = DependencyProperty.Register("UserInfo", typeof(User), typeof(MainWindow));
        private static readonly DependencyProperty ListChatProperty = DependencyProperty.Register("ListChat", typeof(UserList), typeof(MainWindow));

        public UserList items = new UserList();
        //public BottomUserControl bottomUserControl = new BottomUserControl();
        //public User UserInfo
        //{
        //    get => (User)GetValue(Userinfoproperty);
        //    set => SetValue(Userinfoproperty, value);
        //}

        public UserList ListChat
        {
            get => (UserList)GetValue(ListChatProperty);
            set => SetValue(ListChatProperty, value);
        }


        public MainWindow()
        {
            InitializeComponent();
            Image myImage = new Image();

            myImage.Width = 70;
            myImage.Height = 70;
            BitmapImage myBitmapImage = new BitmapImage();

            myBitmapImage.BeginInit();
            myBitmapImage.UriSource = new Uri(@"C:\Program Files (x86)\douzone\Amaranth10 Messenger\Resources\Img\Emoticon\001-01.png");

            myBitmapImage.DecodePixelWidth = 200;
            myBitmapImage.EndInit();
            //set image source
            myImage.Source = myBitmapImage;

            items.Add(new User() { ItsMe = false, Name = "김병준", Position = "연구원", ContentText = "청산도 산아 우뚝 솟은 푸른 산아 철철철 흐르듯 짙푸른 산아", Type = ContentType.SText });
            items.Add(new User() { ItsMe = true, Name = "청산도", Position = "사원", ContentText = "숱한 나무들 무성히 무성히 우겨진 산마루에", Type = ContentType.SText });
            items.Add(new User() { ItsMe = false, Name = "김병준", Position = "연구원", ContentText = "금빛 기름진 햇살은 내려오고, 둥둥 산을 넘어 흰 구름 걷는 자리", Type = ContentType.SText });
            items.Add(new User() { ItsMe = false, Name = "김병준", Position = "연구원", EmoticonText = "/img/001-01.png", Type = ContentType.Emoticon });
            items.Add(new User() { ItsMe = true, Name = "청산도", Position = "사원", ContentText = "씻기는 하늘 사슴도 안오고 바람도 안불고", Type = ContentType.SText });
            items.Add(new User() { ItsMe = false, Name = "김병준", Position = "연구원", ContentText = "너멋골 골짜기에서 울어오는 뻐꾸기...", Type = ContentType.SText });
            items.Add(new User() { ItsMe = true, Name = "청산도", Position = "사원", EmoticonText = "/img/001-01.png", Type = ContentType.Emoticon });
            items.Add(new User() { ItsMe = false, Name = "김병준", Position = "연구원", ContentText = "너멋골 골짜기에서 울어오는 뻐꾸기...", Type = ContentType.SText });

            chatListView.ItemsSource = items;
            bottomUserControl.Item(items, chatListView);

            chatListView.SelectedIndex = chatListView.Items.Count - 1;
            chatListView.ScrollIntoView(chatListView.SelectedItem);
            //this.DataContext = UserInfo;

        }


        private void BottomUserControl_SendChat(User user)
        {
            items.Add(user);
        }
    }

    public class UserList : ObservableCollection<User>
    {
    }

    public class PremiumUserDataTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement elemnt = container as FrameworkElement;
            User user = item as User;
            if(user.ItsMe == true) {
                if(user.Type == ContentType.SText) {
                    Console.WriteLine(user.Type);
                    return elemnt.FindResource("MyTextDataTemplate") as DataTemplate;
                } else if(user.Type == ContentType.Emoticon) {
                    Console.WriteLine(user.Type);
                    return elemnt.FindResource("MyEmoticonDataTemplate") as DataTemplate;
                } else {
                    Console.WriteLine(user.Type);
                    return elemnt.FindResource("MyImgDataTemplate") as DataTemplate;
                }
            } else {
                if(user.Type == ContentType.SText) {
                    Console.WriteLine(user.Type);
                    return elemnt.FindResource("YourTextDataTemplate") as DataTemplate;
                }
                else if(user.Type == ContentType.Emoticon) {
                    Console.WriteLine(user.Type);
                    return elemnt.FindResource("YourEmoticonDataTemplate") as DataTemplate;

                } else {
                    return elemnt.FindResource("YourImgDataTemplate") as DataTemplate;
                }
            }
        }
    }

}
