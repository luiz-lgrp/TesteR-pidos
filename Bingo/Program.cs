Inicio();


static void Inicio()
{
    Console.Clear();
    Console.WriteLine("Bem-vindo ao nosso Bingo!");
    Console.WriteLine("");
    Console.WriteLine("Digite 'X' para sortear um número:");
    string resposta = Console.ReadLine();

    switch (resposta)
    {
        case "x":
            Sortear(); 
            break;
            
        default:
            Console.WriteLine("Digite 'X' para sortear um número!");
            Thread.Sleep(1000);
            Inicio();
            break;
    }

}

static void Sortear()
{

    int quantidade = 79;
    Random rand = new Random();
    int sorteado = 0;

    List<int> Verificador = new List<int>();

    for (int i = 0; i <= quantidade; i++)
    {
        sorteado = rand.Next(0, quantidade + 1);

        while (Verificador.Contains(sorteado))
        {
            if (Verificador.Count >= quantidade)
                break;
            else
                sorteado = rand.Next(0, quantidade + 1);
        }

        Verificador.Add(sorteado);
        
    }

    Console.WriteLine($"Número: {sorteado}");
    Console.WriteLine("");
    Console.WriteLine("Tecle qualquer tecla para retornar");
    Console.ReadKey();
    Inicio();

}

