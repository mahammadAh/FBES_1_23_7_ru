using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace AllElementsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         ObservableCollection<Contact> myContacts { get; set; } = new ObservableCollection<Contact>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           myContacts.Add(new Contact() { Name = TextBoxName.Text , Phone = TextBoxNumber.Text });
           ListBoxContacts.ItemsSource = myContacts;
          



        }

        //private void OnClickRedButton(object sender, RoutedEventArgs e)
        //{
        //    buttonRed.Background = new SolidColorBrush(Colors.Red);
        //}

        //private void OnClickGreenButton(object sender, RoutedEventArgs e)
        //{
        //    buttonGreen.Background = new SolidColorBrush(Colors.Green);
        //}

        //private void OnClickBlueButton(object sender, RoutedEventArgs e)
        //{
        //    buttonBlue.Background = new SolidColorBrush(Colors.Blue);
        //}
    }
}
