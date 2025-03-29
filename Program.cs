Console.Clear();


 double ValorfaturaT;
 double Pagamento;
 
 double TaxaM;
 double PagamentoMin;
 double ValorN;
 double juros;
 double IOFM;
 double IOFD;
 double ValorCo;

Console.WriteLine("Super maquina de calculo de ceditos rotativos!");

Console.WriteLine("Por favor, insira os seguintes valores:");


        Console.WriteLine("Valor total da fatura (R$)...:");
        ValorfaturaT = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Pagamento mínimo (%).........:");
        Pagamento = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Taxa de juros mensais (%)....:");
        TaxaM = Convert.ToDouble(Console.ReadLine());


Console.WriteLine();

PagamentoMin =   ValorfaturaT/ 100 * Pagamento ;

ValorN = Pagamento -PagamentoMin;

juros = PagamentoMin - ValorN;

IOFM = PagamentoMin *  0.0038;

IOFD = PagamentoMin * 0.00246;

ValorCo =  TaxaM+1* PagamentoMin;

Console.WriteLine($"Pagamento mínimo..................:{PagamentoMin}");

Console.WriteLine("Caso seja pago o valor mínimo:");

Console.WriteLine($"Valor não pago....................:{ValorN}");

Console.WriteLine($"Juros.............................:{juros}");

Console.WriteLine($"IOF mensal........................:{IOFM}");

Console.WriteLine($"IOF diário........................:{IOFD}");

Console.WriteLine($"Valor a pagar na próxima fatura...:{ValorPa}");

