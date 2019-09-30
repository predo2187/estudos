create database dbLikeTeste;
use dbLikeTeste;

create table usuarios(
idUser int not null primary key auto_increment,
nomeUser varchar(500),
enderecoUser varchar(500)

);

insert into usuarios(nomeUser,enderecoUser) values("Juan Luiz Cauã Campos","Praça Wisterman Chaparro");
insert into usuarios(nomeUser,enderecoUser) values("Eloá Cecília Brenda Araújo","Travessa Capitalista");
insert into usuarios(nomeUser,enderecoUser) values("Eliane Sophia Lorena Vieira","Rua Nova Prata");
insert into usuarios(nomeUser,enderecoUser) values("Benjamin Renan Pinto","Travessa Delfim");
insert into usuarios(nomeUser,enderecoUser) values("Lorenzo Geraldo Igor das Neves","Quadra SQNW 105 Bloco K");

select * from usuarios where nomeUser like 'a%'; -- Valores que comaçam com a letra
select * from usuarios where nomeUser like '%a'; -- Valores que terminam com a letra
select * from usuarios where nomeUser like '%a%'; -- Valores que contém a letra