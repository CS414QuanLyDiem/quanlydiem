create database QL_Diem

use QL_Diem
GO

CREATE TABLE [dbo].[PHANQUYEN] (MaPhanQuyen INT PRIMARY KEY NOT NULL,TenPhanQuen NVARCHAR (MAX) NULL)

CREATE TABLE [dbo].[TAIKHOAN] (MaTK INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,TaiKhoan NCHAR(30) NULL,MatKhau NCHAR (30) NULL,MaPhanQuyen INT REFERENCES PHANQUYEN NOT NULL)

CREATE TABLE [dbo].[GIAOVIEN] (MaGV NCHAR(20) PRIMARY KEY NOT NULL, TenGV NVARCHAR (MAX) NULL, MaTK INT REFERENCES TAIKHOAN NOT NULL,HinhAnh NVARCHAR(MAX))

CREATE TABLE [dbo].[KHOILOP] (MaKhoi NCHAR(20) PRIMARY KEY NOT NULL, TenKhoi NVARCHAR (100) NULL)

CREATE TABLE [dbo].[LOP] (MaLop INT PRIMARY KEY NOT NULL,TenLop NVARCHAR(MAX) NULL,MaGV NCHAR(20) REFERENCES GIAOVIEN NOT NULL,MaKhoi NCHAR(20) REFERENCES KHOILOP NOT NULL)

CREATE TABLE [dbo].[HOCSINH] (MaHS NCHAR(20) PRIMARY KEY NOT NULL, TenHS NVARCHAR(MAX) NULL, MaLop INT REFERENCES LOP NOT NULL,NgaySinh DATETIME NULL,GioiTinh NVARCHAR (20) NULL,DiaChi NVARCHAR (MAX) NULL,HinhAnh NVARCHAR(MAX))

CREATE TABLE [dbo].[MONHOC] (MaMH INT PRIMARY KEY NOT NULL,TenMH NVARCHAR (MAX) NULL)

CREATE TABLE [dbo].[BANGDIEM] (MaBD INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,MaHS NCHAR(20) REFERENCES HOCSINH NOT NULL,MaMH INT REFERENCES MONHOC NOT NULL, DiemMieng NUMERIC(18) NULL, Diem15Phut NUMERIC(18) NULL,Diem1Tiet NUMERIC(18) NULL,DiemHK NUMERIC(18) NULL)

INSERT PHANQUYEN VALUES(1,'Admin')
INSERT PHANQUYEN VALUES(2,'Giao Vien')

INSERT TAIKHOAN VALUES('admin','admin',1)
insert TAIKHOAN values ('khang','123456',2)
insert into TAIKHOAN values ('vovanan','123456',2)