namespace CadastroPessoaAPI.Models.Exceptions
{
    public class PessoaNotFoundException : Exception
    {
        public PessoaNotFoundException() : base("Pessoa não encontrada!")
        {
        }
    }
}
