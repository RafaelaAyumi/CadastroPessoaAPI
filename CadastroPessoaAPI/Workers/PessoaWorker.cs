using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClickToStudy.Models;
using ClickToStudy.Interfaces;

namespace ClickToStudy.Workers
{
    public class PessoaWorker : IPessoaWorker
    {

        private readonly IPessoaRepository _pessoaRepository;


        public PessoaWorker(IPessoaRepository pessoaWorker)
        {
            _pessoaRepository = pessoaWorker;
        }

        public async Task CadastrarPessoa(Pessoa pessoa)
        {
            await _pessoaRepository.Insert(pessoa);
        }

        public async Task<Pessoa> ConsultarPessoa(Guid guid)
        {
            return await _pessoaRepository.Read(guid);
        }
    }
}
