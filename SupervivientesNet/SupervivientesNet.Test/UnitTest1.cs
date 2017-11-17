using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SupervivientesNet.Negocios;

namespace SupervivientesNet.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int esperado = 100;
            Pedido pe = new Pedido();
            int resultado = pe.ultimoId();
            Assert.AreEqual(esperado, resultado);
        }
    }
}
