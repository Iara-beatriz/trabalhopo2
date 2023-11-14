using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhopoo2
{
    internal class Caminhão:Veiculos
    {
        public Caminhão(string placa, int eixos, int tipo)
            : base(placa, eixos, tipo) 
        {
            CalcularPedagio();
        }

        public override void CalcularPedagio()
        {
            double taxa = 10;
            this.PrecoPedagio = (QntEixos * 7) + ((QntEixos * 7) * (taxa / 100));
            CalcularDesconto();
        }

    }
}
