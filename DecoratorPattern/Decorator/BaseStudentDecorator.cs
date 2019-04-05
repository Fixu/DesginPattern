using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public class BaseStudentDecorator : AbstractStudent
    {
        private readonly AbstractStudent _abstractStudent = null;

        public BaseStudentDecorator(AbstractStudent student)
        {
            this._abstractStudent = student;
        }
        public override void Study()
        {
            this._abstractStudent.Study();
            //Console.WriteLine("Base....");
        }
    }
}
