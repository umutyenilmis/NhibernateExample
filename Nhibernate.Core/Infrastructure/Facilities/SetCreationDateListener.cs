using System;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using Nhibernate.Core.Domain;

namespace Nhibernate.Core.Infrastructure.Facilities
{
    public class SetCreationDateListener : IPreInsertEventListener
    {
        public bool OnPreInsert(PreInsertEvent @event)
        {
            var entity = @event.Entity as EntityBase;
            if (entity == null)
                return false;

            entity.IsDeleted = false;
            entity.CreatedAt = DateTime.Now;
            Set(@event.Persister, @event.State, "CreatedAt", entity.CreatedAt);
            return false;
        }

        private void Set(IEntityPersister persister, object[] state, string propertyName, object value)
        {
            var index = Array.IndexOf(persister.PropertyNames, propertyName);
            if (index == -1)
                return;
            state[index] = value;
        }
    }
}