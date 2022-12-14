using ClickToStudy.Models;

namespace ClickToStudy.Interfaces
{
    public interface IPessoaRepository
    {
        Task Insert(Pessoa pessoa);

        Task<Pessoa> Read(Guid guid);
    }
}
