using AdquisicionDePropiedad.DDD.Domain.Genericos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Infraestructure.Configuraciones
{
    public class StoredEventConfig : IEntityTypeConfiguration<StoredEvent>
    {
        public void Configure(EntityTypeBuilder<StoredEvent> builder)
        {
            builder.ToTable("storedEvent");

            builder.HasKey(p => p.StoredId);
        }
    }
}
