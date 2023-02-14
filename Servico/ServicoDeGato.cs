using UMBIT.API.EXEMPLO.model;
using UMBIT.Core.Repositorio;

namespace UMBIT.API.EXEMPLO.Servico
{
    public class ServicoDeGato : ServiceBase<Gato>
    {
        public ServicoDeGato(DataServiceFactory dataServiceFactory) : base(dataServiceFactory)
        {
        }
    }
}
