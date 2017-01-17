using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using Spring.Context;
using Spring.Context.Support;

namespace Spring.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            IApplicationContext Container = ContextRegistry.GetContext();

            Console.WriteLine("Spring .NET Initialized.");

            IMessage _IMessage = (IMessage) Container.GetObject("IMessage");
            Console.WriteLine(_IMessage.Hello("Diyanada"));

            Person _Person = (Person) Container.GetObject("Person");
            _Person.Name = "Diyanada";
            _Person.Age = 25;

            Console.WriteLine("Person : {0}", _Person);

            Console.ReadLine();
        }
    }
}
