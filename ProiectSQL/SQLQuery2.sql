use DealershipProiect;

INSERT INTO Dealership.tMasini (IdMasina,Brand, Model, AnMasina, Pret, Kilometraj,Combustibil,StatusMasina)
VALUES
(1,'BMW', 'M3', 2018, 45000, 60000, 'Benzina',  'disponibila'),
(2,'Audi', 'A4', 2020, 30000, 20000, 'Motorina', 'disponibila'),
(3,'Mercedes', 'C200', 2019, 35000, 30000, 'Benzina', 'disponibila'),
(4,'Volkswagen', 'Golf 7', 2017, 15000, 95000, 'Motorina',  'disponibila'),
(5,'Dacia', 'Duster', 2021, 18000, 10000, 'Benzina', 'disponibila');
alter table Dealership.tClienti
add  DataNasterii varchar(50);

alter table Dealership.tClienti
add Tara varchar(50);


INSERT INTO Dealership.tClienti (IdClient,Nume, Prenume, CNP, DataNasterii, Telefon, Email, Adresa, Oras, Judet, Tara)
VALUES
(1,'Popescu', 'Andrei', '1234567890123', '1985-03-15', '0712345678', 'andrei.popescu@example.com', 'Str. Florilor 10', 'Bucuresti', 'Bucuresti', 'Romania'),
(2,'Ionescu', 'Maria', '2345678901234', '1990-07-20', '0723456789', 'maria.ionescu@example.com', 'Str. Lalelelor 5', 'Cluj-Napoca', 'Cluj', 'Romania'),
(3,'Georgescu', 'Alex', '3456789012345', '1988-11-05', '0734567890', 'alex.georgescu@example.com', 'Str. Trandafirilor 12', 'Iasi', 'Iasi', 'Romania');

alter table Dealership.tAngajati
add     Tara VARCHAR(50);


INSERT INTO Dealership.tAngajati 
(IdAngajat,Nume, Prenume, Functie, Salariu, CNP, Telefon, Email, Adresa, Oras, Judet, Tara)
VALUES(1,'Popescu', 'Andrei', 'Test Drive Specialist', 4500.00, '1234567890123',
 '0722334455', 'andrei.popescu@testdrive.com',
 'Str. Vitezei nr. 10', 'Bucuresti', 'Bucuresti', 'Romania'),
 (2,'Ionescu', 'Maria', 'Manager Vanzari', 7500.00, '2345678901234',
 '0721555333', 'maria.ionescu@dealership.com',
 'Bd. Libertatii nr. 22', 'Bucuresti', 'Bucuresti', 'Romania'),
 (3,'Georgescu', 'Cristian', 'Consilier Vanzari', 5000.00, '3456789012345',
 '0734001122', 'cristian.georgescu@dealership.com',
 'Str. Florilor nr. 7', 'Cluj-Napoca', 'Cluj', 'Romania'),
 (4,'Enache', 'Madalina', 'Contabil', 6000.00, '0123456789012',
 '0765443322', 'madalina.enache@dealership.com',
 'Str. Independentei nr. 12', 'Ploiesti', 'Prahova', 'Romania'),
 (5,'Petrescu', 'Bianca', 'Marketing Specialist', 4600.00, '8901234567890',
 '0726778899', 'bianca.petrescu@dealership.com',
 'Str. Avrig nr. 18', 'Sibiu', 'Sibiu', 'Romania');

 INSERT INTO Dealership.tVanzari (IdVanzare,IdMasina, IdClient, DataVanzare, PretVanzare)
VALUES
(1,1, 1, '2024-01-15', 44000),
(2,4, 2, '2024-02-10', 14500);

update Dealership.tMasini
set StatusMasina = 'Disponibila'
where IdMasina in (2,3,5);

select * from Dealership.tVanzari;

INSERT INTO Dealership.tFacturi (IdFactura,IdVanzare,DataEmitere, total, tva, ModPlata)
VALUES
(1,1, '2024-01-16', 44000, 8360, 'card'),
(2,2, '2024-02-11', 14500, 2755, 'numerar');

INSERT INTO Dealership.tTestDrive (IdTestDrive,IdClient,IdMasina,DataTestDrive,obersvatii)
VALUES
(1,2, 3, '2024-03-20 10:00:00', 'Client interesat de Mercedes C200'),
(2,3, 5, '2024-03-22 14:30:00', 'Client a cerut test off-road Duster');
