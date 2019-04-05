using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    public class SingletonFactory
    {
        private SingletonFactory()
        {

        }
        private static readonly SingletonFactory _singletonFactory = null;

        static SingletonFactory() => _singletonFactory = new SingletonFactory();

        public static SingletonFactory CreateInstance() => _singletonFactory;

        public void Show() => Console.WriteLine($"时间：{DateTime.Now}...{this.GetType()}");
    }
}
