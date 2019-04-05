using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    /// <summary>
    /// 
    /// 只能传达原有逻辑，不能新增逻辑
    /// 延时加载
    /// 
    /// 添加新功能
    /// 
    /// 缓存
    /// 
    /// 单利【
    /// </summary>
    public class ProxySubject : ISubject
    {
        private readonly RealSubject _realSubject = new RealSubject();

        public bool Do()
        {
            return _realSubject.Do();
        }

        public bool Get()
        {
            return _realSubject.Get();
        }
    }
}
