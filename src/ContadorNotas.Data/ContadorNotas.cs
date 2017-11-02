using System;
using System.Collections.Generic;

namespace ContadorNotas.Data
{
    public class ContadorNotas
    {
        private static int[] listaNotasDisponiveis = new int[7] { 1, 2, 5, 10, 20, 50, 100 };


        private IEnumerable<ItemContagem> RetornarValorVazio()
        {
            return new List<ItemContagem> {
                    new ItemContagem {
                        ItemPrincipal = new Item { Quantidade = 0, ValorNota = 0 }
                    }

            };
        }


        public IEnumerable<ItemContagem> Contar(int valorSaque)
        {
            if (valorSaque <= 0)
            {
                return RetornarValorVazio();
            }
            else
            {
                var retorno = new List<ItemContagem>();

                foreach (int nota in listaNotasDisponiveis)
                {
                    if (nota > valorSaque)
                        break;

                    retorno.Add(ContarPorNota(valorSaque, nota));
                }

                return retorno;
            }
        }

        private ItemContagem ContarPorNota(int valorADividir, int valorNota)
        {
            int quantidade = (valorADividir/ valorNota),
                sobra = valorADividir % valorNota;

            var retorno = new ItemContagem()
            {
                ItemPrincipal = new Item { Quantidade = quantidade, ValorNota = valorNota }
            };

            if (sobra > 0)
            {
                retorno.Sobra = Contar(sobra);
            }

            return retorno;

        }


    }
}
