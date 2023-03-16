using AdquisicionDePropiedad.DDD.Domain.AgenteInmobiliarioAggregate.Comandos;


namespace PruebasPatronAAA.Builder
{
    public class CrearAgenteInmobiliarioComandoBuilder
    {

        private string _Nombre;
        private string _Apellido;
        private int _Edad;
        private string _Genero;

        public CrearAgenteInmobiliarioComandoBuilder ConNombre(string nombre)
        {
            _Nombre = nombre;
            return this;

        }
        public CrearAgenteInmobiliarioComandoBuilder ConApellido(string apellido)
        {
            _Apellido = apellido;
            return this;

        }
        public CrearAgenteInmobiliarioComandoBuilder ConEdad(int edad)
        {
            _Edad = edad;
            return this;

        }
        public CrearAgenteInmobiliarioComandoBuilder ConGenero(string genero)
        {
            _Genero = genero;
            return this;

        }

        public CrearAgenteInmobiliarioComando Build()
        {
            return new CrearAgenteInmobiliarioComando(_Nombre, _Apellido, _Edad, _Genero);

        }






    }
}
