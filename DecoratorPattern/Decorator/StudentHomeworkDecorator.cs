using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public class StudentHomeWorkDecorator : BaseStudentDecorator
    {
        public StudentHomeWorkDecorator(AbstractStudent student) : base(student)
        {
        }
        public override void Study()
        {
            base.Study();
            Console.WriteLine("homework....");
        }
    }
}
