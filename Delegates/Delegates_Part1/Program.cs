using System;

namespace Delegates
{
    class Program
    {
        //This is how a delegate is created
        delegate void LogDel(string text);

        static void Main(string[] args)
        {
            //We make an instance of the other class that is being used.
            Logging log = new Logging();

            //We create two objects type LogDel.
            LogDel LogTextToScreenDel, LogTextToFileDel;

            //We insert inside of the object a function
            LogTextToScreenDel = new LogDel(log.TextToSreen);

            LogTextToFileDel = new LogDel(log.TextToFile);

            //we create an function that will contain two other function as summatory
            LogDel MultiLogDel = LogTextToFileDel + LogTextToScreenDel;

            Console.WriteLine("Please write your name");

            var name = Console.ReadLine();

            //when we call the function, it calls the other two function added before.
            //MultiLogDel(name);

            //here we pass the function as parameter that makes the same as the line that we have before. 
            LogText(MultiLogDel, name);

            Console.ReadKey();
        }

        static void LogText(LogDel logdel, string text)
        {
            //this calls the function passed as a function.
            logdel(text);
        }
    }
}
