// criando classe com propriedades tipadas para usar em outros arquivos adiciono o puplic antes da propriedade pra diser que essa propriedade é pplica

class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida => $"A musica {Nome} pertence ao {Artista}";
 

    // criando  um comportamento pra class musica que vai exibir uma fixa tecninca
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duracao: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        }
        else
        {
            System.Console.WriteLine("Adquira o pano Plus+");
        }
    }
}