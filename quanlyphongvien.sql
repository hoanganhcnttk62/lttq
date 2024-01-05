create database quanlyphongvien
use quanlyphongvien

create table phongvien(
Maphongvien varchar(20) primary key ,
Hoten nvarchar(255),
Gioitinh nvarchar(255),
Sodienthoai nvarchar(255),
Ngayvaolam datetime 

);
create table phongvienthuongtru(
	Maphongvien varchar(20) primary key ,
	Phucap float,
	foreign key (Maphongvien) references phongvien(Maphongvien)
);
create table phongvientaitoasoan(
	Maphongvien varchar(20)  primary key ,
	Sogiolamthem int,
	foreign key (Maphongvien) references phongvien(Maphongvien)

);

insert into phongvien(Maphongvien, Hoten, Gioitinh,Sodienthoai,Ngayvaolam)
values ('pv1','nguyen van a','nam','09999999999','2021-02-03');
insert into phongvienthuongtru(Maphongvien, Phucap)
values ('pv1',20000);
insert into phongvien(Maphongvien, Hoten, Gioitinh,Sodienthoai,Ngayvaolam)
values ('pv2','nguyen van b','nu','09988888899','2020-05-03');
insert into phongvienthuongtru(Maphongvien, Phucap)
values ('pv2',2);



