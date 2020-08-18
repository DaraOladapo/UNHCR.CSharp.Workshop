using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Module17.PerformIOOperations
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await AsyncHttpCall.GetExample();

            Console.Read();
        }
    }
}
