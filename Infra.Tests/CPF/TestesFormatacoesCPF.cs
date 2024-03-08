using Infra.Utils;

namespace Infra.Tests.CPF
{
    public class TestesFormatacoesCPF
    {

        [Test]
        public void RemoverFormatacaoCPF() =>
            Assert.AreEqual("88271242091", FormatarCPF.RemoverMascara("882.712.420-91"));

    }
}