using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhopoo2
{
    internal class Onibus : Veiculos
    {
        public Onibus(string placa, int eixos, int tipo) : base(placa, eixos, tipo) 
        {
            CalcularPedagio();
        }

        public override void CalcularPedagio()
        {
            double taxa = 5;
            this.PrecoPedagio = (QntEixos * 5) + ((QntEixos * 5) * (taxa / 100));
            CalcularDesconto();
        }
    }
}
