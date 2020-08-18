using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04.CreateAndImplementEventsAndCallbacks
{
    class EventWithEventHandler
    {
        //public class MyArgs : EventArgs
        //{
        //    public MyArgs(int value)
        //    {
        //        Value = value;
        //    }
        //    public int Value { get; set; }
        //}
        //class Program
        //{
        //    static void Main(string[] args)
        //    {
        //        var pub = new Pub();

        //        pub.OnChange += (sender, e) => Console.WriteLine($"Event raised: {e.Value}");
        //        pub.OnChange += (sender, e) => Console.WriteLine($"Event raised: {e.Value}");

        //        pub.Raise();
        //        ;
        //    }
        //}

        //public class Pub
        //{
        //    public event EventHandler<MyArgs> OnChange = delegate { };

        //    public void Raise()
        //    {
        //        OnChange(this, new MyArgs(30));
        //    }
        //}
    }
}
