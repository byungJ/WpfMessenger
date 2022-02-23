using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfNote.CustomCtrl
{
    //public class ImgBtn : Button
    //{
    //    public static readonly DependencyProperty NormalImageSrcProperty = DependencyProperty.Register("NormalImageSrc", typeof(ImageSource), typeof(ImgBtn));
    //    public static readonly DependencyProperty OverImageSrcProperty = DependencyProperty.Register("OverImageSrc", typeof(ImageSource), typeof(ImgBtn));
    //    public static readonly DependencyProperty ClickImageSrcProperty = DependencyProperty.Register("ClickImageSrc", typeof(ImageSource), typeof(ImgBtn));

    //    public ImageSource NormalImageSrc
    //    {
    //        get => (ImageSource)GetValue(NormalImageSrcProperty);
    //        set => SetValue(NormalImageSrcProperty, value);
    //    }

    //    public ImageSource OverImageSrc
    //    {
    //        get => (ImageSource)GetValue(OverImageSrcProperty);
    //        set => SetValue(OverImageSrcProperty, value);
    //    }

    //    public ImageSource ClickImageSrc
    //    {
    //        get => (ImageSource)GetValue(ClickImageSrcProperty);
    //        set => SetValue(ClickImageSrcProperty, value);
    //    }

    //    public ImgBtn()
    //        : base()
    //    {

    //    }
    //}

    public class ImgBtn : Button
    {
        public ImgBtn()
            : base()
        {

        }
        public static readonly DependencyProperty NormalImageSrcProperty = DependencyProperty.Register("NormalImageSrc", typeof(ImageSource), typeof(ImgBtn));
        public static readonly DependencyProperty ClickImageSrcProperty = DependencyProperty.Register("ClickImageSrc", typeof(ImageSource), typeof(ImgBtn));

      

        public ImageSource NormalImageSrc
        {
            get => (ImageSource)GetValue(NormalImageSrcProperty);
            set => SetValue(NormalImageSrcProperty, value);
        } 

        public ImageSource ClickImageSrc
        {
            get => (ImageSource)GetValue(ClickImageSrcProperty);
            set => SetValue(ClickImageSrcProperty, value);
        }

    }

}
