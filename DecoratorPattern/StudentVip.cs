using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class StudentVip : AbstractStudent
    {
        public override void Study()
        {
            Console.WriteLine($"{this.Name} is Vip Study......");
        }
    }
}
