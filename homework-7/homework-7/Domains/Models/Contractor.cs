using homework_7.Domains.Models; 
using homework_7.Domains.Enums; 


namespace homework_7.Domains.Models
{
    public class Contractor : Employee
    {
        public double WorkingHours { get; set;}
        public int PayPerHour {get; set;}
        public Manager Responsible {get; set;}
        public Contractor(
            int id,
            string firstName,
            string lastName,
            int age,
            double salary,
            Seniority seniority,
            double workHours,
            int payPerHour,
            Manager responsible
            )
            :base(id, firstName, lastName, age, salary, seniority)
        {
            WorkingHours = workHours;
            PayPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double CalculateAnnualBonus()
        {
            return WorkingHours * PayPerHour;
        }

        public string GetCurrentDepartment()
        {
            return Responsible.Department;
        }
    }
}
