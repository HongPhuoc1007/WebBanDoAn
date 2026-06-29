use QuanLyBanHangOnline
-- Insert du lieu bang KhachHang
INSERT INTO KhachHang VALUES
('0900000001', 'Nguyen Van A', '123 Le Loi'),
('0900000002', 'Tran Thi B', '456 Tran Phu'),
('0900000003', 'Le Van C', '789 Nguyen Hue'),
('0900000004', 'Pham Thi D', '10 Hai Ba Trung'),
('0900000005', 'Hoang Van E', '11 Nguyen Trai'),
('0900000006', 'Nguyen Thi F', '12 Ly Tu Trong'),
('0900000007', 'Tran Van G', '13 Pasteur'),
('0900000008', 'Le Thi H', '14 Le Lai'),
('0900000009', 'Pham Van I', '15 Pham Ngu Lao'),
('0900000010', 'Hoang Thi K', '16 Cach Mang Thang 8');

-- Insert du lieu bang QuanLy
INSERT INTO QuanLy VALUES
('QL01', 'Nguyen Van Quan', '0900000011', 'quan1@email.com');

-- Insert du lieu bang NhanVien
INSERT INTO NhanVien VALUES
('NV01', 'Nguyen Van An', '0900000021', '1 Le Van Sy'),
('NV02', 'Tran Thi Ha', '0900000022', '2 Cach Mang Thang 8'),
('NV03', 'Le Trong Hieu', '0900000023', '3 Vo Thi Sau');

-- Insert du lieu bang TaiKhoan
INSERT INTO TaiKhoan VALUES
('user1', 'pass1', '0900000001', 'user1@gmail.com'),
('user2', 'pass2', '0900000002', 'user2@gmail.com'),
('user3', 'pass3', '0900000003', 'user3@gmail.com'),
('user4', 'pass4', '0900000004', 'user4@gmail.com'),
('user5', 'pass5', '0900000005', 'user5@gmail.com'),
('user6', 'pass6', '0900000006', 'user6@gmail.com'),
('user7', 'pass7', '0900000007', 'user7@gmail.com'),
('user8', 'pass8', '0900000008', 'user8@gmail.com'),
('user9', 'pass9', '0900000009', 'user9@gmail.com'),
('user10', 'pass10', '0900000010', 'user10@gmail.com');

-- Insert du lieu bang MonAn
INSERT INTO MonAn VALUES
('MA01', 'Ga nguyen con', 150000, 'garan.jpg'),
('MA02', 'Dui ga ran', 80000, 'duigarann.jpg'),
('MA03', 'Canh ga ran', 70000, 'canhga.jpg'),
('MA04', 'Khoai tay chien', 25000, 'khoaitaychien.jpg'),
('MA05', 'Khoai tay lac pho mai', 30000, 'khoaitaylac.jpg'),
('MA06', 'Nuoc cam ep', 30000, 'nuoccam.jpg'),
('MA07', 'Nuoc ep dua hau', 25000, 'nuocduahau.jpg'),
('MA08', 'Nuoc ep dua chuot', 20000, 'nuocduachuot.jpg');

--------------

INSERT INTO DanhMuc VALUES
('DM01', 'Ga'),
('DM02', 'Khoai tay'),
('DM03', 'Nuoc ep');

INSERT INTO DanhMuc_MonAn VALUES
('DM01', 'MA01', 'Vua', 10),
('DM01', 'MA02', 'Vua', 8),
('DM01', 'MA03', 'To', 6),
('DM01', 'MA04', 'Vua', 5),
('DM05', 'MA05', 'Nho', 15),
('DM02', 'MA06', 'Vua', 10),
('DM02', 'MA07', 'Vua', 12),
('DM06', 'MA08', 'To', 9),
('DM06', 'MA09', 'To', 7),
('DM08', 'MA10', 'Nho', 4);

INSERT INTO NguyenLieu VALUES
('BCG1', 'Bot chien gion', 50000, 10, 'Miwonfood'),
('BCX1', 'Bot chien xu', 40000, 10, 'Miwonfood'),
('GAX1', 'Ga', 6000, 300, 'OrryChicken'),
('KTB1', 'Khoai tay', 10000, 150, 'ThuHuyenFarm'),
('DCA1', 'Dua chuot', 6000, 100, 'ThuHuyenFarm'),
('DHMN1', 'Dua hau', 7000, 150, 'ThuHuyenFarm'),
('CS1', 'Cam sanh', 15000, 150, 'ThuHuyenFarm');

