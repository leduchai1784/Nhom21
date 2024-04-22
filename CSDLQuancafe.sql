﻿--DROP DATABASE QLYQUANCAFE
CREATE DATABASE QLYQUANCAFE
GO
USE QLYQUANCAFE
GO
CREATE TABLE TaiKhoan (
    TEN_TAIKHOAN VARCHAR(10),
    MATKHAU VARCHAR(15),
    CHOPHEP_LOGIN BIT DEFAULT 1,
    TRANGTHAITK BIT DEFAULT 1,
    CONSTRAINT pk_TAIKHOAN PRIMARY KEY(TEN_TAIKHOAN)
);
CREATE TABLE NhanVien (
    MANV VARCHAR(10) UNIQUE,
    TEN_TAIKHOAN VARCHAR(10)REFERENCES TaiKhoan(TEN_TAIKHOAN),
    TENNV NVARCHAR(40),
    CMND_CCCD VARCHAR(12),
    NGAYSINH DATETIME,
    GIOITINH NVARCHAR(3),
    SDT VARCHAR(12),
    DIACHI NVARCHAR(MAX),
    CHUCVU NVARCHAR(20),
    HINHANH IMAGE,
    NGAYVAOLAM DATETIME DEFAULT GETDATE(),
    TRANGTHAINV BIT DEFAULT 1,
    CONSTRAINT pk_NHANVIEN PRIMARY KEY(MANV)
);
CREATE TABLE LOAI
(
	MALOAI VARCHAR(10) PRIMARY KEY,
	TENLOAI NVARCHAR (50)
);
CREATE TABLE TOPPING
(
	MATOPPING VARCHAR (10) PRIMARY KEY,
	TENTOPPING NVARCHAR (50)
);

--DROP TABLE SANPHAM
CREATE TABLE SANPHAM
(
	MASP VARCHAR(10) PRIMARY KEY,
	TENSP NVARCHAR (50),
	GIA INT,
	HINHSP IMAGE,
	SOLUONG INT,
	MALOAI VARCHAR (10) REFERENCES LOAI(MALOAI),
	MATOPPING VARCHAR (10) REFERENCES TOPPING(MATOPPING)
);

	-- Thêm d? li?u cho b?ng TaiKhoan
INSERT INTO TaiKhoan (TEN_TAIKHOAN, MATKHAU, CHOPHEP_LOGIN, TRANGTHAITK) VALUES
('AD001', '8888', 1, 1),
('nv001', '123456', 0, 1),
('nv002', 'abcdef', 1, 1),
('nv003', 'qwerty', 1, 1),
('nv004', 'password', 1, 1);

INSERT INTO NhanVien (MANV, TEN_TAIKHOAN, TENNV, CMND_CCCD, NGAYSINH, GIOITINH, SDT, DIACHI, CHUCVU, HINHANH, NGAYVAOLAM, TRANGTHAINV) VALUES
('AD001', 'AD001', N'Nguy?n TNN', '40028061', '1999-08-16', N'N?', '0987654321', N'Th? D?u M?t', N'Qu?n l?', NULL, GETDATE(), 1),
('NV001', 'nv001', N'Nguy?n Văn A', '123456789', '1990-01-01', N'Nam', '0987654321', N'Th? D?u M?t ', N'Nhân viên', NULL, GETDATE(), 1),
('NV002', 'nv002', N'Tr?n Th? B', '987654321', '1995-05-05', N'N?', '0123456789', N'H? Chí Minh', N'Nhân viên', NULL, GETDATE(), 1),
('NV003', 'nv003', N'Lê Văn C', '456789123', '1988-12-12', N'Nam', '0369874123', N'Th? D?u M?t', N'K? toán', NULL, GETDATE(), 1),
('NV004', 'nv004', N'Ph?m Th? D', '654123789', '1993-07-07', N'N?', '0321876543', N'Th? D?u M?t', N'Nhân viên', NULL, GETDATE(), 1);


-- Dữ liệu cho bảng LOAI
INSERT INTO LOAI (MALOAI, TENLOAI)
VALUES
('L001', N'Đồ uống'),
('L002', N'Đồ ăn');

-- Dữ liệu cho bảng TOPPING
INSERT INTO TOPPING (MATOPPING, TENTOPPING)
VALUES
('T001', N'Chocolate'),
('T002', N'Caramel'),
('T003', N'Whipped cream');

-- Dữ liệu cho bảng SANPHAM
INSERT INTO SANPHAM (MASP, TENSP, GIA, HINHSP, SOLUONG, MALOAI, MATOPPING)
VALUES
('SP001', N'Cà phê đen', 25000, NULL, 50, 'L001', NULL),
('SP002', N'Latte', 35000, NULL, 40, 'L001', 'T002'),
('SP003', N'Bánh mì thịt', 30000, NULL, 30, 'L002', NULL),
('SP004', N'Bánh mì trứng', 25000, NULL, 35, 'L002', NULL);
