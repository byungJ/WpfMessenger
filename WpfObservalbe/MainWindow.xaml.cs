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

namespace WpfObservalbe
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        //private void AddButton_Click(object sender, RoutedEventArgs e)
        //{
        //    Model.NameCardList myList = Resources["MyListKey"] as Model.MyList;
        //    string inputName, inputTag;
        //    int inputAge;

        //    inputName = NameTextBox.Text;
        //    inputTag = TagTextBox.Text;
        //    try
        //    {
        //        inputAge = Convert.ToInt32(AgeTextBox.Text);
        //    }
        //    catch (Exception ex)
        //    {
        //        inputAge = 30;
        //    }

        //    myList.Add(new Model.NameCard(inputName, inputAge, inputTag));

        //    NameTextBox.Text = AgeTextBox.Text = TagTextBox.Text = "";
        //    NameTextBox.Focus();
        //}
    }
}
