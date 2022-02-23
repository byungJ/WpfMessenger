using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfProfile
{
    public class ProfileButton : Button
    {
        public ProfileButton() : base()
        {

        }

        public static readonly DependencyProperty NormalProperty = DependencyProperty.Register("Normal", typeof(ImageSource), typeof(ProfileButton), new PropertyMetadata(null));
        public static readonly DependencyProperty DownProperty = DependencyProperty.Register("Down", typeof(ImageSource), typeof(ProfileButton), new PropertyMetadata(null));
        public static readonly DependencyProperty OverProperty = DependencyProperty.Register("Over", typeof(ImageSource), typeof(ProfileButton), new PropertyMetadata(null));

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

        public ImageSource Over
        {
            get => (ImageSource)GetValue(OverProperty);
            set => SetValue(OverProperty, value);
        }

    }
}
