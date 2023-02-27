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
    public class WeatherForecastController : ControllerBase
    {

        private IServicoDeGato ServicoDeGato;
        private IServicoDeIdentidade ServicoDeIdentidade;

        public WeatherForecastController(IServicoDeGato ServicoDeGato, IServicoDeIdentidade servicoDeIdentidade)
        {
            this.ServicoDeGato = ServicoDeGato;
            this.ServicoDeIdentidade = servicoDeIdentidade;

        }

        [HttpGet("GetWeatherForecast")]
        public bool AddGato()
        {

            this.ServicoDeGato.AdicionaObjeto(new model.Gato() { Tipo = "" });

            return true;

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