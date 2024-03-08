namespace Core.Repositorio.Interfaces
{
    public interface IUnityOfWork
    {
        IPessoaRepositorio PessoaRepositorio { get; }

        Task Commit();
    }
}
