using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPhotelPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa en Manager
            Manager manager = new Manager("Lisa Ledarsson", 40, "M001", new DateTime(2020, 1, 1), 50000m, "Administration");

            // Skapa en Employee
            Employee employee = new Employee("Erik Eriksson", 30, "E001", new DateTime(2022, 3, 15), 30000m, "Receptionist", "Front Desk");

            Consultant consultant = new Consultant("Eva Expert", 35, "C001", new DateTime(2023, 1, 1), 0, 1000, "Redovisning", "Hotell Experterna AB");

            HouseKeeper houseKeeper = new HouseKeeper("Anna Andersson", 28, "H001", new DateTime(2021, 5, 10), 25000m);

            // Anropa metoder för att testa
            Console.WriteLine("Manager:");
            manager.PrintInfo();
            manager.Introduce();
            manager.HoldMeeting();
            manager.PlanBudget();  

            Console.WriteLine("\nEmployee:");
            employee.PrintInfo();
            employee.Introduce();
            employee.Work();

            Console.WriteLine("\nKonsult:");
            consultant.PrintInfo();
            consultant.Introduce();
            consultant.GiveAdvice();

            Console.WriteLine("\nHouseKeeper:");
            houseKeeper.PrintInfo();
            houseKeeper.Introduce();
            houseKeeper.Work();
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Salary { get; set; }

        public Person(string name, int age, string employeeid, DateTime starttime, decimal salary) 
        { 
            Name = name;
            Age = age;
            EmployeeId = employeeid;
            StartDate = starttime;
            Salary = salary;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}, Ålder: {Age}");
        }
        public virtual void Introduce()
        {
            Console.WriteLine($"Hej jag heter {Name} och är {Age} år gammal!");
        }
    }
    public class Manager : Person
    {
        public string Department { get; set; }

        public Manager(string name, int age, string employeeid, DateTime starttime, decimal salary, string department)
            :base(name, age, employeeid, starttime, salary)
        {
            Department = department;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}, Ålder: {Age} Avdelning {Department}");
        }
        public void HoldMeeting()
        {
            Console.WriteLine($"{Name} håller ett personalmöte i avdelning {Department}!");
        }
        public void PlanBudget()
        {
            Console.WriteLine($"{Name} planerar budgeten för hotellet!");
        }
    }
    public class Employee : Person
    {
        public string JobTitle { get; set; }
        public string Department { get; set; }

        public Employee(string name, int age, string employeeid, DateTime starttime, decimal salary, string jobtitle, string department)
            : base(name, age, employeeid, starttime, salary)
        {
            JobTitle = jobtitle;
            Department = department;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}, Ålder: {Age} Arbetsroll: {JobTitle}, Avdelning: {Department}");
        }
        public void Work()
        {
            Console.WriteLine($"{Name} arbetar som {JobTitle} i {Department}!");
        }
    }
    public class Consultant : Person
    {
        public decimal HourlyRate { get; set; }
        public string Expertise { get; set; }

        public string ConsultingFirm { get; set; }
        
        public Consultant(string name, int age, string employeeid, DateTime starttime, decimal salary, decimal hourlyrate, string expertise, string consultingfirm)
            : base(name, age, employeeid, starttime, salary)
        {
            HourlyRate = hourlyrate;
            ConsultingFirm = consultingfirm;
            Expertise = expertise;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}, Ålder: {Age} timavgift: {HourlyRate} Expertis: {Expertise} Konsultfirma: {ConsultingFirm}");
        }
        public void GiveAdvice()
        {
            Console.WriteLine($"{Name} från {ConsultingFirm} ger råd till hotellet inom området {Expertise}!");
        }
    }
    public class HouseKeeper : Person
    {

        public HouseKeeper(string name, int age, string employeeid, DateTime starttime, decimal salary)
            : base(name, age, employeeid, starttime, salary)
        {

        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}, Ålder: {Age}, Arbetsroll: Städare");
        }

        public void Work()
        {
            Console.WriteLine($"{Name} arbetar som Städare i Vaktmästeriet på Hotellet!");
        }
    }
}
