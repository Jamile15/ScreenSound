// chamo minha calse musica como se fosse um tipo pra por em uma variavel
// esse new musica quer dizer que estamos criando um objeto especifico de tipo Musica

Musica musica1 = new Musica();
musica1.nome = "Roxane";
musica1.artista = "The Police";
musica1.duracao = 273;
musica1.Disponivel=(true);

Musica musica2 = new Musica();
musica2.nome = "Vertigo";
musica2.artista = "U2";
musica2.duracao = 367;
musica2.Disponivel=(false);


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();