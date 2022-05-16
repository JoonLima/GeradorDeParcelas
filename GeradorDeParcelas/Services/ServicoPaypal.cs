using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeParcelas.Services
{
    class ServicoPaypal : IServicoPagamentoOnline
    {

        private const double PorcentagemJuros = 0.02;
        private const double TaxaMensal = 0.01;

        public double Juros(double valor, int meses)
        {
            return valor * TaxaMensal * meses;
        }

        public double TaxaPagamento(double valor)
        {
            return valor * PorcentagemJuros;
        }
    }
}
