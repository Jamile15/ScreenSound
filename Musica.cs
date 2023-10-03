// criando classe com propriedades tipadas para usar em outros arquivos adiciono o puplic antes da propriedade pra diser que essa propriedade é pplica

class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool Disponivel { get; set;}


// criando  um comportamento pra class musica que vai exibir uma fixa tecninca
    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duracao: {duracao}");
        if(Disponivel)
        {
            Console.WriteLine("Disponivel no plano");
        } else
        {
            System.Console.WriteLine("Adquira o pano Plus+");
        }
        }
}