/*
namespace sample_console_app.chapt1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                Name = "Test",
                Birthday = new DateTime(2001, 10, 10),
                Grade = 2,
                ClassNumber = 1,
            };

            Console.WriteLine($"{student.Name} is {student.GetAge()} years old, and belongs to {student.Grade}年 {student.ClassNumber}組.");

            Person person = student;
            Console.WriteLine(person);
            object personObj = student;
            Console.WriteLine(personObj);
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
        public class Student : Person
        {
            public int Grade { get; set; }
            public int ClassNumber { get; set; }

        }
    }
}
 
 */
