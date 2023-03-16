using AdquisicionDePropiedad.DDD.Domain.ClienteAggregate.Comandos;
using AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Comandos;
using AquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.ValueObjects.ObjetoDeValorAgenteInmobiliario;
using AquisicionDePropiedad.DDD.Domain.ClienteAggregate.ValueObjects.ObjetosDeValorCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasPatronAAA.Builder
{
    public class CrearClienteComandoBuilder
    {
        private string _Nombre;
        private string _Apellido;
        private int _Edad;
        private string _Genero;

        public CrearClienteComandoBuilder ConNombre(string nombre)
        {
            _Nombre = nombre;
            return this;

        }
        public CrearClienteComandoBuilder ConApellido(string apellido)
        {
            _Apellido = apellido;
            return this;

        }
        public CrearClienteComandoBuilder ConEdad(int edad)
        {
            _Edad = edad;
            return this;

        }
        public CrearClienteComandoBuilder ConGenero(string genero)
        {
            _Genero = genero;
            return this;

        }

        public CrearClienteComando Build()
        {
            return new CrearClienteComando(_Nombre, _Apellido,_Edad,_Genero);

        }


    }
}
