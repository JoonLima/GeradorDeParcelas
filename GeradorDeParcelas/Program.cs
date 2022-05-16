using GeradorDeParcelas.Entities;
using GeradorDeParcelas.Services;
using System;
using System.Globalization;



namespace GeradorDeParcelas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do contrato:");
            Console.Write("Numero: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Data (DD/MM/YYYY): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do contrato: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Número de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numero, data, valor);

            ServicoDeContrato servicoDeContrato = new ServicoDeContrato(new ServicoPaypal());

            servicoDeContrato.ProcessarContrato(contrato, parcelas);

            Console.WriteLine();
            Console.WriteLine("PARCELAS:");

            foreach (Parcela parcela in contrato.Parcelas)
            {
                Console.WriteLine(parcela);
            }

        }
    }
}
