create database quanlyrapphim
use quanlyrapphim

create table phim(
	Madon varchar(20) primary key,
	Tenphim nvarchar(255),
	Quocgia nvarchar(255),
	Theloai  nvarchar(255),
	Ngaycongchieu datetime,
	Dotuoiquidinh int

);

create table phimhaid(
 	Madon varchar(20) primary key,
	Phuthughedoi float,
	foreign key (Madon) references phim(Madon) 
);
create table phimbad(
	Madon varchar(20) primary key ,
	Phuthusuatchieudacbiet float,
	foreign key (Madon) references phim(Madon)
);

insert into phim (Madon, Tenphim, Quocgia, Theloai, Ngaycongchieu,Dotuoiquidinh) 
values ('p1','noinay','việt nam','tình cảm','2022-01-01',18);
insert into phimhaid(Madon,Phuthughedoi)
values ('p1',20000);
insert into phim (Madon, Tenphim, Quocgia, Theloai, Ngaycongchieu,Dotuoiquidinh) 
values ('p2','tết đến rồi',' hàn','hành động','2021-01-01',19);
insert into phimbad(Madon,Phuthusuatchieudacbiet)
values ('p2',40000);


