using System.Runtime.Serialization;
using System.Text.Json;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;



//public enum SaveMethod {Json , XML};
public class DataRepository
{
    List<string> Data { get; set; }

    public DataRepository()
    {
        this.Data = new List<string>();
    }

    public DataRepository Add(string data)
    {
        this.Data.Add(data);

        return this;
    }

    public void Remove(int idnex)
    {
        this.Data.RemoveAt(idnex);
    }


    public void Save(ISaver _saver)
    {
        _saver.Save(Data);



        //if(saveMethod == SaveMethod.Json)
        //using (FileStream stream = new FileStream("data.json", FileMode.Create, FileAccess.Write))
        //{
        //    JsonSerializer.Serialize <List<string>>(stream, Data);
        //}
        //else if(saveMethod == SaveMethod.XML)
        //{
        //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string>));

        //    using (FileStream stream = new FileStream("data.xml", FileMode.Create, FileAccess.Write))
        //    {
        //        xmlSerializer.Serialize(stream, Data);
        //    }
        //}
    }


    //public void SaveXML()
    //{

    //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string>));

    //    using (FileStream stream = new FileStream("data.json", FileMode.Create, FileAccess.Write))
    //    {
    //        xmlSerializer.Serialize(stream, Data);
    //    }
    //}


}


public interface ISaver
{
    public void Save(List<string> data);
}


public class SaveToJson : ISaver
{
    public void Save(List<string> data)
    {
        using (FileStream stream = new FileStream("data.json", FileMode.Create, FileAccess.Write))
        {
            JsonSerializer.Serialize<List<string>>(stream, data);
        }
    }
}


public class SaveToXML : ISaver
{
    public void Save(List<string> data)
    {
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<string>));

        using (FileStream stream = new FileStream("data.xml", FileMode.Create, FileAccess.Write))
        {
            xmlSerializer.Serialize(stream, data);
        }
    }
}



public class Program
{
    public static void Main(string[] args)
    {

        DataRepository dataRepository = new DataRepository();

        dataRepository.Add("David").Add("Faxri").Add("Ayaz");
        //dataRepository.Save(SaveMethod.Json);
        //dataRepository.Save(SaveMethod.XML);

        dataRepository.Save(new SaveToXML());
    }
}