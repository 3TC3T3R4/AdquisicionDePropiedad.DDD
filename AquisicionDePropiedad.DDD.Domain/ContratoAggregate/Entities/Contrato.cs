using AdquisicionDePropiedad.DDD.Domain.Comunes;
using AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.Eventos;
using AdquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorContrato;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorContrato;
using AquisicionDePropiedad.DDD.Domain.ContratoAggregate.ValueObjects.ObjetoDeValorFiador;


namespace AquisicionDePropiedad.DDD.Domain.ContratoAggregate.Entities
{
    public class Contrato : AggregateEvent<ContratoId>
    {

        public ContratoId ContratoId { get;init; }

        public IdsAgregados IdsAgregados { get; private set; }

        public virtual Fiador Fiador { get; private set; }
        public virtual Estado Estado { get; private set; }


        public Contrato(ContratoId contratoID) : base(contratoID)
        {
            this.ContratoId = contratoID;
        }

        

        public void SetContratoId(ContratoId contratoID)
        {
            AppendChange(new ContratoCreado(contratoID.ToString()));
        }
        public void SetIdsDeAgregados(IdsAgregados idsAgregados)
        {
            AppendChange(new IdsDeAgregadosAgregados(idsAgregados));
        }

        public void SetIdsDeAgregadosFinal(IdsAgregados idsAgregados)
        {
                    this.IdsAgregados = idsAgregados;
        }
        public void SetAgregarFiadorParaContrato(Fiador fiador)
        {

            AppendChange(new FiadorParaContratoAgregado(fiador));

        }

        public void SetFiadorAgregado(Fiador fiador)
        {

            this.Fiador = fiador;

        }

        public void SetAgregarEstadoParaContrato(Estado estado)
        {

            AppendChange(new EstadoParaContratoAgregado(estado));

        }
        public void SetEstadoAgregado(Estado estado)
        {

            this.Estado = estado;

        }




    }
}
