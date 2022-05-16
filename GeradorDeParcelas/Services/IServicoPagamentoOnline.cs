using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeParcelas.Services
{
    interface IServicoPagamentoOnline
    {
        double TaxaPagamento(double valor);
        double Juros(double valor, int meses);
    }
}
