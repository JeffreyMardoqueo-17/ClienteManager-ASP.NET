--CREATE DATABASE Clientes
--USE Clientes

CREATE TABLE Usuarios(
	Id INT PRIMARY KEY IDENTITY(1,1),  
	Nombre Varchar(50),
	Apellido Varchar(50),
	Email Varchar(50),
	Pass Varchar(MAX),
	Telefono Varchar(12),
	FechaRegistro DATE DEFAULT GETDATE()  
);
