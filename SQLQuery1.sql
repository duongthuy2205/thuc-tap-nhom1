create database QL_NhanSu

use QL_NhanSu

create table Login
(
Usename nvarchar(20) Primary key ,
Password nvarchar(20)
)
go
CREATE TABLE NHANVIEN
(
   MaNV NCHAR(20) PRIMARY KEY NOT NULL,
   HoTenNV NVARCHAR(50),
   NgaySinh datetime,
   GioiTinh nvarchar(10),
   PhongBan NCHAR(20),
   ChucVu NVARCHAR(50),
   TDHV nvarchar(20),
   QueQuan nvarchar(50)

)
GO 

CREATE TABLE PhongBan
(
   STT int,
   MaPB NCHAR(20) PRIMARY KEY NOT NULL,
   TenPB NVARCHAR(50),
   SDT nvarchar(20),
   DiaChi nvarchar(50)

)
GO 
CREATE TABLE Luong
(
   STT int,
   BacLuong NCHAR(20) PRIMARY KEY NOT NULL,
   LuongCB DECIMAL(18,3),
   HSLuong FLOAT,
   HSPC FLOAT,
)
GO 
CREATE TABLE ChucVu
(
   STT int, 
   MaCV nvarchar(20) primary key, 
   TenCV nvarchar(20)
)
go
