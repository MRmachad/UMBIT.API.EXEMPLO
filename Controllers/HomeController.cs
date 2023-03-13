using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UMBIT.API.EXEMPLO.Servico;
using UMBIT.Prototico.Core.API.Servico.Interface;

namespace UMBIT.API.EXEMPLO.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {

        private IServicoDeGato ServicoDeGato;
        private IServicoDeIdentidade ServicoDeIdentidade;
        private IServicoDeAPI servicoDeAPI; 

        public HomeController(IServicoDeGato ServicoDeGato, IServicoDeIdentidade servicoDeIdentidade, IServicoDeAPI servicoDeAPI)
        {
            this.ServicoDeGato = ServicoDeGato;
            this.ServicoDeIdentidade = servicoDeIdentidade;
            this.servicoDeAPI = servicoDeAPI;
        }

        [HttpGet("GetHome")]
        public IActionResult AddGato()
        {

            this.ServicoDeGato.AdicionaObjeto(new model.Gato() { Tipo = String.Empty });

            return Ok();

        }

        [HttpGet("teste-api")]
        public async Task<IActionResult> getapiAsync()
        {
            var res  = await this.servicoDeAPI.GetHTTPBinAsync();

            return Ok(res);

        }


        [HttpGet("cadastro")]
        public async Task<IActionResult> Cadastro(string user, string senha)
        {
            return Ok(await this.ServicoDeIdentidade.Cadastro(user, senha));

        }

        [HttpGet("login")]
        public async Task<IActionResult> Login(string user, string senha)
        {
            return Ok(await this.ServicoDeIdentidade.Login(user, senha));
            

        }

        [HttpGet("autentique")]
        public async Task<IActionResult> Autenticar(string user, string senha)
        {
            return Ok(await this.ServicoDeIdentidade.AutenticaUsuarioAsync(user, senha));

        }

        [HttpGet("logout")]
        public async Task<IActionResult> Logout(string user, string senha)
        {
            return Ok(await this.ServicoDeIdentidade.Logout(user, senha));

        }
    }
}