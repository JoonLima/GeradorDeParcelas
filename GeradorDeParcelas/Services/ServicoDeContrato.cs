using GeradorDeParcelas.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeParcelas.Services
{
    class ServicoDeContrato
    {
        private IServicoPagamentoOnline _servicoPagamentoOnline;

        public ServicoDeContrato(IServicoPagamentoOnline servicoPagamentoOnline)
        {
            _servicoPagamentoOnline = servicoPagamentoOnline;
        }

        public void ProcessarContrato(Contrato contrato, int meses)
        {

            double valorBase = contrato.ValorTotal / meses;

            for (int i = 1; i <= meses; i++)
            {
                DateTime data = contrato.Data.AddMonths(i);
                double valorComJuros = valorBase + _servicoPagamentoOnline.Juros(valorBase, i);
                double valorTotal = valorComJuros + _servicoPagamentoOnline.TaxaPagamento(valorComJuros);
                contrato.AdicionarParcelas(new Parcela(data, valorTotal));
            }
            
        }
    }
}
