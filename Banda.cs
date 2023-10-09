class Banda
{
    private List<Albuns> _albuns = new List<Albuns>();
 public string Nome { get; set; }

 public void AdicionarAlbun(Albuns albun)  
 {
    _albuns.Add(albun);
 }

 public void ExibirDiscografia()
 {
    Console.WriteLine($"Discografia da banda {Nome}");
    foreach(Albuns albuns in _albuns)
    {
        Console.WriteLine($"Álbum: {albuns.Nome} ({albuns.DuracaoTotal})");
    }
 }
}