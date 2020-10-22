using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Blah
{
    internal class Program
    {
        // private static void Main(string[] args)
        // {
        //     var bEmployees = new List<Employee>(5)
        //     {
        //         new FullTime("1", "Cam", 3000, 100),
        //         new PartTime("2", "John", 20, 20),
        //         new FullTime("3", "Eric", 2200, 300)
        //     };
        //
        //     bEmployees.Sort((a,b) => a.GetSalary().CompareTo(b.GetSalary()));
        //     bEmployees.Reverse();
        //
        //     foreach (var bEmployee in bEmployees)
        //     {
        //         Console.WriteLine(bEmployee);
        //     }
        // }
    }

    internal abstract class Employee
    {
        protected Employee(string id, string name)
        {
            Id = id;
            Name = name;
        }

        protected string Id { get; set; }
        protected string Name { get; set; }

        public abstract double GetSalary();

        public override string ToString()
        {
            return $" {Id} {Name} {GetSalary()}";
        }
    }

    internal class FullTime : Employee
    {
        public FullTime(string id, string name, double salPerMonth, float bonus) : base(id, name)
        {
            SalPerMonth = salPerMonth;
            Bonus = bonus;
        }

        private double SalPerMonth { set; get; }
        private float Bonus { get; set; }

        public override double GetSalary()
        {
            return SalPerMonth + Bonus;
        }
    }

    internal class PartTime : Employee
    {
        public PartTime(string id, string name, double salPerHour, float hour) : base(id, name)
        {
            SalPerHour = salPerHour;
            Hour = hour;
        }

        private double SalPerHour { get; set; }

        private float Hour { get; set; }

        public override double GetSalary()
        {
            return SalPerHour * Hour;
        }
    }
}