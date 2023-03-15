using AngleSharp.Dom;
using Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.Comunes
{
    public abstract class AggregateEvent<T>  :  Entity<T> where T : Identity
    {
        //este atributo apunta a la lista de eventos 
        private ChangeEventSuscriber ChangeEventSuscriber = new();

        protected AggregateEvent(T entityId) : base(entityId) { }

        public List<DomainEvent> getUncommittedChanges() => ChangeEventSuscriber.GetChanges().ToList();


        //resive un evento de dominio y generar la conversion 
        public void AppendChange(DomainEvent evento)
        {

            //conversion del nombre del evento
            string nameClass = evento.GetType().Name;
            //relaciono ese nombre de evento que se ha disparado 
            evento.SetAggregate(nameClass);
            evento.SetAggregateId(Identity().Uuid.ToString());
            ChangeEventSuscriber.AppendChange(evento);
        }

    }
}
