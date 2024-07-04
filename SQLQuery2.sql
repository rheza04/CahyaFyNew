USE master
GO
DROP DATABASE Aplikasi_kasir
GO
CREATE DATABASE APLIKASI_KASIR

USE Aplikasi_kasir

CREATE TABLE Penjualan(
	Id_barang char(10) constraint pk_dokter primary key not null,
	Nama_barang varchar(30) not null,
	Harga numeric,
	Quantity numeric,
	Sub_total numeric
)