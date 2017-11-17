using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SupervivientesNet.Negocios;
namespace SupervivientesNet.Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ultimoIdPedidos()
        {
            int esperado = 100;
            Pedido pe = new Pedido();
            int resultado = pe.ultimoId();
            Assert.AreEqual(esperado, resultado);
        }

        [TestMethod]
        public void ExistePedido()
        {
            bool esperado = true;
            Pedido pe = new Pedido(100, 1, 3, "Alana", 1);
            bool compara = pe.existePedido();
            Assert.AreEqual(esperado, compara);
        }

        [TestMethod]
        public void ultimoIDContacto()
        {
            int esperado = 1;
            Contacto co = new Contacto() {};
            int compara = co.ultimoId();
            Assert.AreEqual(esperado, compara);
        }

        [TestMethod]
        public void RecintoMasSolicitado()
        {
            string esperado = "Otros";
            Estadisticas stat = new Estadisticas();
            string compara = stat.recintoMasSolicitado();
            Assert.AreEqual(esperado, compara);
        }

        [TestMethod]
        public void DiaMasSolicitado()
        {
            string esperado = "Martes";
            Estadisticas stat = new Estadisticas();
            string compara = stat.DiaConMasSolicitudes();
            Assert.AreEqual(esperado, compara);
        }

        [TestMethod]
        public void BloqueMasSolicitado()
        {
            string esperado = "09:16 - 10:00";
            Estadisticas stat = new Estadisticas();
            string compara = stat.BloqueMasPedido();
            Assert.AreEqual(esperado, compara);
        }

    }
}
