using AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Comandos;
using Azure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasPatronAAA.Builder
{
    public  class AgregarFiadorComandoBuilder
    {


        private string _ContratoId;
        private string _Nombre;
        private int _Telefono;


        public AgregarFiadorComandoBuilder ConId(string id)
        {
            _ContratoId = id;
            return this;
        }

        public AgregarFiadorComandoBuilder ConNombre(string nombre)
        {
            _Nombre = nombre;
            return this;
        }

        public AgregarFiadorComandoBuilder ConTelefono(int telefono)
        {
            _Telefono = telefono;
            return this;
        }
        

        public AgregarFiadorParaContratoComando Build()
        {
            return new AgregarFiadorParaContratoComando(_ContratoId, _Nombre, _Telefono);
        }





    }
}
