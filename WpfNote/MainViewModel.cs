using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

//VM
namespace WpfNote
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event Func<string, int> EventTest;
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        private string detailMessage = "This TextBox will allow the user to enter multiple lines of text.  When the RETURN key is pressed, " + "\n" +
        "or when typed text reaches the edge of the text box, a new line is automatically inserted.";
        public string DetailMessage
        {
            get { return detailMessage; }
            set
            {
                detailMessage = value;
                OnPropertyChanged();

                if(EventTest != null)
                {
                    Console.WriteLine(EventTest(value));
                }

            }
        }
    }

    public class UserListColl : ObservableCollection<User> { }

    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        public int A { get; set; }
        public int F { get; set; }
        public int W { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public DateTime Time { get; set; }
        public string TimeString { get; set; }


    }
}
