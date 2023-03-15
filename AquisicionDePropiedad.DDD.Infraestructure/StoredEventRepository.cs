using AdquisicionDePropiedad.DDD.Domain.CasosDeUso.Entradas;
using AdquisicionDePropiedad.DDD.Domain.Genericos;
using Ardalis.Specification.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Infraestructure
{
    public class StoredEventRepository<T> : RepositoryBase<T>, IStoredEventRepository<T> where T : class
    {

        private readonly DataBaseContext dataBaseContext;
        public StoredEventRepository(DataBaseContext dbContext) : base(dbContext)
        {
            dataBaseContext = dbContext;
        }

        public async Task<List<StoredEvent>> GetEventsByAggregateId(string aggregateId)
        {
            return dataBaseContext.StoredEvents.Where(evento => evento.AggregateId == aggregateId).ToList();

        }
    }
}
