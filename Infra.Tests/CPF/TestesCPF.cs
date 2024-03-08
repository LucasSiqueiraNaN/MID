using Infra.Utils;
using Infra.Validacoes;

namespace Infra.Tests.CPF
{
    public class TestesCPF
    {
        private CPFValido validadorCPF;

        [SetUp]
        public void Setup()
        {
            validadorCPF = new CPFValido();
        }

        [Test]
        public void CPFValido() =>
            Assert.That(validadorCPF.IsValid("79523630008"), Is.EqualTo(true), "Deve ser inserido um CPF valido");
        
        [Test]
        public void CPFInvalido() =>
            Assert.That(validadorCPF.IsValid("79523630000"), Is.EqualTo(false), "Deve ser inserido um CPF invalido");
        
        [Test]
        public void CPFNaoDefinido() =>
            Assert.That(validadorCPF.IsValid(""), Is.EqualTo(false), "CPF não deve ser definido");
    }
}