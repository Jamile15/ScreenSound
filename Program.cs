// chamo minha calse musica como se fosse um tipo pra por em uma variavel
// esse new musica quer dizer que estamos criando um objeto especifico de tipo Musica

Musica musica1 = new Musica();
musica1.nome = "Roxane";
musica1.artista = "The Police";

Console.WriteLine($"Nome da musica {musica1.nome}");
Console.WriteLine($"Nome do artista é {musica1.artista}");


Musica musica2 = new Musica();
musica2.nome = "Vertigo";
musica2.artista = "U2";

Console.WriteLine($"Nome da musica {musica2.nome}");
Console.WriteLine($"Nome do artista é {musica2.artista}");