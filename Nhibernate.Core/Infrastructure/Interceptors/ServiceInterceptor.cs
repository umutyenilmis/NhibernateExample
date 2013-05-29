using System;
using Castle.DynamicProxy;
using Nhibernate.Core.Infrastructure.UoW;
using Nhibernate.Core.Service.DefaultServices;

namespace Nhibernate.Core.Infrastructure.Interceptors
{
    public class ServiceInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            var service = (ServiceBase)invocation.InvocationTarget;

            try
            {
                invocation.Proceed();

               // service.SetResultAsSuccess();
            }
            catch (Exception ex)
            {
                if (UnitOfWork.CurrentSession.Transaction.IsActive)
                    UnitOfWork.CurrentSession.Transaction.Rollback();


				                               
                service.SetResultAsFail(500, ex);
            }
        }
    }
}