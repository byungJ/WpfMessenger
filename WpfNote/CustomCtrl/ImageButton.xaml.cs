using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfNote.CustomCtrl
{
    /// <summary>
    /// ImageButton.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ImageButton : UserControl
    {
        public ImageButton()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty NormalImageSrcProperty = DependencyProperty.Register("NormalImageSrc", typeof(ImageSource), typeof(ImageButton));
        public static readonly DependencyProperty OverImageSrcProperty = DependencyProperty.Register("OverImageSrc", typeof(ImageSource), typeof(ImageButton));
        public static readonly DependencyProperty ClickImageSrcProperty = DependencyProperty.Register("ClickImageSrc", typeof(ImageSource), typeof(ImageButton));

        public ImageSource NormalImageSrc
        {
            get => (ImageSource)GetValue(NormalImageSrcProperty);
            set => SetValue(NormalImageSrcProperty, value);
        }

        public ImageSource OverImageSrc
        {
            get => (ImageSource)GetValue(OverImageSrcProperty);
            set => SetValue(OverImageSrcProperty, value);
        }

        public ImageSource ClickImageSrc
        {
            get => (ImageSource)GetValue(ClickImageSrcProperty);
            set => SetValue(ClickImageSrcProperty, value);
        }


    }
}
