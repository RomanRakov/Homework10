using System;
namespace exercises
{
    internal class Person
    {
        public string Name { get; private set; }
        public string Hobby { get; private set; }
        public Person(string name, string hobby)
        {
            Name = name;
            Hobby = hobby;
        }
        public void ReactToEvent(string eventname)
        {
            if (eventname == Hobby)
            {
                Console.WriteLine($"{Name} рад следующему событию: {eventname}");
            }
        }
    }
}