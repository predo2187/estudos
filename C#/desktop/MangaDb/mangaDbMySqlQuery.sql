create database dbMangas;
use dbMangas;

create table tblMangas(
id int auto_increment not null,

nomeManga1 varchar(5000) not null,
nomeManga2 varchar(5000) not null,

completo char(1),
dropado char(1),
iato char(1),
cancelado char(1),


preco double(4,2),
volumes int,

idAutor int,
idMangaka int,
idGenero1 int,
idGenero2 int,
idEditora int,




imagem varchar(2500)
);

create table tblAutor(
id int not null primary key auto_increment,
nome varchar(120)not null
);

create table tblMangaka(
id int not null primary key auto_increment,
nome varchar(120)not null
);

create table tblGenero(
id int not null primary key auto_increment,
nome varchar(120)not null
);

create table tblEditora(
id int not null primary key auto_increment,
nome varchar(120)not null
);




