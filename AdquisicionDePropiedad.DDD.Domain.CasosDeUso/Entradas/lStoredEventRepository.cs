using System;
using Ardalis.Specification;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdquisicionDePropiedad.DDD.Domain.Genericos;

namespace AdquisicionDePropiedad.DDD.Domain.CasosDeUso.Entradas
{
    public interface IStoredEventRepository<T> : IRepositoryBase<T> where T : class
    {
        Task<List<StoredEvent>> GetEventsByAggregateId(string aggregateId);
    }
}
