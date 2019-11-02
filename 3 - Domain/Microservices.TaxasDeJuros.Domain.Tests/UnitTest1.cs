using CalculadoraDeJuros.Contratos.Domain;
using Microservices.TaxasDeJuros.Domain.Builders.TaxasDeJurosPadrao;
using Microservices.TaxasDeJuros.Domain.Factories.TaxasDeJurosPadrao;
using Moq;
using Xunit;

namespace Microservices.TaxasDeJuros.Domain.Tests
{
    public class UnitTest1
    {
        private const decimal Valor = 0.01M;
        private readonly ITaxaDeJurosPadrao _taxaDeJurosPadrao;
        private readonly ITaxaDeJurosPadraoBuilder<ITaxaDeJurosPadrao> _taxaDeJurosPadraoBuilder;
        private readonly Mock<ITaxaDeJurosPadraoBuilder<ITaxaDeJurosPadrao>> _taxaDeJurosPadraoBuilderMock;
        private readonly ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao> _taxaDeJurosPadraoFactory;
        private readonly Mock<ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao>> _taxaDeJurosPadraoFactoryMock;
        private readonly Mock<ITaxaDeJurosPadrao> _taxaDeJurosPadraoMock;

        public UnitTest1()
        {
            _taxaDeJurosPadraoBuilderMock = new Mock<ITaxaDeJurosPadraoBuilder<ITaxaDeJurosPadrao>>();
            _taxaDeJurosPadraoFactoryMock = new Mock<ITaxaDeJurosPadraoFactory<ITaxaDeJurosPadrao>>();
            _taxaDeJurosPadraoMock = new Mock<ITaxaDeJurosPadrao>();

            _taxaDeJurosPadrao = new TaxaDeJurosPadrao(Valor);
            _taxaDeJurosPadraoBuilder = new TaxaDeJurosPadraoBuilder();
            _taxaDeJurosPadraoFactory = new TaxaDeJurosPadraoFactory(_taxaDeJurosPadraoBuilder);
        }

        [Fact(DisplayName = "Validando o Domínio da Taxa de Juros Padrão")]
        public void ValidarFactoryDaTaxaDeJurosPadrao()
        {
            _taxaDeJurosPadraoFactoryMock.Setup(x => x.Create()).Returns(_taxaDeJurosPadrao).Verifiable();
            _taxaDeJurosPadraoBuilderMock.Setup(x => x.WithValor(Valor)).Returns(_taxaDeJurosPadraoBuilder).Verifiable();
            _taxaDeJurosPadraoBuilderMock.Setup(x => x.Build()).Returns(_taxaDeJurosPadrao).Verifiable();

            var result = _taxaDeJurosPadraoFactory.Create();

            // _taxaDeJurosPadraoFactoryMock.Verify();

            Assert.NotNull(result);
            Assert.Equal(Valor, result.Get());
        }
    }
}