Console.WriteLine("Aplicação de Armazenamento de bandas e suas informações");

Banda cbjr = new Banda("CBJR");


Album album = new Album("Acustico");

Musica musica1 = new Musica(cbjr, "Dias de luta, dias de glória")
{
    Duracao = 213,
    Disponivel = true,
};


Console.WriteLine();
Musica musica2 = new Musica(cbjr, "Zóio de lula")
{
    Duracao = 354,
    Disponivel = false,
};

album.AdicionarMusica(musica1);
album.AdicionarMusica(musica2);
cbjr.AdicionarAlbum(album);
Console.WriteLine();
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
album.ExibirMusicasDoAlbum();
cbjr.ExibirDiscografia();
