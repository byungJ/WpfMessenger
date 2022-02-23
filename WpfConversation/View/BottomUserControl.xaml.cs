using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace WpfConversation.View
{
    /// <summary>
    /// BottomUserControl.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BottomUserControl : UserControl
    {
        // 이벤트를 생성하기
        public event Action<User> SendChat;
        string text;
        User userData = null;
        string emoticon_path;

        public UserList items
        {
            get; set;
        }

        public ListView list;
        //public static readonly DependencyProperty UserInfoProperty = DependencyProperty.Register("UserInfo", typeof(User), typeof(MainWindow));

        //public User UserInfo
        //{
        //    get => (User)GetValue(UserInfoProperty);
        //    set => SetValue(UserInfoProperty, value);
        //}
        public BottomUserControl()
        {
            InitializeComponent();
            //TextBox에 있는 PreviewKeyDown이벤트에 KeyEventHandler을 사용해서 내가만든 함수에 연결 - XAML 에서 직접 실행으로 변경했음
            //
            // 요약:
            //     관련 연결된 이벤트와 미리 보기 이벤트뿐만 아니라 System.Windows.UIElement.KeyUp 및 System.Windows.UIElement.KeyDown
            //     라우트된 이벤트를 처리할 메서드를 나타냅니다.
            //tb.PreviewKeyDown += new KeyEventHandler(OnKeyDownHandler);
        }

        public void Item(UserList items, ListView list)
        {
            this.items = items;
            this.list = list;
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
          
            text = tb.Text;

            if (text == null || text.Trim() == "") {
                return;
            }
            if (checkMe.IsChecked == true) {
                //this.items.Add(new User() { ItsMe = false, Name = "청산도", Position = "연구원", Contents = tb.Text });
                if (SendChat != null) {
                    userData = new User() { ItsMe = false, Name = "김병준T", Position = "연구원", ContentText = text , Type = ContentType.SText };
                }
            }
            else {
                userData = new User() { ItsMe = true, Name = "김병준T", Position = "연구원", ContentText = text, Type = ContentType.SText };
            }

            if (SendChat != null && userData != null) {
               //이벤트 실행...
               SendChat(userData);
            }
            
            list.SelectedIndex = list.Items.Count - 1;
            list.ScrollIntoView(list.SelectedItem);
            tb.Clear();
        }

        // 매개 변수:
        //   sender: 이벤트 처리기가 연결된 개체입니다.
        //   e:이벤트 데이터입니다.
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {

            // AcceptsReturn="True"시 shift + enter, enter 둘다 한칸 밑으로 줄 바꿉합니다.
            // shift + enter에만 메시지를 한 칸 밑으로 이동하고, enter 입력시에는 메시지를 전송하도로 if(조건문)을 설정.
            // 조건: enter키가 들어왔고(true), shift를 비트연산으로 비교 true != true -> false, true && false
            // e.KeyboardDevice.Modifiers: 현재 눌러진 ModifierKeys(전부)를 가져옵니다.
            if (e.Key == Key.Enter && (e.KeyboardDevice.Modifiers & ModifierKeys.Shift) != ModifierKeys.Shift) {
                btnSend_Click(sender, e);
                e.Handled = true;
            }

        }

        //파일참조(추가)
        private void BtnImg_Click(object sender, RoutedEventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //if (openFileDialog.ShowDialog() == true) {
            //    text = openFileDialog.FileName;    
            //    if (checkMe.IsChecked == true) {
            //        this.items.Add(new User() { ItsMe = false, Name = "청산도", Position = "연구원", ContentText = text});
            //    }
            //    else {
            //        this.items.Add(new User() { ItsMe = true, Name = "청산도", Position = "연구원", ContentText = text});
            //    }
            //}
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "Images";
            dlg.DefaultExt = ".jpg";
            dlg.Filter = "JPEG |*.jpg| GIF |*.gif| PNG |*.png";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true) { 
                string selectedFileName = dlg.FileName;
                //BitmapImage bitmap = new BitmapImage();
                //bitmap.BeginInit();
                //bitmap.UriSource = new Uri(selectedFileName);
                //bitmap.EndInit();
                //ImgUserImage.Source = bitmap;
                if (checkMe.IsChecked == true) {
                    this.items.Add(new User() { ItsMe = false, Name = "김병준I", Position = "연구원", ImgText = selectedFileName, Type = ContentType.Img });
                }
                else {
                    this.items.Add(new User() { ItsMe = true, Name = "김병준I", Position = "연구원", ImgText = selectedFileName, Type = ContentType.Img });
                }
            }

            list.SelectedIndex = list.Items.Count - 1;
            list.ScrollIntoView(list.SelectedItem);
        }

        private void BtnImg_Click_Image(object sender, RoutedEventArgs e)
        {
            ImgWindow imgWindow = new ImgWindow();
            imgWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            imgWindow.Show();
            imgWindow.EmoticonSend += EmoticonSendHandler;
        }

        private void EmoticonSendHandler(string eid)
        {
            emoticon_path = eid;
            if (checkMe.IsChecked == true) {
                this.items.Add(new User() { ItsMe = false, Name = "김병준E", Position = "연구원", EmoticonText = emoticon_path });
            }
            else {
                this.items.Add(new User() { ItsMe = true, Name = "김병준E", Position = "연구원", EmoticonText = emoticon_path });
            }
            list.SelectedIndex = list.Items.Count - 1;
            list.ScrollIntoView(list.SelectedItem);
        }
    }
}
