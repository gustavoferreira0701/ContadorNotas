using System;
using System.Collections.Generic;
using System.Text;

namespace ContadorNotas.Data
{
    public class ItemContagem
    {
        public Item ItemPrincipal { get; set; }
        public IEnumerable<ItemContagem> Sobra { get; set; }
    }
}
