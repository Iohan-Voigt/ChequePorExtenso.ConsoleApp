using ChequePorExtenso;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteEscritaExtensoValorReais
{
    [TestClass]
    public class TesteConversaoEscritaNumeroParaReal
    {
        [TestMethod]
        public void DeveRetornarEntradaInválida()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("Entrada Inválida", conversor.Converte("a"));
        }

        [TestMethod]
        public void DeveRetornarUmCentavo()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("um centavo de real", conversor.Converte(0.01));
        }

        [TestMethod]
        public void DeveRetornarCincoCentavos()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("cinco centavos de real", conversor.Converte(0.05));
        }

        [TestMethod]
        public void DeveRetornarDezCentavos()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("dez centavos de real", conversor.Converte(0.10));
        }

        [TestMethod]
        public void DeveRetornarDozeCentavos()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("doze centavos de real", conversor.Converte(0.12));
        }

        [TestMethod]
        public void DeveRetornarVinteESeisCentavos()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("vinte e seis centavos de real", conversor.Converte(0.26));
        }
        [TestMethod]
        public void DeveRetornarUmReal()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("um real", conversor.Converte(1));
        }
        [TestMethod]
        public void DeveRetornarUmRealEVinteESeisCentavos()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("um real e vinte e seis centavos", conversor.Converte(1.26));
        }
        [TestMethod]
        public void DeveRetornarDezReais()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("dez reais", conversor.Converte(10));
        }
        [TestMethod]
        public void DeveRetornarTrezeReais()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("treze reais", conversor.Converte(13));
        }
        [TestMethod]
        public void DeveRetornarDezeseteReaisECinquentaCentavos()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("dezessete reais e cinquenta centavos", conversor.Converte(17.5));
        }
        [TestMethod]
        public void DeveRetornarTrintaReais()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("trinta reais", conversor.Converte(30));
        }
        [TestMethod]
        public void DeveRetornarTrintaESeisReais()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("trinta e seis reais", conversor.Converte(36));
        }
        [TestMethod]
        public void DeveRetornarQuarentaENoveReaisENoventaCentavos()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("quarenta e nove reais e noventa centavos", conversor.Converte(49.9d));
        }
        [TestMethod]
        public void DeveRetornarCemReais()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("cem reais", conversor.Converte(100));
        }
        [TestMethod]
        public void DeveRetornarCentoETresReais()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("cento e três reais", conversor.Converte(103));
        }
        [TestMethod]
        public void DeveRetornarDuzentosEQuarentaECincoReais()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("duzentos e quarenta e cinco reais", conversor.Converte(245));
        }
        [TestMethod]
        public void DeveRetornarTrezentosECinquentaESeteReaisEVinteETresCentavos()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("trezentos e cinquenta e sete reais e vinte e três centavos", conversor.Converte(357.23));
        }
        [TestMethod]
        public void DeveRetornarUmMilReais()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("um mil reais", conversor.Converte(1000));
        }

        [TestMethod]
        public void DeveRetornarDoisMilReais()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("dois mil reais", conversor.Converte(2000));
        }

        [TestMethod]
        public void DeveRetornarUmMilhaoQuatrocentosMilReais()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("um milhão quatocentos mil reais e treze centavos", conversor.Converte(1400000.13));
        }

        [TestMethod]
        public void DeveRetornarQuatrocentosEVinteECincoMilhoesNovecentosESessentaEUmMilSeiscentosEtrintaESeteReaisECinquentaECincoCentavos()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("quatocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais e cinquenta e cinco centavos", conversor.Converte(425961637.55));
        }

        [TestMethod]
        public void DeveRetornarNaCasaCentenalDeBilhoesComCentavos()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("oitocentos e trinta e dois bilhões quatocentos e vinte e cinco milhões novecentos e sessenta e um mil seiscentos e trinta e sete reais e setenta e dois centavos", conversor.Converte(832425961637.72));
        }

        [TestMethod]
        public void DeveRetornarInvalido()
        {
            Conversor conversor = new Conversor();
            Assert.AreEqual("Entrada Inválida", conversor.Converte(8999425961637.72));
        }

    }
}
