List<listaBrasil> LugarPreco;
LugarPreco = new List<listaBrasil>();

List<listaMundo> LugarPreco2;
LugarPreco2 = new List<listaMundo>();

//Lista do Brasil
LugarPreco.Add(new listaBrasil("Fernando de Noronha",10000));
LugarPreco.Add(new listaBrasil("Rio de Janeiro (capital)", 2500));
LugarPreco.Add(new listaBrasil("Bonito", 3500));
LugarPreco.Add(new listaBrasil("Chapada Diamantina", 8000));
LugarPreco.Add(new listaBrasil("Serras Gaúchas", 5500));
LugarPreco.Add(new listaBrasil("Salvador", 4000));
LugarPreco.Add(new listaBrasil("Natal", 3500));
LugarPreco.Add(new listaBrasil("Amazônia", 8500));
LugarPreco.Add(new listaBrasil("Búzios (RJ)", 2800));
LugarPreco.Add(new listaBrasil("Brasília", 4200));

//Lista do Mundo
LugarPreco2.Add(new listaMundo("Buenos Aires", 3000));
LugarPreco2.Add(new listaMundo("Nova York", 15000));
LugarPreco2.Add(new listaMundo("Paris", 8500));
LugarPreco2.Add(new listaMundo("Tokio", 12000));
LugarPreco2.Add(new listaMundo("Cairo", 7000));
LugarPreco2.Add(new listaMundo("Casablanca", 6800));
LugarPreco2.Add(new listaMundo("Nova Deli", 8500));
LugarPreco2.Add(new listaMundo("Ilha da Páscoa", 11000));
LugarPreco2.Add(new listaMundo("Havaí", 8300));
LugarPreco2.Add(new listaMundo("Qebec", 7000));

Console.WriteLine("--------------------------------");
OrdenarMaisCaro();
Console.WriteLine("");
Console.WriteLine("--------------------------------");
OrdenarMaisBarato();
Console.WriteLine("");
Console.WriteLine("--------------------------------");


void OrdenarMaisCaro()
{
  Console.WriteLine("\n5 Lugares mais caros do Brasil");
  Console.WriteLine("");

  LugarPreco.Sort(delegate (listaBrasil x1, listaBrasil x2)
  {
    return x2.Preco.CompareTo(x1.Preco);
  });

  LugarPreco.RemoveRange(5, 5);

  LugarPreco.ForEach(delegate (listaBrasil x)
  {
    Console.WriteLine(String.Format("{0} {1}", x.Preco, x.Lugar));
  });
}



void OrdenarMaisBarato()
{
   Console.WriteLine("\n5 Lugares mais baratos do Mundo");
   Console.WriteLine("");

  LugarPreco2.Sort(delegate (listaMundo x1, listaMundo x2)
  {
      return x1.Preco.CompareTo(x2.Preco);

  });

  LugarPreco2.RemoveRange(5, 5);

  LugarPreco2.ForEach(delegate (listaMundo x)
  {
      
      Console.WriteLine(String.Format("{0} {1}", x.Preco, x.Lugar));
  });
}

public class listaBrasil
{
    //public listaBrasil() { }

    public string Lugar { get; set; }
    public int Preco { get; set; }

    public listaBrasil(string lugar, int preco)
    {
        this.Preco = preco;
        this.Lugar = lugar;
    }
}

public class listaMundo
{
    //public listaMundo() { }

    public string Lugar { get; set; }
    public int Preco { get; set; }

    public listaMundo(string lugar, int preco)
    {
        this.Preco = preco;
        this.Lugar = lugar;
    }
}
