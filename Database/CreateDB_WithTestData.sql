-- 1. Datenbank erstellen
CREATE DATABASE PersonenVerwaltung
GO

USE PersonenVerwaltung
GO


-- 2. Tabellen mit Beziehungen erstellen
CREATE TABLE Person
(
	PersonId		INT IDENTITY(1,1)   NOT NULL,
	Name			NVARCHAR(100)  		NOT NULL,
	Vorname			NVARCHAR(100)  		NOT NULL,
	Geburtsdatum	DATE   		   		NOT NULL,
	
	CONSTRAINT PK_Person PRIMARY KEY (PersonId)
)
GO
 
CREATE TABLE Anschrift
(
	AnschriftId INT IDENTITY(1,1)	NOT NULL,
	PersonId	INT					NOT NULL,
	PLZ			NVARCHAR(10)		NOT NULL,
	Ort			NVARCHAR(100)		NOT NULL,
	Strasse		NVARCHAR(100)		NOT NULL,
	Hausnummer  NVARCHAR(10)		NOT NULL,
	
	CONSTRAINT PK_Anschrift PRIMARY KEY (AnschriftId),
	CONSTRAINT FK_Anschrift_Person FOREIGN KEY (PersonId)
	REFERENCES Person (PersonId)
)
GO
 
CREATE TABLE Telefonverbindung
(
	TelefonNummerRecordId   INT IDENTITY(1,1)   NOT NULL,
	PersonId				INT					NOT NULL,
	Nummer					NVARCHAR(30)		NOT NULL,

	CONSTRAINT PK_Telefonverbindung PRIMARY KEY (TelefonNummerRecordId),
	CONSTRAINT FK_Telefonverbindung_Person FOREIGN KEY (PersonId)
	REFERENCES Person (PersonId)
)
GO

-- 3. Hinzufügen von Testdaten
INSERT INTO Person (Name, Vorname, Geburtsdatum) 
VALUES  ('Mustermann', 'Vitali','1993-01-01'),
		('Schmidt','Julia', '1990-11-03'),
		('Weber',  'Anna',  '1988-07-22'),
		('Meyer',  'Thomas','2002-04-15'),
		('Meyer',  'Wibke', '2003-01-30')
GO
 
-- PersonId 1 = Mustermann, Vitali
INSERT INTO Anschrift (PersonId, PLZ, Ort, Strasse, Hausnummer) 
VALUES  (1, '01067', 'Dresden',   'Hauptstrasse',  '10'),
		(1, '52220', 'Stolberg',  'Dammstrasse',   '1')
GO
 
-- PersonId 2 = Schmidt, Julia
INSERT INTO Anschrift (PersonId, PLZ, Ort, Strasse, Hausnummer) 
VALUES  (2, '01069', 'Dresden',   'Bahnhofstrasse', '5')
GO
 
-- PersonId 3 = Weber, Anna
INSERT INTO Anschrift (PersonId, PLZ, Ort, Strasse, Hausnummer) 
VALUES  (3, '50667', 'Koeln', 'Domplatz',   '1')
GO
 
-- PersonId 4 = Meyer, Thomas
INSERT INTO Anschrift (PersonId, PLZ, Ort, Strasse, Hausnummer) 
VALUES  (4, '20095', 'Hamburg',   'Rathausmarkt',   '3')
GO

-- PersonId 5 = Meyer, Wibke
INSERT INTO Anschrift (PersonId, PLZ, Ort, Strasse, Hausnummer) 
VALUES  (5, '20095', 'Hamburg',   'Rathausmarkt',   '3')
GO
 
INSERT INTO Telefonverbindung (PersonId, Nummer) 
VALUES  (1, '+4917600000029'),
	    (1, '035112345656'),
	    (2, '035198765498'),
	    (3, '02214455665'),
	    (4, 'somewrongdata-4455'), 
	    (5, 'somewrongdata-4456')
GO