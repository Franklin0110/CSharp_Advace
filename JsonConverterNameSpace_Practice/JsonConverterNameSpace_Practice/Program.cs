using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Xml.Linq;

public class program
{
    public static void Main()
    {
        //To convert an string with JSON syntax to an object we do the next
        string something = "{\r\n    \"fruit\": \"Apple\",\r\n    \"size\": \"Large\",\r\n    \"color\": \"Red\"\r\n}\r\n";
        //Object? jsonDesserialiced = System.Text.Json.JsonSerializer.Deserialize<Object>(something);
        fruits? jsonDesserialiced = System.Text.Json.JsonSerializer.Deserialize<fruits>(something);
        Console.WriteLine(jsonDesserialiced.ToString());

        //To convert an object to JSON syntax, we do the next. 
        string Json2 = System.Text.Json.JsonSerializer.Serialize(jsonDesserialiced);
        Console.WriteLine(Json2);
        Console.ReadKey();
    }
}
public class fruits
{
    [DataMember(Name = "fruit")]
    public string fruit { get; set; }
    [DataMember(Name = "size")]
    public string size { get; set; }
    [DataMember(Name = "color")]
    public string color { get; set; }
}

