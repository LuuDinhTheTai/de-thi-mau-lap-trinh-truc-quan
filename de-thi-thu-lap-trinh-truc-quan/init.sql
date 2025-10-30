CREATE
DATABASE QLKhachHang;

USE QLKhachHang;

CREATE TABLE KhachHang
(
    MaKhachHang INT PRIMARY KEY,
    HoTen       NVARCHAR(50),
    DiaChi      NVARCHAR(50),
    ThoiGianGui INT,
    SoTienGui   FLOAT,
    LaiSuatGui  FLOAT,
    SoTienLai   FLOAT,
    NgayGui     DATETIME
);

INSERT INTO KhachHang VALUES (1, 'Nguyen Van A', 'Ha Noi', 1, 1000000, 0.03, 123123, '2025-02-05');
INSERT INTO KhachHang VALUES (2, 'Nguyen Van B', 'Hai Phong', 3, 1500000, 0.03, 123234, '2026-02-06');
INSERT INTO KhachHang VALUES (3, 'Nguyen Thi C', 'Ho Chi Minh', 12, 3000000, 6, 456456, '2027-02-07');

SELECT * FROM KhachHang;