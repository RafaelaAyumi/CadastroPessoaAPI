using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClickToStudy.Interfaces;
using ClickToStudy.Models;
using CadastroPessoaAPI.Models.Exceptions;

namespace ClickToStudy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaWorker _pessoaWorker;

        public PessoaController(IPessoaWorker pessoaWorker)
        {
            _pessoaWorker = pessoaWorker;
        }

        [HttpPost]
        public ActionResult<Task> CadastrarPessoa([FromBody]Pessoa pessoa)
        {
            return Ok(_pessoaWorker.CadastrarPessoa(pessoa));
        }

        [HttpGet]
        public async Task<ActionResult<Pessoa>> ConsultarPessoa([FromQuery]Guid guid)
        {
            Pessoa result;
            try
            {
                result = await _pessoaWorker.ConsultarPessoa(guid);
            }
            catch (PessoaNotFoundException ex)
            {
                return NotFound(ex.Message);
            }

            return Ok(result);
        }
    }
}
