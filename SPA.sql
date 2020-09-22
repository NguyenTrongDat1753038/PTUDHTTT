USE MASTER;
GO
--ALTER DATABASE SPA SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
DROP DATABASE IF EXISTS SPA;
go
CREATE DATABASE SPA;
GO
USE SPA;
GO
CREATE TABLE USERS
(
	ID int identity (1000000,1),
	USERNAME varchar(16) not null,
	PASSWORDS varchar(16) not null,
	TinhTrang bit default 1,
	VaiTro int default 0,
	primary key(ID)
)
CREATE TABLE TTCANHAN
(
	ID_USER INT,
	HOTEN NVARCHAR(50),
	NGHENGHIEP NVARCHAR(20),
	NGAYSINH DATE,
	GIOITINH BIT,
	THOIQUEN NVARCHAR(100),
	CHIEUCAO FLOAT,
	TRONGLUONG FLOAT,
	MO FLOAT,
	MOBUNG FLOAT,
	BMI INT,
	PRIMARY KEY(ID_USER)
)
CREATE TABLE CHINHANH
(
	ID_CHINHANH INT IDENTITY(3000000,1),
	ID_USER INT,
	TEN NVARCHAR(50),
	DIACHI NVARCHAR(50),
	TINHTRANG BIT,
	PRIMARY KEY(ID_CHINHANH)
)
CREATE TABLE PHONG
(
	ID_PHONG INT IDENTITY(4000000,1),
	ID_CHINHANH INT,
	LOAI INT,
	MOTA NVARCHAR(200),
	PRIMARY KEY(ID_PHONG)
)
CREATE TABLE GIUONG
(
	ID_GIUONG INT IDENTITY(5000000,1),
	ID_PHONG INT,
	MOTA NVARCHAR(100),
	PRIMARY KEY(ID_GIUONG)
)
CREATE TABLE CHITIET_GIUONG
(
	ID_GIUONG INT,
	ID_DICHVU INT,
	TNHTRANG INT,
	PRIMARY KEY(ID_GIUONG,ID_DICHVU)
)
CREATE TABLE DICHVU
(
	ID_DICHVU int identity (2000000,1),
	Ten nvarchar(50),
	Mota nvarchar(100),
	Gia money,
	Thoigiancho int,
	ThoiLuong int,
	TinhTrang bit default 0,
	Primary key(ID_DICHVU)
)
CREATE TABLE DATTRUOC
(
	ID_DATTRUOC INT IDENTITY (1000,1),
	ID_KH INT,
	NGAYTAO DATE,
	PRIMARY KEY(ID_DATTRUOC)
)
CREATE TABLE CHITIET_DATTRUOC
(
	ID_DATTRUOC INT,
	ID_DICHVU INT,
	PRIMARY KEY(ID_DATTRUOC,ID_DICHVU)
)
CREATE TABLE GIOHANG
(
	ID_GIOHANG INT IDENTITY (2000,1),
	ID_KH INT,
	NGAYTAO DATE,
	PRIMARY KEY(ID_GIOHANG)
)
CREATE TABLE CHITIET_GIOHANG
(
	ID_GIOHANG INT,
	ID_DICHVU INT,
	PRIMARY KEY(ID_GIOHANG,ID_DICHVU)
)
CREATE TABLE LICHHEN
(
	ID_LH INT IDENTITY(6000000,1),
	ID_KH INT NOT NULL,
	ID_CHINHANH INT NOT NULL,
	GIOHEN TIME,
	NGAYHEN DATE,
	TINHTRANG INT,
	BINHLUAN NVARCHAR(200),
	DANHGIA INT,
	PRIMARY KEY(ID_LH)
)
CREATE TABLE CHITIET_LICHHEN
(
	ID_LH INT,
	ID_HLV INT,
	ID_DICHVU INT,
	ID_GIUONG INT,
	TRANGTHAI INT,
	GHICHU NVARCHAR(50),
	PRIMARY KEY(ID_LH,ID_DICHVU)
)
GO
ALTER TABLE TTCANHAN
ADD FOREIGN KEY (ID_USER) REFERENCES USERS(ID);
ALTER TABLE CHINHANH
ADD FOREIGN KEY (ID_USER) REFERENCES USERS(ID);
ALTER TABLE PHONG
ADD FOREIGN KEY (ID_CHINHANH) REFERENCES CHINHANH(ID_CHINHANH);
ALTER TABLE GIUONG
ADD FOREIGN KEY (ID_PHONG) REFERENCES PHONG(ID_PHONG);
ALTER TABLE CHITIET_GIUONG
ADD FOREIGN KEY (ID_GIUONG) REFERENCES GIUONG(ID_GIUONG);
ALTER TABLE CHITIET_GIUONG
ADD FOREIGN KEY (ID_DICHVU) REFERENCES DICHVU(ID_DICHVU);
ALTER TABLE DATTRUOC
ADD FOREIGN KEY (ID_KH) REFERENCES USERS(ID);
ALTER TABLE CHITIET_DATTRUOC
ADD FOREIGN KEY (ID_DATTRUOC) REFERENCES DATTRUOC(ID_DATTRUOC);
ALTER TABLE CHITIET_DATTRUOC
ADD FOREIGN KEY (ID_DICHVU) REFERENCES DICHVU(ID_DICHVU);
ALTER TABLE GIOHANG
ADD FOREIGN KEY (ID_KH) REFERENCES USERS(ID);
ALTER TABLE CHITIET_GIOHANG
ADD FOREIGN KEY (ID_GIOHANG) REFERENCES GIOHANG(ID_GIOHANG);
ALTER TABLE CHITIET_GIOHANG
ADD FOREIGN KEY (ID_DICHVU) REFERENCES DICHVU(ID_DICHVU);
ALTER TABLE LICHHEN
ADD FOREIGN KEY (ID_KH) REFERENCES USERS(ID);
ALTER TABLE LICHHEN
ADD FOREIGN KEY (ID_CHINHANH) REFERENCES CHINHANH(ID_CHINHANH);
ALTER TABLE CHITIET_LICHHEN
ADD FOREIGN KEY (ID_LH) REFERENCES LICHHEN(ID_LH);
ALTER TABLE CHITIET_LICHHEN
ADD FOREIGN KEY (ID_HLV) REFERENCES USERS(ID);
ALTER TABLE CHITIET_LICHHEN
ADD FOREIGN KEY (ID_DICHVU) REFERENCES DICHVU(ID_DICHVU);
ALTER TABLE CHITIET_LICHHEN
ADD FOREIGN KEY (ID_GIUONG) REFERENCES GIUONG(ID_GIUONG);




GO
INSERT INTO DICHVU(TEN) VALUES('A');
INSERT INTO DICHVU(TEN) VALUES('AA');
INSERT INTO DICHVU(TEN) VALUES('AB');
INSERT INTO DICHVU(TEN) VALUES('B');
INSERT INTO DICHVU(TEN) VALUES('C');
INSERT INTO DICHVU(TEN) VALUES('D');
INSERT INTO DICHVU(TEN) VALUES('E');
INSERT INTO DICHVU(TEN) VALUES('F');

GO
--INSERT INTO USERS(USERNAME,PASSWORDS) VALUES('A',HASHBYTES('MD5',CONVERT(CHAR(50),123)));
INSERT INTO USERS(USERNAME,PASSWORDS) VALUES('A','123');