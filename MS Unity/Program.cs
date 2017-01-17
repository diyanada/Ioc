using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;
using Core;

namespace MS_Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer Container = new UnityContainer();
            Container.RegisterType<IMessage, Message>();
            Container.RegisterType<IFromatter, SimpleFormatter>();
            Container.RegisterType<IFromatter, CapsFormatter>();
            Container.RegisterType<Person>();

            Console.WriteLine("Castle Windsor Initialized.");

            IMessage _IMessage = Container.Resolve<IMessage>();
            Console.WriteLine(_IMessage.Hello("Diyanada"));

            Person _Person = Container.Resolve<Person>();
            _Person.Name = "Diyanada";
            _Person.Age = 25;

            Console.WriteLine("Person : {0}", _Person);
            Console.ReadLine();
        }
    }
}
