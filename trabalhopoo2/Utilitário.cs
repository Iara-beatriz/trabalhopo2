using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhopoo2
{
    internal class Utilitário: Veiculos
    {
        public Utilitário(string placa, int eixos, int tipo) : base(placa, eixos, tipo)
        {
            CalcularPedagio();
        }
        public override void CalcularPedagio()
        {
            double taxa = 2;
            this.PrecoPedagio = (QntEixos * 3.5) + (QntEixos * 3.5) * (taxa / 100.0);
            CalcularDesconto();
        }
    }
}
