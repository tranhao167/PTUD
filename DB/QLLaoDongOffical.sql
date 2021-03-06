USE [QLLaoDong]
GO
/****** Object:  Table [dbo].[CongTrinh]    Script Date: 11/9/2020 6:05:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongTrinh](
	[idCongTrinh] [nvarchar](50) NOT NULL,
	[tenCongTrinh] [nvarchar](200) NOT NULL,
	[diaChi] [nvarchar](200) NOT NULL,
	[ngayBatDau] [datetime] NOT NULL,
	[ngayKetThucDuKien] [datetime] NOT NULL,
	[ngayHoanThanh] [datetime] NOT NULL,
	[trangThai] [nvarchar](50) NOT NULL,
	[isDelete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCongTrinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CongViec]    Script Date: 11/9/2020 6:05:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongViec](
	[idCongViec] [nvarchar](50) NOT NULL,
	[tenCongViec] [nvarchar](200) NOT NULL,
	[isDelete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCongViec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhSachCongViecCongTrinh]    Script Date: 11/9/2020 6:05:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachCongViecCongTrinh](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idCongTrinh] [nvarchar](50) NOT NULL,
	[idCongViec] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhSachPhanCong]    Script Date: 11/9/2020 6:05:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachPhanCong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idNhanVien] [nvarchar](50) NOT NULL,
	[idDSCongViecCongTrinh] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/9/2020 6:05:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[idNhanVien] [nvarchar](50) NOT NULL,
	[tenNhanVien] [nvarchar](200) NOT NULL,
	[diaChi] [nvarchar](200) NOT NULL,
	[sdt] [nvarchar](50) NOT NULL,
	[chucVu] [int] NOT NULL,
	[idPhongBan] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 11/9/2020 6:05:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[idPhongBan] [nvarchar](50) NOT NULL,
	[tenPhongBan] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 11/9/2020 6:05:28 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[idTaiKhoan] [nvarchar](50) NOT NULL,
	[matKhau] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[DanhSachCongViecCongTrinh]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachCongViecCongTrinh_CongTrinh] FOREIGN KEY([idCongTrinh])
REFERENCES [dbo].[CongTrinh] ([idCongTrinh])
GO
ALTER TABLE [dbo].[DanhSachCongViecCongTrinh] CHECK CONSTRAINT [FK_DanhSachCongViecCongTrinh_CongTrinh]
GO
ALTER TABLE [dbo].[DanhSachCongViecCongTrinh]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachCongViecCongTrinh_CongViec] FOREIGN KEY([idCongViec])
REFERENCES [dbo].[CongViec] ([idCongViec])
GO
ALTER TABLE [dbo].[DanhSachCongViecCongTrinh] CHECK CONSTRAINT [FK_DanhSachCongViecCongTrinh_CongViec]
GO
ALTER TABLE [dbo].[DanhSachPhanCong]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachPhanCong_DanhSachCongViecCongTrinh] FOREIGN KEY([idDSCongViecCongTrinh])
REFERENCES [dbo].[DanhSachCongViecCongTrinh] ([id])
GO
ALTER TABLE [dbo].[DanhSachPhanCong] CHECK CONSTRAINT [FK_DanhSachPhanCong_DanhSachCongViecCongTrinh]
GO
ALTER TABLE [dbo].[DanhSachPhanCong]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachPhanCong_NhanVien] FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[NhanVien] ([idNhanVien])
GO
ALTER TABLE [dbo].[DanhSachPhanCong] CHECK CONSTRAINT [FK_DanhSachPhanCong_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([idPhongBan])
REFERENCES [dbo].[PhongBan] ([idPhongBan])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
USE [master]
GO
ALTER DATABASE [QLLaoDong] SET  READ_WRITE 
GO


USE [QLLaoDong]
insert into PhongBan values ('PB0001',N'Dự án');
insert into PhongBan values ('PB0002',N'Kế toán');
insert into PhongBan values ('PB0003',N'Kinh doanh');
insert into PhongBan values ('PB0004',N'Kĩ thuật');

insert into NhanVien values ('NV0001',N'Huỳnh Phúc Huy',N'4 đường số 2','0932774940',0,'PB0001');
insert into NhanVien values ('NV0002',N'Trần Trung Hào',N'69 Lê Lợi','0933883099',0,'PB0002');
insert into NhanVien values ('NV0003',N'Nguyễn Hồng Quang',N'888 Quang Trung','0938884761',1,'PB0001');
insert into NhanVien values ('NV0004',N'Huỳnh Anh Khang',N'123 Âu Cơ','0988838890',1,'PB0001');
insert into NhanVien values ('NV0005',N'Đào Anh Duy',N'456 Trường Chinh','0987665434',1,'PB0002');
insert into NhanVien values ('NV0006',N'Huỳnh Minh Tiến',N'222 Bàn Cờ','0987665434',1,'PB0002');

insert into TaiKhoan values ('NV0001','123');
insert into TaiKhoan values ('NV0002','123');
insert into TaiKhoan values ('NV0003','123');
insert into TaiKhoan values ('NV0004','123');
insert into TaiKhoan values ('NV0005','123');
insert into TaiKhoan values ('NV0006','123');

insert into CongViec values ('CV0001',N'Lao công',0);
insert into CongViec values ('CV0002',N'Thợ sơn nước',0);
insert into CongViec values ('CV0003',N'Thiết kế bản vẽ',0);
insert into CongViec values ('CV0004',N'Thiết kế nội thất',0);
insert into CongViec values ('CV0005',N'Thợ phụ',0);
insert into CongViec values ('CV0006',N'Thầu',0);
insert into CongViec values ('CV0007',N'Chuyên viên giám sát',0);

insert into CongTrinh values ('CT0001',N'Chung cư Gia Phú',N'234 Thoại Ngọc Hầu','20201010','20211010','19000101',N'Đang thực hiện',0);
insert into CongTrinh values ('CT0002',N'VinMart+ Thảo Điền',N'11 Thảo Điền','20201108','20201208','19000101',N'Đang thực hiện',0);

insert into DanhSachCongViecCongTrinh values ('CT0001','CV0001');
insert into DanhSachCongViecCongTrinh values ('CT0001','CV0002');
insert into DanhSachCongViecCongTrinh values ('CT0001','CV0003');
insert into DanhSachCongViecCongTrinh values ('CT0001','CV0004');
insert into DanhSachCongViecCongTrinh values ('CT0001','CV0005');
insert into DanhSachCongViecCongTrinh values ('CT0001','CV0006');
insert into DanhSachCongViecCongTrinh values ('CT0002','CV0001');
insert into DanhSachCongViecCongTrinh values ('CT0002','CV0002');
insert into DanhSachCongViecCongTrinh values ('CT0002','CV0003');

insert into DanhSachPhanCong values ('NV0003',1);
insert into DanhSachPhanCong values ('NV0003',2);
insert into DanhSachPhanCong values ('NV0003',3);
insert into DanhSachPhanCong values ('NV0004',1);
insert into DanhSachPhanCong values ('NV0004',5);
insert into DanhSachPhanCong values ('NV0005',2);
insert into DanhSachPhanCong values ('NV0005',3);

