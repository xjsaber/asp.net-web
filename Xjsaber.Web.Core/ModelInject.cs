using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ninject;

namespace Xjsaber.Web.Core
{
    public class ModelInject
    {
        static IKernel container;

        public static void Init()
        {
            container = new StandardKernel(); //ioc注册
            
        }

        private static void AddBindings()
        {

        }

        /// <summary>
        /// 反转方法
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T Inject<T>()
        {
            return container.Get<T>();
        }

    }
}
