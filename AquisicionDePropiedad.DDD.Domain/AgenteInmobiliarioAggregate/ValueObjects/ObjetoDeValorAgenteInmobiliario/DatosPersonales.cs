using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorAgenteInmobiliario
{
    public record DatosPersonales
    {
        //variables

        public string Nombre { get; init; }
        public string Apellido { get; init; }
        public int Edad { get; init; }
        public string Genero { get; init; }

        internal DatosPersonales(string nombre, string apellido, int edad, string genero)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Genero = genero;
        }

        public DatosPersonales() { }
        //create method
        public static DatosPersonales Crear(string nombre, string apellido, int edad, string genero)
        {
            Validate(nombre, apellido, edad, genero);
            return new DatosPersonales(nombre, apellido, edad, genero);
        }
        //validate method 
        public static void Validate(string nombre, string apellido, int edad, string genero)
        {
            if (nombre.Equals(null))
            {
                throw new ArgumentNullException("Name cannot be null");
            }
            if (apellido.Equals(null))
            {
                throw new ArgumentNullException("Last name cannot be null");
            }
            if (edad.Equals(null))
            {
                throw new ArgumentNullException("Age cannot be null");
            }
            if (genero.Equals(null))
            {
                throw new ArgumentNullException("Gender cannot be null");
            }
        }

    }
}
