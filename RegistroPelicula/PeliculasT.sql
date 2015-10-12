create database Peliculas

use Peliculas

create table PeliculasT (
  PeliculaId int identity(1,1), 
  Titulo varchar(100),
  Descripcion varchar(100),
  Ano int,
  Calificacion int,
  IMDB int,
  CategoriaId varchar(100),
  Genero varchar(50), 
  RutadeImagen varchar(100), 
  RutadePelicula varchar(100)
  );

  select * from PeliculasT

  drop table PeliculasT

