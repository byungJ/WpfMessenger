using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfProfile
{
    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

       
        private string _building;

        /// <summary>
        /// dept path
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                _building = value;
                OnPropertyChanged("cjdtkseh");
            }
        }

        private string _id;

        /// <summary>
        /// 사용자 로그인 아이디
        /// </summary>
        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        private string _mess1;
        /// <summary>
        /// 회사 메일
        /// </summary>
        public string Mess1
        {
            get { return _mess1; }
            set
            {
                _mess1 = value;
                OnPropertyChanged();
            }
        }

        private string _mess2;
        /// <summary>
        /// 개인 이메일
        /// </summary>
        public string Mess2
        {
            get { return _mess2; }
            set
            {
                _mess2 = value;
                OnPropertyChanged();
            }
        }
        private string _phone;
        /// <summary>
        /// 개인 전화번호
        /// </summary>
        public string Phone
        {
            get { return _phone; }
            set
            {
                _phone = value;
                OnPropertyChanged();
            }
        }

        private string _tele;
        /// <summary>
        /// 회사 번호
        /// </summary>
        public string Tele { 
            get { return _tele; }
            set
            {
                _tele = value;
                OnPropertyChanged();
            }
        }

        private string _fax;
        /// <summary>
        /// 팩스번호
        /// </summary>
        public string Fax {
            get { return _fax; }
            set
            {
                _fax = value;
                OnPropertyChanged();
            }
        }

        private string _cake;
        /// <summary>
        /// 생일
        /// </summary>
        public string Cake {
            get { return _cake; }
            set
            {
                _cake = value;
                OnPropertyChanged();
            } 
        }

        private string _com;
        /// <summary>
        /// 담당업무
        /// </summary>
        public string Com { 
            get { return _com; }
            set
            {
                _com = value;
                OnPropertyChanged();
            }
        }

        private string _book;
        /// <summary>
        /// 사무실 주소
        /// </summary>
        public string Book { 
            get { return _book; }
            set
            {
                _book = value;
                OnPropertyChanged();
            }
        }

        private string _userName;
        /// <summary>
        /// 이름
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }

        public string Name { get; internal set; }
    }
}
