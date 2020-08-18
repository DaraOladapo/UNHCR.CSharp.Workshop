using System;

namespace Module10.ManageTheObjectLifeCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseClassWithFinalizer = new BaseClassWithFinalizer();
            baseClassWithFinalizer = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            ;
        }
    }
}
