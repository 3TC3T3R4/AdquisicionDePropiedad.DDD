using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.Comunes
{
    public class Entity<T> where T : Identity
    {
        protected T entityId;

        public Entity(T entityId)
        {
            this.entityId = entityId;
        }

        public T Identity() => entityId;
    }
}
