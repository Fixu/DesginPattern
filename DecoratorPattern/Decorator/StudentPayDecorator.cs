using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public class StudentPayDecorator : BaseStudentDecorator
    {
        public StudentPayDecorator(AbstractStudent student) : base(student)
        {
        }
        public override void Study()
        {
            Console.WriteLine("Pay....");  
            base.Study();
        }
    }
}
