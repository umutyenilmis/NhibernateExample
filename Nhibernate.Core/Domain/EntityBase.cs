using System;

namespace Nhibernate.Core.Domain
{
    public class EntityBase
    {
        public virtual Guid Id { get; set; }
        public virtual DateTime CreatedAt { get; set; }        
        public virtual bool IsDeleted { get; set; }
    }
}