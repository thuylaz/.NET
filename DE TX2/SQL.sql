USE [QLBH]
GO
/****** Object:  Table [dbo].[NhomHang]    Script Date: 6/13/2022 2:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomHang](
	[MaNhomHang] [int] NOT NULL,
	[TenNhomHang] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhomHang] PRIMARY KEY CLUSTERED 
(
	[MaNhomHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 6/13/2022 2:29:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] NOT NULL,
	[TenSanPham] [nvarchar](50) NOT NULL,
	[DonGia] [int] NOT NULL,
	[SoLuongBan] [int] NOT NULL,
	[MaNhomHang] [int] NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[NhomHang] ([MaNhomHang], [TenNhomHang]) VALUES (1, N'NhomHang1')
INSERT [dbo].[NhomHang] ([MaNhomHang], [TenNhomHang]) VALUES (2, N'NhomHang2')
INSERT [dbo].[NhomHang] ([MaNhomHang], [TenNhomHang]) VALUES (3, N'NhomHang3')
GO
INSERT [dbo].[SanPham] ([MaSP], [TenSanPham], [DonGia], [SoLuongBan], [MaNhomHang]) VALUES (1, N'SanPham1', 10000, 3, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSanPham], [DonGia], [SoLuongBan], [MaNhomHang]) VALUES (2, N'SanPham2', 20000, 6, 2)
INSERT [dbo].[SanPham] ([MaSP], [TenSanPham], [DonGia], [SoLuongBan], [MaNhomHang]) VALUES (3, N'SanPham3', 30000, 9, 3)
INSERT [dbo].[SanPham] ([MaSP], [TenSanPham], [DonGia], [SoLuongBan], [MaNhomHang]) VALUES (4, N'SanPham4', 40000, 12, 2)
INSERT [dbo].[SanPham] ([MaSP], [TenSanPham], [DonGia], [SoLuongBan], [MaNhomHang]) VALUES (5, N'Sanpham5', 50000, 15, 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSanPham], [DonGia], [SoLuongBan], [MaNhomHang]) VALUES (6, N'SanPham6', 60000, 18, 2)
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_SanPham]
GO
