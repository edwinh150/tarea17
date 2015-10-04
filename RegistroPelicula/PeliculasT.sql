create database Peliculas

use Peliculas

create table PeliculasT (
  PeliculaId int identity(1,1), 
  Titulo varchar(100),
  Descripcion varchar(100),
  Ano int,
  Calificacion int,
  IMDB int,
  CategoriaId int
  );

  select * from PeliculasT