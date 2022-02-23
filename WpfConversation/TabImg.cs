using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfConversation
{
    public class TabImg : TabItem
    {
        public TabImg() : base()
        {

        }
        public static readonly DependencyProperty NormalProperty = DependencyProperty.Register("Normal", typeof(ImageSource), typeof(TabImg));
        public static readonly DependencyProperty DownProperty = DependencyProperty.Register("Dowm", typeof(ImageSource), typeof(TabImg));


        public ImageSource Normal
        {
            get => (ImageSource)GetValue(NormalProperty);
            set => SetValue(NormalProperty, value);
        }

        public ImageSource Down
        {
            get => (ImageSource)GetValue(DownProperty);
            set => SetValue(DownProperty, value);
        }

    }
}
