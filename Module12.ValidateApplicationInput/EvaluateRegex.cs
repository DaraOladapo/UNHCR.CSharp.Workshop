using System;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Module12.ValidateApplicationInput
{
    public static class EvaluateRegex
    {
        public static void GetExample()
        {
            const string email = "me@me.com";
            var valid = ValidateEmail(email);


            Console.WriteLine($"The e-mail {email} is {(valid ? "" : "not")} valid");

            Console.ReadLine();
        }

        static bool ValidateEmail(string email)
        {
            const string pattern = @"^[a-z0-9._]+@[a-z0-9]+\.[a-z]+\.?([a-z]+)?$";

            return Regex.Match(email, pattern).Success;
        }

        //extra
        static bool IsValidEmail(string emailAddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailAddress);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
