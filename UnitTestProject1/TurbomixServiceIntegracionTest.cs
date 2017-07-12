using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EjercicioEntregar2;

namespace UnitTestProject1
{
    [TestClass]
    public class TurbomixServiceIntegracionTest
    {
        [TestMethod]
        public void TestPrepararPlato()
        {
            IBascula basculaService = new BasculaService();
            ICocina cocinaService = new CocinaService();

            TurbomixService sut = new TurbomixService(basculaService, cocinaService);
            Alimento mAlimento1 = new Alimento();
            mAlimento1.Nombre = "Curry";
            mAlimento1.Peso = 1.5F;
            Alimento mAlimento2 = new Alimento();
            mAlimento2.Nombre = "Queso";
            mAlimento2.Peso = 5F;
            Receta mReceta = new Receta();
            mReceta.NombreAlimento1 = "Curry";
            mReceta.NombreAlimento2 = "Queso";
            mReceta.Peso1 = 1.5F;
            mReceta.Peso2 = 5F;

            Plato resultado = sut.PrepararPlato(mAlimento1, mAlimento2, mReceta);
            Assert.IsTrue(resultado is Plato);
        }
    }
}
