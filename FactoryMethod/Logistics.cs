using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Logistics
    {
        public abstract void Transport();
    }

    public class Railway : Logistics
    {
        public override void Transport()
        {
            Console.WriteLine("Railway");
        }
    }

    public class Sea : Logistics
    {
        public override void Transport()
        {
            Console.WriteLine("Sea");
        }
    }

    public class Road : Logistics
    {
        public override void Transport()
        {
            Console.WriteLine("Road");
        }
    }
}
