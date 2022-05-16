<h2>Programa para ler os dados de um contrato (número do contrato, data do contrato,
e valor total do contrato).</h2>

O programa lê o número de meses para parcelamento do contrato, e gera os registros de parcelas a serem pagas (data e valor),
sendo a primeira parcela a ser paga um mês após a data do contrato, a segunda parcela dois meses após o contrato e assim por diante.

Para as parcelas foi utilizado o seguinte calculo:

O programa aplica juros simples de 1% a cada parcela, mais uma taxa de pagamento de 2%.

Exemplo:

Calculo (1% Por mês de juros simples + 2% Taxa de pagamento):

Valor base: R$ 600,00
Numero de parcelas: 3

Parcela #1: 
200 + 1% * 1 = 202 
202 + 2% = 206.04

Parcela #2: 
200 + 1% * 2 = 204 
204 + 2% = 208.08

Parcela #3: 
200 + 1% * 3 = 206 
206 + 2% = 210.12
