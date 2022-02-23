using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfObservalbe
{
    public class NameCardList : ObservableCollection<NameCard> { }

    public class NameCard
    {
        private string name;
        private int age;
        private string tag;

        public string Name
        {
            get { return name; }
        }

        public int Age
        {
            get { return age; }
        }

        public string Tag
        {
            get { return tag; }
        }

        //public override string ToString()
        //{
        //    return Name;
        //}

        public NameCard(string name, int age, string tag)
        {
            this.name = name;
            this.age = age;
            this.tag = tag;
        }
    }
}
