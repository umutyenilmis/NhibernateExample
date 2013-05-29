using System;
using Nhibernate.Core.Service.DefaultServices.Interfaces;

namespace Nhibernate.Core.Service.DefaultServices
{
    public abstract class ServiceBase : IService
    {
		public ServiceResult Result { get; set; }

        protected internal void SetResultAsFail(int code, Exception exception)
        {
            this.Result = new ServiceResult(ServiceResultType.Fail, exception, code);
        }

        protected internal void SetResultAsFail(int code, string message)
        {
            this.Result = new ServiceResult(ServiceResultType.Fail, message, code);
        }

        protected void SetResultAsSuccess(int code, string message)
        {
            this.Result = new ServiceResult(ServiceResultType.Success, message, code);
        }

        protected void SetResultAsSuccess(int code)
        {
            this.Result = new ServiceResult(ServiceResultType.Success, code);
        }

        
        internal void SetResultAsSuccess()
        {
            this.Result = new ServiceResult(ServiceResultType.Success, 0);
        }
    }
}