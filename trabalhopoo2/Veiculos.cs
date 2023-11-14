using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabalhopoo2
{
    internal class Veiculos
    {

        public string Placa { get; set; }
        public int QntEixos { get; set; }
        public int Tipo { get; set; }
        public double PrecoPedagio { get; set; }
        public double ValorFinal { get; set; }

        public Veiculos(string placa, int eixos, int tipo) 
        {
            this.Placa = placa;
            this.QntEixos = eixos;
            this.Tipo = tipo;
        }
        public virtual void CalcularPedagio()
        {

        }
        public void CalcularDesconto()
        {
            if(Tipo == 1)
            {
                ValorFinal = PrecoPedagio;
            }
            if(Tipo == 2)
            {
                double desconto = 5;
                ValorFinal = PrecoPedagio - (PrecoPedagio * (desconto / 100));
            }
            if(Tipo == 3)
            {
                double desconto = 100;
                ValorFinal = PrecoPedagio - (PrecoPedagio * (desconto / 100));
            }
        }
    }
}
