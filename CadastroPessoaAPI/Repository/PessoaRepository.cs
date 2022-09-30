using ClickToStudy.Interfaces;
using ClickToStudy.Models;

namespace ClickToStudy.Repository
{
    public class PessoaRepository : IPessoaRepository
    {



        public async Task Insert(Pessoa pessoa)
        {
            var nome = pessoa.Nome + ";";
            var cpf = pessoa.CPF + ";";
            var idade = pessoa.Idade + ";";
            var datanascimento = pessoa.DtNascimento + ";";
            var sexo = pessoa.Sexo + ";";
            var celular = pessoa.Celular + ";";

            var linha = nome + cpf + idade + datanascimento + sexo + celular;

            using (StreamWriter arquivo = new StreamWriter(@"C:\Users\pc\OneDrive\Área de Trabalho\Teste\pessoa.csv", true))
                arquivo.WriteLine(linha);

        }

        public async Task Read(Pessoa pessoa)
        {
            // Implementar método aqui - Confirmar erro de Body do GET
        }
    }
}
