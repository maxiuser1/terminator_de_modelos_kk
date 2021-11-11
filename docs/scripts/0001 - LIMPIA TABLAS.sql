USE [Soap]
GO
/****** Object:  StoredProcedure [dbo].[SPObtenerNumeroPoliza]    Script Date: 11/11/2021 16:35:14 ******/
DROP PROCEDURE [dbo].[SPObtenerNumeroPoliza]
GO
/****** Object:  StoredProcedure [dbo].[SPObtenerNumeroFolio]    Script Date: 11/11/2021 16:35:14 ******/
DROP PROCEDURE [dbo].[SPObtenerNumeroFolio]
GO
/****** Object:  Table [dbo].[VentasSoap]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VentasSoap]') AND type in (N'U'))
DROP TABLE [dbo].[VentasSoap]
GO
/****** Object:  Table [dbo].[VentasOnline]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VentasOnline]') AND type in (N'U'))
DROP TABLE [dbo].[VentasOnline]
GO
/****** Object:  Table [dbo].[VentasConPropuesta]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[VentasConPropuesta]') AND type in (N'U'))
DROP TABLE [dbo].[VentasConPropuesta]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type in (N'U'))
DROP TABLE [dbo].[Usuarios]
GO
/****** Object:  Table [dbo].[TagsHtml]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TagsHtml]') AND type in (N'U'))
DROP TABLE [dbo].[TagsHtml]
GO
/****** Object:  Table [dbo].[Sucursales]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sucursales]') AND type in (N'U'))
DROP TABLE [dbo].[Sucursales]
GO
/****** Object:  Table [dbo].[SubModulos]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SubModulos]') AND type in (N'U'))
DROP TABLE [dbo].[SubModulos]
GO
/****** Object:  Table [dbo].[ResponsablePago]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ResponsablePago]') AND type in (N'U'))
DROP TABLE [dbo].[ResponsablePago]
GO
/****** Object:  Table [dbo].[RelacionFormaPagoOnline]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[RelacionFormaPagoOnline]') AND type in (N'U'))
DROP TABLE [dbo].[RelacionFormaPagoOnline]
GO
/****** Object:  Table [dbo].[Reglas]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Reglas]') AND type in (N'U'))
DROP TABLE [dbo].[Reglas]
GO
/****** Object:  Table [dbo].[Regiones]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Regiones]') AND type in (N'U'))
DROP TABLE [dbo].[Regiones]
GO
/****** Object:  Table [dbo].[Propuestas]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Propuestas]') AND type in (N'U'))
DROP TABLE [dbo].[Propuestas]
GO
/****** Object:  Table [dbo].[Propietarios]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Propietarios]') AND type in (N'U'))
DROP TABLE [dbo].[Propietarios]
GO
/****** Object:  Table [dbo].[ProcesosVentaOnline]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcesosVentaOnline]') AND type in (N'U'))
DROP TABLE [dbo].[ProcesosVentaOnline]
GO
/****** Object:  Table [dbo].[ProcesosVentaMasiva]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcesosVentaMasiva]') AND type in (N'U'))
DROP TABLE [dbo].[ProcesosVentaMasiva]
GO
/****** Object:  Table [dbo].[ProcesosRecaudacionOnline]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcesosRecaudacionOnline]') AND type in (N'U'))
DROP TABLE [dbo].[ProcesosRecaudacionOnline]
GO
/****** Object:  Table [dbo].[ProcesosRecaudacionManual]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcesosRecaudacionManual]') AND type in (N'U'))
DROP TABLE [dbo].[ProcesosRecaudacionManual]
GO
/****** Object:  Table [dbo].[ProcesosIngreso]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcesosIngreso]') AND type in (N'U'))
DROP TABLE [dbo].[ProcesosIngreso]
GO
/****** Object:  Table [dbo].[ProcesosEmision]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ProcesosEmision]') AND type in (N'U'))
DROP TABLE [dbo].[ProcesosEmision]
GO
/****** Object:  Table [dbo].[PrimasSoap]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PrimasSoap]') AND type in (N'U'))
DROP TABLE [dbo].[PrimasSoap]
GO
/****** Object:  Table [dbo].[PrimasCampanias]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PrimasCampanias]') AND type in (N'U'))
DROP TABLE [dbo].[PrimasCampanias]
GO
/****** Object:  Table [dbo].[PolizaSoap]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PolizaSoap]') AND type in (N'U'))
DROP TABLE [dbo].[PolizaSoap]
GO
/****** Object:  Table [dbo].[Polizas]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Polizas]') AND type in (N'U'))
DROP TABLE [dbo].[Polizas]
GO
/****** Object:  Table [dbo].[PlantillasModelo]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PlantillasModelo]') AND type in (N'U'))
DROP TABLE [dbo].[PlantillasModelo]
GO
/****** Object:  Table [dbo].[PerfilesModuloSubmodulos]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PerfilesModuloSubmodulos]') AND type in (N'U'))
DROP TABLE [dbo].[PerfilesModuloSubmodulos]
GO
/****** Object:  Table [dbo].[Perfiles]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Perfiles]') AND type in (N'U'))
DROP TABLE [dbo].[Perfiles]
GO
/****** Object:  Table [dbo].[Patentes]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Patentes]') AND type in (N'U'))
DROP TABLE [dbo].[Patentes]
GO
/****** Object:  Table [dbo].[PagoOrdenesCompra]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PagoOrdenesCompra]') AND type in (N'U'))
DROP TABLE [dbo].[PagoOrdenesCompra]
GO
/****** Object:  Table [dbo].[Montos]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Montos]') AND type in (N'U'))
DROP TABLE [dbo].[Montos]
GO
/****** Object:  Table [dbo].[Modulos]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Modulos]') AND type in (N'U'))
DROP TABLE [dbo].[Modulos]
GO
/****** Object:  Table [dbo].[ModelosVentas]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ModelosVentas]') AND type in (N'U'))
DROP TABLE [dbo].[ModelosVentas]
GO
/****** Object:  Table [dbo].[IntencionesVentaSoap]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[IntencionesVentaSoap]') AND type in (N'U'))
DROP TABLE [dbo].[IntencionesVentaSoap]
GO
/****** Object:  Table [dbo].[intencionesConjuntoVentaSoap]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[intencionesConjuntoVentaSoap]') AND type in (N'U'))
DROP TABLE [dbo].[intencionesConjuntoVentaSoap]
GO
/****** Object:  Table [dbo].[HomologacionPatentesMotos]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HomologacionPatentesMotos]') AND type in (N'U'))
DROP TABLE [dbo].[HomologacionPatentesMotos]
GO
/****** Object:  Table [dbo].[HomologacionPatentes]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HomologacionPatentes]') AND type in (N'U'))
DROP TABLE [dbo].[HomologacionPatentes]
GO
/****** Object:  Table [dbo].[HomologacionesRegla]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HomologacionesRegla]') AND type in (N'U'))
DROP TABLE [dbo].[HomologacionesRegla]
GO
/****** Object:  Table [dbo].[FormasPagos]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[FormasPagos]') AND type in (N'U'))
DROP TABLE [dbo].[FormasPagos]
GO
/****** Object:  Table [dbo].[Folios]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Folios]') AND type in (N'U'))
DROP TABLE [dbo].[Folios]
GO
/****** Object:  Table [dbo].[Empresas]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Empresas]') AND type in (N'U'))
DROP TABLE [dbo].[Empresas]
GO
/****** Object:  Table [dbo].[EmisionPolizasPorSoporte]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmisionPolizasPorSoporte]') AND type in (N'U'))
DROP TABLE [dbo].[EmisionPolizasPorSoporte]
GO
/****** Object:  Table [dbo].[DetalleAnulaciones]    Script Date: 11/11/2021 16:35:14 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DetalleAnulaciones]') AND type in (N'U'))
DROP TABLE [dbo].[DetalleAnulaciones]
GO
/****** Object:  Table [dbo].[DatosPrecargadoEmpresa]    Script Date: 11/11/2021 16:35:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DatosPrecargadoEmpresa]') AND type in (N'U'))
DROP TABLE [dbo].[DatosPrecargadoEmpresa]
GO
/****** Object:  Table [dbo].[ControlesHtml]    Script Date: 11/11/2021 16:35:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ControlesHtml]') AND type in (N'U'))
DROP TABLE [dbo].[ControlesHtml]
GO
/****** Object:  Table [dbo].[Contratantes]    Script Date: 11/11/2021 16:35:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Contratantes]') AND type in (N'U'))
DROP TABLE [dbo].[Contratantes]
GO
/****** Object:  Table [dbo].[ConjuntosVentaSoap]    Script Date: 11/11/2021 16:35:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConjuntosVentaSoap]') AND type in (N'U'))
DROP TABLE [dbo].[ConjuntosVentaSoap]
GO
/****** Object:  Table [dbo].[ConfirmacionAach]    Script Date: 11/11/2021 16:35:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ConfirmacionAach]') AND type in (N'U'))
DROP TABLE [dbo].[ConfirmacionAach]
GO
/****** Object:  Table [dbo].[CONFIGURACIONMODELOVENTAS]    Script Date: 11/11/2021 16:35:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CONFIGURACIONMODELOVENTAS]') AND type in (N'U'))
DROP TABLE [dbo].[CONFIGURACIONMODELOVENTAS]
GO
/****** Object:  Table [dbo].[Comunas]    Script Date: 11/11/2021 16:35:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Comunas]') AND type in (N'U'))
DROP TABLE [dbo].[Comunas]
GO
/****** Object:  Table [dbo].[Ciudades]    Script Date: 11/11/2021 16:35:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Ciudades]') AND type in (N'U'))
DROP TABLE [dbo].[Ciudades]
GO
/****** Object:  Table [dbo].[CanalesVentas]    Script Date: 11/11/2021 16:35:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CanalesVentas]') AND type in (N'U'))
DROP TABLE [dbo].[CanalesVentas]
GO
/****** Object:  Table [dbo].[Campanias]    Script Date: 11/11/2021 16:35:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Campanias]') AND type in (N'U'))
DROP TABLE [dbo].[Campanias]
GO
/****** Object:  Table [dbo].[Aseguradoras]    Script Date: 11/11/2021 16:35:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Aseguradoras]') AND type in (N'U'))
DROP TABLE [dbo].[Aseguradoras]
GO
/****** Object:  Table [dbo].[AnulacionesSoap]    Script Date: 11/11/2021 16:35:15 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AnulacionesSoap]') AND type in (N'U'))
DROP TABLE [dbo].[AnulacionesSoap]
GO
/****** Object:  User [soap]    Script Date: 11/11/2021 16:35:15 ******/
DROP USER [soap]
GO
