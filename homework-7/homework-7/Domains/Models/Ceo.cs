using homework_7.Domains.Enums;
using homework_7.Domains.Models;


namespace homework_7.Domains.Models
{
    public class Ceo : Employee
    {
        public Employee[] Employees { get; set; }
        public int Shares { get; set; }

        private double SharesPrice { get;  set; }

        public Ceo(
            int id,
            string firstName,
            string lastName,
            int age,
            double salary,
            Seniority seniority,
            Employee[] employees,
            int shares)
            : base(id, firstName, lastName, age, salary, seniority)
        {
            Employees = employees;
            Shares = shares;
           
        }
               
        public void UpdateSharesPrice(double amount)
        {
            SharesPrice = amount;
        }

        public void PrintEmployees()
        {
            Console.WriteLine($"Employees managed by CEO {FirstName}:");
            foreach (Employee emp in Employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}");
            }
        }

        public override double CalculateAnnualBonus()
        {
            return Salary + (Shares * SharesPrice);
        }
    }
}
