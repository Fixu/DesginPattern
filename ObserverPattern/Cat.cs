using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class Cat
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Add(IObserver observer)
        {
            observers.Add(observer);
        }
        public void Show()
        {
            foreach (var item in observers)
            {
                item.Action();
            }
        }
    }
}
