create database DealershipProiect;
use DealershipProiect

create schema Dealership;

create table Dealership.tMasini (
 IdMasina INT PRIMARY KEY,
 Brand VARCHAR(50),
 Model VARCHAR(50),
 AnMasina INT,
 Pret INT,
 Kilometraj INT,
 Combustibil CHAR(20),
 StatusMasina CHAR(20) DEFAULT 'Disponibil'
);

create table Dealership.tClienti (
    IdClient INT PRIMARY KEY,
	Nume VARCHAR(50),
	Prenume VARCHAR(50),
	CNP CHAR(13) UNIQUE,
	Telefon VARCHAR(20),
	Email VARCHAR(100),
);

create table Dealership.tAngajati (
    IdAngajat INT PRIMARY KEY,
	Nume VARCHAR(50),
	Prenume VARCHAR(50),
	Functie VARCHAR(50),
	Salariu int,
	CNP CHAR(13) UNIQUE,
	Telefon VARCHAR(20),
	Email VARCHAR(100),
);

create table Dealership.tVanzari (
 IdVanzare INT PRIMARY KEY,
 IdMasina int constraint FK_IdMasina foreign key references Dealership.tMasini(IdMasina),
 IdClient int constraint FK_IdClient foreign key references Dealership.tClienti(IdClient),
 DataVanzare date,
 PretVanzare int
);

create table Dealership.tTestDrive (
  IdTestDrive INT PRIMARY KEY,
  IdMasina int constraint FK_IdMasinaTest foreign key references Dealership.tMasini(IdMasina),
  IdClient int constraint FK_IdClientTest foreign key references Dealership.tClienti(IdClient),
  DataTestDrive datetime,
  obersvatii text
);

create table Dealership.tFacturi (
  IdFactura int primary key,
  IdVanzare int constraint FK_Vanzare foreign key references Dealership.tVanzari(IdVanzare),
  DataEmitere date,
  total int,
  tva int,
  ModPlata varchar(20)
);

