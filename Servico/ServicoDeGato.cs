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
        
        public ServicoDeGato(IDataServiceFactory dataServiceFactory) : base(dataServiceFactory)
        {
        }
    }
}
