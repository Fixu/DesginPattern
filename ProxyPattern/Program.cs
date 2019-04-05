using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new RealSubject();

            subject.Get();
            subject.Do();

            ISubject pSubject = new ProxySubject();

            pSubject.Get();
            pSubject.Do();

            Console.ReadLine();
        }
    }
}
