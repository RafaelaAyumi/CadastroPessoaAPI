using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClickToStudy.Models;

namespace ClickToStudy.Interfaces
{
    public interface IPessoaWorker
    {
        Task CadastrarPessoa(Pessoa pessoa);
        Task ConsultarPessoa(Pessoa pessoa);
    }
}
