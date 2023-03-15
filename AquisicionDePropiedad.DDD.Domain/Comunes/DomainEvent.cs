using Microsoft.Graph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.Comunes
{
    public class DomainEvent
    {
        //Tipo evento
        public string Type;
        //id de mi agregado con este id puedo acceder a todos los eventos de ese agregado 
        private string AggregateId;
        //nombre agg, con este nombre puedo hacer una decerializacion 
        private string Aggregate;
        //versionamiento 
        private decimal VersionType;

        public DomainEvent(string type)
        {
            this.Type = type;
        }

        public string GetAggregateId() => AggregateId;

        public string GetAggregate() => Aggregate;

        public decimal GetVersionType() => VersionType;

        public void SetAggregateId(string aggregateId) => AggregateId = aggregateId;

        public void SetAggregate(string aggregate) => Aggregate = aggregate;

        public void SetVersionType(decimal versionType) => VersionType = versionType;
    }
}
