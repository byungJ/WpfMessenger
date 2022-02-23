using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace WpfConversation
{
    /// <summary>
    /// ImgWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ImgWindow : Window
    {
        public event Action<string> EmoticonSend;

        string[] files;

        List<string> emoticonList13 = new List<string>();
        List<string> emoticonList4 = new List<string>();
        List<string> emoticonList5 = new List<string>();
        List<string> emoticonList6 = new List<string>();
        List<string> emoticonList7 = new List<string>();
        List<string> emoticonList8 = new List<string>();

        public ImgWindow()
        {
            InitializeComponent();
           
            files = Directory.GetFiles(@"C:\Program Files (x86)\douzone\Amaranth10 Messenger\Resources\Img\Emoticon", "*.png");
 
            foreach (var file in files) {
            string path = file;

            string filename = null;
            filename = System.IO.Path.GetFileName(path);
        
                if(filename.Contains("001") || filename.Contains("002")|| filename.Contains("003")) {
                    emoticonList13.Add("/img/" + filename);
                }
                if (filename.Contains("004")) {
                    emoticonList4.Add("/img/" + filename);
                }
                if (filename.Contains("005")) {
                    emoticonList5.Add("/img/" + filename);
                }
                if (filename.Contains("006")) {
                    emoticonList6.Add("/img/" + filename);
                }
                if (filename.Contains("007")) {
                    emoticonList7.Add("/img/" + filename);
                }
                if (filename.Contains("008")) {
                    emoticonList8.Add("/img/" + filename);
                }

            }
            lvEmoticon13.ItemsSource = emoticonList13;
            lvEmoticon4.ItemsSource = emoticonList4;
            lvEmoticon5.ItemsSource = emoticonList5;
            lvEmoticon6.ItemsSource = emoticonList6;
            lvEmoticon7.ItemsSource = emoticonList7;
            lvEmoticon8.ItemsSource = emoticonList8;


        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void ListViewItem_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ListViewItem item = (ListViewItem)sender;
            Console.WriteLine("Dfdfdf"+e.Source);
            if(item != null && item.IsSelected) {
                string emoticonPath = (string)item.Content;
                EmoticonSend(emoticonPath);
                e.Handled = true;
            }
                
        }
    }
}
