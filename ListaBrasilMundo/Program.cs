var listBrazil = new List<Brazil>()
{
    new Brazil {Place = "Fernando de Noronha" , Price = 10000},
    new Brazil {Place = "Rio de Janeiro (capital)" , Price = 2500},
    new Brazil {Place = "Bonito" , Price = 3500},
    new Brazil {Place = "Chapada Diamantina" , Price = 8000},
    new Brazil {Place = "Serras Gaúchas" , Price = 5500},
    new Brazil {Place = "Salvador" , Price = 4000},
    new Brazil {Place = "Natal" , Price = 3500},
    new Brazil {Place = "Amazônia" , Price = 8500},
    new Brazil {Place = "Búzios (RJ)" , Price = 2800},
    new Brazil {Place = "Brasília" , Price = 4200}
};

var listWorld = new List<World>()
{
    new World {Place = "Buenos Aires" , Price = 3000},
    new World {Place = "Nova York" , Price = 15000},
    new World {Place = "Paris" , Price = 8500},
    new World {Place = "Tokio" , Price = 12000},
    new World {Place = "Cairo" , Price = 7000},
    new World {Place = "Casablanca" , Price = 6800},
    new World {Place = "Nova Deli" , Price = 8500},
    new World {Place = "Ilha da Páscoa" , Price = 11000},
    new World {Place = "Havaí" , Price = 8300},
    new World {Place = "Qebec" , Price = 7000}
};


Console.WriteLine("\n5 LUGARES MAIS CAROS DO BRASIL");
Console.WriteLine("");

var listB = listBrazil.OrderByDescending(x => x.Price).Take(5);


foreach (var result in listB)
{
    Console.WriteLine($"Preço: {result.Price} - Lugar: {result.Place}");
}



Console.WriteLine("");
Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
Console.WriteLine("");


Console.WriteLine("5 LUGARES MAIS BARATOS DO MUNDO");
Console.WriteLine("");

var listW = listWorld.OrderBy(x => x.Price).Take(5);


foreach (var result in listW)
{
    Console.WriteLine($"Preço: {result.Price} - Lugar: {result.Place}");
}

Console.ReadKey();





class Brazil
{
    public string Place { get; set; }
    public int Price { get; set; }
}

class World
{
    public string Place { get; set; }
    public int Price { get; set; }
}

