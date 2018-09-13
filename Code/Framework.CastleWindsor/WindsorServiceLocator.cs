using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Framework.Core;

namespace Framework.CastleWindsor
{
    public class WindsorServiceLocator : IServiceLocator
    {
        private IWindsorContainer _container;
        public WindsorServiceLocator(IWindsorContainer container)
        {
            this._container = container;
        }

        public T GetInstance<T>()
        {
            return _container.Resolve<T>();
        }

        public void Release(object obj)
        {
            _container.Release(obj);
        }
    }
}
