create database QLTinhCuocDT2
go

use QLTinhCuocDT2
go

create table KhachHang
(
	MaKH varchar(20) primary key,
	TenKH nvarchar(50),
	CMND varchar(10),
	Email varchar(20),
	NgheNghiep nvarchar(50),
	ChucVu nvarchar(50),
	DiaChi nvarchar(100),
	NgayDangKy datetime,
	Flag bit
) 
go

create table ThongTinSIM
(
	IDSIM varchar(20) primary key,
	SoDienThoai varchar(10) unique,
	NgayDangKy datetime,
	NgayHetHan datetime,
	Flag bit,
	MaKH varchar(20)
	
	foreign key (MaKH) references KhachHang(MaKH)
) 
go

create table HoaDonDangKy
(
	MaHDDK varchar(20) primary key,
	IDSIM varchar(20),
	ChiPhiDangKy decimal(19,3),
	NgayDangKy datetime,
	Flag bit,

	foreign key (IDSIM) references ThongTinSIM(IDSIM)
) 
go

create table HoaDonTinhCuoc
(
	MaHDTC int primary key,
	IDSIM varchar(20),
	TuNgay datetime,
	DenNgay datetime,
	PhiHangThang decimal(19,3),
	TongTien decimal(19,3),
	NgayXuat datetime,
	ThanhToan bit,
	Flag bit,
	
	foreign key (IDSIM) references ThongTinSIM(IDSIM)
) 
go


create table ChiTietSuDung
(
	ID int PRIMARY KEY,
	IDSIM varchar(20),
	
	TGBD datetime,
	TGKT datetime,
	SoPhutSD7h23h decimal(19,3),
	SoPhutSD23h7h decimal(19,3),
	
	
	foreign key (IDSIM) references ThongTinSIM(IDSIM)

) 
go

create table GiaCuoc
(
	MaGiaCuoc varchar(20) primary key,
	
	TGBD time,
	TGKT time,
	Giacuoc decimal(19, 3)

) 
go

-- Thêm dữ liệu khách hàng
insert into KhachHang values (N'KHACH001',N'Đào Chí Vũ','038472182','chivu@gmail.com',N'Giảng viên',N'Giảng viên',N'Số 2, Nguyễn Văn Cừ, Q5, HCM','2018-03-14',1)
go
insert into KhachHang values (N'KHACH002',N'Lệ Rơi','039746712','chivu@gmail.com',N'Đầu bếp',N'Bếp trưởng',N'Số 50, Phổ Quang, Q Phú Nhuận, HCM','2018-03-15',1)
go
insert into KhachHang values (N'KHACH003',N'Quân Kun','029476198','chivu@gmail.com',N'Công nhân xây dựng',N'Công nhân',N'Số 228/3, Nguyễn Văn Công, Q Gò Vấp, HCM','2018-03-11',1)
go
insert into KhachHang values (N'KHACH004',N'Hy Hữu','028302938','chivu@gmail.com',N'Phục vụ',N'Nhân viên',N'Số 14, Nguyễn Hữu Huân, Q1, HCM','2018-06-19',1)
go
insert into KhachHang values (N'KHACH005',N'Nguyễn Trương Việt Hòa','02424758','chivu@gmail.com',N'Bác sĩ',N'Phó khoa',N'Số 2, Âu Cơ, Q11, HCM','2018-02-15',1)
go
insert into KhachHang values (N'KHACH006',N'Dư Bính Khôn','025437287','chivu@gmail.com',N'Xe ôm công nghệ Grab',N'Nhân viên',N'Số 1, Lạc Long Quân, Q10, HCM','2018-07-15',1)
go

-- Thông tin sim
insert into ThongTinSIM values ('SIM01','012331566','2018-03-10','2019-03-10',1,'KHACH001')
go
insert into ThongTinSIM values ('SIM02','0949417778','2018-03-11','2019-03-11',1,'KHACH002')
go
insert into ThongTinSIM values ('SIM03','0908745567','2018-03-12','2019-03-12',1,'KHACH003')
go
insert into ThongTinSIM values ('SIM04','0234826731','2018-03-13','2019-03-13',1,'KHACH004')
go
insert into ThongTinSIM values ('SIM05','0123786232','2018-03-14','2019-03-14',1,'KHACH005')
go
insert into ThongTinSIM values ('SIM06','0121236887','2018-03-15','2019-03-15',1,'KHACH006')
go

