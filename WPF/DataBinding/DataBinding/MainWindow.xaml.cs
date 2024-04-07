using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window , INotifyPropertyChanged
    {

        private string dataFromTextBox;
        public string DataFromTextBox
        {
            get { return dataFromTextBox; }
            set 
            { MySet<string>(ref dataFromTextBox, value); }
        }

        private int size = 12;

        public int Size
        {
            get { return size; }
            set { MySet<int>(ref size, value);}
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { MySet<string>(ref name, value); }
        }





        public event PropertyChangedEventHandler? PropertyChanged;

        public void MySet<T>(ref T prop , T value ,[CallerMemberName]string propName = "")
        {
            prop = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }



        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void SizeIncrease(object sender, RoutedEventArgs e)
        {
            Size++;
        }

        private void SizeDicrease(object sender, RoutedEventArgs e)
        {
            Size--;
        }
    }
}
