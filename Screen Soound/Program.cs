﻿Banda CamilaC = new Banda();
CamilaC.Nome = "Camila Cabello";

Album albumCamilaCabello = new Album();
albumCamilaCabello.Nome = "Romance";

Musica musica1 = new Musica(CamilaC);
musica1.Nome = "Bad Kind Of The Butterflies";
musica1.Duracao = 250;

/*Genero genero1 = new Genero();
genero1.Nome = "Pop";

musica1.AdicionarGenero(genero1);
genero1.ExibirGenero(genero1);*/

Musica musica2 = new Musica(CamilaC);
musica2.Nome = "Cry In The Club";
musica2.Duracao = 337;

/*Genero genero2 = new Genero();
genero2.Nome = "Balada";

musica2.AdicionarGenero(genero1);
musica2.AdicionarGenero(genero2);*/


albumCamilaCabello.AdicionarMusica(musica1);
albumCamilaCabello.AdicionarMusica(musica2);


CamilaC.AdicionarAlbum(albumCamilaCabello);
CamilaC.ExibirDiscografia();
albumCamilaCabello.ExibirMusicasDoAlbum();