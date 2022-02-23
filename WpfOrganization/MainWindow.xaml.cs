using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
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

namespace WpfOrganization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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

            department.Teams.Add(team);
            department.Teams.Add(teamA);
            department.Teams.Add(teamI);
            department.Teams.Add(teamM);
            department.Teams.Add(teamP);

            team.Members.Add(new TeamMember() { Name = "김태호", Duty = "모바일", Position = "수석연구원" });

            teamA.Members.Add(new TeamMember() { Name = "김지섭", Duty = "Android 개발", Position = "주임연구원" });
            teamA.Members.Add(new TeamMember() { Name = "우영윤", Duty = "Android 개발", Position = "주임연구원" });
            teamA.Members.Add(new TeamMember() { Name = "김제헌", Duty = "Android 개발", Position = "주임연구원" });
            teamA.Members.Add(new TeamMember() { Name = "김준형", Duty = "Android 개발", Position = "주임연구원" });
            teamA.Members.Add(new TeamMember() { Name = "곽지선", Duty = "Android 개발", Position = "주임연구원" });
            teamA.Members.Add(new TeamMember() { Name = "윤혜미", Duty = "Android 개발", Position = "주임연구원" });

            teamI.Members.Add(new TeamMember() { Name = "서정준", Duty = "iOS 개발", Position = "책임연구원" });
            teamI.Members.Add(new TeamMember() { Name = "김지욱", Duty = "iOS 개발", Position = "주임연구원" });
            teamI.Members.Add(new TeamMember() { Name = "유현재", Duty = "iOS 개발", Position = "주임연구원" });
            teamI.Members.Add(new TeamMember() { Name = "이상봉", Duty = "iOS 개발", Position = "이상봉" });
            teamI.Members.Add(new TeamMember() { Name = "윤형찬", Duty = "iOS 개발", Position = "윤형찬" });

            teamM.Members.Add(new TeamMember() { Name = "이한형", Duty = "메신저", Position = "선임연구원" });
            teamM.Members.Add(new TeamMember() { Name = "유효진", Duty = "데이터", Position = "사원" });
            teamM.Members.Add(new TeamMember() { Name = "한승엽", Duty = "데이터", Position = "사원" });
            teamM.Members.Add(new TeamMember() { Name = "김병준", Duty = "메신저", Position = "연구원" });

            teamP.Members.Add(new TeamMember() { Name = "김예찬", Duty = "모바일 기획", Position = "대리" });
            teamP.Members.Add(new TeamMember() { Name = "방유라", Duty = "모바일 기획", Position = "사원" });
            teamP.Members.Add(new TeamMember() { Name = "이인경", Duty = "모바일 기획", Position = "사원" });
            families.Add(department);
            trvFamilies.ItemsSource = families;
        }
       
    }

    public class Department : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


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
    }
}
