
using Person = MyClasses.MyPerson;
using Student = MyClasses.Student;

Person.Person student1 = new Person.Person();

Student.Person student2 = new Student.Person();



//using static System.Console;


//WriteLine("Hello STEP IT");




//using MyClasses.MyPerson;
//using MyClasses.Student;

//MyClasses.MyPerson.Person student = new MyClasses.MyPerson.Person();
//student.Name = "Anvar";


//Animal cat = new Animal("Boris", 7);
//Console.WriteLine(cat.getName());
//Console.WriteLine(cat.getAge());

//cat.setPawCount(4);
//Console.WriteLine(cat.getPawCount());


//Book book1 = new Book("1984", "Orwell", 1949);

//book1.Name = "451";
//Console.WriteLine(book1.getName());
//book1.Name = "451";
//Console.WriteLine(book1.Name);

//book1.PageCount = 10;


//using System.Text;

//Book book1 = new Book("451", "Owrell", 1950);

//Page page1 = new Page();
//page1.Text = "\"Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?\"";
//Page page2 = new Page();
//page2.Text = "\"But I must explain to you how all this mistaken idea of denouncing pleasure and praising pain was born and I will give you a complete account of the system, and expound the actual teachings of the great explorer of the truth, the master-builder of human happiness. No one rejects, dislikes, or avoids pleasure itself, because it is pleasure, but because those who do not know how to pursue pleasure rationally encounter consequences that are extremely painful. Nor again is there anyone who loves or pursues or desires to obtain pain of itself, because it is pain, but because occasionally circumstances occur in which toil and pain can procure him some great pleasure. To take a trivial example, which of us ever undertakes laborious physical exercise, except to obtain some advantage from it? But who has any right to find fault with a man who chooses to enjoy a pleasure that has no annoying consequences, or one who avoids a pain that produces no resultant pleasure?\"";
//Page page3 = new Page();
//page3.Text = "\"At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident, similique sunt in culpa qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi optio cumque nihil impedit quo minus id quod maxime placeat facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat.\"";


//book1.Pages.Add(page1);
//book1.Pages.Add(page2);
//book1.Pages.Add(page3);

//Page page4 = new Page();

//book1.Pages.Add(page4);


//book1.PrintBook();



//string data=null;

//// ?? - null объединение
//string dataCopy = data ?? "data was NULL";
//Console.WriteLine(dataCopy);

//Console.WriteLine(data ?? "value is NULL");

//data = null;
////  ??= null присваивание
//data = data ?? "data was NULL";
//data ??= "value is null";
//Console.WriteLine(data);



//string name = null;
//int[] arr = null;

//int temperature = 0;
//Console.WriteLine(temperature);


//Weather today = new Weather();
//today.temperature ??= 100;

//if(today.temperature != null)
//{
//    Console.WriteLine(today.temperature);
//}
//else
//{
//    Console.WriteLine("Temperature is not found");
//}



//class Weather {
//    public int? temperature;
//}



//partial class Animal
//{
//    private string name;
//    private int age;

//    public Animal(string name, int age)
//    {
//        this.name = name;
//        this.age = age;
//    }

//    public void setName(string name)
//    {
//        this.name = name;
//    }
//    public string getName()
//    {
//        return this.name;
//    }

//    public void setAge(int age)
//    {
//        this.age = age;
//    }
//    public int getAge()
//    {
//        return this.age;
//    }
//}

//partial class Animal
//{
//    private int pawCount;

//    public void setPawCount(int pawCount)
//    {
//        this.pawCount = pawCount;
//    }

//    public int getPawCount()
//    {
//        return pawCount;
//    }
//}



//class Page { 
//    public string Text { get; set; }
//}



//class Book
//{
//    public string Name { get; set; }
//    public string Author { get; set; }
//    public int PublishYear { get; set; }
//    // private int pageCount;
//    public int PageCount {
//        get
//        {
//            return Pages.Count;
//        }
//    }
//    public List<Page> Pages { get; set; }

//    public Book()
//    {
//        Pages = new List<Page>();
//    }

//    public Book(string name, string author, int publishYear)
//    {
//        Pages = new List<Page>();
//        this.Name = name;
//        this.Author = author;
//        this.PublishYear = publishYear;
//    }

//    public void PrintBook ()
//    {
//        int i = 1;
//        foreach (var page in Pages)
//        {
//            Console.WriteLine($"Page : {i}");
//            Console.WriteLine(page.Text);
//            //page.Text!= null
//            //!String.IsNullOrEmpty(page.Text)
//            //!String.IsNullOrWhiteSpace(page.Text)
//            //if (!String.IsNullOrWhiteSpace(page.Text))
//            //{
//                Console.WriteLine($"Sym count  : {page.Text?.Length}");
//            //}

//            i++;
//        }
//    }


//}



