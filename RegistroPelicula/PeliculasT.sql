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

  drop table GeneroT

  create table Generos (
  GeneroId int identity(1,1), 
  Descripcion varchar(100)
  );

  select * from Generos

  Insert Into Generos (Descripcion) Values ('Aventura')


  Insert Into Generos (Descripcion) Values ('Terror')
