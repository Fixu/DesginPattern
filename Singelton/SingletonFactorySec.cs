using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton
{
    public class SingletonFactorySec
    {
        private SingletonFactorySec()
        {

        }
        private static SingletonFactorySec _singletonFactory = null;
        private static object _lock = new object();
        public static SingletonFactorySec CreateInstance()
        {
            if (_singletonFactory == null)
            {
                lock (_lock)
                {
                    if (_singletonFactory == null)
                    {
                        _singletonFactory = new SingletonFactorySec();
                    }
                }
            }
            return _singletonFactory;
        }



        public void Show() => Console.WriteLine($"时间：{DateTime.Now}...{this.GetType()}");
    }
}
