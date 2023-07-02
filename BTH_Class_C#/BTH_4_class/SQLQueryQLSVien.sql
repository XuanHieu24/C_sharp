use QLSinhVien
go

create table SV (
	MaSV int not null primary key,
	Hoten nvarchar(20),
	Ngaysinh date,
	Gioitinh nvarchar (10),
	Quequan nvarchar (50),
	Lop nvarchar (30),
	Khoa nvarchar (10)
)

insert into SV values ( 1234, N'Ngô Xuân Hiếu', '2003/06/24', 'Nam' , N'Bắc Ninh', '63CNTT1', ' CNTT')
insert into SV values ( 1454, N'Bùi Văn Đạt', '2003/04/20', 'Nữ' , N'Hà Tĩnh', '63HTTT', ' CNTT')
insert into SV values ( 1654, N'Phan Phú Anh', '2003/01/23', 'Nam' , N'Hà Nội', '63KTPM', ' CNTT')
insert into SV values ( 1757, N'Lê Quang Anh', '2003/8/2', 'Nữ' , N'Hà Nội', '63TTNT', ' CNTT')

select * from SV