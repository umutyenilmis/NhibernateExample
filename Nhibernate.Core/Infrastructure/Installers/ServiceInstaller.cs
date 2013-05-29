using Castle.Core;
using Castle.DynamicProxy;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Nhibernate.Core.Infrastructure.Interceptors;
using Nhibernate.Core.Service.DefaultServices.Interfaces;

namespace Nhibernate.Core.Infrastructure.Installers
{
    public class ServiceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container
                .Register(AllTypes.FromAssemblyContaining<IService>()
                                  .BasedOn<IService>()
                                  .WithServiceAllInterfaces()
                                  .LifestyleSingleton()
                                  .Configure(c => c.Interceptors<ServiceInterceptor>()),
                          AllTypes.FromAssemblyContaining<IService>().BasedOn<IInterceptor>()
                );



        }
    }
}