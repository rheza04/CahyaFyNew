USE master
GO
DROP DATABASE Aplikasi_kasir
GO
CREATE DATABASE APLIKASI_KASIR

USE AAPLIKASI_KASIR

Drop table Supplier

CREATE TABLE Penjualan(
	Id_Barang char(10) constraint pk_Barang primary key not null,
	Nama_barang varchar(30) not null,
	Harga numeric,
	Quantity numeric,
	Sub_total numeric
)

CREATE TABLE Supplier(
	Id_Supplier char(10) constraint pk_Supplier primary key not null,
	Nama varchar(30) not null,
)

Insert into Penjualan values ('D0005', 'Sampho', 3000000, 10, 30000000)

SELECT * FROM Penjualan