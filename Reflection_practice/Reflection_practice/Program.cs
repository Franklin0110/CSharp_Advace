using System;
using System.Reflection;
public class MainClass
{


    public static void Main()
    {
        anobject patito = new anobject();

        var objecto = typeof(anobject).Assembly.GetType();

        var propeties = objecto.GetMethods();
        foreach (var prop in propeties)
        {

            var parameters = prop.GetParameters();
            foreach (var item in parameters)
            {
                Console.WriteLine($"Parameter: {item.Name} : {item.ParameterType}");
            }

        }
        Console.WriteLine(objecto);


        Console.ReadKey();
    }


}

public class anobject
{

    public anobject()
    {
        ID = 0;
        name = "pedro";
        somethingelse = "something";
    }

    public int ID { get; set; }
    public string name { get; set; }
    public string somethingelse { get; set; }

}