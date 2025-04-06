Console.Clear();


 double ValorfaturaT;
 double Pagamento;
 double TaxaM;

 double PagamentoMin;
 double ValorN;
 double juros;
 double IOFM;
 double IOFD;
 double ValorPP;
 double ValorPPF;

Console.WriteLine("Super maquina de calculo de ceditos rotativos!");

Console.WriteLine("Por favor, insira os seguintes valores:");

Console.WriteLine();


        Console.WriteLine("Valor total da fatura (R$)...:");
        ValorfaturaT = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Pagamento mínimo (%).........:");
        Pagamento = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Taxa de juros mensais (%)....:");
        TaxaM = Convert.ToDouble(Console.ReadLine());


Console.WriteLine();

PagamentoMin = Pagamento /100 * ValorfaturaT;
Console.WriteLine($"Pagamento mínimo..................: R${PagamentoMin}");

ValorN = ValorfaturaT - PagamentoMin; 
Console.WriteLine($"Valor não pago....................: R${ValorN}");

ValorPP =( 1 +(TaxaM /100)) * ValorN;

        juros = ValorPP - ValorN; 
        Console.WriteLine($"Juros.............................: R${Math.Round(juros, 3)}");

        IOFD = ValorN * 0.0038;
        Console.WriteLine($"IOF mensal........................: R${IOFD}");

        IOFM = 0.00246 * ValorN;
        Console.WriteLine($"IOF Diario........................: R${Math.Round(IOFM, 2)}");

        Console.WriteLine();

Console.WriteLine($"Valor a pagar na próxima fatura...: R${Math.Round(ValorPP, 3)}");


ValorPPF = juros + IOFM + IOFD;
Console.WriteLine($"Custo do crédito rotativo.........: R${Math.Round(ValorPPF, 2)}");