INSERT INTO HoaDon VALUES
('HD01', '2025-07-01', '0900000001', 'NV01'),
('HD02', '2025-07-02', '0900000002', 'NV02'),
('HD03', '2025-07-03', '0900000003', 'NV03'),
('HD04', '2025-07-04', '0900000004', 'NV04'),
('HD05', '2025-07-05', '0900000005', 'NV05'),
('HD06', '2025-07-06', '0900000006', 'NV06'),
('HD07', '2025-07-07', '0900000007', 'NV07'),
('HD08', '2025-07-08', '0900000008', 'NV08'),
('HD09', '2025-07-09', '0900000009', 'NV09'),
('HD10', '2025-07-10', '0900000010', 'NV10');

INSERT INTO ChiTietHoaDon VALUES
('HD01', 'MA01', 150000, 2, 300000),
('HD02', 'MA02', 20000, 1, 20000),
('HD03', 'MA03', 30000, 3, 90000),
('HD04', 'MA04', 20000, 1, 20000);

INSERT INTO PhieuNhap VALUES
('PN01', '2025-07-01', 'Nguyen Van Chung', 'NV01', 'ThuHuyenFarm', 'Nguyen Van An', ''),
('PN02', '2025-05-08', 'Nguyen Van Chung', 'NV02', 'ThuHuyenFarm', 'Tran Thi Ha', '');

INSERT INTO ChiTietPhieuNhap VALUES
('PN01', 'NL01', 'Thit Bo', 'Kg', 200000, 5, 1000000),
('PN02', 'NL02', 'Bun', 'Kg', 10000, 10, 100000),
('PN03', 'NL03', 'Com', 'Kg', 8000, 20, 160000),
('PN04', 'NL04', 'Thit Ga', 'Kg', 180000, 4, 720000),
('PN05', 'NL05', 'Banh Mi', 'O', 5000, 30, 150000),
('PN06', 'NL06', 'Banh Cuon', 'Kg', 15000, 6, 90000),
('PN07', 'NL07', 'Gao', 'Kg', 12000, 10, 120000),
('PN08', 'NL08', 'Mi', 'Kg', 11000, 8, 88000),
('PN09', 'NL09', 'Rau', 'Kg', 7000, 12, 84000),
('PN10', 'NL10', 'Gia Vi', 'Goi', 50000, 5, 250000);

INSERT INTO BaoCaoNgay VALUES
('BCN01', '2025-07-01', 'MA01', 'To', 10, 450000),
('BCN02', '2025-07-02', 'MA02', 'To', 5, 200000),
('BCN03', '2025-07-03', 'MA03', 'Dia', 7, 245000),
('BCN04', '2025-07-04', 'MA04', 'Phan', 3, 180000),
('BCN05', '2025-07-05', 'MA05', 'O', 10, 200000),
('BCN06', '2025-07-06', 'MA06', 'Phan', 4, 120000),
('BCN07', '2025-07-07', 'MA07', 'To', 6, 150000),
('BCN08', '2025-07-08', 'MA08', 'To', 8, 304000),
('BCN09', '2025-07-09', 'MA09', 'To', 5, 210000),
('BCN10', '2025-07-10', 'MA10', 'Noi', 2, 300000);

INSERT INTO BaoCaoThang VALUES
('BCT01', '2025-07-01', 'MA01', 'To', 100, 4500000),
('BCT02', '2025-07-01', 'MA02', 'To', 50, 2000000),
('BCT03', '2025-07-01', 'MA03', 'Dia', 70, 2450000),
('BCT04', '2025-07-01', 'MA04', 'Phan', 30, 1800000),
('BCT05', '2025-07-01', 'MA05', 'O', 100, 2000000),
('BCT06', '2025-07-01', 'MA06', 'Phan', 40, 1200000),
('BCT07', '2025-07-01', 'MA07', 'To', 60, 1500000),
('BCT08', '2025-07-01', 'MA08', 'To', 80, 3040000),
('BCT09', '2025-07-01', 'MA09', 'To', 50, 2100000),
('BCT10', '2025-07-01', 'MA10', 'Noi', 20, 3000000);

INSERT INTO KiemKe VALUES
('KK01', '2025-07-01', 'NL01', 'Kg', 200000, 30),
('KK02', '2025-07-02', 'NL02', 'Kg', 10000, 50),
('KK03', '2025-07-03', 'NL03', 'Kg', 8000, 60),
('KK04', '2025-07-04', 'NL04', 'Kg', 180000, 25),
('KK05', '2025-07-05', 'NL05', 'O', 5000, 70),
('KK06', '2025-07-06', 'NL06', 'Kg', 15000, 30),
('KK07', '2025-07-07', 'NL07', 'Kg', 12000, 40),
('KK08', '2025-07-08', 'NL08', 'Kg', 11000, 35),
('KK09', '2025-07-09', 'NL09', 'Kg', 7000, 55),
('KK10', '2025-07-10', 'NL10', 'Goi', 50000, 20);


select * from KiemKe