USE [Soap]
GO
/****** Object:  Table [dbo].[Consolidacion]    Script Date: 11/11/2021 17:35:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consolidacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [datetime] NULL,
	[IdModeloConsolidable] [int] NULL,
	[NuevoNombreMarca] [varchar](500) NULL,
	[NuevoNombreModelo] [varchar](500) NULL,
	[IdNuevoMarca] [int] NULL,
	[IdTipoVehiculo] [int] NULL,
	[NuevoNombreTipoVehiculo] [varchar](500) NULL,
 CONSTRAINT [PK_Consolidacion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemConsolidacion]    Script Date: 11/11/2021 17:35:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemConsolidacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ConsolidacionId] [int] NULL,
	[IdModeloSeleccionado] [int] NULL,
	[NombreModelo] [varchar](500) NULL,
	[IdMarca] [int] NULL,
	[NombreMarca] [varchar](500) NULL,
	[IdTipoVehiculo] [int] NULL,
	[NombreTipoVehiculo] [varchar](500) NULL,
 CONSTRAINT [PK_ItemConsolidacion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Consolidacion]  WITH CHECK ADD  CONSTRAINT [FK_Consolidacion_Consolidacion] FOREIGN KEY([Id])
REFERENCES [dbo].[Consolidacion] ([Id])
GO
ALTER TABLE [dbo].[Consolidacion] CHECK CONSTRAINT [FK_Consolidacion_Consolidacion]
GO
ALTER TABLE [dbo].[ItemConsolidacion]  WITH CHECK ADD  CONSTRAINT [FK_ItemConsolidacion_Consolidacion] FOREIGN KEY([ConsolidacionId])
REFERENCES [dbo].[Consolidacion] ([Id])
GO
ALTER TABLE [dbo].[ItemConsolidacion] CHECK CONSTRAINT [FK_ItemConsolidacion_Consolidacion]
GO
