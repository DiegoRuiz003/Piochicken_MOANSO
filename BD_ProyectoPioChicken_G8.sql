USE [BDProyectoBrasasPioChickenV3]
GO
/****** Object:  UserDefinedTableType [dbo].[Detalle_NotaVenta]    Script Date: 21/11/2023 11:07:32 ******/
CREATE TYPE [dbo].[Detalle_NotaVenta] AS TABLE(
	[Id] [int] NULL,
	[IdNotaVenta] [int] NULL,
	[IdPlato] [varchar](5) NULL,
	[Cantidad] [int] NULL,
	[Precio] [decimal](12, 2) NULL,
	[SubTotal] [decimal](12, 2) NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[EDetalle_NotaVenta]    Script Date: 21/11/2023 11:07:32 ******/
CREATE TYPE [dbo].[EDetalle_NotaVenta] AS TABLE(
	[Id] [int] NULL,
	[IdNotaVenta] [int] NULL,
	[IdPlato] [varchar](5) NULL,
	[Cantidad] [int] NULL,
	[Precio] [decimal](12, 2) NULL,
	[SubTotal] [decimal](12, 2) NULL
)
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Dni] [varchar](8) NOT NULL,
	[Telefono] [varchar](9) NULL,
	[Correo] [varchar](150) NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Detalle_NotaVenta]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Detalle_NotaVenta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdNotaVenta] [int] NOT NULL,
	[IdPlato] [varchar](5) NULL,
	[Cantidad] [int] NOT NULL,
	[Precio] [decimal](12, 2) NOT NULL,
	[SubTotal] [decimal](12, 2) NOT NULL,
 CONSTRAINT [PK_Detalle_NotaVenta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Insumo]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Insumo](
	[InsumoID] [nvarchar](10) NOT NULL,
	[CantidadInsumo] [int] NOT NULL,
	[TipoinsumoID] [nvarchar](10) NOT NULL,
	[EstadoInsumo] [bit] NOT NULL,
	[NombreInsumo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Insumo] PRIMARY KEY CLUSTERED 
(
	[InsumoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InsumoPlato]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InsumoPlato](
	[PlatoID] [nvarchar](10) NOT NULL,
	[InsumoID] [nvarchar](10) NOT NULL,
	[EstadoInsumoPlato] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PlatoID] ASC,
	[InsumoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MetodoPago]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MetodoPago](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MetodoPago] [varchar](50) NULL,
	[Estado] [bit] NULL,
 CONSTRAINT [PK_MetodoPago] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotaVenta]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotaVenta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Total] [decimal](12, 2) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_NotaVenta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pago]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pago](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdMetodoPago] [int] NOT NULL,
	[IdNotaVenta] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
	[Total] [decimal](12, 2) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Pago] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Plato]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Plato](
	[PlatoID] [nvarchar](10) NOT NULL,
	[EstadoPlato] [bit] NULL,
	[TipoplatoID] [nvarchar](10) NOT NULL,
	[NombrePlato] [nvarchar](50) NULL,
	[PrecioPlato] [decimal](10, 2) NULL,
 CONSTRAINT [PK_Plato] PRIMARY KEY CLUSTERED 
(
	[PlatoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PlatoR]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlatoR](
	[Id] [varchar](5) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[IdTipoPlato] [int] NOT NULL,
	[Precio] [decimal](10, 2) NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[RazonSocial] [varchar](100) NOT NULL,
	[Telefono] [varchar](9) NOT NULL,
	[Estado] [bit] NULL,
	[Direccion] [varchar](100) NULL,
	[Correo] [varchar](64) NULL,
	[RUC] [varchar](11) NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipoinsumo]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipoinsumo](
	[NombreTipoInsumo] [nvarchar](50) NULL,
	[TipoinsumoID] [nvarchar](10) NOT NULL,
	[EstadoTipoInsumo] [bit] NULL,
 CONSTRAINT [PK_Tipoinsumo] PRIMARY KEY CLUSTERED 
(
	[TipoinsumoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipoplato]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipoplato](
	[NombreTipoPlato] [nvarchar](50) NULL,
	[TipoplatoID] [nvarchar](10) NOT NULL,
	[EstadoTipoPlato] [bit] NULL,
 CONSTRAINT [PK_Tipoplato] PRIMARY KEY CLUSTERED 
(
	[TipoplatoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPlatoR]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPlatoR](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([Id], [Nombre], [Dni], [Telefono], [Correo], [Estado]) VALUES (1, N'Diego Ruiz', N'70820348', N'961302287', N'ruizrecharted@gmail.com', 1)
INSERT [dbo].[Cliente] ([Id], [Nombre], [Dni], [Telefono], [Correo], [Estado]) VALUES (2, N'Diego', N'70879834', N'987654456', N'ochoa@gmail.com', 0)
INSERT [dbo].[Cliente] ([Id], [Nombre], [Dni], [Telefono], [Correo], [Estado]) VALUES (3, N'Brayan Jose Sanchez', N'70879835', N'990780670', N'sanchez@gmail.com', 1)
INSERT [dbo].[Cliente] ([Id], [Nombre], [Dni], [Telefono], [Correo], [Estado]) VALUES (4, N'Diego Ochoa', N'76421739', N'94851252', N'ochoa@gmail.com', 0)
INSERT [dbo].[Cliente] ([Id], [Nombre], [Dni], [Telefono], [Correo], [Estado]) VALUES (5, N'Diego Ochoa', N'76421739', N'949701458', N'ochoa@gamil.com', 1)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([Id], [Nombre], [Estado]) VALUES (1, N'Diego', 1)
INSERT [dbo].[Clientes] ([Id], [Nombre], [Estado]) VALUES (2, N'Tony', 1)
INSERT [dbo].[Clientes] ([Id], [Nombre], [Estado]) VALUES (1002, N'Alejandro', 1)
INSERT [dbo].[Clientes] ([Id], [Nombre], [Estado]) VALUES (2002, N'', 0)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Detalle_NotaVenta] ON 

INSERT [dbo].[Detalle_NotaVenta] ([Id], [IdNotaVenta], [IdPlato], [Cantidad], [Precio], [SubTotal]) VALUES (31, 47, N'PAB04', 5, CAST(13.00 AS Decimal(12, 2)), CAST(65.00 AS Decimal(12, 2)))
INSERT [dbo].[Detalle_NotaVenta] ([Id], [IdNotaVenta], [IdPlato], [Cantidad], [Precio], [SubTotal]) VALUES (32, 48, N'PAB03', 6, CAST(19.00 AS Decimal(12, 2)), CAST(114.00 AS Decimal(12, 2)))
INSERT [dbo].[Detalle_NotaVenta] ([Id], [IdNotaVenta], [IdPlato], [Cantidad], [Precio], [SubTotal]) VALUES (33, 48, N'PRL05', 7, CAST(14.00 AS Decimal(12, 2)), CAST(98.00 AS Decimal(12, 2)))
INSERT [dbo].[Detalle_NotaVenta] ([Id], [IdNotaVenta], [IdPlato], [Cantidad], [Precio], [SubTotal]) VALUES (34, 49, N'PAB04', 4, CAST(13.00 AS Decimal(12, 2)), CAST(52.00 AS Decimal(12, 2)))
INSERT [dbo].[Detalle_NotaVenta] ([Id], [IdNotaVenta], [IdPlato], [Cantidad], [Precio], [SubTotal]) VALUES (35, 50, N'PRL06', 2, CAST(13.00 AS Decimal(12, 2)), CAST(26.00 AS Decimal(12, 2)))
INSERT [dbo].[Detalle_NotaVenta] ([Id], [IdNotaVenta], [IdPlato], [Cantidad], [Precio], [SubTotal]) VALUES (36, 50, N'PAB01', 2, CAST(60.00 AS Decimal(12, 2)), CAST(120.00 AS Decimal(12, 2)))
INSERT [dbo].[Detalle_NotaVenta] ([Id], [IdNotaVenta], [IdPlato], [Cantidad], [Precio], [SubTotal]) VALUES (37, 52, N'PRL06', 2, CAST(13.00 AS Decimal(12, 2)), CAST(26.00 AS Decimal(12, 2)))
INSERT [dbo].[Detalle_NotaVenta] ([Id], [IdNotaVenta], [IdPlato], [Cantidad], [Precio], [SubTotal]) VALUES (38, 52, N'PAB01', 1, CAST(60.00 AS Decimal(12, 2)), CAST(60.00 AS Decimal(12, 2)))
SET IDENTITY_INSERT [dbo].[Detalle_NotaVenta] OFF
GO
INSERT [dbo].[Insumo] ([InsumoID], [CantidadInsumo], [TipoinsumoID], [EstadoInsumo], [NombreInsumo]) VALUES (N'COST', 20, N'CARN', 1, N'Costillas')
INSERT [dbo].[Insumo] ([InsumoID], [CantidadInsumo], [TipoinsumoID], [EstadoInsumo], [NombreInsumo]) VALUES (N'FILE', 20, N'CARN', 1, N'Filete')
INSERT [dbo].[Insumo] ([InsumoID], [CantidadInsumo], [TipoinsumoID], [EstadoInsumo], [NombreInsumo]) VALUES (N'MUSL', 20, N'POLL', 1, N'Muslos')
INSERT [dbo].[Insumo] ([InsumoID], [CantidadInsumo], [TipoinsumoID], [EstadoInsumo], [NombreInsumo]) VALUES (N'PECH', 20, N'POLL', 1, N'Pechugas')
INSERT [dbo].[Insumo] ([InsumoID], [CantidadInsumo], [TipoinsumoID], [EstadoInsumo], [NombreInsumo]) VALUES (N'PO001', 10, N'VEGE', 1, N' Tallarines')
GO
INSERT [dbo].[InsumoPlato] ([PlatoID], [InsumoID], [EstadoInsumoPlato]) VALUES (N'ASAD', N'COST', 1)
INSERT [dbo].[InsumoPlato] ([PlatoID], [InsumoID], [EstadoInsumoPlato]) VALUES (N'BROC', N'COST', 1)
INSERT [dbo].[InsumoPlato] ([PlatoID], [InsumoID], [EstadoInsumoPlato]) VALUES (N'BROC', N'MUSL', 1)
INSERT [dbo].[InsumoPlato] ([PlatoID], [InsumoID], [EstadoInsumoPlato]) VALUES (N'BROC', N'PECH', 1)
INSERT [dbo].[InsumoPlato] ([PlatoID], [InsumoID], [EstadoInsumoPlato]) VALUES (N'PLB003', N'PECH', 1)
GO
SET IDENTITY_INSERT [dbo].[MetodoPago] ON 

INSERT [dbo].[MetodoPago] ([Id], [MetodoPago], [Estado]) VALUES (1, N'Tarjeta Debito', 1)
INSERT [dbo].[MetodoPago] ([Id], [MetodoPago], [Estado]) VALUES (2, N'Efectivo', 1)
SET IDENTITY_INSERT [dbo].[MetodoPago] OFF
GO
SET IDENTITY_INSERT [dbo].[NotaVenta] ON 

INSERT [dbo].[NotaVenta] ([Id], [IdCliente], [Fecha], [Total], [Estado]) VALUES (47, 1, CAST(N'2023-11-20T22:11:23.373' AS DateTime), CAST(65.00 AS Decimal(12, 2)), 1)
INSERT [dbo].[NotaVenta] ([Id], [IdCliente], [Fecha], [Total], [Estado]) VALUES (48, 2, CAST(N'2023-11-21T02:01:01.533' AS DateTime), CAST(212.00 AS Decimal(12, 2)), 0)
INSERT [dbo].[NotaVenta] ([Id], [IdCliente], [Fecha], [Total], [Estado]) VALUES (49, 1, CAST(N'2023-11-21T08:07:36.087' AS DateTime), CAST(52.00 AS Decimal(12, 2)), 0)
INSERT [dbo].[NotaVenta] ([Id], [IdCliente], [Fecha], [Total], [Estado]) VALUES (50, 5, CAST(N'2023-11-21T10:15:07.143' AS DateTime), CAST(146.00 AS Decimal(12, 2)), 1)
INSERT [dbo].[NotaVenta] ([Id], [IdCliente], [Fecha], [Total], [Estado]) VALUES (51, 1, CAST(N'2023-11-21T10:24:21.083' AS DateTime), CAST(0.00 AS Decimal(12, 2)), 0)
INSERT [dbo].[NotaVenta] ([Id], [IdCliente], [Fecha], [Total], [Estado]) VALUES (52, 5, CAST(N'2023-11-21T10:36:36.470' AS DateTime), CAST(86.00 AS Decimal(12, 2)), 0)
SET IDENTITY_INSERT [dbo].[NotaVenta] OFF
GO
SET IDENTITY_INSERT [dbo].[Pago] ON 

INSERT [dbo].[Pago] ([Id], [IdMetodoPago], [IdNotaVenta], [Fecha], [Total], [Estado]) VALUES (1, 1, 47, CAST(N'2023-11-21T00:00:00.000' AS DateTime), CAST(65.00 AS Decimal(12, 2)), 1)
INSERT [dbo].[Pago] ([Id], [IdMetodoPago], [IdNotaVenta], [Fecha], [Total], [Estado]) VALUES (2, 1, 50, CAST(N'2023-11-21T00:00:00.000' AS DateTime), CAST(146.00 AS Decimal(12, 2)), 1)
SET IDENTITY_INSERT [dbo].[Pago] OFF
GO
INSERT [dbo].[Plato] ([PlatoID], [EstadoPlato], [TipoplatoID], [NombrePlato], [PrecioPlato]) VALUES (N'ASAD', 1, N'PARR', N'Asado de Tira', CAST(60.00 AS Decimal(10, 2)))
INSERT [dbo].[Plato] ([PlatoID], [EstadoPlato], [TipoplatoID], [NombrePlato], [PrecioPlato]) VALUES (N'BROC', 1, N'PARR', N'Brochetas de Carne con Huevo', CAST(50.00 AS Decimal(10, 2)))
INSERT [dbo].[Plato] ([PlatoID], [EstadoPlato], [TipoplatoID], [NombrePlato], [PrecioPlato]) VALUES (N'PLB003', 1, N'POLL', N' Pollo a la Brasa', CAST(60.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[PlatoR] ([Id], [Nombre], [Descripcion], [IdTipoPlato], [Precio], [Estado]) VALUES (N'PAB01', N'1 Pollo a la Brasa', N'Pollo asado con piel crujiente y jugoso interior.', 1, CAST(60.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[PlatoR] ([Id], [Nombre], [Descripcion], [IdTipoPlato], [Precio], [Estado]) VALUES (N'PAB02', N'1/2 Pollo a la Brasa', N'Media porción de pollo asado a la brasa.', 1, CAST(33.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[PlatoR] ([Id], [Nombre], [Descripcion], [IdTipoPlato], [Precio], [Estado]) VALUES (N'PAB03', N'1/4 Pollo a la Brasa', N'Cuarta parte de pollo asado a la brasa.', 1, CAST(19.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[PlatoR] ([Id], [Nombre], [Descripcion], [IdTipoPlato], [Precio], [Estado]) VALUES (N'PAB04', N'1/8 Pollo a la Brasa', N'Octava parte de pollo asado a la brasa.', 1, CAST(13.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[PlatoR] ([Id], [Nombre], [Descripcion], [IdTipoPlato], [Precio], [Estado]) VALUES (N'PRL05', N'LOMO SALTADO CARNE', N'Carne de res salteada con verduras y especias.', 2, CAST(14.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[PlatoR] ([Id], [Nombre], [Descripcion], [IdTipoPlato], [Precio], [Estado]) VALUES (N'PRL06', N'LOMO SALTADO POLLO', N'Pollo salteado con verduras y especias.', 2, CAST(13.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[PlatoR] ([Id], [Nombre], [Descripcion], [IdTipoPlato], [Precio], [Estado]) VALUES (N'PRL07', N'LOMO FINO', N'Preparación gourmet de carne de res finamente cortada.', 2, CAST(25.00 AS Decimal(10, 2)), 1)
GO
SET IDENTITY_INSERT [dbo].[Proveedor] ON 

INSERT [dbo].[Proveedor] ([Id], [Nombre], [RazonSocial], [Telefono], [Estado], [Direccion], [Correo], [RUC]) VALUES (1, N'', N'', N'', 0, N'', N'', N'20123456789')
INSERT [dbo].[Proveedor] ([Id], [Nombre], [RazonSocial], [Telefono], [Estado], [Direccion], [Correo], [RUC]) VALUES (2, N'Luis Rodriguez', N'Rodriguez SAC', N'961302287', 1, N'Jr. Los Pinos 456, Arequipa', N'luis.rodriguez@rodriguezsac.com', N'20234567890')
INSERT [dbo].[Proveedor] ([Id], [Nombre], [RazonSocial], [Telefono], [Estado], [Direccion], [Correo], [RUC]) VALUES (3, N'LUIS OBLITAS', N'LUJAN SAC', N'123456678', 1, N'Calle Los Eucaliptos 789, Trujillo', N'luis.oblitas@lujansac.com', N'20345678901')
INSERT [dbo].[Proveedor] ([Id], [Nombre], [RazonSocial], [Telefono], [Estado], [Direccion], [Correo], [RUC]) VALUES (4, N'Perez', N'PEREZ SAC', N'12345678', 0, N'Av. Los Cedros 321, Cusco', N'perez@perezsac.com', N'20456789012')
INSERT [dbo].[Proveedor] ([Id], [Nombre], [RazonSocial], [Telefono], [Estado], [Direccion], [Correo], [RUC]) VALUES (5, N'Diego', N'Diego SAC', N'12345678', 0, N'Jr. Los Laureles 654, Piura', N'diego@diegosac.com', N'20567890123')
INSERT [dbo].[Proveedor] ([Id], [Nombre], [RazonSocial], [Telefono], [Estado], [Direccion], [Correo], [RUC]) VALUES (6, N'', N'', N'', 0, NULL, NULL, NULL)
INSERT [dbo].[Proveedor] ([Id], [Nombre], [RazonSocial], [Telefono], [Estado], [Direccion], [Correo], [RUC]) VALUES (7, N'Anthony', N'TONY SAC', N'12345678', 0, N'Calle Los Manzanos 987, Iquitos', N'anthony@tonysac.com', N'20678901234')
INSERT [dbo].[Proveedor] ([Id], [Nombre], [RazonSocial], [Telefono], [Estado], [Direccion], [Correo], [RUC]) VALUES (8, N'', N'', N'', 0, NULL, NULL, NULL)
INSERT [dbo].[Proveedor] ([Id], [Nombre], [RazonSocial], [Telefono], [Estado], [Direccion], [Correo], [RUC]) VALUES (9, N'Brayan', N'Brayan.S.A.C', N'946852315', 0, NULL, NULL, NULL)
INSERT [dbo].[Proveedor] ([Id], [Nombre], [RazonSocial], [Telefono], [Estado], [Direccion], [Correo], [RUC]) VALUES (10, N'Juan', N'JuanSAC', N'98721432', 0, N'juan@juansac.com', N'Av. Los Alamos 542, Lima', N'20123126789')
INSERT [dbo].[Proveedor] ([Id], [Nombre], [RazonSocial], [Telefono], [Estado], [Direccion], [Correo], [RUC]) VALUES (11, N'Luiss', N'luissSAC', N'961122287', 0, N'Jr. Los Pinos 452, Lima', N'luiss@luissac.com', N'20244567890')
INSERT [dbo].[Proveedor] ([Id], [Nombre], [RazonSocial], [Telefono], [Estado], [Direccion], [Correo], [RUC]) VALUES (12, N'Luisooi', N'luis SAC', N'961302288', 1, N'961302288', N'961302288', N'961302288')
INSERT [dbo].[Proveedor] ([Id], [Nombre], [RazonSocial], [Telefono], [Estado], [Direccion], [Correo], [RUC]) VALUES (13, N'Brayan Sanchez', N'Pollos SAC', N'987678675', 1, N'brayan@gmail.com', N'Mz B49 Lote 20 Manuel Arevalo', N'10234565434')
SET IDENTITY_INSERT [dbo].[Proveedor] OFF
GO
INSERT [dbo].[Tipoinsumo] ([NombreTipoInsumo], [TipoinsumoID], [EstadoTipoInsumo]) VALUES (N'Bebidas', N'BEBI', 1)
INSERT [dbo].[Tipoinsumo] ([NombreTipoInsumo], [TipoinsumoID], [EstadoTipoInsumo]) VALUES (N'Carnes', N'CARN', 1)
INSERT [dbo].[Tipoinsumo] ([NombreTipoInsumo], [TipoinsumoID], [EstadoTipoInsumo]) VALUES (N'Pollo', N'POLL', 1)
INSERT [dbo].[Tipoinsumo] ([NombreTipoInsumo], [TipoinsumoID], [EstadoTipoInsumo]) VALUES (N'Vegetales', N'VEGE', 1)
GO
INSERT [dbo].[Tipoplato] ([NombreTipoPlato], [TipoplatoID], [EstadoTipoPlato]) VALUES (N'Parrillas', N'PARR', 1)
INSERT [dbo].[Tipoplato] ([NombreTipoPlato], [TipoplatoID], [EstadoTipoPlato]) VALUES (N'Pollos a la Brasas', N'POLL', 1)
GO
SET IDENTITY_INSERT [dbo].[TipoPlatoR] ON 

INSERT [dbo].[TipoPlatoR] ([Id], [Nombre], [Estado]) VALUES (1, N'Pollos a la Brasas', 1)
INSERT [dbo].[TipoPlatoR] ([Id], [Nombre], [Estado]) VALUES (2, N'Parrillas', 1)
INSERT [dbo].[TipoPlatoR] ([Id], [Nombre], [Estado]) VALUES (3, N'Bebidas', 1)
SET IDENTITY_INSERT [dbo].[TipoPlatoR] OFF
GO
ALTER TABLE [dbo].[Detalle_NotaVenta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_NotaVenta_NotaVenta] FOREIGN KEY([IdNotaVenta])
REFERENCES [dbo].[NotaVenta] ([Id])
GO
ALTER TABLE [dbo].[Detalle_NotaVenta] CHECK CONSTRAINT [FK_Detalle_NotaVenta_NotaVenta]
GO
ALTER TABLE [dbo].[Detalle_NotaVenta]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_NotaVenta_Plato] FOREIGN KEY([IdPlato])
REFERENCES [dbo].[PlatoR] ([Id])
GO
ALTER TABLE [dbo].[Detalle_NotaVenta] CHECK CONSTRAINT [FK_Detalle_NotaVenta_Plato]
GO
ALTER TABLE [dbo].[Insumo]  WITH CHECK ADD  CONSTRAINT [FK_Insumo_Tipoinsumo] FOREIGN KEY([TipoinsumoID])
REFERENCES [dbo].[Tipoinsumo] ([TipoinsumoID])
GO
ALTER TABLE [dbo].[Insumo] CHECK CONSTRAINT [FK_Insumo_Tipoinsumo]
GO
ALTER TABLE [dbo].[InsumoPlato]  WITH CHECK ADD  CONSTRAINT [FK_InsumoPlato_Insumo] FOREIGN KEY([InsumoID])
REFERENCES [dbo].[Insumo] ([InsumoID])
GO
ALTER TABLE [dbo].[InsumoPlato] CHECK CONSTRAINT [FK_InsumoPlato_Insumo]
GO
ALTER TABLE [dbo].[InsumoPlato]  WITH CHECK ADD  CONSTRAINT [FK_InsumoPlato_Plato] FOREIGN KEY([PlatoID])
REFERENCES [dbo].[Plato] ([PlatoID])
GO
ALTER TABLE [dbo].[InsumoPlato] CHECK CONSTRAINT [FK_InsumoPlato_Plato]
GO
ALTER TABLE [dbo].[NotaVenta]  WITH CHECK ADD  CONSTRAINT [FK_NotaVenta_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[NotaVenta] CHECK CONSTRAINT [FK_NotaVenta_Cliente]
GO
ALTER TABLE [dbo].[Pago]  WITH CHECK ADD  CONSTRAINT [FK_Pago_MetodoPago] FOREIGN KEY([IdMetodoPago])
REFERENCES [dbo].[MetodoPago] ([Id])
GO
ALTER TABLE [dbo].[Pago] CHECK CONSTRAINT [FK_Pago_MetodoPago]
GO
ALTER TABLE [dbo].[Pago]  WITH CHECK ADD  CONSTRAINT [FK_Pago_NotaVenta] FOREIGN KEY([IdNotaVenta])
REFERENCES [dbo].[NotaVenta] ([Id])
GO
ALTER TABLE [dbo].[Pago] CHECK CONSTRAINT [FK_Pago_NotaVenta]
GO
ALTER TABLE [dbo].[Plato]  WITH CHECK ADD  CONSTRAINT [FK_Plato_Tipoplato] FOREIGN KEY([TipoplatoID])
REFERENCES [dbo].[Tipoplato] ([TipoplatoID])
GO
ALTER TABLE [dbo].[Plato] CHECK CONSTRAINT [FK_Plato_Tipoplato]
GO
ALTER TABLE [dbo].[PlatoR]  WITH CHECK ADD FOREIGN KEY([IdTipoPlato])
REFERENCES [dbo].[TipoPlatoR] ([Id])
GO
/****** Object:  StoredProcedure [dbo].[spBuscarCliente]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[spBuscarCliente]
@dni varchar(8)
as
begin 
	select * from Cliente where Dni=@dni and Estado=1
end
GO
/****** Object:  StoredProcedure [dbo].[spBuscarMetodoPago]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create   proc [dbo].[spBuscarMetodoPago]
@idmetodopago int
as
begin 
	select * from MetodoPago where Id=@idmetodopago 
end
GO
/****** Object:  StoredProcedure [dbo].[spBuscarNotaVenta]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spBuscarNotaVenta]
@idnotaventa int
as
begin
SELECT c.Nombre,c.Dni,nv.Total,nv.Estado FROM 
NotaVenta nv 
--inner join Detalle_NotaVenta dnv on dnv.IdNotaVenta=nv.Id
--inner join Plato pl on pl.Id=dnv.IdPlato
inner join Cliente c on c.Id=nv.IdCliente
where nv.Id=@idnotaventa
end
GO
/****** Object:  StoredProcedure [dbo].[spBuscarPlato]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    proc [dbo].[spBuscarPlato]
@idplato varchar(5)
as
begin 
	select * from PlatoR where Id=@idplato and Estado=1
end
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarCliente]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   proc [dbo].[spDeshabilitarCliente]
@idcliente int
as
begin 
update Cliente set
Estado=0
where Id=@idcliente
end
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarinsumo]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spDeshabilitarinsumo]
(@insumoid nvarchar(10))
as
update
insumo
set
Estadoinsumo = 0
where
@insumoid = insumoid
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarInsumoPlato]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spDeshabilitarInsumoPlato]
(@insumoid nvarchar(10), @platoid nvarchar(10))
as
update InsumoPlato
set estadoinsumoplato = 0
where PlatoID = @platoid and InsumoID = @insumoid
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarMetodoPago]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create   proc [dbo].[spDeshabilitarMetodoPago]
@idmetodopago int
as
begin 
update MetodoPago set
Estado=0
where Id=@idmetodopago
end
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarPlato]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   proc [dbo].[spDeshabilitarPlato]
(@platoid nvarchar(10))
as
update Plato
set EstadoPlato = 0
where PlatoID = @platoid
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarTipoinsumo]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spDeshabilitarTipoinsumo]
(@tipoinsumoid nvarchar(10))
as
update
Tipoinsumo
set
EstadoTipoinsumo = 0
where
@tipoinsumoid = TipoinsumoID
GO
/****** Object:  StoredProcedure [dbo].[spDeshabilitarTipoPlato]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spDeshabilitarTipoPlato]
(@tipoplatoid nvarchar(10))
as
update
Tipoplato
set
EstadoTipoPlato = 0
where
@tipoplatoid = TipoplatoID
GO
/****** Object:  StoredProcedure [dbo].[spEditaCliente]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create   proc [dbo].[spEditaCliente]
@idcliente int,
@nombre varchar(50),
@estado bit
as
begin 
update Clientes set
Nombre=@nombre,
Estado=@estado
where Id=@idcliente
end
GO
/****** Object:  StoredProcedure [dbo].[spEditaProveedor]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spEditaProveedor]
@idproveedor int,
@nombre varchar(50),
@razonsocial varchar(100),
@telefono varchar(9),
@estado bit,
@direccion varchar(100),
@correo varchar(64),
@ruc varchar(11)
AS
BEGIN 
UPDATE Proveedor SET
Nombre = @nombre,
RazonSocial = @razonsocial,
Telefono = @telefono,
Estado = @estado,
Direccion = @direccion,
Correo = @correo,
RUC = @ruc
WHERE Id = @idproveedor
END
GO
/****** Object:  StoredProcedure [dbo].[spEditarInsumo]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spEditarInsumo]
(@insumoid nvarchar(10), @nombreinsumo nvarchar(50), @idtipoinsumo nvarchar(10), @cantidadinsumo int, @estadoinsumo bit)
as
update
Insumo
set
NombreInsumo = @nombreinsumo,
TipoinsumoID = @idtipoinsumo,
CantidadInsumo = @cantidadinsumo,
Estadoinsumo = @estadoinsumo
where 
@insumoid = insumoid
GO
/****** Object:  StoredProcedure [dbo].[spEditarPlato]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spEditarPlato]
(@platoid nvarchar(50), @estadoplato bit, @tipoplatoid nvarchar(50), @nombreplato nvarchar(50), @precioplato decimal)
as
update Plato
set 
EstadoPlato = @estadoplato,
TipoplatoID = @tipoplatoid,
NombrePlato = @nombreplato,
PrecioPlato = @precioplato
where PlatoID = @platoid
GO
/****** Object:  StoredProcedure [dbo].[spEditarTipoInsumo]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spEditarTipoInsumo]
(@tipoinsumoid nvarchar(10), @nombretipoinsumo nvarchar(50), @estadotipoinsumo bit)
as
update
Tipoinsumo 
set
NombreTipoinsumo = @nombretipoinsumo,
EstadoTipoinsumo = @estadotipoinsumo
where 
@tipoinsumoid = tipoinsumoid
GO
/****** Object:  StoredProcedure [dbo].[spEditarTipoPlato]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   proc [dbo].[spEditarTipoPlato]
(@tipoplatoid nvarchar(10), @nombretipoplato nvarchar(50), @estadotipoplato bit)
as
update
Tipoplato 
set
NombreTipoPlato = @nombretipoplato,
EstadoTipoPlato = @estadotipoplato
where 
@tipoplatoid = TipoplatoID
GO
/****** Object:  StoredProcedure [dbo].[spEliminarCliente]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create   proc [dbo].[spEliminarCliente]
@idcliente int
as
begin 
update Clientes set
Estado=0
where Id=@idcliente
end
GO
/****** Object:  StoredProcedure [dbo].[spEliminarProveedor]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create   proc [dbo].[spEliminarProveedor]
@idproveedor int
as
begin 
update Proveedor set
Estado=0
where Id=@idproveedor
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarCliente]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spInsertarCliente]
@nombre varchar(50),
@dni varchar(8),
@telefono varchar(9),
@correo varchar(50),
@estado bit
as
begin
	insert into Cliente values(@nombre,@dni,@telefono,@correo,@estado)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarDetNotaVenta]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   Procedure [dbo].[spInsertarDetNotaVenta]
@idnotaventa int,
@idplato varchar(5),
@cantidad int,
@precio decimal(12,2),
@subtotal decimal(12,2)
As Begin        
    SET IDENTITY_INSERT Detalle_NotaVenta OFF 		
		Insert into Detalle_NotaVenta Values (@idnotaventa,@idplato,@cantidad,@precio,@subtotal)
			--Set @Mensaje='Registrado Correctamente.'
	--SET IDENTITY_INSERT Detalle_NotaVenta off
End
GO
/****** Object:  StoredProcedure [dbo].[spInsertarInsumo]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spInsertarInsumo]
(@insumoid nvarchar(10), @nombreinsumo nvarchar(50), @idtipoinsumo nvarchar(10), @cantidadinsumo int, @estadoinsumo bit)
as
insert into insumo values
(@insumoid, @cantidadinsumo, @idtipoinsumo, @estadoinsumo, @nombreinsumo)
GO
/****** Object:  StoredProcedure [dbo].[spInsertarInsumoPlato]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spInsertarInsumoPlato]
(@insumoid nvarchar(50), @platoid nvarchar(50), @estadoinsumoplato bit)
as
if not exists (select 1 From InsumoPlato where @insumoid = InsumoID and @platoid = PlatoID)
begin
insert into InsumoPlato values
(@platoid, @insumoid, @estadoinsumoplato)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarMetodoPago]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spInsertarMetodoPago]
@metodopago varchar(50),
@estado bit
as
begin
	insert into MetodoPago values(@metodopago,@estado)
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarNotaVenta]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   Procedure [dbo].[spInsertarNotaVenta]
@idcliente int,
@fecha datetime,
@total decimal(12,2),
@estado bit
--@Mensaje Varchar(100) Out
As 
	Declare @idnotaventa int
Begin TRANSACTION
	Insert NotaVenta Values(@idcliente,@fecha, @total, @estado)
		---Set @Mensaje='El Pedido se ha Generado Correctamente.'

		SET @idnotaventa = @@IDENTITY

	IF @@ERROR<>0
	BEGIN
		ROLLBACK TRANSACTION
		return -1
	END
    COMMIT TRANSACTION
    return @idnotaventa
GO
/****** Object:  StoredProcedure [dbo].[spInsertarPago]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spInsertarPago]
@idmetodopago int,
@idnotaventa int,
@fecha datetime,
@total decimal(12,2),
@estado bit
as
begin
	insert into Pago values (@idmetodopago,@idnotaventa,@fecha,@total,@estado)
	update NotaVenta SET Estado=1 where Id=@idnotaventa
end
GO
/****** Object:  StoredProcedure [dbo].[spInsertarPlato]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spInsertarPlato]
(@platoid nvarchar(50), @estadoplato bit, @tipoplatoid nvarchar(50), @nombreplato nvarchar(50), @precioplato decimal)
as
insert into Plato values
(@platoid, @estadoplato, @tipoplatoid, @nombreplato, @precioplato)
GO
/****** Object:  StoredProcedure [dbo].[spInsertarProveedor]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spInsertarProveedor]
@nombre varchar(50),
@razonsocial varchar(100),
@telefono varchar(9),
@estado bit,
@direccion varchar(100),
@correo varchar(64),
@ruc varchar(11)
AS
BEGIN 
INSERT INTO Proveedor (Nombre, RazonSocial, Telefono, Estado, Direccion, Correo, RUC) 
VALUES (@nombre, @razonsocial, @telefono, @estado, @direccion, @correo, @ruc)
END
GO
/****** Object:  StoredProcedure [dbo].[spInsertarTipoInsumo]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spInsertarTipoInsumo]
(@tipoinsumoid nvarchar(10), @nombretipoinsumo nvarchar(50), @estadotipoinsumo bit)
as
insert into Tipoinsumo values
(@nombretipoinsumo, @tipoinsumoid, @estadotipoinsumo)
GO
/****** Object:  StoredProcedure [dbo].[spInsertarTipoPlato]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   proc [dbo].[spInsertarTipoPlato]
(@tipoplatoid nvarchar(10), @nombretipoplato nvarchar(50), @estadotipoplato bit)
as
insert into Tipoplato values
(@nombretipoplato, @tipoplatoid, @estadotipoplato)
GO
/****** Object:  StoredProcedure [dbo].[spLeerCliente]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spLeerCliente]
as
select * from Clientes
GO
/****** Object:  StoredProcedure [dbo].[spLeerProveedor]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spLeerProveedor]
as
select * from Proveedor 
GO
/****** Object:  StoredProcedure [dbo].[spListaCliente]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spListaCliente]
as
select * from Clientes where Estado=1
GO
/****** Object:  StoredProcedure [dbo].[spListaProveedor]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spListaProveedor]
as
select * from Proveedor where Estado=1
GO
/****** Object:  StoredProcedure [dbo].[spListarCliente]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spListarCliente]
as
begin
	select * from Cliente where Estado=1
end
GO
/****** Object:  StoredProcedure [dbo].[spListarDetalleNotaVenta]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create    proc [dbo].[spListarDetalleNotaVenta]
@idnotaventa int
as
begin
select dnv.IdNotaVenta,dnv.IdPlato,p.Nombre,dnv.Cantidad,dnv.Precio,dnv.SubTotal from 
Detalle_NotaVenta dnv 
inner join PlatoR p on p.Id=dnv.IdPlato where dnv.IdNotaVenta=@idnotaventa
end
GO
/****** Object:  StoredProcedure [dbo].[spListarDetallePlato]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create    proc [dbo].[spListarDetallePlato]
(@platoid nvarchar(10))
as
select * from Insumo i inner join InsumoPlato inpl on inpl.InsumoID = i.InsumoID
where inpl.PlatoID = @platoid and inpl.estadoinsumoplato = 1
GO
/****** Object:  StoredProcedure [dbo].[spListarInsumo]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spListarInsumo]
as
select * from insumo
where EstadoInsumo = 1
GO
/****** Object:  StoredProcedure [dbo].[spListarInsumoEscogido]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spListarInsumoEscogido]
(@insumoId nvarchar(10))
as
select * from Insumo
where InsumoID = @insumoid and EstadoInsumo = 1
GO
/****** Object:  StoredProcedure [dbo].[spListarInsumoPlato]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spListarInsumoPlato]
(@idplato nvarchar(50))
as
select * from InsumoPlato
where estadoinsumoplato = 1 and @idplato = PlatoID
GO
/****** Object:  StoredProcedure [dbo].[spListarMetodoPago]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spListarMetodoPago]
as
begin
	select * from MetodoPago where Estado = 1
end
GO
/****** Object:  StoredProcedure [dbo].[spListarNotaVenta]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spListarNotaVenta]
as
begin
	select * from NotaVenta 
end
GO
/****** Object:  StoredProcedure [dbo].[spListarPlato]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spListarPlato]
as
select * from Plato
where EstadoPlato = 1
GO
/****** Object:  StoredProcedure [dbo].[spListarPlato_Tipo]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spListarPlato_Tipo]
@idtipoplato int
as
begin
	select p.Id,p.Nombre,p.Descripcion,p.Precio,p.Estado from 
	PlatoR p 
	inner join TipoPlatoR tp on tp.Id=p.IdTipoPlato where tp.Id=@idtipoplato
end
GO
/****** Object:  StoredProcedure [dbo].[spListarPlatoR]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spListarPlatoR]
as
select * from PlatoR
GO
/****** Object:  StoredProcedure [dbo].[spListarPlatoTipo]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spListarPlatoTipo]
(@idtipoplato nvarchar(50))
as
select p.nombre from plator p inner join TipoPlatoR tp on tp.Id = p.IdTipoPlato
where tp.id = @idtipoplato
GO
/****** Object:  StoredProcedure [dbo].[spListarTipoInsumo]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spListarTipoInsumo]
as
select * from TipoInsumo
where EstadoTipoInsumo = 1
GO
/****** Object:  StoredProcedure [dbo].[spListarTipoPlato]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create   proc [dbo].[spListarTipoPlato]
as
select * from Tipoplato
where EstadoTipoPlato = 1
GO
/****** Object:  StoredProcedure [dbo].[spListarTipoPlatoR]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spListarTipoPlatoR]
as
select * from TipoPlatoR
GO
/****** Object:  StoredProcedure [dbo].[spModificarCliente]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spModificarCliente]
@idcliente int,
@nombre varchar(50),
@dni varchar(8),
@telefono varchar(9),
@correo varchar(50),
@estado bit
as
begin
	update Cliente set Nombre=@nombre,Dni=@dni,Telefono=@telefono,Correo=@correo,Estado=@estado where Id=@idcliente
end
GO
/****** Object:  StoredProcedure [dbo].[spModificarMetodoPago]    Script Date: 21/11/2023 11:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[spModificarMetodoPago]
@idmetodopago int,
@metodopago varchar(50),
@estado bit
as
begin
	update MetodoPago set MetodoPago=@metodopago,Estado=@estado where Id=@idmetodopago 
end
GO
