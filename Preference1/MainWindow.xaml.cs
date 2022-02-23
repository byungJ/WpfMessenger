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

namespace Preference1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        int time =10;
        int stepOut = 10;
        int search = 10;
        double font = 3.5;
        int notionNum = 3;
        

        public MainWindow()
        {
            InitializeComponent();
            timeLock.Text = time.ToString();
            afk.Text = stepOut.ToString();
            searchList.Text = search.ToString();
            fontSize.Text = font.ToString();
            notice.Text = notionNum.ToString();
        }

        private void TimeLockUp(object sender, RoutedEventArgs e)
        {
            time++;
            timeLock.Text = time.ToString();
        }

        private void TimeLockDown(object sender, RoutedEventArgs e)
        {
            time--;
            timeLock.Text = time.ToString();
        }

        private void AfkUp(object sender, RoutedEventArgs e)
        {
            stepOut++;
            afk.Text = stepOut.ToString();
        }

        private void AfkDown(object sender, RoutedEventArgs e)
        {
            stepOut--;
            afk.Text = stepOut.ToString();
        }

        private void SerchUp(object sender, RoutedEventArgs e)
        {
            search++;
            searchList.Text = search.ToString();
        }

        private void SerchDown(object sender, RoutedEventArgs e)
        {
            search--;
            searchList.Text = search.ToString();
        }

        //private void du_Click(object sender, RoutedEventArgs e)
        //{
        //    f += 0.5;
        //    d.Text = f.ToString();
        //}

        private void FontSizeDown(object sender, RoutedEventArgs e)
        {
            font -= 0.5;
            fontSize.Text = font.ToString();
        }

        private void FontSizeUp(object sender, RoutedEventArgs e)
        {
            font += 0.5;
            fontSize.Text = font.ToString();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void NoticeUp(object sender, RoutedEventArgs e)
        {
            notionNum++;
            notice.Text = notionNum.ToString();
        }

        private void NoticeDown(object sender, RoutedEventArgs e)
        {
            notionNum--;
            notice.Text = notionNum.ToString();
        }
    }
}


