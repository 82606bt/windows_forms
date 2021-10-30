--use master
create database QLT
go

use QLT
go

create table Account
(
	UserName Nvarchar(100) primary key,
	Password Nvarchar(100) not null,
	Name NVarchar(100) not null,
	Type int not null default 0 
)
go

create table ThemVe
(
	IDVE int identity not null primary key,
	MaTau Nvarchar(20) not null ,
	Gadi Nvarchar(100) not null,
	Gaden nvarchar(100) not null,
	Loaive nvarchar(20) not null,
	Tang int null,
	Ngaydi  date Not Null ,
	Giodi nvarchar(20) not null,
	Ngayve date null,
	Giove nvarchar(20)  null,
	Toa int not null,
	Loaicho nvarchar (50) not null,
	Ghe_Giuong int not null,
	Giave int not null,
	Status nvarchar(50) null 
	 
)
go
create table Hoadon(
	IDHD int identity not null primary key,
	IDVE int not null references ThemVe(IDVE),
	Price float not null,
	DateCheckIn Date Not Null default getdate()

	
)
go
create table NguoiMua(
	IDVE int not null references ThemVe(IDVE),
	Ten nvarchar(50) not null,
	CMND int not null,
	SDT int not null,
	Giave int not null,

)
go
set dateformat DMY
--add
insert Account values('admin','admin',N'Admin',0)
insert Account values('doanlong','159357',N'Doãn Văn Long',1)
insert Account values('conghieu','1832',N'Trần Công Hiếu',1)
--add Banve
insert ThemVe(MaTau, Gadi, Gaden, Loaive, Tang, Ngaydi, Giodi, Ngayve, Giove, Toa, Loaicho, Ghe_Giuong, Giave) 
values('SA1',N'Sài Gòn',N'Hà Nội',N'Một chiều',1,'8/5/2020','18:30','23/5/2020','10:30',8,N'Ghế ngồi mềm',25,1500000)

insert ThemVe(MaTau, Gadi, Gaden, Loaive, Tang, Ngaydi, Giodi, Ngayve, Giove, Toa, Loaicho, Ghe_Giuong, Giave) 
values('SA1',N'Sài Gòn',N'Hà Nội',N'Một chiều',1,'8/5/2020','18:30','23/5/2020','10:30',8,N'Ghế ngồi mềm',12,2500000)

insert ThemVe(MaTau, Gadi, Gaden, Loaive, Tang, Ngaydi, Giodi, Ngayve, Giove, Toa, Loaicho, Ghe_Giuong, Giave) 
values('AB2',N'Biên Hòa',N'Nha Trang',N'Khứ Hồi',1,'9/5/2020','13:30','16/5/2020','20:30',3,N'Giường nằm lạnh',25,125000)

insert ThemVe(MaTau, Gadi, Gaden, Loaive, Tang, Ngaydi, Giodi, Ngayve, Giove, Toa, Loaicho, Ghe_Giuong, Giave) 
values('AB2',N'Biên Hòa',N'Nha Trang',N'Khứ Hồi',2,'9/5/2020','13:30','16/5/2020','20:30',3,N'Giường nằm lạnh',26,125000)

insert ThemVe(MaTau, Gadi, Gaden, Loaive, Tang, Ngaydi, Giodi, Ngayve, Giove, Toa, Loaicho, Ghe_Giuong, Giave) 
values('CF1',N'Phú Yên',N'Phú Yên',N'Khứ Hồi',1,'9/5/2020','13:30','16/5/2020','20:30',3,N'Giường nằm lạnh',12,500000)

insert ThemVe(MaTau, Gadi, Gaden, Loaive, Tang, Ngaydi, Giodi, Ngayve, Giove, Toa, Loaicho, Ghe_Giuong, Giave) 
values('AB2',N'Phú Yên',N'Phú Yên',N'Khứ Hồi',2,'9/5/2020','13:30','16/5/2020','20:30',3,N'Giường nằm lạnh',13,500000)


--lập hóa đơn
create proc sp_AddHoadon
@idve int
As
	begin	
		declare @gia int
		begin
			 select @gia = (select  Giave from ThemVe where IDVE = @idve)
			 insert Hoadon(IDVE,Price,DateCheckIn) values (@idve,@gia,getdate())
		end
	end
go
create proc sp_AddNguoiMua
@idve int,
@ten nvarchar (50),
@cmnd int,
@sdt int
As
	begin	
		declare @gia int
		begin
			 select @gia = (select  Giave from ThemVe where IDVE = @idve)
			 insert NguoiMua(IDVE,Ten,CMND,SDT,Giave) values (@idve,@ten,@cmnd,@sdt,@gia)
		end
	end
go
--check hóa đơn
create proc sp_CheckBill
@datecheck date
as
	Begin
		select IDHD as N'Mã hóa đơn', IDVE as N'Mã vé tàu', Price as N'Thành tiền', DateCheckIn as N'Ngày mua'
		from Hoadon
		where DateCheckIn = @datecheck
		
	End
go
--select *from ThemVe
--select *from Hoadon
--exec sp_AddHoadon '2','3'	
--select *from Account
--select * from NguoiMua