using System;

namespace Module05.ImplementExceptionHandling
{
    class RethrowingExceptions
    {
        static void Main(string[] args)
        {
            var notSoGreatPhrase = "That is a not-so-great phrase";

            //try
            //{
            //    var phrase1ToInt = int.Parse(notSoGreatPhrase);
            //}
            //catch (FormatException)
            //{
            //    //Log Something, you don't really want to change the exception
            //    //throw;
            //    Console.WriteLine("I could not understand. So I'm skipping this");
            //}

            try
            {
                var phrase2ToInt = int.Parse(notSoGreatPhrase);
            }
            catch (FormatException exception)
            {
                // THrow a new exception, but add the original as a parameter. 
                // You keep the information about the original exception
                throw new NotSoGreatException("Invalid conversion.", exception);
            }

            //try
            //{
            //    var phrase3ToInt = int.Parse(notSoGreatPhrase);
            //}
            //catch (FormatException)
            //{
            //    // Throwing the same exception does not really help a lot, since it cleans the call stack and make
            //    // harder to debug the code
            //    throw new FormatException("Throwing the same exception");
            //}

            Console.ReadKey();
        }

        public class NotSoGreatException : Exception
        {
            public NotSoGreatException(string message, Exception exception) : base(message, exception)
            {

            }
        }
    }
}
