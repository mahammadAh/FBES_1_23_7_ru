using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace StudentBook
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public class Student 
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private string gPI;

        public Student()
        { 
            Id = Guid.NewGuid().ToString();
        }

        public string GPI
        {
            get { return gPI; }
            set 
            { 
                gPI = value;
                if (Int32.Parse(value) > 50)
                {
                    gPIColor = "Blue";
                }
                else
                {
                    gPIColor = "Red";
                }

            }
        }

        public string gPIColor { get; set; } = "Red";
    }

    public partial class MainWindow : Window , INotifyPropertyChanged
    {
        //private string studentName;
        //public string StudentName { get { return studentName; } set { MySet<string>(ref studentName, value); } }

        //private string studentSurname;
        //public string StudentSurname { get { return studentSurname; } set { MySet<string>(ref studentSurname, value); } }

        //private string studentGPI;
        //public string StudentGPI { get { return studentGPI; } set { MySet<string>(ref studentGPI, value); } }



        private Student student = new Student();

        public Student Student
        {
            get { return student; }
            set { MySet<Student>(ref student, value); }
        }

 
        private ObservableCollection<Student> students;
        public ObservableCollection<Student> Students { get { return students; } set { MySet<ObservableCollection<Student>>(ref students, value); } }



        public event PropertyChangedEventHandler? PropertyChanged;

        public void MySet<T>(ref T prop, T value, [CallerMemberName] string propName = "")
        {
            prop = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }



        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Students = new ObservableCollection<Student>()
            {
                new Student
                {
                    Name = "Anvar",
                    Surname = "Sadiq",
                    GPI = "96",
                },
                 new Student
                {
                    Name = "David",
                    Surname = "Sladkov",
                    GPI = "47",
                },
                  new Student
                {
                    Name = "Farman",
                    Surname = "Gadji",
                    GPI = "36",
                },
                   new Student
                {
                    Name = "Dinara",
                    Surname = "Qasimova",
                    GPI = "88",
                },
                    new Student
                {
                    Name = "Ayaz",
                    Surname = "Bagirzade",
                    GPI = "90",
                },
                   new Student
                {
                    Name = "Alyona",
                    Surname = "Vishnevetskaya",
                    GPI = "31",
                }
            };

        }


        private void OnClickAddButton(object sender, RoutedEventArgs e)
        {
            Students.Add(new Student
            {
                Name = student.Name,
                Surname = student.Surname,
                GPI = student.GPI,
            });

            Student = new Student();
        }

        private void OnClickEditButton(object sender, RoutedEventArgs e)
        {
       
            Student selectedStudent = Students.FirstOrDefault(s => s.Id == Student.Id);
            selectedStudent = Student;

        }
    }
}
