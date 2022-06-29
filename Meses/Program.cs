try
{
    Console.WriteLine("Digite um número para visualizar o mês: ");
    short resposta = short.Parse(Console.ReadLine());
    Console.WriteLine("");

    switch (resposta)
    {
        case 1: Console.WriteLine("Janeiro"); break;
        case 2: Console.WriteLine("Fevereiro"); break;
        case 3: Console.WriteLine("Março"); break;
        case 4: Console.WriteLine("Abril"); break;
        case 5: Console.WriteLine("Maio"); break;
        case 6: Console.WriteLine("Junho"); break;
        case 7: Console.WriteLine("Julho"); break;
        case 8: Console.WriteLine("Agosto"); break;
        case 9: Console.WriteLine("Setembro"); break;
        case 10: Console.WriteLine("Outubro"); break;
        case 11: Console.WriteLine("Novembro"); break;
        case 12: Console.WriteLine("Dezembro"); break;
        default:
            Console.WriteLine("Regra: dígite somente números de 1 a 12");
            Thread.Sleep(1000);
            break;
    }
}
catch (Exception)
{
    Console.WriteLine("Dígite apenas números");
}
