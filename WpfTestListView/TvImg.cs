using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfTestListView
{
    public class TvImg : TreeViewItem
    {
        public TvImg()
        {

        }

        public static readonly DependencyProperty NormalProperty = DependencyProperty.Register("Normal", typeof(ImageSource), typeof(TvImg));
        public static readonly DependencyProperty ClickProperty = DependencyProperty.Register("Click", typeof(ImageSource), typeof(TvImg));

        public ImageSource Normal
        {
            get => (ImageSource)GetValue(NormalProperty);
            set => SetValue(NormalProperty, value);
        }

        public ImageSource Clcik
        {
            get => (ImageSource)GetValue(ClickProperty);
            set => SetValue(ClickProperty, value);
        }
    }
}
