
using System.Security.Cryptography;

class Program
{
    public static void Main(String[] args)
    {
        string binaryVal = "101010";
        int num = Convert.ToInt32(binaryVal,2);
        Console.WriteLine(num);
        //try
        //{
        //    Foo();
        //    //var result = DivideRandomNum(20);
        //    //Console.WriteLine(result);
        //}
        //catch (StudentException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //catch (Exception ex)
        //{

        //    Console.WriteLine(ex.Message);
        //    Console.WriteLine(ex.StackTrace);
        //    Console.WriteLine(ex.TargetSite);
        //    Console.WriteLine(ex.Data);
        //    Console.WriteLine(ex.HelpLink);
        //    Console.WriteLine(ex.HResult);
        //}

        try
        {
            byte val1 = 127;
            byte val2 = 127;

            checked
            {
                var result = (byte)(val1 * val2);
                Console.WriteLine(result);
            }

            unchecked
            {
                var result = (byte)(val1 * val2);
                Console.WriteLine(result);
            }
        }
        catch(Exception e) 
        {
            Console.WriteLine(e.Message);
            //throw;
        }




    }
}


//    public static int DivideRandomNum(int n)
//    {
//        int result;
//        Random r = new Random();
//        int n2 = r.Next(3,7);
//        if(n2 == 5)
//        {
//            //Exception myException = new Exception("Divide 5 error");
//            //throw myException; 
//            throw new Exception("Divide 5 error");

//        }
//        result = n / n2;
//        return result;
//    }

//    public static void Foo()
//    {
//        string val = "w11";
//        int result;
//        Int32.TryParse(val,out result);
//        if(result != 0)
//        {
//            Console.WriteLine(result);
//        }
       
//            //try
//            //{
//            //    //School school = new School();
//            //    //Student student = null;

//            //    school.students.Add(student);

//            //    Console.WriteLine(school.students[0].Name);
//            //}
//            //catch (NullReferenceException ex)
//            //{
//            //    Console.WriteLine(ex.Message);
//            //}

//            //Student student = new Student();
//            //student.Name = "Firuddin";
//            //Random r = new Random();
//            //student.age = 99;

//            //if(student.age == 99)
//            //{

//            //    throw new StudentException(student,"This student very old for study");
//            //}


//        }
//    }


//class Student
//{
//    public string Name { get; set; }
//    public int age { get; set; }
//}


//class StudentException : Exception {
//    public Student student { get; set; }

//    public StudentException(Student student , string message) : base($"Code 278 : {message} Student name --> {student.Name}")
//    {
//        this.student = student;
//    }

//}




