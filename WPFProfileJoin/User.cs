using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFProfileJoin
{
    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        private string _building;
        private string _id;
        private string _com;
        private string _phone;
        private string _cake;
        private string _tele;
        private string _name;
        private string _fax;
        private string _mess1;
        private string _mess2;
        private string _book;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged();
            }
        }

        public string Building
        {
            get { return _building; }
            set
            {
                _building = value;
                OnPropertyChanged();
            }
        }

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        public string Com
        {
            get { return _com; }
            set
            {
                _com = value;
                OnPropertyChanged();
            }
        }
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }

        public string Cake
        { 
            get { return _cake; }
            set
            {
                _cake = value;
                OnPropertyChanged();
            }
        }

        public string Tele
        {
            get { return _tele; }
            set
            {
                _tele = value;
                OnPropertyChanged();
            }
        }

        public string Fax
        {
            get { return _fax; }
            set 
            {
                _fax = value;
                OnPropertyChanged();
            }
        }

        public string Mess1
        {
            get { return _mess1; }
            set 
            {
                _mess1 = value;
                OnPropertyChanged();
            }
        }

        public string Mess2
        {
            get { return _mess2; }
            set
            {
                _mess2 = value;
                OnPropertyChanged();
            }
        }

        public string Book
        {
            get { return _book; }
            set
            {
                _book = value;
                OnPropertyChanged();
            }
        }
    }
}
