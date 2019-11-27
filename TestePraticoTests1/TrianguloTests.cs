using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestePratico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestePratico.Tests
{
    [TestClass()]
    public class TrianguloTests
    {
        [TestMethod()]
        public void ValidarTrianguloRetanguloTest_valido()
        {
            Triangulo obj = new Triangulo();
            Assert.AreEqual(true, obj.ValidarTrianguloRetangulo(3,4,5));
        }

        [TestMethod()]
        public void ValidarTrianguloRetanguloTest_invalido()
        {
            Triangulo obj = new Triangulo();
            Assert.AreEqual(false, obj.ValidarTrianguloRetangulo(3, 3, 5));
        }
        
        [TestMethod()]
        public void ValidarTrianguloEquilateroTest_valido()
        {
            Triangulo obj = new Triangulo();
            Assert.AreEqual(true,obj.ValidarTrianguloEquilatero(3,3,3));
        }


        [TestMethod()]
        public void ValidarTrianguloEquilateroTest_invalido()
        {
            Triangulo obj = new Triangulo();
            Assert.AreNotEqual(true, obj.ValidarTrianguloEquilatero(3, 1, 3));
        }

        [TestMethod()]
        public void CalcularHipotenusaTest()
        {
            Triangulo obj = new Triangulo();
            Assert.AreEqual(10,obj.CalcularHipotenusa(6,8));
        }

        [TestMethod()]
        public void CalcularAreaTrianguloTest()
        {
            Triangulo obj = new Triangulo();
            Assert.AreEqual(48,obj.CalcularAreaTriangulo(10,10,12));
        }

        [TestMethod()]
        public void ValidarTrianguloTest()
        {
            Triangulo obj = new Triangulo();
            Assert.AreEqual(true,obj.ValidarTriangulo(5,7,8));
        }
    }
}