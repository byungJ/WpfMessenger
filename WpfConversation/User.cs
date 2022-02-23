using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfConversation
{
    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private bool _itsMe;
        private bool _emp;
        private string _name;
        private string _position;
        private ContentType _type;

        private string _contentText;
        private string _emoticonText;
        private string _imgText;
        public string ImgText
        {
            get {
                return _imgText;
            }
            set {
                _imgText = value;
                OnPropertyChanged();
            }
        }

        public string ContentText
        {
            get {
                return _contentText;
            }
            set {
                _contentText = value;
                OnPropertyChanged();
            }
        }

        public string EmoticonText
        {
            get {
                return _emoticonText;
            }
            set {
                _emoticonText = value;
                OnPropertyChanged();
            }
        }

        public bool ItsMe
        {
            get {
                return _itsMe;
            }
            set {
                _itsMe = value;
                OnPropertyChanged();
            }
        }

        public bool Emp
        {
            get {
                return _emp;
            }
            set {
                _emp = value;
                OnPropertyChanged();
            }
        }

        public string Name
        {
            get {
                return _name;
            }
            set {
                _name = value;
                OnPropertyChanged();
            }
        }

      


        public string Position
        {
            get {
                return _position;
            }
            set {
                _position = value;
                OnPropertyChanged();
            }
        }

        public ContentType Type
        {
            get {
                return _type;
            }
            set {
                _type = value;
                OnPropertyChanged();
            }
        }
    }
}
