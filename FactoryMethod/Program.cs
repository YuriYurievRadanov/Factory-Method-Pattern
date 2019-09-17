using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = new Creator();
            Logistics logistics = creator.LogisticsFactory(LogistcisEnum.Railway);

            logistics.Transport();
        }
    }
}
