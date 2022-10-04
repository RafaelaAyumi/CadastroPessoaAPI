using CadastroPessoaAPI.Models.Exceptions;
using ClickToStudy.Interfaces;
using ClickToStudy.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing.Constraints;
using static System.Net.Mime.MediaTypeNames;

namespace ClickToStudy.Repository
{
    public class PessoaRepository : IPessoaRepository
    {


        public async Task Insert(Pessoa pessoa)
        {
            var guid = Guid.NewGuid() + ";";
            var nome = pessoa.Nome + ";";
            var cpf = pessoa.CPF + ";";
            var idade = pessoa.Idade + ";";
            var datanascimento = pessoa.DtNascimento + ";";
            var sexo = pessoa.Sexo + ";";
            var celular = pessoa.Celular + ";";

            var linha = nome + cpf + idade + datanascimento + sexo + celular + guid;

            using (StreamWriter arquivo = new StreamWriter(@"C:\Users\pc\OneDrive\Área de Trabalho\Teste\pessoa.csv", true))
                arquivo.WriteLine(linha);

        }

        public async Task<Pessoa> Read(Guid guid)
        {
            var path = @"C:\Users\pc\OneDrive\Área de Trabalho\Teste\pessoa.csv";
            var reader = new StreamReader(File.OpenRead(path));
            var line = reader.ReadLine();
            var columns = line.Split(";");
            (int indexNome, int indexCPF, int indexIdade, int indexDtNascimento, int indexSexo,  int indexCelular, int indexGuid) = SetColumnsIndex(columns);
             var pessoalista = CriarListaPessoa(reader, indexNome, indexCPF, indexIdade, indexDtNascimento, indexSexo, indexCelular, indexGuid);

            foreach(var pessoa in pessoalista) 
            {
                if (pessoa.Guid == guid.ToString()) 
                   return pessoa;
            }
            throw new PessoaNotFoundException();
        }



        private static (int, int, int, int, int, int, int) SetColumnsIndex(string [] columns)
        {
            int indexNome = -1;
            int indexCPF = -1;
            int indexIdade = -1;
            int indexDtNascimento = -1;
            int indexSexo = -1;
            int indexCelular = -1;
            int indexGuid = -1;
            for (int i =0; i < columns.Length; i++)
            {
                if (string.IsNullOrEmpty(columns[i]))
                    continue;
                if (columns[i].ToLower() == "nome")
                {
                    indexNome = i;

                }

                if (columns[i].ToLower() == "cpf")
                {
                    indexCPF = i;

                }

                if (columns[i].ToLower() == "idade")
                {
                    indexIdade = i;

                }

                if (columns[i].ToLower() == "dtnascimento")
                {
                    indexDtNascimento = i;

                }

                if (columns[i].ToLower() == "sexo")
                {
                    indexSexo = i;

                }

                if (columns[i].ToLower() == "celular")
                {
                    indexCelular = i;

                }

                if (columns[i].ToLower() == "guid")
                {
                    indexGuid = i;

                }

            }

            return (indexNome, indexCPF, indexIdade, indexDtNascimento, indexSexo,  indexCelular, indexGuid);
        }
        
        private static List<Pessoa> CriarListaPessoa(StreamReader reader, int indexNome, int indexCPF, int indexIdade, int indexDtNascimento, int indexSexo, int indexCelular, int indexGuid)
        {
            string line;
            var pessoalista=new List<Pessoa>();
            Pessoa pessoa;
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(';');
                pessoa = new Pessoa();
                if (indexNome != -1)
                    pessoa.Nome = values[indexNome];

                if (indexCPF != -1)
                    pessoa.CPF = values[indexCPF];

                if (indexIdade != -1)
                    pessoa.CPF = values[indexIdade];

                if (indexCPF != -1)
                    pessoa.DtNascimento = values[indexDtNascimento];

                if (indexCPF != -1)
                    pessoa.Sexo = char.Parse(values[indexSexo]);

                if (indexCPF != -1)
                    pessoa.Celular = values[indexCelular];

                if (indexGuid != -1 )
                    pessoa.Guid = values[indexGuid];

                pessoalista.Add(pessoa);
            }

            return pessoalista;
        }
    }
}
