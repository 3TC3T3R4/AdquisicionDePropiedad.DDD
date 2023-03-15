using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.Genericos
{
    public class StoredEvent
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StoredId { get; set; }

        public string StoredName { get; set; }

        public string AggregateId { get; set; }

        public string EventBody { get; set; }

    }
}
