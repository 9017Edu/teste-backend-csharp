using System;
using Infrastructure.TorreHanoi.Log;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Domain.TorreHanoi;

namespace Tests.TorreHanoi.Domain
{
    [TestClass]
    public class TorreHanoiUnit
    {
        private const string CategoriaTeste = "Domain/TorreHanoi";

        private Mock<ILogger> _mockLogger;

        [TestInitialize]
        public void SetUp()
        {
            _mockLogger = new Mock<ILogger>();
            _mockLogger.Setup(s => s.Logar(It.IsAny<string>(), It.IsAny<TipoLog>()));
        }

        [TestMethod]
        [TestCategory(CategoriaTeste)]
        public void Construtor_Deve_Retornar_Sucesso()
        {
            //Assert.Fail();
            var torreHanoi = new global::Domain.TorreHanoi.TorreHanoi(6, _mockLogger.Object);

            Assert.IsNotNull(torreHanoi);
            Assert.AreEqual(torreHanoi.Origem.Discos.Count, 6);
        }

        [TestMethod]
        [TestCategory(CategoriaTeste)]
        public void Processar_Deverar_Retornar_Sucesso()
        {
            //Assert.Fail();
            var torreHanoi = new global::Domain.TorreHanoi.TorreHanoi(3, _mockLogger.Object);
            torreHanoi.Processar();

            Assert.AreEqual(torreHanoi.Status, TipoStatus.FinalizadoSucesso);
        }
    }
}
