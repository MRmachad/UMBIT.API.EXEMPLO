using UMBIT.API.EXEMPLO.model;
using UMBIT.Core.Repositorio;

namespace UMBIT.API.EXEMPLO.Servico
{
    public interface IServicoDeGato : IServiceBase<Gato>
    {
    }

    public class ServicoDeGato :  ServiceBase<Gato>, IServicoDeGato
    {
        public ServicoDeGato(IDataServiceFactory dataServiceFactory) : base(dataServiceFactory)
        {
        }
    }
}
