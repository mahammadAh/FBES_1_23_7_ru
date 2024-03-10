using System.Collections;
using System.IO;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        //string path = "firstFile.txt";
        //using (FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write))
        //{
        //    string text = "Hello Step IT 2016";
        //    int number = 9;
        //    if (fs.CanWrite)
        //    {
        //        foreach (var sym in text)
        //        {
        //            fs.WriteByte(Convert.ToByte(sym));
        //        }

        //    }
        //}



        //using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        //{
        //    StringBuilder stringBuilder = new StringBuilder();

        //    if (fs.CanRead)
        //    {
        //        int readed = 0;

        //        while (true)
        //        {
        //            readed = fs.ReadByte();

        //            if (readed == -1) break;

        //            stringBuilder.Append(Convert.ToChar(readed));

        //        }

        //    }

        //    Console.WriteLine(stringBuilder.ToString());


        //}


        //using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        //{
        //    using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
        //    {
        //        string text = "Qarabag !";
        //        int number = 0556067878;
        //        string text2 = "Победа";
        //        sw.WriteLine(text);
        //        sw.WriteLine(number);
        //        sw.Write(text2);
        //        sw.Write(" STEP IT");     
        //    }
        //}


        //using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        //{
        //    using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
        //    {
        //        while(!sr.EndOfStream)
        //        {
        //            Console.WriteLine(sr.ReadLine());
        //        }         
        //    }
        //}


        //using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        //{
        //    using (BinaryWriter br = new BinaryWriter(fs, Encoding.UTF8))
        //    {
        //        br.Write('C');

        //    }
        //}


        //using (FileStream fs = new FileStream(path, FileMode.Open , FileAccess.Read ))
        //{
        //    using (BinaryReader br = new BinaryReader(fs, Encoding.UTF8))
        //    {
        //        var readed1 = br.ReadChar();
        //        Console.WriteLine(readed1);
        //    }
        //}


        // DirectoryInfo df = new DirectoryInfo("");

        //Console.WriteLine(Directory.GetCurrentDirectory());

        //var directories = Directory.GetDirectories("C:\\Users\\ahmadov_m\\Desktop\\CODE\\FBES_1_23_7_ru\\C#");

        //int i = 1;
        //foreach(var directory in directories)
        //{
        //    var pathArray = directory.ToString().Split('\\');
        //    Console.WriteLine($"{i} : {pathArray[pathArray.Length-1]}");
        //    i++;
        //}

        //Console.Write("Selected Directory : ");
        //int selectedDirectory =Int32.Parse(Console.ReadLine());

        //var childDirectorie = Directory.GetDirectories(directories[selectedDirectory - 1]);

        //Console.Clear();
        //i = 1;
        //foreach (var directory in childDirectorie)
        //{
        //    var pathArray = directory.ToString().Split('\\');
        //    Console.WriteLine($"{i} : {pathArray[pathArray.Length - 1]}");
        //    i++;
        //}

       // Directory.CreateDirectory("C:\\Users\\ahmadov_m\\Desktop\\Books");
       // Directory.Delete("C:\\Users\\ahmadov_m\\Desktop\\Books");

        //Directory
        //DirectoryInfo

        //File 
        //FileInfo

        DirectoryInfo dfCSharp = new DirectoryInfo("C:\\Users\\ahmadov_m\\Desktop\\CODE\\FBES_1_23_7_ru\\C#");

        DirectoryInfo dfCplus_plus= new DirectoryInfo("C:\\Users\\ahmadov_m\\Desktop\\CODE\\FBES_1_23_7_ru\\C++");

        DirectoryInfo dfPython= new DirectoryInfo("C:\\Users\\ahmadov_m\\Desktop\\CODE\\FBES_1_23_7_ru\\Python");

       // DirectoryInfo pythonFile1 = new DirectoryInfo("C:\\Users\\ahmadov_m\\Desktop\\CODE\\FBES_1_23_7_ru\\Python\\2.While.py");

        List <DirectoryInfo> myDirectories = new List<DirectoryInfo>() { dfCSharp , dfCplus_plus, dfPython };

        //foreach(DirectoryInfo dir in myDirectories)
        //{
        //    Console.WriteLine(dir.FullName);
        //    Console.WriteLine();
        //   foreach (DirectoryInfo subDirs in dir.GetDirectories())
        //    {
        //        Console.WriteLine(subDirs.FullName);

        //    }
        //    foreach (FileInfo subFiles in dir.GetFiles())
        //    {

        //        Console.WriteLine(subFiles.FullName);

        //    }
        //    Console.WriteLine();
        //}


        //FileInfo pythonFile1 = new FileInfo("C:\\Users\\ahmadov_m\\Desktop\\CODE\\FBES_1_23_7_ru\\Python\\2.While.py");

       

        //using (FileStream fs = pythonFile1.OpenRead())
        //{
        //    using (StreamReader sr = new StreamReader(fs))
        //    {
        //        Console.WriteLine(sr.ReadToEnd());
        //    }
        //}

        string path= "C:\\Users\\ahmadov_m\\Desktop\\Files";
        string findedFile = Directory.GetFiles(path,"*.png").FirstOrDefault();
        FileInfo jpg = new FileInfo(findedFile);

        using (FileStream fs = jpg.Open(FileMode.Open))
        {
            using (BinaryReader br = new BinaryReader(fs))
            {
                byte[] biteArray = new byte[br.BaseStream.Length];

                int i = 0;
                while (br.BaseStream.Position < br.BaseStream.Length-1)
                {
                    biteArray[i] = br.ReadByte();
                    i++;
                }

                var imageBase64 = Convert.ToBase64String(biteArray);
                Console.WriteLine(imageBase64);
            }
        }
    }

}
