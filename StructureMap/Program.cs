using System;
using System.Collections.Generic;
using System.Text;
using Core;
using StructureMap;
using StructureMap.Configuration.DSL;


namespace Structure_Map
{
    class Program
    {
        static void Main(string[] args)
        {
            Initializing();
            Console.WriteLine("Structure Map Initialized.");

            IMessage _IMessage = ObjectFactory.GetInstance<IMessage>();
            Console.WriteLine(_IMessage.Hello("Diyanada"));

            Person _Person = ObjectFactory.GetInstance<Person>();
            _Person.Name = "Diyanada";
            _Person.Age = 25;

            Console.WriteLine("Person : {0}", _Person);
            Console.ReadLine();
        }

        public static void Initializing()
        {
            ObjectFactory.Configure(config =>
            {
                config.Scan(scan =>
                {
                    scan.WithDefaultConventions();
                    scan.Assembly("Core");
                });
                config.For<IFromatter>().Use<SimpleFormatter>();
                config.For<IFromatter>().Use<CapsFormatter>();
            });
        }
    }
}
