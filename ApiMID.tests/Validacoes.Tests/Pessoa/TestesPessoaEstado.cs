using Core.DTOs;
using Core.Validacoes;

namespace ApiMID.tests.Validacoes.Tests.Pessoa
{
    [TestFixture]
    public class TestesPessoaNome
    {
        private EstadoUFValido validadorEstado;

        [SetUp]
        public void Setup()
        {
            validadorEstado = new EstadoUFValido();
        }

        [Test]
        public void EstadoValido()
        {
            var pessoa = new PessoaDTO { UF = "RS" };
            Assert.That(validadorEstado.IsValid(pessoa), Is.EqualTo(true), "Estado deve conter somente 2 caracteres");
        }

        [Test]
        public void EstadoInvalido()
        {
            var pessoa = new PessoaDTO { UF = "" };
            Assert.That(validadorEstado.IsValid(pessoa), Is.EqualTo(false), "Estado não deve ser informado");
        }
    }
}