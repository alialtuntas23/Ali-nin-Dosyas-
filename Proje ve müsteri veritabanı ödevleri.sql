create database Ödev2
create table Musteri
(
MusteriID int primary key not null,
MusteriAdi varchar not null,
MusteriTel varchar not null,
);

create table Tedarikci
(
TedarikciID int primary key not null,
TedarikciAdi varchar(20) not null,
TedarikciTel varchar(20) not null,
TeadrikciMail varchar(20) not null
);

Create table Urun
(
UrunID int primary key not null,
UrunAdi varchar(20) not null,
UrunFiyat varchar(20) not null,
UrunMiktar varchar(20) not null,
TedarikciID int foreign key not null references Tedarikci (TedarikciID)
);

create table SatinAlma
(
SatisID int primary key not null,
OdemeDurumu varchar(20) not null,
SatýnAlmaTarihi varchar(20) not null,
UrunID int not null foreign key references Urun (UrunID),
Adet varchar(20) not null,
SatýsFiyati varchar(20) not null,
MusteriID int not null foreign key references Musteri (MusteriID)
);