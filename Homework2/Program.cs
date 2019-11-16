using System;

namespace Homework2
{
    abstract class Employee
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Level { get; set; }

        public Employee(int id, string FirstName, string LastName, string Level)
        {
            this.id = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Level = Level;
        }
        public abstract void print();
    }
    class Tester : Employee
    {
        public int project { get; set; }
        public string type { get; set; }

        public Tester(int id, string FirstName, string LastName, string Level, int project, string type) : base(id, FirstName, LastName, Level)
        {
            this.project = project;
            this.type = type;
        }
        public override void print()
        {
            Console.WriteLine("Номер сотрудника: " + id);
            Console.WriteLine("Имя: " + FirstName);
            Console.WriteLine("Фамилия: " + LastName);
            Console.WriteLine("Уровень: " + Level);
            Console.WriteLine("Проект: " + project);
            Console.WriteLine("Должность: " + type);
        }
    }
    class Developer : Employee
    {
        public int project { get; set; }
        public string language { get; set; }

        public Developer(int id, string FirstName, string LastName, string Level, int project, string language) : base(id, FirstName, LastName, Level)
        {
            this.project = project;
            this.language = language;
        }
        public override void print()
        {
            Console.WriteLine("Номер сотрудника: " + id);
            Console.WriteLine("Имя: " + FirstName);
            Console.WriteLine("Фамилия: " + LastName);
            Console.WriteLine("Уровень: " + Level);
            Console.WriteLine("Проект: " + project);
            Console.WriteLine("Язык программирования: " + language);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee tester = new Tester(156, "Коля", "Николаев", "junior", 678, "functional tester");
            tester.print();
            Console.WriteLine("______________________________");
            Employee developer = new Developer(157, "Илья", "Ильин", "middle", 43, "java, c#");
            developer.print();
        }
    }
        }
    
