using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPFProfileJoin
{ 
    public class BtnImg : Button
    {
        public BtnImg() : base()
        {

        }
        public static readonly DependencyProperty NormalProperty = DependencyProperty.Register("Normal", typeof(ImageSource), typeof(BtnImg));
        public static readonly DependencyProperty OverProperty = DependencyProperty.Register("Over", typeof(ImageSource), typeof(BtnImg));
        public static readonly DependencyProperty DownProperty = DependencyProperty.Register("Down", typeof(ImageSource), typeof(BtnImg));

        public ImageSource Normal
        {
            get => (ImageSource)GetValue(NormalProperty);
            set => SetValue(NormalProperty, value );
        }

        public ImageSource Over
        {
            get => (ImageSource)GetValue(NormalProperty);
            set => SetValue(NormalProperty, value);
        }

        public ImageSource Down
        {
            get => (ImageSource)GetValue(NormalProperty);
            set => SetValue(NormalProperty, value);
        }
    }
}

