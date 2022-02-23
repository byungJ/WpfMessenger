using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfTutorial
{
    public class BtnImg : Button
    {
        public BtnImg() : base()
        {

        }


        public static readonly DependencyProperty NormalImageSrcProperty = DependencyProperty.Register("NormalImageSrc", typeof(ImageSource), typeof(BtnImg));
        public static readonly DependencyProperty ClickImageSrcProperty = DependencyProperty.Register("ClickImageSrc", typeof(ImageSource), typeof(BtnImg));

        public ImageSource NormalImageSrc
        {
            get => (ImageSource) GetValue(NormalImageSrcProperty);
            set => SetValue(NormalImageSrcProperty,value);
            
        }

        public ImageSource ClickImageSrc
        {
            get => (ImageSource)GetValue(ClickImageSrcProperty);
            set => SetValue(ClickImageSrcProperty, value);
        }
    }
}
