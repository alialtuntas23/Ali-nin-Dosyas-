create table Calisan
(
CalisanID int primary key,
CalisanAdi varchar(20) not null,
CalisanPozisyon varchar(20) not null,
CalisanTel varchar(20) not null,
CalisanMail varchar(20) not null
);

create table Sirket 
(
SirketID int primary key ,
SirketAdi varchar(20) not null,
SirketTel varchar(20) not null,
SirketMail varchar(20) not null
);
create table Proje
(
ProjeID int primary key,
ProjeAdi varchar(20) not null,
ProjeBaslamaTarihi varchar(20) not null,
ProjeBitisTarihi varchar(20) not null,
ProjeButce varchar(20) not null, 
CalisanID int foreign key references Calisan (CalisanID),
SirketID int foreign key references Sirket (SirketID)
);