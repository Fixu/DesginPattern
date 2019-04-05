using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public class StudentPreviewDecorator : BaseStudentDecorator
    {
        public StudentPreviewDecorator(AbstractStudent student) : base(student)
        {
        }
        public override void Study()
        {
            Console.WriteLine("Peview....");  
            base.Study();
        }
    }
}
