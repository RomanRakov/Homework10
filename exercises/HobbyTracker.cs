using System;
namespace exercises
{
    internal class HobbyTracker
    {
        public delegate void EventReaction(string eventbame);
        public event EventReaction EventOccurred;
        public void AddPerson(string name, string hobby)
        {
            var person = new Person(name, hobby);
            EventOccurred += person.ReactToEvent;
        }
        public void TriggerEvent(string eventname)
        {
            EventOccurred?.Invoke(eventname);
        }
    }
}
