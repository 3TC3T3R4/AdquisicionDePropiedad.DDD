using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.Comunes
{
    public class ChangeEventSuscriber
    {
        private List<DomainEvent> Changes = new List<DomainEvent>();

        public List<DomainEvent> GetChanges() => Changes;

        public void AppendChange(DomainEvent domainEvent)
        {
            this.Changes.Add(domainEvent);
        }
    }

}
