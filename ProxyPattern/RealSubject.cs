using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RealSubject : ISubject
    {
        public bool Do()
        {
            Console.WriteLine("DO...");
            return true;
        }

        public bool Get()
        {
            Console.WriteLine("Get....");
            return true;
        }
    }
}
