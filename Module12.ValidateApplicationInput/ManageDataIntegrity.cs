using Module12.ValidateApplicationInput;
using System;

namespace Module12.ValidateApplicationInput
{
    public static class ManageDataIntegrity
    {
        public static void GetExample()
        {
            var student = new Student("l", 5);

            var entityErrors = Validator<Student>.Validate(student);

            Console.WriteLine($"Errors: {string.Join(", ", entityErrors)}");

            Console.ReadLine();
        }
    }
}
