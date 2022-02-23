using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WpfOr
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        string name = "";
        SQLiteConnection conn = null;
        string filepath = @"C:\Users\김병준\Documents\Amaranth10\BizBoxAOrg.sqlite";

        public MainWindow()
        {
            InitializeComponent();
            List<Department> families = new List<Department>();

            Department department = new Department() { DepartmentName = "모바일Cell" };

            Team team = new Team() { TeamName = "리더" };
            Team teamA = new Team() { TeamName = "Android" };
            Team teamI = new Team() { TeamName = "iOS" };
            Team teamM = new Team() { TeamName = "메신저&데이터" };
            Team teamP = new Team() { TeamName = "기획" };


            team.Members.Add(new TeamMember() { Name = "김태호", Duty = "모바일", Position = "수석연구원", State = "0", Auth = false });

            teamA.Members.Add(new TeamMember() { Name = "김지섭", Duty = "Android 개발", Position = "주임연구원", State = "0", Auth = false });
            teamA.Members.Add(new TeamMember() { Name = "우영윤", Duty = "Android 개발", Position = "주임연구원", State = "1", Auth = false });
            teamA.Members.Add(new TeamMember() { Name = "김제헌", Duty = "Android 개발", Position = "주임연구원", State = "0", Auth = false });
            teamA.Members.Add(new TeamMember() { Name = "김준형", Duty = "Android 개발", Position = "주임연구원", State = "1", Auth = false });
            teamA.Members.Add(new TeamMember() { Name = "곽지선", Duty = "Android 개발", Position = "주임연구원", State = "2", Auth = false });
            teamA.Members.Add(new TeamMember() { Name = "윤혜미", Duty = "Android 개발", Position = "주임연구원", State = "0", Auth = false });

            teamI.Members.Add(new TeamMember() { Name = "서정준", Duty = "iOS 개발", Position = "책임연구원", State = "2", Auth = false });
            teamI.Members.Add(new TeamMember() { Name = "김지욱", Duty = "iOS 개발", Position = "주임연구원", State = "0", Auth = false });
            teamI.Members.Add(new TeamMember() { Name = "유현재", Duty = "iOS 개발", Position = "주임연구원", State = "1", Auth = false });
            teamI.Members.Add(new TeamMember() { Name = "이상봉", Duty = "iOS 개발", Position = "연구원", State = "2", Auth = false });
            teamI.Members.Add(new TeamMember() { Name = "윤형찬", Duty = "iOS 개발", Position = "연구원", State = "0", Auth = false });

            teamM.Members.Add(new TeamMember() { Name = "이한형", Duty = "메신저", Position = "선임연구원", State = "1", Auth = false });
            teamM.Members.Add(new TeamMember() { Name = "유효진", Duty = "데이터", Position = "사원", State = "1", Auth = false });
            teamM.Members.Add(new TeamMember() { Name = "한승엽", Duty = "데이터", Position = "사원", State = "2", Auth = false });
            teamM.Members.Add(new TeamMember() { Name = "김병준", Duty = "메신저", Position = "연구원", State = "0", Auth = true }); ;
            
            teamP.Members.Add(new TeamMember() { Name = "김예찬", Duty = "모바일 기획", Position = "대리", State = "1", Auth = false });
            teamP.Members.Add(new TeamMember() { Name = "방유라", Duty = "모바일 기획", Position = "사원", State = "0", Auth = false });
            teamP.Members.Add(new TeamMember() { Name = "이인경", Duty = "모바일 기획", Position = "사원", State = "2", Auth = false });

            department.Teams.Add(team);
            department.Teams.Add(teamA);
            department.Teams.Add(teamI);
            department.Teams.Add(teamM);
            department.Teams.Add(teamP);

            families.Add(department);
            trvFamilies.ItemsSource = families;

            string path = "Data Source=" + filepath;
            conn = new SQLiteConnection(path);
            conn.Open();
            tbSearchTextBox.Text = "sucess";

            string sql = @"select t_co_comp_multi.comp_name from t_co_comp join t_co_comp_multi on t_co_comp.comp_seq = t_co_comp_multi.comp_seq where t_co_comp.comp_seq = 6 AND lang_code = 'kr'";

            SQLiteCommand cmd = new SQLiteCommand(sql, conn);
            SQLiteDataReader rdr = cmd.ExecuteReader();
            string all = "";

            while (rdr.Read())
            {
                all += rdr["comp_name"];
            }
            tbSearchTextBox.Text = all;

            rdr.Close();

            // 트리뷰 로드가 끝나면 이벤트를 실행.
            trvFamilies.Loaded += TrvFamilies_Loaded;
        }

        private void TrvFamilies_Loaded(object sender, RoutedEventArgs e)
        {
            // Department
            foreach (object item in this.trvFamilies.Items)
            {
                // Department여러개 있을수도 있음,,현재 여기서는 한개
                // 여러개의 Department여러개에서 현재 item으로 나온 Department를 item으로 반환.
                TreeViewItem treeItem = this.trvFamilies.ItemContainerGenerator.ContainerFromItem(item) as TreeViewItem;
                if (treeItem != null)
                {
                    // 반환받은 item , 찾고싶은 사용자
                    JumpToNode(treeItem, "김병준");
                }
                //treeItem.IsExpanded = true;
            }
        }

        bool JumpToNode(TreeViewItem tvi, string NodeName)
        {
            var dataCtx = tvi.DataContext;
           
            // 데이터에 TeamMember가 있는지 검사 && 데이터에서 Name 찾아서 비교.
            if (dataCtx is TeamMember && (dataCtx as TeamMember).Name == NodeName)
            {
                tvi.IsSelected = true;

                //이 요소를 포함된 스크롤 가능한 영역 내에서 뷰에 표시하려고 합니다.
                //tvi.BringIntoView();
                Console.WriteLine("1");
                return true;
            }

            if (tvi.HasItems)
            {
                // 접혀있는 상태에서는 null이 들어오기 때문에 펼친 상태에서 업데이트를 한 후 데이터를 읽어서 temp에 저장.
                tvi.IsExpanded = true;
                tvi.UpdateLayout();

                foreach (var item in tvi.Items)
                {
                    // TreeViewItem, ListBoxItem이 가지고 있는 IsSelected, IsEnabled 같은 의존성 속성(Dependency Object)을 구해야 될 때 사용
                    TreeViewItem temp = tvi.ItemContainerGenerator.ContainerFromItem(item) as TreeViewItem; 
                    Console.WriteLine("item: " + item);
                    Console.WriteLine("temp: " + temp);  
                    bool childOriginState = temp.IsExpanded;
                    Console.WriteLine(childOriginState);
                    // 재귀함수
                    if (temp != null)
                    {
                        if (JumpToNode(temp, NodeName) == true)
                        {
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("else: " + item.ToString());

                            // false, true를 유지 하기 위해서 설정.
                            temp.IsExpanded = childOriginState;
                            Console.WriteLine(temp.IsExpanded);
                        }
                    }
                    Console.WriteLine("3");
                }
            }
            Console.WriteLine("4");
            return false;
        }

        private void TreeViewItem_MouseRightButtonDown(object sender, MouseEventArgs e)
        {
            TreeViewItem item = sender as TreeViewItem;
            if (item != null)
            {
                // focus를 사용하면 <Trigger Property="IsSelected" Value="true"> 발동하는 거 같다.
                item.Focus();
                e.Handled = true;
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            name = tbSearchTextBox.Text;
            if (name == null || name.Trim() == "")
            {
                return;
            }
            // Department
            foreach (object item in this.trvFamilies.Items)
            {
                // Department여러개 있을수도 있음,,현재 여기서는 한개
                // 여러개의 Department여러개에서 현재 item으로 나온 Department를 item으로 반환.
                TreeViewItem treeItem = this.trvFamilies.ItemContainerGenerator.ContainerFromItem(item) as TreeViewItem;
                if (treeItem != null)
                {
                    // 반환받은 item , 찾고싶은 사용자
                    JumpToNode(treeItem, name);
                }
                //treeItem.IsExpanded = true;
            }
            Console.WriteLine("enter");
        }

        private void tbSearchTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && (e.KeyboardDevice.Modifiers & ModifierKeys.Shift) != ModifierKeys.Shift)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
            }
        }
    }

    public class Department //: INotifyPropertyChanged
    {
        //public event PropertyChangedEventHandler PropertyChanged;


        public Department()
        {
            this.Teams = new ObservableCollection<Team>();
        }

        // C#에는 Attribute가 있습니다.
        // 그 중 CallerMemberName을 사용하면 이 함수를 호출한 대상에 대한 이름을 인자로 받게 됩니다.
        // 주의할 점은 default value를 지정해 주어야 한다는 점입니다.
        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            //PropertyChange가 null이 아니면 Invoke를 실행 null이면 null반환(뒤에 메서드는 실행 X)

        }
        // public string State { get; set; }
        public string DepartmentName { get; set; }
        public ObservableCollection<Team> Teams { get; set; }
    }

    public class Team
    {

        public Team()
        {
            this.Members = new ObservableCollection<TeamMember>();
        }
        public string TeamName { get; set; }
        public ObservableCollection<TeamMember> Members { get; set; }
    }

    public class TeamMember
    {
        public string Name { get; set; }

        public string Position { get; set; }

        public string Duty { get; set; }

        public string State { get; set; }

        public bool Auth { get; set; }
    }

    class TreeViewLineConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
        object parameter, System.Globalization.CultureInfo culture)
        {
            TreeViewItem item = (TreeViewItem)value;
            ItemsControl ic = ItemsControl.ItemsControlFromItemContainer(item);

        // 트리뷰에서 첫번째 루트 노드에 대한 트리뷰 아이템 객체를 구한다
        // TreeViewItem firstRootItem = this.treeView.ItemContainerGenerator.ContainerFromIndex(0) as TreeViewItem;
            return ic.ItemContainerGenerator.IndexFromContainer(item) == ic.Items.Count - 1;
        }

        public object ConvertBack(object value, Type targetType,
        object parameter, System.Globalization.CultureInfo culture)
        {
            return false;
        }
    }

}
