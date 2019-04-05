using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    /// <summary>
    /// 纵向关系：继承、实现
    /// 
    /// 横向关系：依赖、关联、组合 聚合
    /// 
    /// 
    /// 结构设计模式：组合优于继承
    /// 
    /// 
    /// 组合+继承
    /// 
    /// 
    /// 装饰器模式可以在程序运行过程中，动态添加功能
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            AbstractStudent student = new StudentFree()
            {
                Id = 001,
                Name = "小张"
            };

            //student.Study();


            //AbstractStudent studentPreviewDecorator = new StudentPreviewDecorator(student);
            //studentPreviewDecorator.Study();

            student = new StudentPreviewDecorator(student);
            student = new StudentRegDecorator(student);
            student = new StudentPayDecorator(student);
            student = new StudentHomeWorkDecorator(student);
            student.Study();


            Console.Read();
        }
    }
}
