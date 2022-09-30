using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ClickToStudy.Interfaces;
using ClickToStudy.Models;

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
        public ActionResult CadastrarPessoa(Pessoa pessoa)
        {
            return Ok(_pessoaWorker.CadastrarPessoa(pessoa));
        }

        [HttpGet]
        public ActionResult ConsultarPessoa(Pessoa pessoa)
        {
            return Ok(_pessoaWorker.ConsultarPessoa(pessoa));
        }
    }
}
