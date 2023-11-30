using System;
using System.Collections.Generic;
using System.IO;
namespace exercises
{
    internal class EventManager
    {  
        private List<Student> students;
        private List<Event> events;
        private string eventsFilePath;
        public EventManager(string studentsFilePath, string eventsFilePath)
        {
            students = LoadStudents(studentsFilePath);
            events = LoadEvents(eventsFilePath);
            this.eventsFilePath = eventsFilePath;
        }
        private List<Student> LoadStudents(string filePath)
        {
            List<Student> loadedStudents = new List<Student>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 2)
                    {
                        Student student = new Student
                        {
                            Name = parts[0],
                            Group = parts[1]
                        };
                        loadedStudents.Add(student);
                    }
                }
            }
            catch
            {
                Console.WriteLine($"Не получилось загрузить данные студентов из файла");
            }

            return loadedStudents;
        }
        private List<Event> LoadEvents(string filePath)
        {
            List<Event> loadedEvents = new List<Event>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 3)
                    {
                        Event evnt = new Event
                        {
                            Name = parts[0],
                            Date = DateTime.Parse(parts[1]),
                            ParticipantsPerGroup = int.Parse(parts[2])
                        };
                        loadedEvents.Add(evnt);
                    }
                }
            }
            catch
            {
                Console.WriteLine($"Не получилось загрузить события из файла");
            }

            return loadedEvents;
        }
        private void WriteEventToFile(string eventName, DateTime eventDate, List<Student> selectedStudents)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(eventsFilePath, true))
                {
                    writer.WriteLine($"{eventDate.ToShortDateString()}; {eventName};");

                    foreach (Student student in selectedStudents)
                    {
                        writer.WriteLine($"{student.Name}; {student.Group}");
                    }
                    writer.WriteLine();
                }
            }
            catch
            {
                Console.WriteLine($"Не получилось записать событие в файл");
            }
        }
        public List<Student> SelectStudentsForEvent(string eventName, DateTime eventDate, int minGroupCount)
        {
            List<Student> selectedStudents = new List<Student>();
            List<Student> eligibleStudents = GetEligibleStudents();
            Dictionary<string, List<Student>> groupedStudents = GroupStudentsByGroup(eligibleStudents);
            foreach (var group in groupedStudents)
            {
                if (group.Value.Count >= minGroupCount)
                {
                    for (int i = 0; i < minGroupCount; i++)
                    {
                        selectedStudents.Add(group.Value[i]);
                    }
                }
            }
            WriteEventToFile(eventName, eventDate, selectedStudents);
            return selectedStudents;
        }
        private List<Student> GetEligibleStudents()
        {
            List<Student> eligibleStudents = new List<Student>();

            if (events.Count >= 3)
            {
                List<Event> lastThreeEvents = events.GetRange(events.Count - 3, 3);

                foreach (Student student in students)
                {
                    bool participated = false;

                    foreach (Event evnt in lastThreeEvents)
                    {
                        if (DidStudentParticipate(student, evnt))
                        {
                            participated = true;
                            break;
                        }
                    }
                    if (!participated)
                    {
                        eligibleStudents.Add(student);
                    }
                }
            }
            else
            {
                eligibleStudents = students;
            }
            return eligibleStudents;
        }
        private bool DidStudentParticipate(Student student, Event evnt)
        {
            return false;
        }
        private Dictionary<string, List<Student>> GroupStudentsByGroup(List<Student> students)
        {
            Dictionary<string, List<Student>> groupedStudents = new Dictionary<string, List<Student>>();

            foreach (Student student in students)
            {
                if (!groupedStudents.ContainsKey(student.Group))
                {
                    groupedStudents[student.Group] = new List<Student>();
                }

                groupedStudents[student.Group].Add(student);
            }
            return groupedStudents;
        }
    }
}
