USE [master]
GO
/****** Object:  Database [QLQuanBIDA]    Script Date: 12/16/19 9:47:39 PM ******/
CREATE DATABASE [QLQuanBIDA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLQuanBIDA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLQuanBIDA.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLQuanBIDA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLQuanBIDA_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLQuanBIDA] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLQuanBIDA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLQuanBIDA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLQuanBIDA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLQuanBIDA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLQuanBIDA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLQuanBIDA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLQuanBIDA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLQuanBIDA] SET  MULTI_USER 
GO
ALTER DATABASE [QLQuanBIDA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLQuanBIDA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLQuanBIDA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLQuanBIDA] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLQuanBIDA]
GO
/****** Object:  Table [dbo].[BANBIDA]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BANBIDA](
	[MaBan] [varchar](10) NOT NULL,
	[TenBan] [nvarchar](30) NULL,
	[ViTri] [nvarchar](30) NULL,
	[MaLoaiBan] [varchar](10) NULL,
	[MaTrangThai] [varchar](10) NULL,
 CONSTRAINT [PK_BANBIDA] PRIMARY KEY CLUSTERED 
(
	[MaBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_HOADON]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_HOADON](
	[MaHang] [varchar](10) NOT NULL,
	[MaHD] [varchar](10) NOT NULL,
	[SoLuongBan] [float] NULL,
	[DonGiaBan] [float] NULL,
	[ThanhTien] [float] NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_CT_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC,
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_NHOMNGUOIDUNG_MANHINH]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_NHOMNGUOIDUNG_MANHINH](
	[MaNhom] [varchar](10) NOT NULL,
	[MaManHinh] [varchar](10) NOT NULL,
	[CoQuyen] [bit] NULL,
 CONSTRAINT [PK_CT_NHOMNGUOIDUNG_MANHINH] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC,
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_NHOMNGUOIDUNG_NGUOIDUNG]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_NHOMNGUOIDUNG_NGUOIDUNG](
	[TenDangNhap] [varchar](10) NOT NULL,
	[MaNhom] [varchar](10) NOT NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_CT_NHOMNGUOIDUNG_NGUOIDUNG1] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC,
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_PHIEUNHAP]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_PHIEUNHAP](
	[MaHang] [varchar](10) NOT NULL,
	[MaPN] [varchar](10) NOT NULL,
	[SoLuongNhap] [float] NULL,
	[DonGiaNhap] [float] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_CT_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC,
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_TAMTINH]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_TAMTINH](
	[MaHang] [varchar](10) NOT NULL,
	[MaTamTinh] [varchar](10) NOT NULL,
	[SoLuongBan] [float] NULL,
	[DonGiaBan] [float] NULL,
	[ThanhTien] [float] NULL,
 CONSTRAINT [PK_CT_TAMTINH] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC,
	[MaTamTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DATBANBIDA]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DATBANBIDA](
	[MaDat] [varchar](10) NOT NULL,
	[GioDat] [datetime] NULL,
	[SoDTDat] [varchar](13) NULL,
	[TrangThaiDat] [varchar](10) NULL,
	[GhiChu] [nvarchar](50) NULL,
	[MaBan] [varchar](10) NULL,
 CONSTRAINT [PK_DATBANBIDA] PRIMARY KEY CLUSTERED 
(
	[MaDat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANGHOA]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANGHOA](
	[MaHang] [varchar](10) NOT NULL,
	[TenHang] [nvarchar](50) NULL,
	[DonViTinh] [nvarchar](50) NULL,
	[SoLuongTon] [float] NULL,
	[DonGia] [float] NULL,
	[MaLoai] [varchar](10) NULL,
 CONSTRAINT [PK_HANGHOA] PRIMARY KEY CLUSTERED 
(
	[MaHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HOADON](
	[MaHD] [varchar](10) NOT NULL,
	[NgayLap] [date] NULL,
	[GioDatBan] [datetime] NULL,
	[GioTraBan] [datetime] NULL,
	[TGChoi] [varchar](12) NULL,
	[TienBan] [float] NULL,
	[TienChuyenBan] [float] NULL,
	[TongTienDichVu] [float] NULL,
	[ThueVAT] [float] NULL,
	[TongGiaTri] [float] NULL,
	[ThanhTien] [float] NULL,
	[TienNo] [float] NULL,
	[MaBan] [varchar](10) NULL,
	[MaKH] [varchar](10) NULL,
	[MaNV] [varchar](10) NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKH] [varchar](10) NOT NULL,
	[HoTenKH] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](70) NULL,
	[SoDT] [varchar](13) NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIBANBIDA]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAIBANBIDA](
	[MaLoaiBan] [varchar](10) NOT NULL,
	[TenLoaiBan] [nvarchar](20) NULL,
	[DonGia] [float] NULL,
 CONSTRAINT [PK_LOAIBANBIDA] PRIMARY KEY CLUSTERED 
(
	[MaLoaiBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAIHANG]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAIHANG](
	[MaLoai] [varchar](10) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_LOAIHANG] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MANHINH]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MANHINH](
	[MaManHinh] [varchar](10) NOT NULL,
	[TenManHinh] [nvarchar](70) NULL,
 CONSTRAINT [PK_MANHINH] PRIMARY KEY CLUSTERED 
(
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGUOIDUNG]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGUOIDUNG](
	[TenDangNhap] [varchar](10) NOT NULL,
	[MatKhau] [varchar](30) NULL,
	[HoatDong] [bit] NULL,
	[MaNV] [varchar](10) NULL,
 CONSTRAINT [PK_NGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNCC] [varchar](10) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](70) NULL,
	[SoDT] [varchar](13) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [varchar](10) NOT NULL,
	[HoTenNV] [nvarchar](70) NULL,
	[NgaySinh] [date] NULL,
	[CMND] [varchar](12) NULL,
	[GioiTinh] [nvarchar](3) NULL,
	[DiaChi] [nvarchar](70) NULL,
	[SoDT] [varchar](13) NULL,
	[NgayVaoLam] [date] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHOMNGUOIDUNG]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHOMNGUOIDUNG](
	[MaNhom] [varchar](10) NOT NULL,
	[TenNhom] [nvarchar](50) NULL,
	[GhiChu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHOMNGUOIDUNG] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPN] [varchar](10) NOT NULL,
	[TongSoLuongNhap] [float] NULL,
	[TongGiaTriNhap] [float] NULL,
	[NgayNhap] [date] NULL,
	[MaNCC] [varchar](10) NULL,
	[MaNV] [varchar](10) NULL,
	[TienNo] [float] NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TAMTINH]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAMTINH](
	[MaTamTinh] [varchar](50) NOT NULL,
	[TienBan] [float] NULL,
	[GioDatBan] [datetime] NULL,
	[MaBan] [varchar](10) NULL,
	[MaKhach] [varchar](10) NULL,
	[MaNV] [varchar](10) NULL,
	[TienChuyenBan] [float] NULL,
 CONSTRAINT [PK_TAMTINH] PRIMARY KEY CLUSTERED 
(
	[MaTamTinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TRANGTHAIBAN]    Script Date: 12/16/19 9:47:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TRANGTHAIBAN](
	[MaTrangThai] [varchar](10) NOT NULL,
	[TenTrangThai] [nvarchar](50) NULL,
	[Mau] [varchar](30) NULL,
 CONSTRAINT [PK_TRANGTHAIBAN] PRIMARY KEY CLUSTERED 
(
	[MaTrangThai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[BANBIDA] ([MaBan], [TenBan], [ViTri], [MaLoaiBan], [MaTrangThai]) VALUES (N'BIDA001', N'Bàn số 1', N'1', N'MLB01', N'MTT001')
INSERT [dbo].[BANBIDA] ([MaBan], [TenBan], [ViTri], [MaLoaiBan], [MaTrangThai]) VALUES (N'BIDA002', N'Bàn số 2', N'1', N'MLB02', N'MTT002')
INSERT [dbo].[BANBIDA] ([MaBan], [TenBan], [ViTri], [MaLoaiBan], [MaTrangThai]) VALUES (N'BIDA003', N'Bàn số 3', N'2', N'MLB01', N'MTT003')
INSERT [dbo].[BANBIDA] ([MaBan], [TenBan], [ViTri], [MaLoaiBan], [MaTrangThai]) VALUES (N'BIDA004', N'Bàn số 4', N'2', N'MLB01', N'MTT003')
INSERT [dbo].[BANBIDA] ([MaBan], [TenBan], [ViTri], [MaLoaiBan], [MaTrangThai]) VALUES (N'BIDA005', N'Bàn số 5', N'1', N'MLB02', N'MTT004')
INSERT [dbo].[BANBIDA] ([MaBan], [TenBan], [ViTri], [MaLoaiBan], [MaTrangThai]) VALUES (N'BIDA006', N'Bàn số 6', N'1', N'MLB02', N'MTT002')
INSERT [dbo].[BANBIDA] ([MaBan], [TenBan], [ViTri], [MaLoaiBan], [MaTrangThai]) VALUES (N'BIDA007', N'Bàn số 7', N'2', N'MLB02', N'MTT004')
INSERT [dbo].[BANBIDA] ([MaBan], [TenBan], [ViTri], [MaLoaiBan], [MaTrangThai]) VALUES (N'BIDA008', N'Bàn số 8', N'2', N'MLB01', N'MTT004')
INSERT [dbo].[BANBIDA] ([MaBan], [TenBan], [ViTri], [MaLoaiBan], [MaTrangThai]) VALUES (N'BIDA009', N'Bàn số 9', N'1', N'MLB01', N'MTT004')
INSERT [dbo].[BANBIDA] ([MaBan], [TenBan], [ViTri], [MaLoaiBan], [MaTrangThai]) VALUES (N'BIDA010', N'Bàn số 10', N'1', N'MLB02', N'MTT001')
INSERT [dbo].[BANBIDA] ([MaBan], [TenBan], [ViTri], [MaLoaiBan], [MaTrangThai]) VALUES (N'BIDA011', N'Bàn số 11', N'2', N'MLB02', N'MTT001')
INSERT [dbo].[BANBIDA] ([MaBan], [TenBan], [ViTri], [MaLoaiBan], [MaTrangThai]) VALUES (N'BIDA012', N'Bàn số 12', N'2', N'MLB01', N'MTT004')
INSERT [dbo].[BANBIDA] ([MaBan], [TenBan], [ViTri], [MaLoaiBan], [MaTrangThai]) VALUES (N'BIDA013', N'Bàn số 13', N'1', N'MLB02', N'MTT004')
INSERT [dbo].[BANBIDA] ([MaBan], [TenBan], [ViTri], [MaLoaiBan], [MaTrangThai]) VALUES (N'BIDA014', N'Bàn số 14', N'1', N'MLB01', N'MTT002')
INSERT [dbo].[BANBIDA] ([MaBan], [TenBan], [ViTri], [MaLoaiBan], [MaTrangThai]) VALUES (N'BIDA015', N'Bàn số 15', N'2', N'MLB01', N'MTT001')
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH001', N'HDE3yJbQv8', 2, 10000, 20000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH001', N'HDHmCr2G0l', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH001', N'HDTDa4JqsX', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH002', N'HDE3yJbQv8', 1, 15000, 15000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH002', N'HDHmCr2G0l', 2, 15000, 30000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH002', N'HDN927JNNS', 2, 15000, 30000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH002', N'HDTDa4JqsX', 1, 15000, 15000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH003', N'HDH5QXQOf9', 1, 10000, NULL, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH003', N'HDhP6hk7l6', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH003', N'HDLWAVM7dD', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH003', N'HDN927JNNS', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH003', N'HDqzevHf3u', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH003', N'HDWFl6Hf9w', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH004', N'HDhP6hk7l6', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH004', N'HDLWAVM7dD', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH004', N'HDqzevHf3u', 2, 10000, 20000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH005', N'HDH5QXQOf9', 1, 10000, NULL, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH005', N'HDha4RfTBi', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH005', N'HDLWAVM7dD', 2, 10000, 20000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH005', N'HDsQUU8Jj5', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH005', N'HDU6UT8H7K', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH005', N'HDWFl6Hf9w', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH005', N'HDYFS7nbKB', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH006', N'HDfYKl3zA8', 1, 25000, NULL, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH006', N'HDha4RfTBi', 1, 25000, 25000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH006', N'HDiLoTu22I', 3, 25000, 75000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH006', N'HDN927JNNS', 3, 25000, 75000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH006', N'HDsQUU8Jj5', 1, 25000, 25000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH006', N'HDU6UT8H7K', 1, 25000, 25000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH006', N'HDWFl6Hf9w', 2, 25000, 50000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH006', N'HDYFS7nbKB', 1, 25000, 25000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH007', N'HD3cXoaHH3', 2, 10000, 20000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH007', N'HDfYKl3zA8', 1, 10000, NULL, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH007', N'HDha4RfTBi', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH007', N'HDiLoTu22I', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH007', N'HDsQUU8Jj5', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH007', N'HDU6UT8H7K', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH007', N'HDWFl6Hf9w', 4, 10000, 40000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH007', N'HDYFS7nbKB', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH008', N'HD3cXoaHH3', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH008', N'HDha4RfTBi', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH008', N'HDiLoTu22I', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH008', N'HDsQUU8Jj5', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH008', N'HDU6UT8H7K', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH008', N'HDYFS7nbKB', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH009', N'HD3cXoaHH3', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH009', N'HDfYKl3zA8', 1, 10000, NULL, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH009', N'HDha4RfTBi', 2, 10000, 20000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH009', N'HDsQUU8Jj5', 2, 10000, 20000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH009', N'HDU6UT8H7K', 2, 10000, 20000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH009', N'HDYFS7nbKB', 2, 10000, 20000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH010', N'HD5JsNnEm4', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH010', N'HDha4RfTBi', 2, 10000, 20000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH010', N'HDsQUU8Jj5', 2, 10000, 20000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH010', N'HDU6UT8H7K', 2, 10000, 20000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH010', N'HDYFS7nbKB', 2, 10000, 20000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH011', N'HDfYKl3zA8', 1, 15000, NULL, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH011', N'HDha4RfTBi', 1, 15000, 15000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH011', N'HDsQUU8Jj5', 1, 15000, 15000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH011', N'HDU6UT8H7K', 1, 15000, 15000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH011', N'HDYFS7nbKB', 1, 15000, 15000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH012', N'HDn0WDSJNX', 2, 16000, 32000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH013', N'HDn0WDSJNX', 2, 15000, 30000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH014', N'HDgnipvv54', 1, 18000, 18000, NULL)
INSERT [dbo].[CT_HOADON] ([MaHang], [MaHD], [SoLuongBan], [DonGiaBan], [ThanhTien], [GhiChu]) VALUES (N'HH015', N'HDgnipvv54', 1, 10000, 10000, NULL)
INSERT [dbo].[CT_NHOMNGUOIDUNG_MANHINH] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'NHOM001', N'SCR001', 1)
INSERT [dbo].[CT_NHOMNGUOIDUNG_MANHINH] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'NHOM001', N'SCR002', 1)
INSERT [dbo].[CT_NHOMNGUOIDUNG_MANHINH] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'NHOM001', N'SCR003', 1)
INSERT [dbo].[CT_NHOMNGUOIDUNG_MANHINH] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'NHOM001', N'SCR004', 0)
INSERT [dbo].[CT_NHOMNGUOIDUNG_MANHINH] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'NHOM001', N'SCR005', 0)
INSERT [dbo].[CT_NHOMNGUOIDUNG_MANHINH] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'NHOM002', N'SCR001', 0)
INSERT [dbo].[CT_NHOMNGUOIDUNG_MANHINH] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'NHOM002', N'SCR002', 0)
INSERT [dbo].[CT_NHOMNGUOIDUNG_MANHINH] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'NHOM002', N'SCR003', 0)
INSERT [dbo].[CT_NHOMNGUOIDUNG_MANHINH] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'NHOM002', N'SCR004', 1)
INSERT [dbo].[CT_NHOMNGUOIDUNG_MANHINH] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'NHOM002', N'SCR005', 1)
INSERT [dbo].[CT_NHOMNGUOIDUNG_MANHINH] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'NHOM002', N'SCR008', 0)
INSERT [dbo].[CT_NHOMNGUOIDUNG_MANHINH] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'NHOM003', N'SCR001', 0)
INSERT [dbo].[CT_NHOMNGUOIDUNG_MANHINH] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'NHOM003', N'SCR002', 0)
INSERT [dbo].[CT_NHOMNGUOIDUNG_MANHINH] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'NHOM003', N'SCR003', 0)
INSERT [dbo].[CT_NHOMNGUOIDUNG_MANHINH] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'NHOM003', N'SCR007', 1)
INSERT [dbo].[CT_NHOMNGUOIDUNG_MANHINH] ([MaNhom], [MaManHinh], [CoQuyen]) VALUES (N'NHOM003', N'SCR008', 1)
INSERT [dbo].[CT_NHOMNGUOIDUNG_NGUOIDUNG] ([TenDangNhap], [MaNhom], [GhiChu]) VALUES (N'admin', N'NHOM001', NULL)
INSERT [dbo].[CT_NHOMNGUOIDUNG_NGUOIDUNG] ([TenDangNhap], [MaNhom], [GhiChu]) VALUES (N'admin2', N'NHOM001', NULL)
INSERT [dbo].[CT_NHOMNGUOIDUNG_NGUOIDUNG] ([TenDangNhap], [MaNhom], [GhiChu]) VALUES (N'user1', N'NHOM002', NULL)
INSERT [dbo].[CT_NHOMNGUOIDUNG_NGUOIDUNG] ([TenDangNhap], [MaNhom], [GhiChu]) VALUES (N'user2', N'NHOM002', N'')
INSERT [dbo].[CT_NHOMNGUOIDUNG_NGUOIDUNG] ([TenDangNhap], [MaNhom], [GhiChu]) VALUES (N'user2', N'NHOM003', NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([MaHang], [MaPN], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (N'HH001', N'PN00002', 50, 8000, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([MaHang], [MaPN], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (N'HH001', N'PNE2B18skX', 5, 7500, 37500)
INSERT [dbo].[CT_PHIEUNHAP] ([MaHang], [MaPN], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (N'HH001', N'PNo8T9ez55', 10, 9000, 90000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaHang], [MaPN], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (N'HH001', N'PNr5IW4391', 1, 7000, 7000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaHang], [MaPN], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (N'HH002', N'PN00001', 50, 13000, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([MaHang], [MaPN], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (N'HH002', N'PNE2B18skX', 10, 7000, 70000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaHang], [MaPN], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (N'HH002', N'PNo8T9ez55', 20, 9000, 180000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaHang], [MaPN], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (N'HH003', N'PN00001', 50, 8000, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([MaHang], [MaPN], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (N'HH003', N'PNr5IW4391', 1, 6500, 6500)
INSERT [dbo].[CT_PHIEUNHAP] ([MaHang], [MaPN], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (N'HH004', N'PN00002', 50, 8000, NULL)
INSERT [dbo].[CT_PHIEUNHAP] ([MaHang], [MaPN], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (N'HH004', N'PNLVGQ95ZQ', 50, 7250, 362500)
INSERT [dbo].[CT_PHIEUNHAP] ([MaHang], [MaPN], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (N'HH005', N'PNr5IW4391', 1, 5500, 5500)
INSERT [dbo].[CT_PHIEUNHAP] ([MaHang], [MaPN], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (N'HH006', N'PNLVGQ95ZQ', 20, 150000, 3000000)
INSERT [dbo].[CT_PHIEUNHAP] ([MaHang], [MaPN], [SoLuongNhap], [DonGiaNhap], [ThanhTien]) VALUES (N'HH007', N'PNr5IW4391', 1, 3750, 3750)
INSERT [dbo].[CT_TAMTINH] ([MaHang], [MaTamTinh], [SoLuongBan], [DonGiaBan], [ThanhTien]) VALUES (N'HH002', N'TT0fz3o6PA', 1, 15000, 15000)
INSERT [dbo].[CT_TAMTINH] ([MaHang], [MaTamTinh], [SoLuongBan], [DonGiaBan], [ThanhTien]) VALUES (N'HH003', N'TT0fz3o6PA', 1, 10000, 10000)
INSERT [dbo].[CT_TAMTINH] ([MaHang], [MaTamTinh], [SoLuongBan], [DonGiaBan], [ThanhTien]) VALUES (N'HH004', N'TT0fz3o6PA', 2, 10000, 20000)
INSERT [dbo].[CT_TAMTINH] ([MaHang], [MaTamTinh], [SoLuongBan], [DonGiaBan], [ThanhTien]) VALUES (N'HH005', N'TT0fz3o6PA', 2, 10000, 20000)
INSERT [dbo].[CT_TAMTINH] ([MaHang], [MaTamTinh], [SoLuongBan], [DonGiaBan], [ThanhTien]) VALUES (N'HH005', N'TT6K06ISz8', 1, 10000, 10000)
INSERT [dbo].[CT_TAMTINH] ([MaHang], [MaTamTinh], [SoLuongBan], [DonGiaBan], [ThanhTien]) VALUES (N'HH006', N'TT0fz3o6PA', 1, 25000, 25000)
INSERT [dbo].[CT_TAMTINH] ([MaHang], [MaTamTinh], [SoLuongBan], [DonGiaBan], [ThanhTien]) VALUES (N'HH006', N'TT6K06ISz8', 1, 25000, 25000)
INSERT [dbo].[CT_TAMTINH] ([MaHang], [MaTamTinh], [SoLuongBan], [DonGiaBan], [ThanhTien]) VALUES (N'HH007', N'TT6K06ISz8', 1, 10000, 10000)
INSERT [dbo].[CT_TAMTINH] ([MaHang], [MaTamTinh], [SoLuongBan], [DonGiaBan], [ThanhTien]) VALUES (N'HH008', N'TT6K06ISz8', 1, 10000, 10000)
INSERT [dbo].[CT_TAMTINH] ([MaHang], [MaTamTinh], [SoLuongBan], [DonGiaBan], [ThanhTien]) VALUES (N'HH009', N'TT6K06ISz8', 2, 10000, 20000)
INSERT [dbo].[CT_TAMTINH] ([MaHang], [MaTamTinh], [SoLuongBan], [DonGiaBan], [ThanhTien]) VALUES (N'HH010', N'TT6K06ISz8', 2, 10000, 20000)
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonViTinh], [SoLuongTon], [DonGia], [MaLoai]) VALUES (N'HH001', N'Nước trà xanh C2', N'Chai', 46, 10000, N'MLH002')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonViTinh], [SoLuongTon], [DonGia], [MaLoai]) VALUES (N'HH002', N'Bò húc lon', N'Lon', 44, 15000, N'MLH002')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonViTinh], [SoLuongTon], [DonGia], [MaLoai]) VALUES (N'HH003', N'Cocacola', N'Lon', 45, 10000, N'MLH002')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonViTinh], [SoLuongTon], [DonGia], [MaLoai]) VALUES (N'HH004', N'Sting dâu', N'Chai', 46, 10000, N'MLH002')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonViTinh], [SoLuongTon], [DonGia], [MaLoai]) VALUES (N'HH005', N'Nước suối', N'Chai', 45, 10000, N'MLH002')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonViTinh], [SoLuongTon], [DonGia], [MaLoai]) VALUES (N'HH006', N'Khô bò', N'Bịch', 40, 25000, N'MLH001')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonViTinh], [SoLuongTon], [DonGia], [MaLoai]) VALUES (N'HH007', N'Đậu phộng', N'Bịch', 41, 10000, N'MLH001')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonViTinh], [SoLuongTon], [DonGia], [MaLoai]) VALUES (N'HH008', N'Trà xanh oolong', N'Chai', 46, 10000, N'MLH002')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonViTinh], [SoLuongTon], [DonGia], [MaLoai]) VALUES (N'HH009', N'Trà xanh không độ', N'Chai', 45, 10000, N'MLH002')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonViTinh], [SoLuongTon], [DonGia], [MaLoai]) VALUES (N'HH010', N'Tăng lực', N'Chai', 45, 10000, N'MLH002')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonViTinh], [SoLuongTon], [DonGia], [MaLoai]) VALUES (N'HH011', N'Nước yến', N'Lon', 48, 15000, N'MLH002')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonViTinh], [SoLuongTon], [DonGia], [MaLoai]) VALUES (N'HH012', N'Bia tiger', N'Lon', 48, 16000, N'MLH002')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonViTinh], [SoLuongTon], [DonGia], [MaLoai]) VALUES (N'HH013', N'Bia 333', N'Lon', 48, 15000, N'MLH002')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonViTinh], [SoLuongTon], [DonGia], [MaLoai]) VALUES (N'HH014', N'Strongbow', N'Chai', 49, 18000, N'MLH002')
INSERT [dbo].[HANGHOA] ([MaHang], [TenHang], [DonViTinh], [SoLuongTon], [DonGia], [MaLoai]) VALUES (N'HH015', N'Cơm cháy', N'Bịch', 49, 10000, N'MLH001')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HD3cXoaHH3', CAST(N'2019-12-10' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, 40000, 40000, 0, NULL, N'KH001', N'NV004')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HD483x73Dh', CAST(N'2019-12-12' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, 25000, 25000, 0, N'BIDA004', N'KH002', N'NV004')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HD5JsNnEm4', CAST(N'2019-12-10' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, 10000, 10000, 0, NULL, N'KH001', N'NV005')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HD6Xz09fqW', CAST(N'2019-12-12' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, 20000, 20000, 0, N'BIDA002', N'KH002', N'NV006')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDE3yJbQv8', CAST(N'2019-12-15' AS Date), CAST(N'2019-12-15 14:52:04.677' AS DateTime), CAST(N'2019-12-15 22:27:18.220' AS DateTime), N'07:35:13', 189583.328125, 0, 35000, 10, 224583.296875, 246583.40625, 0, N'BIDA004', NULL, N'NV003')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDfYKl3zA8', CAST(N'2019-12-11' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, 80000, 80000, 0, N'BIDA005', N'KH002', N'NV005')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDgnipvv54', CAST(N'2019-12-10' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, 28000, 28000, 0, NULL, N'KH001', N'NV002')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDH5QXQOf9', CAST(N'2019-12-11' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, 70000, 70000, 0, NULL, N'KH001', N'NV002')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDha4RfTBi', CAST(N'2019-12-14' AS Date), CAST(N'2019-12-13 20:41:20.000' AS DateTime), CAST(N'2019-12-14 21:46:58.793' AS DateTime), N'01:05:38', 21666.666015625, 0, 110000, 10, 131666.671875, 144833.296875, 0, N'BIDA002', N'KH002', N'NV006')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDHmCr2G0l', CAST(N'2019-12-16' AS Date), CAST(N'2019-12-16 21:36:35.253' AS DateTime), CAST(N'2019-12-16 21:37:07.853' AS DateTime), N'00:00:32', 0, 0, 40000, 10, 40000, 44000, 4000, N'BIDA008', NULL, N'NV003')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDhP6hk7l6', CAST(N'2019-12-15' AS Date), CAST(N'2019-12-15 15:26:50.027' AS DateTime), CAST(N'2019-12-15 15:28:43.107' AS DateTime), N'00:01:53', 333.33334350585938, 0, 20000, 10, 20000, 22000, 7000, N'BIDA005', NULL, N'NV005')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDiLoTu22I', CAST(N'2019-12-16' AS Date), CAST(N'2019-12-16 20:27:03.747' AS DateTime), CAST(N'2019-12-16 20:39:20.220' AS DateTime), N'00:12:16', 4000, 40000, 95000, 10, 179000, 148500, 8500, N'BIDA010', NULL, N'NV003')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDLWAVM7dD', CAST(N'2019-12-16' AS Date), CAST(N'2019-12-16 19:53:32.533' AS DateTime), CAST(N'2019-12-16 20:19:59.713' AS DateTime), N'00:26:27', 10833.3330078125, 20000, 40000, 10, 70833.328125, 66000, 6000, N'BIDA015', NULL, N'NV003')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDn0WDSJNX', CAST(N'2019-12-16' AS Date), CAST(N'2019-12-16 21:40:14.890' AS DateTime), CAST(N'2019-12-16 21:43:42.887' AS DateTime), N'00:03:27', 1250, 0, 62000, 10, 63250, 68200, 200, N'BIDA009', NULL, N'NV003')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDN927JNNS', CAST(N'2019-12-16' AS Date), CAST(N'2019-12-16 20:40:30.063' AS DateTime), CAST(N'2019-12-16 20:58:46.220' AS DateTime), N'00:18:16', 7500, 20000, 115000, 10, 162500, 148500, 8500, N'BIDA008', NULL, N'NV003')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDq0YdpeY2', CAST(N'2019-12-11' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, 20000, 20000, 0, N'BIDA002', N'KH002', N'NV003')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDqzevHf3u', CAST(N'2019-12-10' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, 30000, 30000, 0, NULL, N'KH001', N'NV004')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDsQUU8Jj5', CAST(N'2019-12-14' AS Date), CAST(N'2019-12-13 20:41:20.000' AS DateTime), CAST(N'2019-12-14 16:23:39.550' AS DateTime), N'19:42:19', 394000, 0, 110000, 10, 504000, 5544000, 54400, N'BIDA002', N'KH002', N'NV005')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDTDa4JqsX', CAST(N'2019-12-16' AS Date), CAST(N'2019-12-15 21:58:09.597' AS DateTime), CAST(N'2019-12-16 19:43:31.920' AS DateTime), N'21:45:22', 543750, 0, 25000, 10, 568750, 27500, 12500, N'BIDA012', NULL, N'NV003')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDU6UT8H7K', CAST(N'2019-12-13' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, 200000, 200000, 0, N'BIDA002', N'KH002', N'NV006')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDU6UTnk90', CAST(N'2019-11-30' AS Date), NULL, NULL, NULL, NULL, NULL, NULL, NULL, 20000, 20000, 0, NULL, NULL, NULL)
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDWFl6Hf9w', CAST(N'2019-12-16' AS Date), CAST(N'2019-12-16 21:27:15.937' AS DateTime), CAST(N'2019-12-16 21:34:21.187' AS DateTime), N'00:07:05', 2333.333251953125, 20000, 110000, 10, 152333.328125, 144466.703125, 4466.703125, N'BIDA005', NULL, N'NV003')
INSERT [dbo].[HOADON] ([MaHD], [NgayLap], [GioDatBan], [GioTraBan], [TGChoi], [TienBan], [TienChuyenBan], [TongTienDichVu], [ThueVAT], [TongGiaTri], [ThanhTien], [TienNo], [MaBan], [MaKH], [MaNV]) VALUES (N'HDYFS7nbKB', CAST(N'2019-12-14' AS Date), CAST(N'2019-12-13 20:41:20.000' AS DateTime), CAST(N'2019-12-14 16:41:11.413' AS DateTime), N'19:59:51', 399666.65625, NULL, NULL, NULL, NULL, 399666.65625, 0, N'BIDA002', N'KH002', N'NV004')
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTenKH], [DiaChi], [SoDT]) VALUES (N'KH001', N'Khách lẻ', NULL, NULL)
INSERT [dbo].[KHACHHANG] ([MaKH], [HoTenKH], [DiaChi], [SoDT]) VALUES (N'KH002', N'Trần Văn C', N'81A, Trường Chinh, Tân Bình', N'0936485709')
INSERT [dbo].[LOAIBANBIDA] ([MaLoaiBan], [TenLoaiBan], [DonGia]) VALUES (N'MLB01', N'Bida lỗ', 25000)
INSERT [dbo].[LOAIBANBIDA] ([MaLoaiBan], [TenLoaiBan], [DonGia]) VALUES (N'MLB02', N'Bida 3 băng', 20000)
INSERT [dbo].[LOAIHANG] ([MaLoai], [TenLoai]) VALUES (N'MLH001', N'Đồ ăn ')
INSERT [dbo].[LOAIHANG] ([MaLoai], [TenLoai]) VALUES (N'MLH002', N'Nước uống')
INSERT [dbo].[LOAIHANG] ([MaLoai], [TenLoai]) VALUES (N'MLH003', N'')
INSERT [dbo].[LOAIHANG] ([MaLoai], [TenLoai]) VALUES (N'MLH004', N'')
INSERT [dbo].[LOAIHANG] ([MaLoai], [TenLoai]) VALUES (N'MLH005', N'')
INSERT [dbo].[LOAIHANG] ([MaLoai], [TenLoai]) VALUES (N'MLH006', N'')
INSERT [dbo].[LOAIHANG] ([MaLoai], [TenLoai]) VALUES (N'MLH007', N'Nước trà xanh C2')
INSERT [dbo].[LOAIHANG] ([MaLoai], [TenLoai]) VALUES (N'MLH008', N'Nước trà xanh C2')
INSERT [dbo].[LOAIHANG] ([MaLoai], [TenLoai]) VALUES (N'MLH009', N'')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SCR001', N'Danh mục người dùng')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SCR002', N'Thêm người dùng')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SCR003', N'Phân quyền')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SCR004', N'Bán hàng')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SCR005', N'Nhập hàng')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SCR006', N'Danh mục nhà cung cấp')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SCR007', N'Danh mục khách hàng')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SCR008', N'Doanh thu')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [HoatDong], [MaNV]) VALUES (N'admin', N'1234', 1, N'NV001')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [HoatDong], [MaNV]) VALUES (N'admin1', N'1234', 0, N'NV001')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [HoatDong], [MaNV]) VALUES (N'admin2', N'1234', 1, N'NV002')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [HoatDong], [MaNV]) VALUES (N'admin3', N'1234', 1, N'NV006')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [HoatDong], [MaNV]) VALUES (N'user1', N'123', 1, N'NV001')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [HoatDong], [MaNV]) VALUES (N'user2', N'123', 0, N'NV002')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [HoatDong], [MaNV]) VALUES (N'user3', N'123', 1, N'NV003')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [HoatDong], [MaNV]) VALUES (N'user4', N'123', 1, N'NV004')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [HoatDong], [MaNV]) VALUES (N'user5', N'123', 1, N'NV005')
INSERT [dbo].[NGUOIDUNG] ([TenDangNhap], [MatKhau], [HoatDong], [MaNV]) VALUES (N'user6', N'123', 1, N'NV006')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SoDT]) VALUES (N'NCC001', N'An Phát', N'A5/22A, ấp 1 Vĩnh Lộc B, huyện Bình Chánh, TPHCM', N'0762836405')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SoDT]) VALUES (N'NCC002', N'Hoàng Lan', N'22A, Liên ấp 123, Vĩnh Lộc B, Bình Chánh, TPHCM', N'0723455443')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SoDT]) VALUES (N'NCC003', N'Hưng Bảo', N'102/3G, xã Tân Xuân, huyện Hóc Môn', N'0757221489')
INSERT [dbo].[NHACUNGCAP] ([MaNCC], [TenNCC], [DiaChi], [SoDT]) VALUES (N'NCC004', N'Kim Phúc', N'125 Nguyễn Kiệm, quận Gò Vấp, TPHCM', N'0238736479')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [CMND], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV001', N'Nguyễn Huỳnh Bá Huy', CAST(N'1998-10-25' AS Date), N'234516785', N'Nam', N'huyện Bình Chánh, TP HCM', N'0762836505', CAST(N'2019-09-30' AS Date))
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [CMND], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV002', N'Nguyễn Ngọc Tuấn Khôi', CAST(N'1998-10-30' AS Date), N'768231450', N'Nam', N'huyện Hóc Môn, TP HCM', N'0956437873', CAST(N'2019-09-20' AS Date))
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [CMND], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV003', N'Phạm Văn Thanh', CAST(N'1999-11-11' AS Date), N'934448559', N'Nam', N'quận Tân Phú, TP HCM', N'0984747474', CAST(N'2019-10-11' AS Date))
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [CMND], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV004', N'Hoàng Thị Lan', CAST(N'2000-02-03' AS Date), N'304899595', N'Nữ', N'quận Gò Vấp, TP HCM', N'0758589329', CAST(N'2019-10-14' AS Date))
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [CMND], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV005', N'Lê Kim Anh', CAST(N'2001-07-31' AS Date), N'248589500', N'Nữ', N'quận Gò Vấp, TP HCM', N'0947447478', CAST(N'2019-10-15' AS Date))
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTenNV], [NgaySinh], [CMND], [GioiTinh], [DiaChi], [SoDT], [NgayVaoLam]) VALUES (N'NV006', N'Phạm Hoàng Đức', CAST(N'2000-09-09' AS Date), N'859598939', N'Nam', N'quận Phú Nhuận, TP HCM', N'0885756747', CAST(N'2019-11-11' AS Date))
INSERT [dbo].[NHOMNGUOIDUNG] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'NHOM001', N'Admin', NULL)
INSERT [dbo].[NHOMNGUOIDUNG] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'NHOM002', N'Nhân Viên', NULL)
INSERT [dbo].[NHOMNGUOIDUNG] ([MaNhom], [TenNhom], [GhiChu]) VALUES (N'NHOM003', N'Quản lý', NULL)
INSERT [dbo].[PHIEUNHAP] ([MaPN], [TongSoLuongNhap], [TongGiaTriNhap], [NgayNhap], [MaNCC], [MaNV], [TienNo]) VALUES (N'PN00001', 100, 1500000, CAST(N'2019-08-10' AS Date), N'NCC001', NULL, NULL)
INSERT [dbo].[PHIEUNHAP] ([MaPN], [TongSoLuongNhap], [TongGiaTriNhap], [NgayNhap], [MaNCC], [MaNV], [TienNo]) VALUES (N'PN00002', 100, 800000, CAST(N'2019-08-10' AS Date), N'NCC001', NULL, NULL)
INSERT [dbo].[PHIEUNHAP] ([MaPN], [TongSoLuongNhap], [TongGiaTriNhap], [NgayNhap], [MaNCC], [MaNV], [TienNo]) VALUES (N'PNE2B18skX', 15, 107500, CAST(N'2019-12-08' AS Date), N'NCC001', N'NV006', 7500)
INSERT [dbo].[PHIEUNHAP] ([MaPN], [TongSoLuongNhap], [TongGiaTriNhap], [NgayNhap], [MaNCC], [MaNV], [TienNo]) VALUES (N'PNLVGQ95ZQ', 70, 3362500, CAST(N'2019-12-08' AS Date), N'NCC002', N'NV003', 362500)
INSERT [dbo].[PHIEUNHAP] ([MaPN], [TongSoLuongNhap], [TongGiaTriNhap], [NgayNhap], [MaNCC], [MaNV], [TienNo]) VALUES (N'PNo8T9ez55', 30, 270000, CAST(N'2019-12-11' AS Date), N'NCC002', N'NV006', 70000)
INSERT [dbo].[PHIEUNHAP] ([MaPN], [TongSoLuongNhap], [TongGiaTriNhap], [NgayNhap], [MaNCC], [MaNV], [TienNo]) VALUES (N'PNr5IW4391', 4, 22750, CAST(N'2019-12-08' AS Date), N'NCC001', N'NV003', 2000)
INSERT [dbo].[TAMTINH] ([MaTamTinh], [TienBan], [GioDatBan], [MaBan], [MaKhach], [MaNV], [TienChuyenBan]) VALUES (N'TT0fz3o6PA', 0, CAST(N'2019-12-15 15:26:50.027' AS DateTime), N'BIDA014', N'KH2WZ24kOT', N'NV003', 20000)
INSERT [dbo].[TAMTINH] ([MaTamTinh], [TienBan], [GioDatBan], [MaBan], [MaKhach], [MaNV], [TienChuyenBan]) VALUES (N'TT6K06ISz8', 20000, CAST(N'2019-12-13 20:41:20.000' AS DateTime), N'BIDA002', N'KHX3oU8v3r', N'NV002', 0)
INSERT [dbo].[TAMTINH] ([MaTamTinh], [TienBan], [GioDatBan], [MaBan], [MaKhach], [MaNV], [TienChuyenBan]) VALUES (N'TTf2k8iJo8', 0, CAST(N'2019-12-15 15:27:57.557' AS DateTime), N'BIDA006', N'KHRjY20t78', N'NV005', 40000)
INSERT [dbo].[TRANGTHAIBAN] ([MaTrangThai], [TenTrangThai], [Mau]) VALUES (N'MTT001', N'Sẵn sàng đón khách', N'Office 2007 Green')
INSERT [dbo].[TRANGTHAIBAN] ([MaTrangThai], [TenTrangThai], [Mau]) VALUES (N'MTT002', N'Có khách', N'Caramel')
INSERT [dbo].[TRANGTHAIBAN] ([MaTrangThai], [TenTrangThai], [Mau]) VALUES (N'MTT003', N'Đang sửa chữa', N'Office 2007 Silver')
INSERT [dbo].[TRANGTHAIBAN] ([MaTrangThai], [TenTrangThai], [Mau]) VALUES (N'MTT004', N'Đang dọn dẹp', N'Office 2007 Pink')
ALTER TABLE [dbo].[BANBIDA]  WITH CHECK ADD  CONSTRAINT [FK_BANBIDA_LOAIBANBIDA] FOREIGN KEY([MaLoaiBan])
REFERENCES [dbo].[LOAIBANBIDA] ([MaLoaiBan])
GO
ALTER TABLE [dbo].[BANBIDA] CHECK CONSTRAINT [FK_BANBIDA_LOAIBANBIDA]
GO
ALTER TABLE [dbo].[BANBIDA]  WITH CHECK ADD  CONSTRAINT [FK_BANBIDA_TRANGTHAIBAN] FOREIGN KEY([MaTrangThai])
REFERENCES [dbo].[TRANGTHAIBAN] ([MaTrangThai])
GO
ALTER TABLE [dbo].[BANBIDA] CHECK CONSTRAINT [FK_BANBIDA_TRANGTHAIBAN]
GO
ALTER TABLE [dbo].[CT_HOADON]  WITH CHECK ADD  CONSTRAINT [FK_CT_HOADON_HANGHOA] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HANGHOA] ([MaHang])
GO
ALTER TABLE [dbo].[CT_HOADON] CHECK CONSTRAINT [FK_CT_HOADON_HANGHOA]
GO
ALTER TABLE [dbo].[CT_HOADON]  WITH CHECK ADD  CONSTRAINT [FK_CT_HOADON_HOADON] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HOADON] ([MaHD])
GO
ALTER TABLE [dbo].[CT_HOADON] CHECK CONSTRAINT [FK_CT_HOADON_HOADON]
GO
ALTER TABLE [dbo].[CT_NHOMNGUOIDUNG_MANHINH]  WITH CHECK ADD  CONSTRAINT [FK_CT_NHOMNGUOIDUNG_MANHINH_MANHINH] FOREIGN KEY([MaManHinh])
REFERENCES [dbo].[MANHINH] ([MaManHinh])
GO
ALTER TABLE [dbo].[CT_NHOMNGUOIDUNG_MANHINH] CHECK CONSTRAINT [FK_CT_NHOMNGUOIDUNG_MANHINH_MANHINH]
GO
ALTER TABLE [dbo].[CT_NHOMNGUOIDUNG_MANHINH]  WITH CHECK ADD  CONSTRAINT [FK_CT_NHOMNGUOIDUNG_MANHINH_NHOMNGUOIDUNG] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NHOMNGUOIDUNG] ([MaNhom])
GO
ALTER TABLE [dbo].[CT_NHOMNGUOIDUNG_MANHINH] CHECK CONSTRAINT [FK_CT_NHOMNGUOIDUNG_MANHINH_NHOMNGUOIDUNG]
GO
ALTER TABLE [dbo].[CT_NHOMNGUOIDUNG_NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_CT_NHOMNGUOIDUNG_NGUOIDUNG_NGUOIDUNG] FOREIGN KEY([TenDangNhap])
REFERENCES [dbo].[NGUOIDUNG] ([TenDangNhap])
GO
ALTER TABLE [dbo].[CT_NHOMNGUOIDUNG_NGUOIDUNG] CHECK CONSTRAINT [FK_CT_NHOMNGUOIDUNG_NGUOIDUNG_NGUOIDUNG]
GO
ALTER TABLE [dbo].[CT_NHOMNGUOIDUNG_NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_CT_NHOMNGUOIDUNG_NGUOIDUNG_NHOMNGUOIDUNG] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NHOMNGUOIDUNG] ([MaNhom])
GO
ALTER TABLE [dbo].[CT_NHOMNGUOIDUNG_NGUOIDUNG] CHECK CONSTRAINT [FK_CT_NHOMNGUOIDUNG_NGUOIDUNG_NHOMNGUOIDUNG]
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUNHAP_HANGHOA] FOREIGN KEY([MaHang])
REFERENCES [dbo].[HANGHOA] ([MaHang])
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP] CHECK CONSTRAINT [FK_CT_PHIEUNHAP_HANGHOA]
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUNHAP_PHIEUNHAP] FOREIGN KEY([MaPN])
REFERENCES [dbo].[PHIEUNHAP] ([MaPN])
GO
ALTER TABLE [dbo].[CT_PHIEUNHAP] CHECK CONSTRAINT [FK_CT_PHIEUNHAP_PHIEUNHAP]
GO
ALTER TABLE [dbo].[DATBANBIDA]  WITH CHECK ADD  CONSTRAINT [FK_DATBANBIDA_BANBIDA] FOREIGN KEY([MaBan])
REFERENCES [dbo].[BANBIDA] ([MaBan])
GO
ALTER TABLE [dbo].[DATBANBIDA] CHECK CONSTRAINT [FK_DATBANBIDA_BANBIDA]
GO
ALTER TABLE [dbo].[HANGHOA]  WITH CHECK ADD  CONSTRAINT [FK_HANGHOA_LOAIHANG] FOREIGN KEY([MaLoai])
REFERENCES [dbo].[LOAIHANG] ([MaLoai])
GO
ALTER TABLE [dbo].[HANGHOA] CHECK CONSTRAINT [FK_HANGHOA_LOAIHANG]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_BANBIDA] FOREIGN KEY([MaBan])
REFERENCES [dbo].[BANBIDA] ([MaBan])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_BANBIDA]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_KHACHHANG] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KHACHHANG] ([MaKH])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_KHACHHANG]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_NHANVIEN]
GO
ALTER TABLE [dbo].[NGUOIDUNG]  WITH CHECK ADD  CONSTRAINT [FK_NGUOIDUNG_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[NGUOIDUNG] CHECK CONSTRAINT [FK_NGUOIDUNG_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NHACUNGCAP] ([MaNCC])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHANVIEN] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHANVIEN]
GO
USE [master]
GO
ALTER DATABASE [QLQuanBIDA] SET  READ_WRITE 
GO
