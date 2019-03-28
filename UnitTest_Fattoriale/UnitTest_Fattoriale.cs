using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_Fattoriale
{
    [TestClass]
    public class UnitTest_Fattoriale
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(50)]
        public void TestMethod1(long numero)
        {
            long fattoriale;

            fattoriale = Fattoriale.Program1.Fattoriale(numero);

            Console.WriteLine("{0}!={1}", numero, fattoriale);
        }
    }
}