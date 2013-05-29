using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Nhibernate.Core.Infrastructure.Facilities;

namespace Nhibernate.Core.Infrastructure.Installers
{
    public class PersistenceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
           container.AddFacility<PersistenceFacility>();
        }
    }
}