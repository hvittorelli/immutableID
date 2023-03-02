using System;

namespace immutableID
{
    class Progam
    {
        class Student
        {
            // auto-implemented properties
            public int Id { get; init; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            // default constructor
            public Student()
            {
                Id = 0;
                FirstName = "";
                LastName = "";
            }
            // parameterized constructor
            public Student(int i, string First, string Last)
            {
                Id = i;
                FirstName = First;
                LastName = Last;
            }

            public Student(int id)
            {
                Id=id;
                FirstName = string.Empty;
                LastName = string.Empty;
            }

        }
        static void Main(string[] args)
        {
            Student student1 = new(10);
            student1.FirstName = "Johnny";
            student1.LastName = "Jones";
            Student student2 = new Student(20, "Donald", "Donaldson");
            Console.WriteLine("Student Information:");
            Console.WriteLine($"Id: {student1.Id}");
            Console.WriteLine($"First Name: {student1.FirstName}");
            Console.WriteLine($"Last Name: {student1.LastName}");
            Console.WriteLine($"Id: {student2.Id}");
            Console.WriteLine($"First Name: {student2.FirstName}");
            Console.WriteLine($"Last Name: {student2.LastName}");
        }
        
    }
}
