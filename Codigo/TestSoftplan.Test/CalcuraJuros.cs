using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestSoftplan.Test
{
    [TestClass]
    public class CalcuraJuros
    {
        [TestMethod]
        public void CalculaJurosCompostoValidado()
        {
            double valorInicial = 100;
            int meses = 5;
            double valorFinalTemp = valorInicial * (1 + 0.01);
            var valorFinal = exp(meses, valorFinalTemp);
            Assert.Equals(valorFinal, 105.10m);
        }

        [TestMethod]
        public void CalculaJurosCompostoNaoValidado()
        {
            double valorInicial = 100;
            int meses = 5;
            double valorFinalTemp = valorInicial * (1 + 0.01);
            var valorFinal = exp(meses, valorFinalTemp);
            Assert.AreNotEqual(valorFinal, 105.10m);
        }

        public static double exp(double valueBase, double expoente)
        {
            double resultado = 0;

            if (valueBase == 0)
            {
                resultado = 0;
            }
            else
                for (int i = 1; i < expoente; i++)
                {
                    resultado = valueBase * i;
                }

            return resultado;
        }
    }
}
