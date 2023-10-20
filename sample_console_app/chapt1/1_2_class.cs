/*
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Employee emp001 = new Employee
        {
            Id = 1,
            Name = "Test",
            Birthday = new DateTime(2001, 01, 10),
            DivisionName = "sales"
        };

        Console.WriteLine("{0} on {1}",emp001.Name,emp001.DivisionName);

    }
}

public class Person
{
    public string Name { get; set; }
    public DateTime Birthday { get; set; }
    public int GetAge()
    {
        DateTime today = DateTime.Today;
        int age = today.Year - Birthday.Year;
        if (today < Birthday.AddYears(age))
            age--;
        return age;
    }
}

public class Employee : Person
{
    public int Id { get; set; }
    public string DivisionName { get; set; }
}
 
 */
