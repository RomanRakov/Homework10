using System;
using System.Collections.Generic;

namespace exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 1");
            string studentsFilePath = "students.txt";
            string eventsFilePath = "events.txt";
            EventManager eventManager = new EventManager(studentsFilePath, eventsFilePath);
            string eventName = "«Театральная постановка»";
            DateTime eventDate = new DateTime(2023, 11, 30);
            int minGroupCount = 3;
            List<Student> selectedStudents = eventManager.SelectStudentsForEvent(eventName, eventDate, minGroupCount);
            Console.WriteLine($"Выбранные студенты на событие {eventName} в следующую дату: {eventDate.ToShortDateString()}:");
            foreach (Student student in selectedStudents)
            {
                Console.WriteLine($"{student.Name} - {student.Group}");
            }

            Console.WriteLine("\nУпражнение 2");
            var tracker = new HobbyTracker();
            tracker.AddPerson("Георгий", "Вышел новый фильм");
            tracker.AddPerson("Антон", "Вышел новый сериал");
            tracker.AddPerson("Артем", "Вышла новая видеоигра");
            Console.WriteLine("Введите событие:");
            string eventname = Console.ReadLine();
            tracker.TriggerEvent(eventname);
            Console.ReadKey();
        }
    }
}
