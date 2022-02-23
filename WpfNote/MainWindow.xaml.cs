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

namespace WpfNote
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _vm = new MainViewModel();
        UserListColl users = new UserListColl();
        List<User> users2 = new List<User>();

        public static string textbox = "This TextBox will allow the user to enter multiple lines of text.  When the RETURN key is pressed, " +
        "or when typed text reaches the edge of the text box, a new line is automatically inserted.";

        public MainWindow()
        {
            InitializeComponent();
            

            users.Add(new User() { A = 1, F = 1, W = 1, Name = "KBJ1", Text = "청산도 산아 우뚞 솟은 푸른산아,", Category = "일반", Time = new DateTime(1993, 6, 22), TimeString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
            users.Add(new User() { A = 2, F = 2, W = 2, Name = "KBJ2", Text = "철철철 흐르듯 짙푸른 산아.", Category = "예약", Time = new DateTime(1991, 9, 23), TimeString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
            users.Add(new User() { A = 3, F = 3, W = 3, Name = "KBJ3", Text = "숱한 나무들 무성히 무성히 우겨진 산마루에.", Category = "일반", Time = new DateTime(1992, 1, 12), TimeString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
            users.Add(new User() { A = 4, F = 4, W = 4, Name = "KBJ4", Text = "금빛 기름진 햇살은 내려오고 .", Category = "예약", Time = new DateTime(1995, 3, 22), TimeString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
            users.Add(new User() { A = 5, F = 5, W = 5, Name = "KBJ5", Text = "둥둥 산을 넘어 흰 구름 걷는 자리.", Category = "일반", Time = new DateTime(2001, 9, 2), TimeString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
            users.Add(new User() { A = 6, F = 6, W = 6, Name = "KBJ6", Text = "씻기는 하늘 사슴도 안오고 바람도 안불고.", Category = "일반", Time = new DateTime(2001, 11, 9), TimeString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });
            users.Add(new User() { A = 7, F = 7, W = 7, Name = "KBJ7", Text = "너멋골 골짜기에서 울어오는 뻐꾸기.....", Category = "예약", Time = new DateTime(2002, 10, 5), TimeString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });


            //dgUsers.ItemsSource = users;

            this.DataContext = _vm;
            //gridmain.DataContext = _vm;
            dgUsers.ItemsSource = users;

            

            _vm.EventTest += _vm_EventTest;

        }

        private int _vm_EventTest(string msg)
        {
            Console.WriteLine(msg);
            return 90129301;
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            _vm.DetailMessage = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            int count = users.Count + 1;

            users.Add(new User() { A = count, F = count, W = count, Name = "KBJ7", Text = "너멋골 골짜기에서 울어오는 뻐꾸기.....", Category = "예약", Time = new DateTime(2002, 10, 5), TimeString = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") });

        }

        private void dgUsers_Selected(object sender, SelectedCellsChangedEventArgs e)
        {
            _vm.DetailMessage = users.ElementAt(dgUsers.SelectedIndex).Text;
        }
    }

    //public class User
    //{
    //    public int A { get; set; }
    //    public int F { get; set; }
    //    public int W { get; set; }
    //    public string Name { get; set; }
    //    public string Text { get; set; }
    //    public string Title { get; set; }
    //    public string Category { get; set; }
    //    public DateTime Time { get; set;}
    //    public string TimeString { get; set; }

 
    //}
}
