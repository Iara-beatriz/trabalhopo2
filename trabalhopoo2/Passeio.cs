using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhopoo2
{
    internal class Passeio: Veiculos
    {
        public Passeio(string placa, int eixos, int tipo) 
          : base(placa,eixos, tipo)
        {
            CalcularPedagio();
        }

        public override void CalcularPedagio()
        {
            this.PrecoPedagio = QntEixos * 3;
            CalcularDesconto();
        }
    }
}
