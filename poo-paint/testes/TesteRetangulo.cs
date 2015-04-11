using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using poo_paint;

namespace testes
{
    [TestClass]
    public class TesteRetangulo
    {
        [TestMethod]
        public void TesteConstrutorPadrao()
        {
            Retangulo r = new Retangulo(12, 34, 50, 40);
            Retangulo r2 = r;
            r2.x = 33;
            Assert.AreEqual(12, r.x);
            Assert.AreEqual(34, r.y);

            Assert.AreEqual("retangulo[x:12,y:34,l:50,a:40]", r.Imprime());

            //Retangulo r2 = new Retangulo(20, 20, 10, 10);
            //Assert.AreEqual("retangulo[x:20,y:20,l:10,a:10]", r2.Imprime());
        }

        [TestMethod]
        public void TesteContador()
        {
            Retangulo.ZeraContador();
            Assert.AreEqual(0, Retangulo.LeContador());

            new Retangulo(20, 20, 10, 10);
            new Retangulo(20, 20, 10, 10);
            Assert.AreEqual(2, Retangulo.LeContador());

            new Retangulo(20, 20, 10, 10);
            Assert.AreEqual(3, Retangulo.LeContador());
        }
    }
}
