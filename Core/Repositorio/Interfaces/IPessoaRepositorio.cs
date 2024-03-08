using Core.Dominio;

namespace Core.Repositorio.Interfaces
{
    public interface IPessoaRepositorio : IRepositorio<Pessoa>
    {
        public Task<bool> AdicionarPessoaSeNaoExistir(Pessoa pessoa);
    }
}
