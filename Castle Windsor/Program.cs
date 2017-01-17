using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using Castle.MicroKernel.Registration;
using Castle.Windsor;

namespace Castle_Windsor
{
    class Program
    {
        static void Main(string[] args)
        {
            WindsorContainer Container = new WindsorContainer();
            Container.Register(Component.For<IMessage>().ImplementedBy<Message>());
            Container.Register(Component.For<IFromatter>().ImplementedBy<CapsFormatter>());
            Container.Register(Component.For<IFromatter>().ImplementedBy<SimpleFormatter>());
            Container.Register(Component.For<Person>());

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
