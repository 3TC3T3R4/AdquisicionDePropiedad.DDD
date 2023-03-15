using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Comandos
{
   public class CrearClienteComando
    {
        public string Nombre { get; init; }
        public string Apellido { get; init; }
        public int Edad { get; init; }
        public string Genero { get; init; }

        public CrearClienteComando(string nombre, string apellido, int edad, string genero)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Genero = genero;
        }


    }
}
