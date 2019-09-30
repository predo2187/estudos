create database dbMangas;
use dbMangas;

select sum(volumes) as total from manga;
SELECT nomeManga, SUM(preco * volumes) AS total FROM manga group by nomeManga;
create table manga(
idManga int primary key auto_increment,
nomeManga varchar(500),
volumes int(20),
preco double (5,2),
paginas int(20),
Mangaka varchar(500),
Genero1 varchar(500),
Genero2 varchar(500)

);
alter table manga add column nome2 varchar (5000);
alter table manga add column sobre varchar (730);
alter table manga add column editora varchar (500);
alter table manga add column estatus varchar (500);
alter table manga add column idUsuario int (3);
alter table manga add column imagem varchar (6000);
select idManga as Id, nomeManga as Nome, volumes as Volumes, preco as Preco from manga where idUsuario = 4 order by idManga;
select idManga as Id, nomeManga as Nome, volumes as Volumes from manga;
select * from manga;
select Mangaka from tblMangaka;
select * from tblMangaka where Mangaka = 'Boichi';
update manga set idUsuario = 1 where idManga = 1;
update manga set estatus = 'não' where idManga = 26;
update tblUsuario set idUsuario = 1 where Usuario = 'Predo';
select sum(estatus = 'não') as total from manga;
create table tblMangaka(
idMangaka int(20) auto_increment primary key,
Mangaka varchar(500)

);
create table tblGenero(
idGenero int(20) auto_increment primary key,
Genero varchar(500)

);
delete from manga where idManga = 33;
create table tblEditora(
idEditora int(20) auto_increment primary key,
Editora varchar(500)
);

select * from manga;
create table tblObra(
nomeObra varchar(2000),
idObra int(20)

);

create table tblUsuario(
idUsuario int (3) primary key auto_increment,
Usuario varchar (700)
);
select sum(volumes * 0 + 1)as total from manga;

select * from tblUsuario;
alter table tblUsuario add column senha varchar (5000);
select * from tblUsuario;
drop table tblUsuario;
select * from manga;

update tblUsuario set idUsuario = 1 where Usuario = 'Predo';
delete from tblusuario where idUsuario = 5;


