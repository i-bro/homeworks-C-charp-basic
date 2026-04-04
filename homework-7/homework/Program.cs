// See https://aka.ms/new-console-template for more information
using homework_7.Domains.Models;
using homework_7.Domains.Enums;



Manager mgr1 = new Manager(1, "Bob", "Bobsky", 40, 5000, Seniority.Senior, "IT");
Manager mgr2 = new Manager(2, "Alice", "Alison", 38, 5500, Seniority.Lead, "Marketing");

Developer dev1 = new Developer(3, "John", "Johnsky", 25, 3000, Seniority.Junior, "C#");
Developer dev2 = new Developer(4, "Jane", "Janesky", 28, 3500, Seniority.Lead, "Java");

Contractor con1 = new Contractor(5, "Charlie", "Charsky", 30, 0, Seniority.Senior, 160, 40, mgr1);

Employee[] companyEmployees = new Employee[] { mgr1, mgr2, dev1, dev2, con1 };

Ceo bigBoss = new Ceo(6, "Bill", "Billsky", 50, 10000, Seniority.Lead, companyEmployees, 100);

bigBoss.UpdateSharesPrice(150.50);

Console.WriteLine(bigBoss.GetDetails());

Console.WriteLine("----------------------------");

bigBoss.PrintEmployees();

Console.WriteLine("----------------------------");

double bonus = bigBoss.CalculateAnnualBonus();
Console.WriteLine($"CEO Annual Bonus: {bonus:C}");