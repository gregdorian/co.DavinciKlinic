USE master
IF EXISTS(select * from sys.databases where name='DavinciKlinicDB')
DROP DATABASE DavinciKlinicDB

GO

CREATE DATABASE DavinciKlinicDB

GO

USE [DavinciKlinicDB]
GO
--ALTER TABLE [dbo].[FacturaVenta] DROP CONSTRAINT [FK_FacturaVenta_IdCliente]
--GO
--ALTER TABLE [dbo].[ItemFactura] DROP CONSTRAINT [FK_ItemFactura_IdProducto]
--GO
--ALTER TABLE [dbo].[ItemFactura] DROP CONSTRAINT [FK_ItemFactura__IdFacturaVenta]
--GO
--/****** Object:  Table [dbo].[Productos]    Script Date: 3/05/2021 1:01:58 p. m. ******/
--DROP TABLE [dbo].[Productos]
--GO
--/****** Object:  Table [dbo].[FacturaVenta]    Script Date: 3/05/2021 1:01:58 p. m. ******/
--DROP TABLE [dbo].[FacturaVenta]
--GO
--/****** Object:  Table [dbo].[ItemFactura]    Script Date: 3/05/2021 1:01:58 p. m. ******/
--DROP TABLE [dbo].[ItemFactura]
--GO
--/****** Object:  Table [dbo].[Clientes]    Script Date: 3/05/2021 1:01:58 p. m. ******/
--DROP TABLE [dbo].[Clientes]
--GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 3/05/2021 1:01:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[CodigoCliente] [nvarchar](5) NOT NULL,
	[NombreCliente] [nvarchar](20) NULL,
	[DireccionCliente] [nvarchar](60) NULL,
	[TelefonoCliente] [nvarchar](10) NULL,
	[DescripcionCliente] [nvarchar](10) NULL,
	[FechaIngreso] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemFactura]    Script Date: 3/05/2021 1:01:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemFactura](
	[IdItemFactura] [int] IDENTITY(1,1) NOT NULL,
	[IdFacturaVenta] [int] NULL,
	[IdProducto] [int] NULL,
	[CodigoProducto] [nvarchar](5) NOT NULL,
	[NombreProducto] [nvarchar](30) NULL,
	[Descuento] [decimal](18, 0) NULL,
	[Cantidad] [smallint] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdItemFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FacturaVenta]    Script Date: 3/05/2021 1:01:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FacturaVenta](
	[IdFacturaVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NULL,
	[NumeroFactura] [nvarchar](6) NOT NULL,
	[Sub_Total] [decimal](18, 0) NULL,
	[Impuesto] [decimal](18, 0) NULL,
	[Total] [decimal](18, 0) NULL,
	[FechaFactura] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdFacturaVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 3/05/2021 1:01:58 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[CodigoProducto] [nvarchar](5) NOT NULL,
	[NombreProducto] [nvarchar](30) NULL,
	[PrecioUnitario] [decimal](18, 0) NULL,
	[PrecioCosto] [decimal](18, 0) NULL,
	[Stock] [smallint] NULL,
	[StockMinimo] [smallint] NULL,
	[FechaIngreso] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 
GO
INSERT [dbo].[Clientes] ([IdCliente], [CodigoCliente], [NombreCliente], [DireccionCliente], [TelefonoCliente], [DescripcionCliente], [FechaIngreso]) VALUES (1, N'0PSZ', N'Sheff Banham', N'91 Sutteridge Hill', N'183 5740', N'Peru', CAST(N'2018-12-14T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Clientes] ([IdCliente], [CodigoCliente], [NombreCliente], [DireccionCliente], [TelefonoCliente], [DescripcionCliente], [FechaIngreso]) VALUES (2, N'0BJZ', N'Gill Please', N'6 Kinsman Point', N'389 8090', N'Malta', CAST(N'2018-12-24T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Clientes] ([IdCliente], [CodigoCliente], [NombreCliente], [DireccionCliente], [TelefonoCliente], [DescripcionCliente], [FechaIngreso]) VALUES (3, N'09HZ', N'Paten Huglin', N'48512 Ridgeway Point', N'647 8987', N'Greece', CAST(N'2019-02-03T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Clientes] ([IdCliente], [CodigoCliente], [NombreCliente], [DireccionCliente], [TelefonoCliente], [DescripcionCliente], [FechaIngreso]) VALUES (4, N'06QZ', N'Gwenette Shawell', N'903 Pankratz Plaza', N'923 4461', N'China', CAST(N'2018-09-10T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Clientes] ([IdCliente], [CodigoCliente], [NombreCliente], [DireccionCliente], [TelefonoCliente], [DescripcionCliente], [FechaIngreso]) VALUES (5, N'0F9Z', N'Sileas Yeell', N'3 Del Mar Park', N'273 7261', N'Russia', CAST(N'2018-09-06T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Clientes] ([IdCliente], [CodigoCliente], [NombreCliente], [DireccionCliente], [TelefonoCliente], [DescripcionCliente], [FechaIngreso]) VALUES (6, N'0FWZ', N'Lemmy Carloni', N'700 Utah Court', N'457 1108', N'Croatia', CAST(N'2018-05-01T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Clientes] ([IdCliente], [CodigoCliente], [NombreCliente], [DireccionCliente], [TelefonoCliente], [DescripcionCliente], [FechaIngreso]) VALUES (8, N'CP1Z', N'Fallon Butterfint', N'01 Becker Park', N'991 5915', N'Sweden', CAST(N'2018-09-28T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Clientes] ([IdCliente], [CodigoCliente], [NombreCliente], [DireccionCliente], [TelefonoCliente], [DescripcionCliente], [FechaIngreso]) VALUES (9, N'089Z', N'Natale MacIllrick', N'20214 Hazelcrest Center', N'756 4058', N'Brazil', CAST(N'2018-12-20T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Clientes] ([IdCliente], [CodigoCliente], [NombreCliente], [DireccionCliente], [TelefonoCliente], [DescripcionCliente], [FechaIngreso]) VALUES (10, N'0LZZ', N'Hartley Chedgey', N'3892 Park Meadow Circle', N'338 2852', N'Indonesia', CAST(N'2019-02-05T00:00:00' AS SmallDateTime))
GO
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[ItemFactura] ON 
GO
INSERT [dbo].[ItemFactura] ([IdItemFactura], [IdFacturaVenta], [IdProducto], [CodigoProducto], [NombreProducto], [Descuento], [Cantidad]) VALUES (0, 1, 4, N'9239', N'Soup - Boston Clam Chowder', CAST(5 AS Decimal(18, 0)), 10)
GO
INSERT [dbo].[ItemFactura] ([IdItemFactura], [IdFacturaVenta], [IdProducto], [CodigoProducto], [NombreProducto], [Descuento], [Cantidad]) VALUES (1, 1, 12, N'3378', N'Pie Shell - 9', CAST(2 AS Decimal(18, 0)), 65)
GO
INSERT [dbo].[ItemFactura] ([IdItemFactura], [IdFacturaVenta], [IdProducto], [CodigoProducto], [NombreProducto], [Descuento], [Cantidad]) VALUES (2, 2, 8, N'7132', N'Toothpick Frilled', CAST(5 AS Decimal(18, 0)), 10)
GO
INSERT [dbo].[ItemFactura] ([IdItemFactura], [IdFacturaVenta], [IdProducto], [CodigoProducto], [NombreProducto], [Descuento], [Cantidad]) VALUES (3, 2, 14, N'5052', N'Cardamon Seed / Pod', CAST(2 AS Decimal(18, 0)), 56)
GO
INSERT [dbo].[ItemFactura] ([IdItemFactura], [IdFacturaVenta], [IdProducto], [CodigoProducto], [NombreProducto], [Descuento], [Cantidad]) VALUES (4, 2, 17, N'6775', N'Bread - 10 Grain Parisian', CAST(3 AS Decimal(18, 0)), 10)
GO
INSERT [dbo].[ItemFactura] ([IdItemFactura], [IdFacturaVenta], [IdProducto], [CodigoProducto], [NombreProducto], [Descuento], [Cantidad]) VALUES (5, 3, 17, N'6775', N'Bread - 10 Grain Parisian', CAST(5 AS Decimal(18, 0)), 10)
GO
INSERT [dbo].[ItemFactura] ([IdItemFactura], [IdFacturaVenta], [IdProducto], [CodigoProducto], [NombreProducto], [Descuento], [Cantidad]) VALUES (6, 3, 15, N'0101', N'Beef - Cow Feet Split', CAST(3 AS Decimal(18, 0)), 52)
GO
INSERT [dbo].[ItemFactura] ([IdItemFactura], [IdFacturaVenta], [IdProducto], [CodigoProducto], [NombreProducto], [Descuento], [Cantidad]) VALUES (7, 4, 15, N'0101', N'Beef - Cow Feet Split', CAST(2 AS Decimal(18, 0)), 6)
GO
INSERT [dbo].[ItemFactura] ([IdItemFactura], [IdFacturaVenta], [IdProducto], [CodigoProducto], [NombreProducto], [Descuento], [Cantidad]) VALUES (8, 4, 19, N'7910', N'Mint - Fresh', CAST(2 AS Decimal(18, 0)), 10)
GO
SET IDENTITY_INSERT [dbo].[ItemFactura] OFF
GO
SET IDENTITY_INSERT [dbo].[FacturaVenta] ON 
GO
INSERT [dbo].[FacturaVenta] ([IdFacturaVenta], [IdCliente], [NumeroFactura], [Sub_Total], [Impuesto], [Total], [FechaFactura]) VALUES (1, 6, N'270', CAST(49569 AS Decimal(18, 0)), CAST(16 AS Decimal(18, 0)), CAST(57501 AS Decimal(18, 0)), CAST(N'2019-03-07T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[FacturaVenta] ([IdFacturaVenta], [IdCliente], [NumeroFactura], [Sub_Total], [Impuesto], [Total], [FechaFactura]) VALUES (2, 2, N'1719', CAST(571238 AS Decimal(18, 0)), CAST(16 AS Decimal(18, 0)), CAST(662636 AS Decimal(18, 0)), CAST(N'2019-03-07T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[FacturaVenta] ([IdFacturaVenta], [IdCliente], [NumeroFactura], [Sub_Total], [Impuesto], [Total], [FechaFactura]) VALUES (3, 4, N'2465', CAST(469162 AS Decimal(18, 0)), CAST(12 AS Decimal(18, 0)), CAST(525461 AS Decimal(18, 0)), CAST(N'2019-03-07T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[FacturaVenta] ([IdFacturaVenta], [IdCliente], [NumeroFactura], [Sub_Total], [Impuesto], [Total], [FechaFactura]) VALUES (4, 8, N'2007', CAST(100438 AS Decimal(18, 0)), CAST(19 AS Decimal(18, 0)), CAST(119522 AS Decimal(18, 0)), CAST(N'2019-03-07T00:00:00' AS SmallDateTime))
GO
SET IDENTITY_INSERT [dbo].[FacturaVenta] OFF
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (1, N'6446', N'Soup - Knorr, Chicken Noodle', CAST(515 AS Decimal(18, 0)), CAST(16 AS Decimal(18, 0)), 49, 11, CAST(N'2018-10-25T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (2, N'4885', N'Chilli Paste, Sambal Oelek', CAST(7426 AS Decimal(18, 0)), CAST(862 AS Decimal(18, 0)), 46, 35, CAST(N'2018-06-01T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (3, N'1336', N'Kale - Red', CAST(5995 AS Decimal(18, 0)), CAST(851 AS Decimal(18, 0)), 51, 64, CAST(N'2018-10-17T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (4, N'9239', N'Soup - Boston Clam Chowder', CAST(3394 AS Decimal(18, 0)), CAST(975 AS Decimal(18, 0)), 17, 21, CAST(N'2018-12-30T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (5, N'3277', N'Soup - Campbells', CAST(4865 AS Decimal(18, 0)), CAST(128 AS Decimal(18, 0)), 84, 41, CAST(N'2018-03-12T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (6, N'2083', N'Cookie Dough - Chocolate Chip', CAST(6061 AS Decimal(18, 0)), CAST(949 AS Decimal(18, 0)), 6, 45, CAST(N'2018-09-30T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (7, N'6122', N'Pasta - Shells, Medium, Dry', CAST(1863 AS Decimal(18, 0)), CAST(992 AS Decimal(18, 0)), 83, 6, CAST(N'2019-01-17T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (8, N'7132', N'Toothpick Frilled', CAST(3315 AS Decimal(18, 0)), CAST(923 AS Decimal(18, 0)), 21, 36, CAST(N'2018-03-18T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (9, N'4922', N'Savory', CAST(2685 AS Decimal(18, 0)), CAST(782 AS Decimal(18, 0)), 67, 65, CAST(N'2019-02-02T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (10, N'5525', N'Salt - Sea', CAST(2789 AS Decimal(18, 0)), CAST(697 AS Decimal(18, 0)), 53, 64, CAST(N'2018-11-20T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (11, N'4482', N'Vaccum Bag 10x13', CAST(2237 AS Decimal(18, 0)), CAST(296 AS Decimal(18, 0)), 45, 2, CAST(N'2019-01-18T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (12, N'3378', N'Pie Shell - 9', CAST(272 AS Decimal(18, 0)), CAST(873 AS Decimal(18, 0)), 31, 80, CAST(N'2018-07-20T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (13, N'3290', N'Urban Zen Drinks', CAST(7552 AS Decimal(18, 0)), CAST(969 AS Decimal(18, 0)), 47, 4, CAST(N'2018-12-12T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (14, N'5052', N'Cardamon Seed / Pod', CAST(9677 AS Decimal(18, 0)), CAST(484 AS Decimal(18, 0)), 62, 78, CAST(N'2018-05-25T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (15, N'0101', N'Beef - Cow Feet Split', CAST(9133 AS Decimal(18, 0)), CAST(693 AS Decimal(18, 0)), 25, 57, CAST(N'2018-12-18T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (16, N'3134', N'Oil - Olive', CAST(3296 AS Decimal(18, 0)), CAST(643 AS Decimal(18, 0)), 90, 28, CAST(N'2018-09-30T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (17, N'6775', N'Bread - 10 Grain Parisian', CAST(894 AS Decimal(18, 0)), CAST(357 AS Decimal(18, 0)), 9, 81, CAST(N'2019-01-04T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (18, N'5786', N'Seedlings - Mix, Organic', CAST(7818 AS Decimal(18, 0)), CAST(443 AS Decimal(18, 0)), 12, 95, CAST(N'2018-03-07T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (19, N'7910', N'Mint - Fresh', CAST(4769 AS Decimal(18, 0)), CAST(966 AS Decimal(18, 0)), 60, 49, CAST(N'2018-09-01T00:00:00' AS SmallDateTime))
GO
INSERT [dbo].[Productos] ([IdProducto], [CodigoProducto], [NombreProducto], [PrecioUnitario], [PrecioCosto], [Stock], [StockMinimo], [FechaIngreso]) VALUES (20, N'0791', N'Nut - Natural', CAST(654 AS Decimal(18, 0)), CAST(777 AS Decimal(18, 0)), 42, 89, CAST(N'2018-06-29T00:00:00' AS SmallDateTime))
GO
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
ALTER TABLE [dbo].[ItemFactura]  WITH CHECK ADD FOREIGN KEY([IdFacturaVenta])
REFERENCES [dbo].[FacturaVenta] ([IdFacturaVenta])
GO
ALTER TABLE [dbo].[ItemFactura]  WITH CHECK ADD FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Productos] ([IdProducto])
GO
ALTER TABLE [dbo].[FacturaVenta]  WITH CHECK ADD FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Clientes] ([IdCliente])
GO