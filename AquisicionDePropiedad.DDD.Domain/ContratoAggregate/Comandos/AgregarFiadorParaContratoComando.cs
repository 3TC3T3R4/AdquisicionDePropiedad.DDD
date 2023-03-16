
namespace AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Comandos
{
    public class AgregarFiadorParaContratoComando
    {

        public string ContratoId { get; set; }
        public string Nombre { get; init; }
        public int Telefono { get; set; }
     


        public AgregarFiadorParaContratoComando(string contratoId, string nombre, int telefono) {

            ContratoId = contratoId;
            Nombre = nombre;
            Telefono = telefono;

        }


    }
}
