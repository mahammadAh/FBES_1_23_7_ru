class Program
{
    static void Main(string[] args)
    {
        //MyDate today;

        //today.day = 6;
        //today.month = 2;
        //today.year = 2024;

        //Console.WriteLine($"Day : {today.day} Month : {today.month}  Year : {today.year}");

        //MyDate tomorrow= new MyDate();
        ////tomorrow.day = 1; tomorrow.month = 3; tomorrow.year = 20;  
        //tomorrow.PrintDate();

        //MyDate yesterday = new MyDate(5,2,2024);
        //Console.WriteLine($"Day : {yesterday.day} Month : {yesterday.month}  Year : {yesterday.year}");


        //Student.schoolNumb = 10;

        // Student Nazim = new Student(new Mark() { subjectName = "Math", _mark = 10});
        //Mark newMark = new Mark() { subjectName = "Russian", _mark = 2 };
        // Nazim.mark = newMark;
        // Nazim.mark._mark = 12;

        //Console.WriteLine(Nazim.groupNumb);


        //Student David = new Student(18,"David","Sladkov");
        //Console.WriteLine(David.age);

        //Console.WriteLine(Student.schoolNumb);

        //Student Faxri = new Student(18, "Faxri", "Gozalov");

        //Faxri.PrintInfo();
        //var result = Faxri.isBetweenAgeDiapazone(10, 15);
        //Console.WriteLine(result);

        //int[] marks = { 10, 15, 20, 25 };
        //Faxri.SetMarks(marks);
        //Faxri.SetMarks(10, 15, 20, 25, 30, 35, 40);

        // Student.PrintSchoolNumb();

        //Car mercedes = new Car(Color.BLACK, 2018, "ML");
        //mercedes.PrintInfo();
        //Console.WriteLine();

        //int carYear = 1965;
        //mercedes.setYear(ref carYear);
        //mercedes.PrintInfo();

        //Console.WriteLine($"\nCar Year : {carYear}");

        MathMetods mathMetods = new MathMetods();
        int value;
        int digit = 2;

        mathMetods.randVal(out value);

        mathMetods.addDigitToValue(ref value, digit);

        Console.WriteLine(value);

        //int[] arrVal = { 5, 10, 15 };

        //mathMetods.addDigitToArrayValue(ref arrVal, digit);

        //foreach (int val in arrVal)
        //{
        //    Console.WriteLine(val);

        //}
    }

    class MathMetods
    {

        public void randVal(out int val)
        {
            Random random = new Random();

            val = random.Next();
        }


        public void addDigitToValue(ref int value, int digit)
        {
       
            value += digit;
        }

        public void addDigitToArrayValue(ref int[] value, int digit)
        {
            int[] newArr = { 20, 25, 30 };
            value = newArr;
            for (int i = 0; i < value.Length; i++)
            {
                value[i] += digit;
            }
        }
    }
}



//struct MyDate {
//    public int year;
//    public int month;
//    public int day;

//    public MyDate()
//    {
//        year = 1970;
//        month = 1;
//        day = 1;
//    }

//    public MyDate(int day , int month , int year)
//    {
//        this.year = year;
//        this.month = month;
//        this.day = day;
//    }

//    public void PrintDate()
//    {
//        Console.WriteLine($"Day : {day} Month : {month}  Year : {year}");
//    }

//}

//public class Mark {
//    public string subjectName;
//    public int _mark;
//}



// internal class 
//public class Student {
//    public string name;
//    public string surname;
//    public int age;

//    public static int schoolNumb;
//    //public readonly int groupNumb;
//    //public const bool isActive =  true;
//    //public readonly Mark mark ;
//    //public readonly int[] marks;

//    public Student()
//    {
//        age = 4;
//    }

//    public Student(int age , string name , string surname)
//    {
//        this.age = age;
//        this.name = name;
//        this.surname = surname;
//    }

//    //static Student()
//    //{
//    //    schoolNumb = 10;
//    //    Console.WriteLine("Static Constructor work");
//    //}


//    public void PrintInfo()
//    {
//        Console.WriteLine($"Name : {this.name} \n" +
//                          $"Surname : {this.surname} \n" +
//                          $"Age : {this.age}");
//    }

//    //public void PrintInfo(string schoolName)
//    //{
//    //    Console.WriteLine($"Name : {this.name} \n" +
//    //                      $"Surname : {this.surname} \n" +
//    //                      $"Age : {this.age}");
//    //}


//    public bool isBetweenAgeDiapazone(int minAge , int maxAge)
//    {
//        bool checkResult = age > minAge && age < maxAge;
//       return checkResult;
//    }

//    public void SetMarks(params int[] values)
//    {
//     foreach (int value in values)
//        {
//            Console.Write(value + " ");
//        }
//    }

//    public static void PrintSchoolNumb()
//    {
//        Console.WriteLine(schoolNumb);
//    }

//    //public Student(int groupNumb)
//    //{
//    //    this.groupNumb = groupNumb;
//    //}

//    //public Student(Mark mark)
//    //{
//    //    this.groupNumb = groupNumb;
//    //}



//    // Модификаторы доступа 
//    //public string val1;  -- Везде
//    //protected string val2; -- Везде в наследниках
//    //internal string val3; -- Везде в пределах проекта
//    //internal protected string val4; -- Только в наследниках и только в пределах проекта
//    //private string val5; -- В пределах самого класса 
//}



//enum Color
//{
//    RED = 1,
//    GREEN = 2,
//    BLUE = 3,
//    WHITE = 4,
//    BLACK = 5

//}


//class Car
//{
//    public Color carColor;
//    public int year;
//    public string model;


//    public Car(Color color , int year , string model)
//    {
//        carColor = color;
//        this.year = year;
//        this.model = model;
//    }

//    public void setColor(Color color)
//    {
//        this.carColor = color;  
//    }

//    public void setYear(ref int newYear)
//    {
//        if (newYear < 1970) newYear = 1970;

//        this.year = newYear;

//    }

//    public void setModel(string Model)
//    {
//        this.model = model;
//    }

//    public void PrintInfo()
//    {
//        Console.WriteLine($"Model : {model} \nYear : {year} \nColor : {carColor}");
//    }
//}





