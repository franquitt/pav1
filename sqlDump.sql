USE [ProyPav]
GO
/****** Object:  Table [dbo].[CLASIFICACION]    Script Date: 14/11/2018 09:12:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLASIFICACION](
	[codigoClasificacion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[descripcion] [varchar](200) NOT NULL,
	[activo] [bit] NOT NULL,
 CONSTRAINT [PK_CLASIFICACION] PRIMARY KEY CLUSTERED 
(
	[codigoClasificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 14/11/2018 09:12:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[codigoCliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[apellido] [varchar](30) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
	[cuit] [varchar](14) NOT NULL,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[codigoCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLE_VENTA]    Script Date: 14/11/2018 09:12:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_VENTA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[numeroLote] [int] NOT NULL,
	[numeroVenta] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precioVenta] [money] NOT NULL,
 CONSTRAINT [PK_DETALLE_VENTA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOTES]    Script Date: 14/11/2018 09:12:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOTES](
	[numeroLote] [int] IDENTITY(1,1) NOT NULL,
	[codigoProveedor] [int] NOT NULL,
	[codigoProducto] [int] NOT NULL,
	[stockInicial] [int] NOT NULL,
	[stockActual] [int] NOT NULL,
	[fechaIngreso] [date] NOT NULL,
 CONSTRAINT [PK_LOTES] PRIMARY KEY CLUSTERED 
(
	[numeroLote] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCTOS]    Script Date: 14/11/2018 09:12:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCTOS](
	[codigoProducto] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](200) NOT NULL,
	[precio] [money] NOT NULL,
	[clasificacion] [int] NOT NULL,
	[activo] [bit] NOT NULL,
 CONSTRAINT [PK_PRODUCTOS] PRIMARY KEY CLUSTERED 
(
	[codigoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVEEDOR]    Script Date: 14/11/2018 09:12:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVEEDOR](
	[codigoProveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[apellido] [varchar](30) NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[telefono] [varchar](50) NOT NULL,
	[activo] [bit] NOT NULL,
 CONSTRAINT [PK_PROVEEDOR] PRIMARY KEY CLUSTERED 
(
	[codigoProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PROVxPROD]    Script Date: 14/11/2018 09:12:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROVxPROD](
	[codigoProveedor] [int] NOT NULL,
	[codigoProducto] [int] NOT NULL,
	[tiempoEntrega] [int] NOT NULL,
	[precio] [money] NOT NULL,
 CONSTRAINT [PK_PROVxPROD] PRIMARY KEY CLUSTERED 
(
	[codigoProveedor] ASC,
	[codigoProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pruebaFecha]    Script Date: 14/11/2018 09:12:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pruebaFecha](
	[fecha] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_FACTURA]    Script Date: 14/11/2018 09:12:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_FACTURA](
	[codigoTipo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	[activo] [bit] NOT NULL,
 CONSTRAINT [PK_TIPO_FACTURA] PRIMARY KEY CLUSTERED 
(
	[codigoTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPO_USUARIO]    Script Date: 14/11/2018 09:12:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_USUARIO](
	[codigoTipo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](10) NOT NULL,
	[activo] [bit] NOT NULL,
 CONSTRAINT [PK_TIPO_USUARIO] PRIMARY KEY CLUSTERED 
(
	[codigoTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 14/11/2018 09:12:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO](
	[legajo] [int] IDENTITY(1,1) NOT NULL,
	[fechaIngreso] [date] NOT NULL,
	[telefono] [varchar](50) NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
	[nombre] [varchar](30) NOT NULL,
	[apellido] [varchar](30) NOT NULL,
	[password] [varchar](250) NOT NULL,
	[tipo] [int] NOT NULL,
	[ultimoLogin] [datetime] NOT NULL,
	[activo] [bit] NOT NULL,
 CONSTRAINT [PK_USUARIO] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VENTAS]    Script Date: 14/11/2018 09:12:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VENTAS](
	[numeroVenta] [int] IDENTITY(1,1) NOT NULL,
	[tipoFactura] [int] NOT NULL,
	[vendedor] [int] NOT NULL,
	[cliente] [int] NOT NULL,
	[fecha] [date] NOT NULL,
	[activo] [bit] NOT NULL,
 CONSTRAINT [PK_VENTAS] PRIMARY KEY CLUSTERED 
(
	[numeroVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CLASIFICACION] ON 

INSERT [dbo].[CLASIFICACION] ([codigoClasificacion], [nombre], [descripcion], [activo]) VALUES (1, N'asda', N'asdasd', 0)
INSERT [dbo].[CLASIFICACION] ([codigoClasificacion], [nombre], [descripcion], [activo]) VALUES (2, N'Pintura', N'Pintura', 1)
INSERT [dbo].[CLASIFICACION] ([codigoClasificacion], [nombre], [descripcion], [activo]) VALUES (3, N'Tuercas', N'Tuercas', 1)
INSERT [dbo].[CLASIFICACION] ([codigoClasificacion], [nombre], [descripcion], [activo]) VALUES (4, N'Tornillos', N'Tornillos', 1)
INSERT [dbo].[CLASIFICACION] ([codigoClasificacion], [nombre], [descripcion], [activo]) VALUES (5, N'', N'', 0)
SET IDENTITY_INSERT [dbo].[CLASIFICACION] OFF
SET IDENTITY_INSERT [dbo].[CLIENTES] ON 

INSERT [dbo].[CLIENTES] ([codigoCliente], [nombre], [apellido], [telefono], [cuit]) VALUES (1, N'Juan', N'Martin', N'123', N'12-34567890-0')
INSERT [dbo].[CLIENTES] ([codigoCliente], [nombre], [apellido], [telefono], [cuit]) VALUES (2, N'Franco', N'Banco', N'123', N'12-34567890-0')
INSERT [dbo].[CLIENTES] ([codigoCliente], [nombre], [apellido], [telefono], [cuit]) VALUES (3, N'Combo', N'Wombo', N'123', N'12-34567890-0')
INSERT [dbo].[CLIENTES] ([codigoCliente], [nombre], [apellido], [telefono], [cuit]) VALUES (4, N'Cacho', N'Castaña', N'123', N'33-33333333-3')
INSERT [dbo].[CLIENTES] ([codigoCliente], [nombre], [apellido], [telefono], [cuit]) VALUES (5, N'Darth', N'Vader', N'456', N'44-44444444-4')
INSERT [dbo].[CLIENTES] ([codigoCliente], [nombre], [apellido], [telefono], [cuit]) VALUES (6, N'Lisa', N'Simpson', N'123', N'12-34566889-0')
INSERT [dbo].[CLIENTES] ([codigoCliente], [nombre], [apellido], [telefono], [cuit]) VALUES (7, N'Jhonny', N'Depp', N'a', N'11-11111111-1')
SET IDENTITY_INSERT [dbo].[CLIENTES] OFF
SET IDENTITY_INSERT [dbo].[DETALLE_VENTA] ON 

INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (1, 2, 2, 5, 1.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (2, 3, 2, 10, 1.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (3, 3, 3, 10, 1.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (4, 3, 4, 10, 1.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (5, 3, 5, 10, 1.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (6, 3, 6, 5, 1.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (7, 3, 7, 10, 5.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (8, 11, 7, 50, 2.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (9, 8, 8, 1, 5.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (10, 14, 8, 60, 5.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (11, 16, 8, 56, 3.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (12, 17, 8, 70, 2.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (13, 10, 9, 7, 140.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (14, 1, 9, 4, 100.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (15, 6, 9, 6, 100.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (16, 7, 9, 9, 100.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (17, 3, 10, 50, 5.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (18, 10, 11, 7, 140.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (19, 15, 11, 30, 90.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (20, 11, 11, 20, 2.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (21, 12, 12, 90, 6.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (22, 10, 12, 10, 140.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (23, 14, 15, 10, 5.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (24, 11, 16, 5, 2.5000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (25, 7, 16, 1, 100.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (26, 10, 17, 6, 140.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (27, 11, 17, 20, 2.5000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (28, 4, 18, 5, 5.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (29, 5, 18, 6, 5.0000)
INSERT [dbo].[DETALLE_VENTA] ([id], [numeroLote], [numeroVenta], [cantidad], [precioVenta]) VALUES (30, 11, 19, 5, 2.5000)
SET IDENTITY_INSERT [dbo].[DETALLE_VENTA] OFF
SET IDENTITY_INSERT [dbo].[LOTES] ON 

INSERT [dbo].[LOTES] ([numeroLote], [codigoProveedor], [codigoProducto], [stockInicial], [stockActual], [fechaIngreso]) VALUES (1, 3, 2, 4, 0, CAST(N'1111-11-11' AS Date))
INSERT [dbo].[LOTES] ([numeroLote], [codigoProveedor], [codigoProducto], [stockInicial], [stockActual], [fechaIngreso]) VALUES (2, 1, 1, 5, 0, CAST(N'1997-11-11' AS Date))
INSERT [dbo].[LOTES] ([numeroLote], [codigoProveedor], [codigoProducto], [stockInicial], [stockActual], [fechaIngreso]) VALUES (3, 1, 1, 100, 0, CAST(N'1997-11-11' AS Date))
INSERT [dbo].[LOTES] ([numeroLote], [codigoProveedor], [codigoProducto], [stockInicial], [stockActual], [fechaIngreso]) VALUES (4, 1, 1, 5, 0, CAST(N'1997-11-11' AS Date))
INSERT [dbo].[LOTES] ([numeroLote], [codigoProveedor], [codigoProducto], [stockInicial], [stockActual], [fechaIngreso]) VALUES (5, 1, 1, 1, 0, CAST(N'1997-11-11' AS Date))
INSERT [dbo].[LOTES] ([numeroLote], [codigoProveedor], [codigoProducto], [stockInicial], [stockActual], [fechaIngreso]) VALUES (6, 3, 2, 2, 0, CAST(N'1111-11-11' AS Date))
INSERT [dbo].[LOTES] ([numeroLote], [codigoProveedor], [codigoProducto], [stockInicial], [stockActual], [fechaIngreso]) VALUES (7, 3, 2, 4, 0, CAST(N'1111-11-11' AS Date))
INSERT [dbo].[LOTES] ([numeroLote], [codigoProveedor], [codigoProducto], [stockInicial], [stockActual], [fechaIngreso]) VALUES (8, 2, 9, 1, 0, CAST(N'1111-11-11' AS Date))
INSERT [dbo].[LOTES] ([numeroLote], [codigoProveedor], [codigoProducto], [stockInicial], [stockActual], [fechaIngreso]) VALUES (9, 2, 6, 100, 100, CAST(N'1111-11-11' AS Date))
INSERT [dbo].[LOTES] ([numeroLote], [codigoProveedor], [codigoProducto], [stockInicial], [stockActual], [fechaIngreso]) VALUES (10, 3, 3, 30, 0, CAST(N'1111-11-11' AS Date))
INSERT [dbo].[LOTES] ([numeroLote], [codigoProveedor], [codigoProducto], [stockInicial], [stockActual], [fechaIngreso]) VALUES (11, 1, 4, 100, 0, CAST(N'1111-11-11' AS Date))
INSERT [dbo].[LOTES] ([numeroLote], [codigoProveedor], [codigoProducto], [stockInicial], [stockActual], [fechaIngreso]) VALUES (12, 1, 5, 100, 10, CAST(N'1111-11-11' AS Date))
INSERT [dbo].[LOTES] ([numeroLote], [codigoProveedor], [codigoProducto], [stockInicial], [stockActual], [fechaIngreso]) VALUES (13, 3, 8, 50, 50, CAST(N'1111-11-11' AS Date))
INSERT [dbo].[LOTES] ([numeroLote], [codigoProveedor], [codigoProducto], [stockInicial], [stockActual], [fechaIngreso]) VALUES (14, 2, 9, 100, 31, CAST(N'1111-11-11' AS Date))
INSERT [dbo].[LOTES] ([numeroLote], [codigoProveedor], [codigoProducto], [stockInicial], [stockActual], [fechaIngreso]) VALUES (15, 3, 10, 60, 30, CAST(N'1111-11-11' AS Date))
INSERT [dbo].[LOTES] ([numeroLote], [codigoProveedor], [codigoProducto], [stockInicial], [stockActual], [fechaIngreso]) VALUES (16, 2, 11, 100, 44, CAST(N'1111-11-11' AS Date))
INSERT [dbo].[LOTES] ([numeroLote], [codigoProveedor], [codigoProducto], [stockInicial], [stockActual], [fechaIngreso]) VALUES (17, 2, 12, 100, 30, CAST(N'1111-11-11' AS Date))
SET IDENTITY_INSERT [dbo].[LOTES] OFF
SET IDENTITY_INSERT [dbo].[PRODUCTOS] ON 

INSERT [dbo].[PRODUCTOS] ([codigoProducto], [nombre], [descripcion], [precio], [clasificacion], [activo]) VALUES (1, N'Tuerca 1/2', N'Tuerca 1/2', 5.0000, 3, 1)
INSERT [dbo].[PRODUCTOS] ([codigoProducto], [nombre], [descripcion], [precio], [clasificacion], [activo]) VALUES (2, N'Lata de pintura 20 litros', N'Lata de pintura 20 litros', 100.0000, 2, 1)
INSERT [dbo].[PRODUCTOS] ([codigoProducto], [nombre], [descripcion], [precio], [clasificacion], [activo]) VALUES (3, N'Lata de pintura para exterior', N'Lata de pintura para exterior', 140.0000, 2, 1)
INSERT [dbo].[PRODUCTOS] ([codigoProducto], [nombre], [descripcion], [precio], [clasificacion], [activo]) VALUES (4, N'Tuerca de 3/4', N'Tuerca de 3/4', 2.5000, 4, 1)
INSERT [dbo].[PRODUCTOS] ([codigoProducto], [nombre], [descripcion], [precio], [clasificacion], [activo]) VALUES (5, N'Tuerca de 1', N'Tuerca de 1', 6.0000, 3, 1)
INSERT [dbo].[PRODUCTOS] ([codigoProducto], [nombre], [descripcion], [precio], [clasificacion], [activo]) VALUES (6, N'Tornillo cabeza cónica', N'Tornillo cabeza cónica', 3.0000, 4, 1)
INSERT [dbo].[PRODUCTOS] ([codigoProducto], [nombre], [descripcion], [precio], [clasificacion], [activo]) VALUES (7, N'G', N'gggg', 15.3000, 3, 0)
INSERT [dbo].[PRODUCTOS] ([codigoProducto], [nombre], [descripcion], [precio], [clasificacion], [activo]) VALUES (8, N'Lata de pintura de 15 litros', N'Lata de pintura de 15 litros', 50.0000, 2, 1)
INSERT [dbo].[PRODUCTOS] ([codigoProducto], [nombre], [descripcion], [precio], [clasificacion], [activo]) VALUES (9, N'Tornillo phillips para metal', N'Tornillo phillips', 5.0000, 4, 1)
INSERT [dbo].[PRODUCTOS] ([codigoProducto], [nombre], [descripcion], [precio], [clasificacion], [activo]) VALUES (10, N'Lata de pintura para interior', N'Lata de pintura para interior', 90.0000, 2, 1)
INSERT [dbo].[PRODUCTOS] ([codigoProducto], [nombre], [descripcion], [precio], [clasificacion], [activo]) VALUES (11, N'Tornillo para madera', N'Tornillo para madera', 3.0000, 4, 1)
INSERT [dbo].[PRODUCTOS] ([codigoProducto], [nombre], [descripcion], [precio], [clasificacion], [activo]) VALUES (12, N'Tornillo cabeza redonda', N'Tornillo cabeza redonda', 2.5000, 4, 1)
SET IDENTITY_INSERT [dbo].[PRODUCTOS] OFF
SET IDENTITY_INSERT [dbo].[PROVEEDOR] ON 

INSERT [dbo].[PROVEEDOR] ([codigoProveedor], [nombre], [apellido], [direccion], [telefono], [activo]) VALUES (1, N'Proveedor', N'Tuercas', N'Tuercas', N'123', 1)
INSERT [dbo].[PROVEEDOR] ([codigoProveedor], [nombre], [apellido], [direccion], [telefono], [activo]) VALUES (2, N'Proveedor', N'Tornillos', N'Tornillos', N'123', 1)
INSERT [dbo].[PROVEEDOR] ([codigoProveedor], [nombre], [apellido], [direccion], [telefono], [activo]) VALUES (3, N'Proveedor', N'Pintura', N'Pintura', N'123', 1)
SET IDENTITY_INSERT [dbo].[PROVEEDOR] OFF
INSERT [dbo].[PROVxPROD] ([codigoProveedor], [codigoProducto], [tiempoEntrega], [precio]) VALUES (1, 1, 1, 5.0000)
INSERT [dbo].[PROVxPROD] ([codigoProveedor], [codigoProducto], [tiempoEntrega], [precio]) VALUES (1, 4, 1, 2.5000)
INSERT [dbo].[PROVxPROD] ([codigoProveedor], [codigoProducto], [tiempoEntrega], [precio]) VALUES (1, 5, 1, 6.0000)
INSERT [dbo].[PROVxPROD] ([codigoProveedor], [codigoProducto], [tiempoEntrega], [precio]) VALUES (2, 6, 1, 3.0000)
INSERT [dbo].[PROVxPROD] ([codigoProveedor], [codigoProducto], [tiempoEntrega], [precio]) VALUES (2, 9, 1, 5.0000)
INSERT [dbo].[PROVxPROD] ([codigoProveedor], [codigoProducto], [tiempoEntrega], [precio]) VALUES (2, 11, 1, 3.0000)
INSERT [dbo].[PROVxPROD] ([codigoProveedor], [codigoProducto], [tiempoEntrega], [precio]) VALUES (2, 12, 1, 2.5000)
INSERT [dbo].[PROVxPROD] ([codigoProveedor], [codigoProducto], [tiempoEntrega], [precio]) VALUES (3, 2, 1, 100.0000)
INSERT [dbo].[PROVxPROD] ([codigoProveedor], [codigoProducto], [tiempoEntrega], [precio]) VALUES (3, 3, 2, 140.0000)
INSERT [dbo].[PROVxPROD] ([codigoProveedor], [codigoProducto], [tiempoEntrega], [precio]) VALUES (3, 8, 1, 50.0000)
INSERT [dbo].[PROVxPROD] ([codigoProveedor], [codigoProducto], [tiempoEntrega], [precio]) VALUES (3, 10, 1, 90.0000)
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
GO
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
GO
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
GO
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
INSERT [dbo].[pruebaFecha] ([fecha]) VALUES (CAST(N'2018-09-19T14:15:16.790' AS DateTime))
SET IDENTITY_INSERT [dbo].[TIPO_FACTURA] ON 

INSERT [dbo].[TIPO_FACTURA] ([codigoTipo], [nombre], [activo]) VALUES (1, N'B', 0)
INSERT [dbo].[TIPO_FACTURA] ([codigoTipo], [nombre], [activo]) VALUES (2, N'B', 0)
INSERT [dbo].[TIPO_FACTURA] ([codigoTipo], [nombre], [activo]) VALUES (3, N'C', 1)
INSERT [dbo].[TIPO_FACTURA] ([codigoTipo], [nombre], [activo]) VALUES (4, N'C', 1)
INSERT [dbo].[TIPO_FACTURA] ([codigoTipo], [nombre], [activo]) VALUES (5, N'D', 1)
INSERT [dbo].[TIPO_FACTURA] ([codigoTipo], [nombre], [activo]) VALUES (6, N'X', 1)
SET IDENTITY_INSERT [dbo].[TIPO_FACTURA] OFF
SET IDENTITY_INSERT [dbo].[TIPO_USUARIO] ON 

INSERT [dbo].[TIPO_USUARIO] ([codigoTipo], [nombre], [activo]) VALUES (1, N'admin', 1)
INSERT [dbo].[TIPO_USUARIO] ([codigoTipo], [nombre], [activo]) VALUES (2, N'vendedor', 1)
INSERT [dbo].[TIPO_USUARIO] ([codigoTipo], [nombre], [activo]) VALUES (3, N'tester', 0)
INSERT [dbo].[TIPO_USUARIO] ([codigoTipo], [nombre], [activo]) VALUES (4, N'user', 1)
SET IDENTITY_INSERT [dbo].[TIPO_USUARIO] OFF
SET IDENTITY_INSERT [dbo].[USUARIO] ON 

INSERT [dbo].[USUARIO] ([legajo], [fechaIngreso], [telefono], [fechaNacimiento], [nombre], [apellido], [password], [tipo], [ultimoLogin], [activo]) VALUES (1, CAST(N'2018-10-10' AS Date), N'12345', CAST(N'1997-04-11' AS Date), N'Agustin', N'Venturi', N'6B86B273FF34FCE19D6B804EFF5A3F5747ADA4EAA22F1D49C01E52DDB7875B4B', 1, CAST(N'2018-10-10T02:35:43.787' AS DateTime), 1)
INSERT [dbo].[USUARIO] ([legajo], [fechaIngreso], [telefono], [fechaNacimiento], [nombre], [apellido], [password], [tipo], [ultimoLogin], [activo]) VALUES (2, CAST(N'2018-01-01' AS Date), N'12345', CAST(N'1997-04-11' AS Date), N'Franco', N'Agresta', N'6B86B273FF34FCE19D6B804EFF5A3F5747ADA4EAA22F1D49C01E52DDB7875B4B', 1, CAST(N'2018-01-11T01:01:01.000' AS DateTime), 0)
INSERT [dbo].[USUARIO] ([legajo], [fechaIngreso], [telefono], [fechaNacimiento], [nombre], [apellido], [password], [tipo], [ultimoLogin], [activo]) VALUES (3, CAST(N'2018-09-24' AS Date), N'12345', CAST(N'1997-04-11' AS Date), N'Leo', N'Loza', N'6B86B273FF34FCE19D6B804EFF5A3F5747ADA4EAA22F1D49C01E52DDB7875B4B', 1, CAST(N'2018-09-24T13:51:13.573' AS DateTime), 0)
INSERT [dbo].[USUARIO] ([legajo], [fechaIngreso], [telefono], [fechaNacimiento], [nombre], [apellido], [password], [tipo], [ultimoLogin], [activo]) VALUES (4, CAST(N'2018-09-26' AS Date), N'1', CAST(N'1997-11-11' AS Date), N'1', N'3', N'6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 1, CAST(N'2018-09-26T09:35:28.820' AS DateTime), 0)
INSERT [dbo].[USUARIO] ([legajo], [fechaIngreso], [telefono], [fechaNacimiento], [nombre], [apellido], [password], [tipo], [ultimoLogin], [activo]) VALUES (5, CAST(N'2018-11-06' AS Date), N'1', CAST(N'2008-11-11' AS Date), N'Leonardo', N'Loza', N'6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 1, CAST(N'2018-11-06T15:51:31.520' AS DateTime), 1)
INSERT [dbo].[USUARIO] ([legajo], [fechaIngreso], [telefono], [fechaNacimiento], [nombre], [apellido], [password], [tipo], [ultimoLogin], [activo]) VALUES (6, CAST(N'2018-11-06' AS Date), N'1', CAST(N'1997-11-11' AS Date), N'Juan', N'Perez', N'6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 2, CAST(N'2018-11-06T15:50:49.123' AS DateTime), 1)
INSERT [dbo].[USUARIO] ([legajo], [fechaIngreso], [telefono], [fechaNacimiento], [nombre], [apellido], [password], [tipo], [ultimoLogin], [activo]) VALUES (7, CAST(N'2018-11-06' AS Date), N'123124', CAST(N'1997-04-11' AS Date), N'Franco', N'Agresta', N'6b86b273ff34fce19d6b804eff5a3f5747ada4eaa22f1d49c01e52ddb7875b4b', 1, CAST(N'2018-11-06T15:51:45.097' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[USUARIO] OFF
SET IDENTITY_INSERT [dbo].[VENTAS] ON 

INSERT [dbo].[VENTAS] ([numeroVenta], [tipoFactura], [vendedor], [cliente], [fecha], [activo]) VALUES (2, 3, 2, 3, CAST(N'2018-10-10' AS Date), 1)
INSERT [dbo].[VENTAS] ([numeroVenta], [tipoFactura], [vendedor], [cliente], [fecha], [activo]) VALUES (3, 3, 2, 3, CAST(N'2018-10-10' AS Date), 1)
INSERT [dbo].[VENTAS] ([numeroVenta], [tipoFactura], [vendedor], [cliente], [fecha], [activo]) VALUES (4, 3, 2, 3, CAST(N'2018-10-10' AS Date), 1)
INSERT [dbo].[VENTAS] ([numeroVenta], [tipoFactura], [vendedor], [cliente], [fecha], [activo]) VALUES (5, 3, 2, 3, CAST(N'2018-10-10' AS Date), 1)
INSERT [dbo].[VENTAS] ([numeroVenta], [tipoFactura], [vendedor], [cliente], [fecha], [activo]) VALUES (6, 4, 2, 3, CAST(N'2018-10-10' AS Date), 1)
INSERT [dbo].[VENTAS] ([numeroVenta], [tipoFactura], [vendedor], [cliente], [fecha], [activo]) VALUES (7, 3, 7, 7, CAST(N'2018-11-06' AS Date), 1)
INSERT [dbo].[VENTAS] ([numeroVenta], [tipoFactura], [vendedor], [cliente], [fecha], [activo]) VALUES (8, 3, 5, 4, CAST(N'2018-11-06' AS Date), 1)
INSERT [dbo].[VENTAS] ([numeroVenta], [tipoFactura], [vendedor], [cliente], [fecha], [activo]) VALUES (9, 4, 6, 2, CAST(N'2018-11-06' AS Date), 1)
INSERT [dbo].[VENTAS] ([numeroVenta], [tipoFactura], [vendedor], [cliente], [fecha], [activo]) VALUES (10, 3, 1, 3, CAST(N'2018-11-06' AS Date), 1)
INSERT [dbo].[VENTAS] ([numeroVenta], [tipoFactura], [vendedor], [cliente], [fecha], [activo]) VALUES (11, 3, 1, 5, CAST(N'2018-11-06' AS Date), 1)
INSERT [dbo].[VENTAS] ([numeroVenta], [tipoFactura], [vendedor], [cliente], [fecha], [activo]) VALUES (12, 6, 1, 6, CAST(N'2018-11-06' AS Date), 1)
INSERT [dbo].[VENTAS] ([numeroVenta], [tipoFactura], [vendedor], [cliente], [fecha], [activo]) VALUES (15, 4, 5, 1, CAST(N'2012-11-13' AS Date), 1)
INSERT [dbo].[VENTAS] ([numeroVenta], [tipoFactura], [vendedor], [cliente], [fecha], [activo]) VALUES (16, 3, 5, 1, CAST(N'2018-11-14' AS Date), 1)
INSERT [dbo].[VENTAS] ([numeroVenta], [tipoFactura], [vendedor], [cliente], [fecha], [activo]) VALUES (17, 6, 5, 1, CAST(N'2013-11-14' AS Date), 1)
INSERT [dbo].[VENTAS] ([numeroVenta], [tipoFactura], [vendedor], [cliente], [fecha], [activo]) VALUES (18, 5, 5, 1, CAST(N'2018-11-14' AS Date), 1)
INSERT [dbo].[VENTAS] ([numeroVenta], [tipoFactura], [vendedor], [cliente], [fecha], [activo]) VALUES (19, 4, 5, 2, CAST(N'2018-11-14' AS Date), 1)
SET IDENTITY_INSERT [dbo].[VENTAS] OFF
ALTER TABLE [dbo].[DETALLE_VENTA]  WITH CHECK ADD  CONSTRAINT [DETALLE_VENTA_fk0] FOREIGN KEY([numeroLote])
REFERENCES [dbo].[LOTES] ([numeroLote])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[DETALLE_VENTA] CHECK CONSTRAINT [DETALLE_VENTA_fk0]
GO
ALTER TABLE [dbo].[DETALLE_VENTA]  WITH CHECK ADD  CONSTRAINT [DETALLE_VENTA_fk1] FOREIGN KEY([numeroVenta])
REFERENCES [dbo].[VENTAS] ([numeroVenta])
GO
ALTER TABLE [dbo].[DETALLE_VENTA] CHECK CONSTRAINT [DETALLE_VENTA_fk1]
GO
ALTER TABLE [dbo].[DETALLE_VENTA]  WITH CHECK ADD  CONSTRAINT [DETALLE_VENTA_fk2] FOREIGN KEY([numeroVenta])
REFERENCES [dbo].[VENTAS] ([numeroVenta])
GO
ALTER TABLE [dbo].[DETALLE_VENTA] CHECK CONSTRAINT [DETALLE_VENTA_fk2]
GO
ALTER TABLE [dbo].[DETALLE_VENTA]  WITH CHECK ADD  CONSTRAINT [DETALLE_VENTA_fk5] FOREIGN KEY([numeroLote])
REFERENCES [dbo].[LOTES] ([numeroLote])
GO
ALTER TABLE [dbo].[DETALLE_VENTA] CHECK CONSTRAINT [DETALLE_VENTA_fk5]
GO
ALTER TABLE [dbo].[DETALLE_VENTA]  WITH CHECK ADD  CONSTRAINT [DETALLE_VENTA_fk6] FOREIGN KEY([numeroVenta])
REFERENCES [dbo].[VENTAS] ([numeroVenta])
GO
ALTER TABLE [dbo].[DETALLE_VENTA] CHECK CONSTRAINT [DETALLE_VENTA_fk6]
GO
ALTER TABLE [dbo].[LOTES]  WITH CHECK ADD  CONSTRAINT [LOTES_fk0] FOREIGN KEY([codigoProveedor])
REFERENCES [dbo].[PROVEEDOR] ([codigoProveedor])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LOTES] CHECK CONSTRAINT [LOTES_fk0]
GO
ALTER TABLE [dbo].[LOTES]  WITH CHECK ADD  CONSTRAINT [LOTES_fk1] FOREIGN KEY([codigoProducto])
REFERENCES [dbo].[PRODUCTOS] ([codigoProducto])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[LOTES] CHECK CONSTRAINT [LOTES_fk1]
GO
ALTER TABLE [dbo].[PRODUCTOS]  WITH CHECK ADD  CONSTRAINT [PRODUCTOS_fk0] FOREIGN KEY([clasificacion])
REFERENCES [dbo].[CLASIFICACION] ([codigoClasificacion])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[PRODUCTOS] CHECK CONSTRAINT [PRODUCTOS_fk0]
GO
ALTER TABLE [dbo].[USUARIO]  WITH CHECK ADD  CONSTRAINT [USUARIO_fk0] FOREIGN KEY([tipo])
REFERENCES [dbo].[TIPO_USUARIO] ([codigoTipo])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[USUARIO] CHECK CONSTRAINT [USUARIO_fk0]
GO
ALTER TABLE [dbo].[VENTAS]  WITH CHECK ADD  CONSTRAINT [VENTAS_fk0] FOREIGN KEY([tipoFactura])
REFERENCES [dbo].[TIPO_FACTURA] ([codigoTipo])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[VENTAS] CHECK CONSTRAINT [VENTAS_fk0]
GO
ALTER TABLE [dbo].[VENTAS]  WITH CHECK ADD  CONSTRAINT [VENTAS_fk1] FOREIGN KEY([vendedor])
REFERENCES [dbo].[USUARIO] ([legajo])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[VENTAS] CHECK CONSTRAINT [VENTAS_fk1]
GO
ALTER TABLE [dbo].[VENTAS]  WITH CHECK ADD  CONSTRAINT [VENTAS_fk2] FOREIGN KEY([cliente])
REFERENCES [dbo].[CLIENTES] ([codigoCliente])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[VENTAS] CHECK CONSTRAINT [VENTAS_fk2]
GO
