using UMBIT.API.EXEMPLO.model;
using UMBIT.Core.Repositorio;
using UMBIT.CORE.API.Servico.Interface;
using UMBIT.Prototico.Core.API.Servico.Basicos;
using UMBIT.Prototico.Core.API.Servico.Interface;

namespace UMBIT.API.EXEMPLO.Servico
{
    public interface IServicoDeGato : IServicoDeEntidadeBase<Gato>
    {
    }

    public class ServicoDeGato :  ServicoDeEntidadeBase<Gato>, IServicoDeGato
    {
        public readonly IServicoDeJWT servicoDeJWT;
        public ServicoDeGato(IDataServiceFactory dataServiceFactory, IServicoDeJWT servicoDeJWT) : base(dataServiceFactory)
        {
            this.servicoDeJWT = servicoDeJWT;
        }
    }
}
