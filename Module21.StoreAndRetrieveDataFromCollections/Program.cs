using System;
using System.Collections.Generic;
using System.Linq;

namespace Module21.StoreAndRetrieveDataFromCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            var Students = GetStudents().ToList();
            //Console.WriteLine("Students before addition.");
            //foreach (var Student in Students)
            //{
            //    Console.WriteLine($"{Students.IndexOf(Student) + 1}. {Student.FullName} with email address: {Student.EmailAddress}.");
            //}
            //var StudentToAdd = new Student()
            //{
            //    FirstName = "Mel",
            //    LastName = "Gibson",
            //    EmailAddress = "mel@gibson.com"
            //};
            //Students.Add(StudentToAdd);
            //Console.WriteLine("Students after addition.");
            //foreach (var Student in Students)
            //{
            //    Console.WriteLine($"{Students.IndexOf(Student) + 1}. {Student.FullName} with email address: {Student.EmailAddress}.");
            //}
            var StudentsWithNInFirstName = Students
                .Where(filter => filter.FirstName.ToLower().Contains("n")).ToList();
            foreach (var Student in StudentsWithNInFirstName)
            {
                Console.WriteLine($"{StudentsWithNInFirstName.IndexOf(Student) + 1}. {Student.FullName} with email address: {Student.EmailAddress}.");
            }
        }
        static IEnumerable<Student> GetStudents()
        {
            return new List<Student>()
            {
                new Student()
                {
                    FirstName = "Melina",
                    LastName = "Gibson",
                    EmailAddress = "melina@gibson.com"
                },
                new Student()
                {
                    FirstName = "Julia",
                    LastName = "Robert",
                    EmailAddress = "julia@robert.com"
                },
                new Student()
                {
                    FirstName = "Smith",
                    LastName = "Anderson",
                    EmailAddress = "smith@anderson.com"
                },
                new Student()
                {
                    FirstName = "Ozu",
                    LastName = "Fil",
                    EmailAddress = "ozu@fil.com"
                },
        };
        }
    }
}
