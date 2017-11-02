using Microsoft.VisualStudio.TestTools.UnitTesting;

using ContadorNotas.Data;
using System.Collections.Generic;
using System.Linq;

namespace ContadorNotas.Tests
{
    [TestClass]
    public class ContadorNotasTest
    {
        [TestMethod]
        public void DeveTestarValorZerado()
        {
            var contadorNotas = new ContadorNotas.Data.ContadorNotas();

            var resultadoContagem = contadorNotas.Contar(0);

            var resultadoEsperado = new List<ItemContagem> {
                    new ItemContagem {
                        ItemPrincipal = new Item { Quantidade = 0, ValorNota = 0 }
                    }
            };

            Assert.AreEqual(resultadoEsperado, resultadoContagem);
        }

        [TestMethod]
        public void DeveContarValor100()
        {
            int valorSaque = 100;

            var contadorNotas = new ContadorNotas.Data.ContadorNotas();

            IEnumerable<ItemContagem> resultadoContagem = contadorNotas.Contar(valorSaque);

            IEnumerable<ItemContagem> resultadoEsperado = new List<ItemContagem> {
                    new ItemContagem {
                        ItemPrincipal = new Item { Quantidade = 100, ValorNota = 1 }
                    },
                    new ItemContagem {
                        ItemPrincipal = new Item { Quantidade = 50, ValorNota = 2 }
                    },
                    new ItemContagem {
                        ItemPrincipal = new Item { Quantidade = 20, ValorNota = 5 }
                    },
                    new ItemContagem {
                        ItemPrincipal = new Item { Quantidade = 10, ValorNota = 10 }
                    },
                    new ItemContagem {
                        ItemPrincipal = new Item { Quantidade = 5, ValorNota = 20 }
                    },
                    new ItemContagem {
                        ItemPrincipal = new Item { Quantidade = 2, ValorNota = 50 }
                    },
                    new ItemContagem {
                        ItemPrincipal = new Item { Quantidade = 1, ValorNota = 100 }
                    }
            };
        }
    }
}
