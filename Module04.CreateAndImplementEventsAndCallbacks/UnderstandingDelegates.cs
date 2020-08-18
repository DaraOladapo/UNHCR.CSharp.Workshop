//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Module04.CreateAndImplementEventsAndCallbacks
//{
//    class UnderstandingDelegates
//    {
//        public delegate int Calculate(int x, int y);

//        public static int Add(int x, int y)
//        {
//            return x + y;
//        }

//        public static int Multiply(int x, int y)
//        {
//            return x * y;
//        }
//        public static int Subtract(int x, int y)
//        {
//            return x - y;
//        }
//        public static int Divide(int x, int y)
//        {
//            return x / y;
//        }

//        static void Main(string[] args)
//        {
//            Calculate calc = Add;
//            Console.WriteLine(calc(3, 4));

//            calc = Multiply;
//            Console.WriteLine(calc(3, 4));

//            calc = Subtract;
//            Console.WriteLine(calc(9, 6));
            
//            calc = Divide;
//            Console.WriteLine(calc(9, 6));

//            Console.ReadKey();
//        }
//    }
//}
