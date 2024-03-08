using Core.DTOs;
using Core.Validacoes;

namespace ApiMID.tests.Validacoes.Tests.Pessoa
{
    [TestFixture]
    public class TestesPessoaEstado
    {
        private NomeValido validadorNome;

        [SetUp]
        public void Setup()
        {
            validadorNome = new NomeValido();
        }

        [Test]
        public void NomeValido()
        {
            var pessoa = new PessoaDTO { Nome = "Kaian" };
            Assert.That(validadorNome.IsValid(pessoa), Is.EqualTo(true), "Nome deve conter ao menos 3 caracteres");

        }

        [Test]
        public void NomeNaoInformado()
        {
            var pessoa = new PessoaDTO { };
            Assert.That(validadorNome.IsValid(pessoa), Is.EqualTo(false), "Nome não deve ser informado");
        }

        [Test]
        public void NomeMuitoLongo()
        {
            var pessoa = new PessoaDTO
            {
                Nome = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis at eros vel urna scelerisque condimentum eget id dolor. Vestibulum nec viverra ligula. Sed ullamcorper ligula at mauris lacinia, eget euismod mi tincidunt. Aenean consequat, neque at vestibulum elementum, lacus felis auctor nulla, vitae vehicula nulla ante non magna. Sed at urna non enim ultrices sollicitudin nec vitae est. Integer eu eleifend sapien. Duis vitae eros a dolor sagittis vehicula. Nam sollicitudin dapibus fermentum. Sed eget mauris eu metus consequat posuere. Aliquam sit amet erat non enim aliquam fermentum. Nulla id ante ut felis tristique vestibulum at ac sapien. Donec at posuere magna. Nam euismod lacinia ipsum, nec feugiat purus ultricies non. Phasellus ut sodales sem, ut laoreet dolor."
            };
            Assert.That(validadorNome.IsValid(pessoa), Is.EqualTo(false), "Nome deve ser >= 100 caracteres");
        }
    }
}
