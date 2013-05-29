using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Nhibernate.Core.Infrastructure.IoC;
using Nhibernate.UI.Infrastructure.Mvc;

namespace Nhibernate.UI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication , IContainerAccessor
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            _container = CreateContainer();
            ControllerBuilder.Current.SetControllerFactory(_container.Resolve<IControllerFactory>());
        }
        private static IWindsorContainer _container;

        public IWindsorContainer Container
        {
            get { return _container; }
        }

        private static IWindsorContainer CreateContainer()
        {
            _container = ServiceIoC.Container;
            return
                _container
                    .Install(FromAssembly.This());
        }
    }
}