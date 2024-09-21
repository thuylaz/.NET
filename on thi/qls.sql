create database qlbh
go 
use qlbh
go

create table nxb(
	manxb nchar(10) not null primary key,
	tennxb nchar(50)
)

create table sach(
	masach nchar(10) not null primary key,
	tensach nchar(50),
	manxb nchar(10),
	sotrang int,
	constraint fk_s_nxbb foreign key(manxb)
	references nxb(manxb)
)

insert into nxb values
('A01','tuoi tre'),
('A02','giao duc')

insert into sach values
('01','kinh te hoc', 'A01',88),
('02','triet hoc', 'A01',77),
('03','toan cao cap', 'A02',59),
('04','tin hoc', 'A02',92)

