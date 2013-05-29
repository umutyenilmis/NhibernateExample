using NHibernate;
using Nhibernate.Core.Infrastructure.IoC;

namespace Nhibernate.Core.Infrastructure.UoW
{
    public class UnitOfWork
    {
        internal static ISession CurrentSession
        {
            get
            {
                var container = ServiceIoC.Container;
                return container.Resolve<ISession>();
            }
        }

    }
}