-- Hóa đơn đăng ký
insert into HoaDonDangKy values ('HDDK01','SIM01',50000,'2019-09-10',1)
go
insert into HoaDonDangKy values ('HDDK02','SIM02',50000,'2019-03-13',1)
go
insert into HoaDonDangKy values ('HDDK03','SIM03',50000,'2019-08-16',1)
go
insert into HoaDonDangKy values ('HDDK04','SIM04',50000,'2019-03-12',1)
go
insert into HoaDonDangKy values ('HDDK05','SIM05',50000,'2019-05-22',1)
go
insert into HoaDonDangKy values ('HDDK06','SIM06',50000,'2019-03-10',1)
go

-- Hóa đơn tính cước
insert into HoaDonTinhCuoc values (1,'SIM01','2018-01-01','2019-03-31',52400,52400,'2018-01-10',1,1)
go
insert into HoaDonTinhCuoc values (2,'SIM01','2018-02-01','2019-04-30',52400,104800,'2018-02-10',1,1)
go
insert into HoaDonTinhCuoc values (3,'SIM02','2018-03-01','2019-02-28',51400,51400,'2018-03-10',1,1)
go
insert into HoaDonTinhCuoc values (4,'SIM02','2018-04-01','2019-05-31',51400,102800,'2018-04-10',1,1)
go
insert into HoaDonTinhCuoc values (5,'SIM03','2018-05-01','2019-06-30',52000,52000,'2018-05-10',1,1)
go

-- Chi tiết sử dụng
insert into ChiTietSuDung values (1,'SIM01','2018-03-10 10:34:09','2018-03-10 10:37:09',3,0)
go
insert into ChiTietSuDung values (2,'SIM01','2018-03-12 08:20:00','2018-03-12 08:25:00',5,0)
go
insert into ChiTietSuDung values (3,'SIM01','2018-03-29 22:35:03','2018-03-29 22:39:03',4,0)
go
insert into ChiTietSuDung values (4,'SIM01','2018-04-10 10:34:09','2018-04-10 10:37:09',3,0)
go
insert into ChiTietSuDung values (5,'SIM01','2018-04-12 08:20:00','2018-04-12 08:25:00',5,0)
go
insert into ChiTietSuDung values (6,'SIM01','2018-04-29 22:35:03','2018-04-29 22:39:03',4,0)
go
insert into ChiTietSuDung values (7,'SIM02','2018-04-12 11:09:27','2018-04-12 11:13:23',4,0)
go
insert into ChiTietSuDung values (8,'SIM02','2018-04-23 16:03:12','2018-04-23 16:04:21',1,0)
go
insert into ChiTietSuDung values (9,'SIM02','2018-04-30 17:43:32','2018-04-30 17:45:33',2,0)
go
insert into ChiTietSuDung values (10,'SIM02','2018-05-12 11:09:27','2018-05-12 11:13:23',4,0)
go
insert into ChiTietSuDung values (11,'SIM02','2018-05-23 16:03:12','2018-05-23 16:04:21',1,0)
go
insert into ChiTietSuDung values (12,'SIM02','2018-05-30 17:43:32','2018-05-30 17:45:33',2,0)
go
insert into ChiTietSuDung values (13,'SIM03','2018-05-18 16:26:32','2018-05-18 16:29:22',3,0)
go
insert into ChiTietSuDung values (14,'SIM03','2018-05-22 07:21:45','2018-05-22 07:25:33',4,0)
go

-- Giá cước
insert into GiaCuoc values ('GC01','07:00:00','22:59:00',200)
go
insert into GiaCuoc values ('GC02','23:00:00','06:59:00',150)
go
