using Core.Dominio;
using Core.Repositorio.Interfaces;

namespace Core.Repositorio
{
    public class PessoaRepositorio : Repositorio<Pessoa>, IPessoaRepositorio
    {
        public PessoaRepositorio(AppDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<bool> AdicionarPessoaSeNaoExistir(Pessoa pessoa)
        {
            if (await GetByID(p => p.CPF == pessoa.CPF) != null)
            {
                return false;
            }
            Add(pessoa);
            return true;
        }
    }
}
