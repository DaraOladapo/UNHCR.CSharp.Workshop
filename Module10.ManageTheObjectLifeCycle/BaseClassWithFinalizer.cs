using System;

namespace Module10.ManageTheObjectLifeCycle
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var baseClassWithFinalizer = new BaseClassWithFinalizer();
    //        baseClassWithFinalizer = null;

    //        GC.Collect();
    //        GC.WaitForPendingFinalizers();

    //        ;
    //    }
    //}

    public class BaseClassWithFinalizer
    {
        private UnmanagedResource _unmanagedResource;

        public BaseClassWithFinalizer()
        {
            _unmanagedResource = new UnmanagedResource();
            _unmanagedResource.DoStuff();
        }

        ~BaseClassWithFinalizer()
        {
            Console.WriteLine("BaseClassWithFinalizer is being called.");

            _unmanagedResource.Free();
        }
    }

    public class UnmanagedResource
    {
        public void DoStuff()
        {
            Console.WriteLine("Doing unmanaged stuff. File access created.");
        }

        public void Free()
        {
            Console.WriteLine("Freeing Unmanaged Resource.");
        }
    }
}
