using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public class StudentRegDecorator : BaseStudentDecorator
    {
        public StudentRegDecorator(AbstractStudent student) : base(student)
        {
        }
        public override void Study()
        {
            Console.WriteLine("Reg....");  
            base.Study();
        }
    }
}
