using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Observer
{
    public class Walk : IObserver
    {
        public void Action()
        {
            this.Do();
        }
        private void Do()
        {
            Console.WriteLine("Do walk");
        }
    }
}
