using System.Net.Http;
using System.Threading.Tasks;
using UMBIT.API.EXEMPLO.model;
using UMBIT.Prototico.Core.API.Servico.Basicos;
using UMBIT.Prototico.Core.API.Servico.Interface;

namespace UMBIT.API.EXEMPLO.Servico
{

    public interface IServicoDeAPI : IServicoDeRequisicao
    {
        Task<RequestResponse<HTTPBIN>> GetHTTPBinAsync();
    }
    public class ServicoDeAPI : ServicoDeRequisicao, IServicoDeAPI
    {
        public ServicoDeAPI(HttpClient cliente) : base(cliente)
        {
        }

        public async Task<RequestResponse<HTTPBIN>> GetHTTPBinAsync()
        {
            var obj = await this.ExecuteGetAsync<HTTPBIN>("/get");

            return obj;
        }
    }
}
