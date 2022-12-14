USE [master]
GO
/****** Object:  Database [Tecnico]    Script Date: 11/6/2022 10:00:42 PM ******/
CREATE DATABASE [Tecnico]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Tecnico', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Tecnico.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Tecnico_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Tecnico_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Tecnico] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Tecnico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Tecnico] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Tecnico] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Tecnico] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Tecnico] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Tecnico] SET ARITHABORT OFF 
GO
ALTER DATABASE [Tecnico] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Tecnico] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Tecnico] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Tecnico] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Tecnico] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Tecnico] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Tecnico] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Tecnico] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Tecnico] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Tecnico] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Tecnico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Tecnico] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Tecnico] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Tecnico] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Tecnico] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Tecnico] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Tecnico] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Tecnico] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Tecnico] SET  MULTI_USER 
GO
ALTER DATABASE [Tecnico] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Tecnico] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Tecnico] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Tecnico] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Tecnico] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Tecnico] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Tecnico] SET QUERY_STORE = OFF
GO
USE [Tecnico]
GO
/****** Object:  Table [dbo].[Table_Aspirante]    Script Date: 11/6/2022 10:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Aspirante](
	[Nombres] [varchar](100) NULL,
	[ApellidoP] [nchar](50) NULL,
	[ApellidoS] [varchar](50) NULL,
	[Correo] [varchar](100) NULL,
	[IdCarrera] [int] NULL,
	[Dui] [varchar](100) NULL,
	[Nit] [varchar](100) NULL,
	[Telefono] [varchar](100) NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_Carrera]    Script Date: 11/6/2022 10:00:43 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Carrera](
	[Id] [int] NOT NULL,
	[Escuela] [varchar](50) NULL,
	[Carrera] [varchar](100) NULL,
	[Descripcion] [varchar](600) NULL,
	[Asignatura] [int] NULL,
	[Duracion] [varchar](50) NULL,
 CONSTRAINT [pk_carrera_Id] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Table_Aspirante] ON 

INSERT [dbo].[Table_Aspirante] ([Nombres], [ApellidoP], [ApellidoS], [Correo], [IdCarrera], [Dui], [Nit], [Telefono], [Id]) VALUES (N'danielss', N'bonilla                                           ', N'bonilla', N'danie@gmail.com', 1, N'0433283', N'132456798123', N'1222245687', 5)
INSERT [dbo].[Table_Aspirante] ([Nombres], [ApellidoP], [ApellidoS], [Correo], [IdCarrera], [Dui], [Nit], [Telefono], [Id]) VALUES (N'daniel', N'bonilla                                           ', N'bonilla', N'danie@gmail.com', 4, N'0433283', N'132456798123', N'1222245687', 6)
SET IDENTITY_INSERT [dbo].[Table_Aspirante] OFF
GO
INSERT [dbo].[Table_Carrera] ([Id], [Escuela], [Carrera], [Descripcion], [Asignatura], [Duracion]) VALUES (1, N'ingenieria', N'Ingeniero en Ciencias de la Computación.', N'El/la Ingeniero/a en Ciecias de la Computación de la Universidad Don Bosco es el profesional que gestiona proyectos informáticos, crea software innovadores, gestiona redes informáticas, aplicando normas técnicas internacionales. Se espera que sea un profesional ético, crítico y proposito de liderazgo, fundamentado en el carsma salesiano, para la busqueda de la verdad, mediante el dialogo con la realidad, con la conciencia social y medioambiental.', 44, N'5 años (10 ciclos)')
INSERT [dbo].[Table_Carrera] ([Id], [Escuela], [Carrera], [Descripcion], [Asignatura], [Duracion]) VALUES (2, N'ingenieria', N'Ingeniero/Ingeniera en Telecomunicaciones y Redes.', N'El graduado de Ingeniería en Telecomunicaciones y Redes tiene como campo de actuación las empresas del sector de telecomunicaciones como operadores de telefonía fija y móvil, empresas que ofrecen servicios relacionados con el ámbito de redes de datos, proveedores de equipo y sistemas de redes datos y telecomunicaciones, los departamentos de información y comunicaciones de compañías de cualquier rubro y el mundo académico.', 40, N'5 años (10 ciclos)')
INSERT [dbo].[Table_Carrera] ([Id], [Escuela], [Carrera], [Descripcion], [Asignatura], [Duracion]) VALUES (3, N'ingenieria', N'Ingeniero/Ingeniera en Mecatrónica.', N'El/la Ingeniero/a en Mecatrónica de la Universidad Don Bosco planifica, innova, implementa y da mantenimiento a instalaciones de sistemas mecatrónicos industriales; diseña equipo mecatrónico y además de gestionar y dirigir proyectos brinda consultoría a empresas y dirige operaciones de negocios relacionados con sistemas mecatrónicos. Se espera que trabaje en equipos multidisciplinarios, comprendiendo y asumiendo la responsabilidad del impacto de las soluciones de ingeniería en un contexto social y global, de modo que se conduzca profesionalmente, con responsabilidad ética y valores humanos.', 40, N'5 años (10 ciclos)')
INSERT [dbo].[Table_Carrera] ([Id], [Escuela], [Carrera], [Descripcion], [Asignatura], [Duracion]) VALUES (4, N'ingenieria', N'Ingeniero/Ingeniera Industrial.', N'El/la Ingeniero/a Industrial de la Universidad Don Bosco, es el profesional que diseña, implementa, administra, mejora y optimiza los sistemas productivos de bienes y/o servicios gestionando los recursos humanos, tecnológicos y financieros. Se integra al trabajo de equipos multidisciplinarios, actualizándose permanentemente y desenvolviéndose con actitud emprendedora, mostrando valores éticos en su relación con las personas y con el medio ambiente, con vocación de servicio a la sociedad a partir del carisma salesiano, contribuyendo al progreso social y económico del país.', 44, N'5 años (10 ciclos)')
INSERT [dbo].[Table_Carrera] ([Id], [Escuela], [Carrera], [Descripcion], [Asignatura], [Duracion]) VALUES (5, N'Licenciatura', N'Licenciado/Licenciada en Ciencias de la Comunicación.', N'El/la Licenciado/a en Ciencias de la Comunicación de la Universidad Don Bosco es un profesional capacitado para producir mensajes en forma oral, escrita, y gráfica y visual, destinados a los distintos soportes Multimedia existentes, esto mediante procesos de investigación previa. Además, el profesional formado en este programa académico es capaz de gestionar e integrar los diferentes procesos estratégicos de comunicación que se dan dentro de una organización, con el fin de lograr los objetivos estratégicos establecidos por esta.', 43, N' 5 años (10 ciclos)')
INSERT [dbo].[Table_Carrera] ([Id], [Escuela], [Carrera], [Descripcion], [Asignatura], [Duracion]) VALUES (6, N'Licenciatura', N'Licenciado/Licenciada en Diseño Gráfico.', N'El/la Licenciado/a en Diseño Gráfico de la Universidad Don Bosco es un profesional que soluciona problemas de comunicación multimedia, mediante el desarrollo de procesos creativos propios de su profesión, aplicando innovaciones tecnológicas. También gestiona, desarrolla y emprende proyectos innovadores de diseño gráfico.', 38, N'5 años (10 ciclos)')
INSERT [dbo].[Table_Carrera] ([Id], [Escuela], [Carrera], [Descripcion], [Asignatura], [Duracion]) VALUES (7, N'Licenciatura', N'Licenciado/Licenciada en Mercadotecnia.', N'El/la Licenciado/a en Mercadotecnia de la Universidad Don Bosco es un profesional que diseña e implementa planes estratégicos de mercadeo en ambientes de incertidumbre, para lograr los objetivos de posicionamiento y participación en el mercado meta local y/o internacional; basados en estudios de la organización, de su entorno e integrando las tecnologías de información y comunicación disponibles.', 47, N'5 años (10 ciclos)')
INSERT [dbo].[Table_Carrera] ([Id], [Escuela], [Carrera], [Descripcion], [Asignatura], [Duracion]) VALUES (8, N'Licenciatura', N'Licenciado/Licenciada en Administración de Empresas.', N'El/la Licenciado/a en Administración de Empresas de la Universidad Don Bosco, es un profesional que aplica eficientemente el proceso administrativo en todo tipo de empresas, utilizando herramientas técnicas y tecnológicas del ámbito administrativo, en las funciones financieras, mercadológicas, de investigación, de recursos humanos y de logística, para lograr eficazmente el desarrollo gerencial y optimizar la productividad organizacional, gestionando efectivamente los riesgos de negocios.', 47, N'5 años (10 ciclos)')
INSERT [dbo].[Table_Carrera] ([Id], [Escuela], [Carrera], [Descripcion], [Asignatura], [Duracion]) VALUES (9, N'tecnico', N'Técnico/Técnica en Diseño Gráfico', N'El/la Técnico/a en Diseño Gráfico de laUniversidad Don Bosco es un profesional que soluciona problemas de comunicación gráfica, mediante el desarrollo de procesos creativos propios de su profesión, aplicando innovaciones tecnológicas, se espera que sea un profesional reflexivo,en constante autoformación, aplique las leyes y los principios éticos en el ejercicio de su profesión. Además debe ser socialmente responsable, participativo y consecuente en la transformación de los diversos entornos, según los principios del modelo educativo salesiano.', 20, N'2 años (4 ciclos)')
INSERT [dbo].[Table_Carrera] ([Id], [Escuela], [Carrera], [Descripcion], [Asignatura], [Duracion]) VALUES (10, N'tecnico', N'Técnico/Técnica en Ingeniería Mecánica.', N'El/la Técnico/a en Ingeniería Mecánica graduado de la Universidad Don Bosco, es el profesional que aplica las técnicas de diseño, manufactura, simula y automatiza elementos mecánicos empleando máquinas herramientas para la solución de problemas de ingeniería. Además, desarrolla actividades de planificación y aplicación del mantenimiento, dirigido al soporte técnico de sistemas mecánicos mediante el diagnóstico y reparación de maquinaria o equipo industrial..', 20, N'2 años (4 ciclos)')
INSERT [dbo].[Table_Carrera] ([Id], [Escuela], [Carrera], [Descripcion], [Asignatura], [Duracion]) VALUES (11, N'tecnico', N'Técnico/Técnica en Ingeniería en Computación.', N'El egresado de la carrera de Técnico en Ingeniería en Computación de la Universidad Don Bosco, es un profesional que diseña y desarrolla aplicaciones de software, apoya en la administración de la estructura física y de servicios en redes de área local y redes de área amplia, da mantenimiento y configura equipos informáticos actuales y de nueva tecnología. Asimismo, se espera que el Técnico en Ingeniería en Computación tome decisiones con criterio personal, interactuando con profesionales en ámbitos interdisciplinarios, que sea emprendedor y con deseos de superación personal y profesional.', 20, N'2 años (4 ciclos)')
INSERT [dbo].[Table_Carrera] ([Id], [Escuela], [Carrera], [Descripcion], [Asignatura], [Duracion]) VALUES (12, N'tecnico', N'Técnico/Técnica en Mantenimiento Aeronáutico.', N'El/la Técnico/a en Mantenimiento Aeronáutico de la Universidad Don Bosco inspecciona, diagnostica y soluciona problemas inherentes al mantenimiento de aeronaves, así como también, realiza tareas de gestión y logística del mantenimiento aeronáutico, siguiendo los procedimientos y las normas nacionales e internacionales relacionadas con la seguridad aérea, a fin de garantizar la seguridad operacional de las aeronaves. Se espera que el Técnico en Mantenimiento Aeronáutico, sea un profesional responsable, emprendedor, con solida identidad personal y principios éticos.', 23, N'2 años (4 ciclos)')
INSERT [dbo].[Table_Carrera] ([Id], [Escuela], [Carrera], [Descripcion], [Asignatura], [Duracion]) VALUES (13, N'Virtual', N'Ingeniero(a) en Ciencias de la Computación(VIRTUAL)', N'La carrera de Ingeniería en Ciencias de la Computación de la Universidad Don Bosco tiene como objetivo gestionar proyectos informáticos, crear software innovador, gestionar redes informáticas, aplicando normas técnicas internacionales, para mejorar la productividad y eficiencia de las organizaciones, posicionar al país en escenarios competitivos a nivel global y mejorar el nivel de vida de las personas. ', 44, N'5 años (10 ciclos)')
INSERT [dbo].[Table_Carrera] ([Id], [Escuela], [Carrera], [Descripcion], [Asignatura], [Duracion]) VALUES (14, N'Virtual', N'Técnico en Diseño Gráfico (VIRTUAL)', N'La carrera del Técnico en Diseño Gráfico de la Universidad Don Bosco, tiene como objetivo formar profesionales capaces de desarrollar y producir proyectos globales de diseño integrado que den solución a problemas de comunicación Multimedia. Así mismo pueda gestionar estratégicamente el diseño para la innovación y generación de valor en las empresas locales e internacionales, además de llegar a ocupar un espacio dentro de la actual industria del diseño a través del emprendimiento y la autogestión. ', 20, N'2 años (4 ciclos)')
INSERT [dbo].[Table_Carrera] ([Id], [Escuela], [Carrera], [Descripcion], [Asignatura], [Duracion]) VALUES (15, N'Virtual', N'Técnico en Ingeniería en Computación (VIRTUAL)', N'La carrera del Técnico en Ingeniería en Computación de la Universidad Don Bosco, tiene como objetivo formar profesionales que planifiquen, organicen, diseñen y desarrollen aplicaciones de escritorio y la web basadas en tecnologías emergentes, seleccionando la mejor plataforma y tecnología para ofrecer soluciones a los requerimientos de la industria y mercado nacional e internacional. Actuando con un sentido humanista, responsable, crítico, creativo e innovador, capaces de tomar decisiones que generen valor a la industria y al país.', 20, N'2 años (4 ciclos)')
INSERT [dbo].[Table_Carrera] ([Id], [Escuela], [Carrera], [Descripcion], [Asignatura], [Duracion]) VALUES (16, N'Virtual', N'Técnico en Marketing Digital y Ventas (VIRTUAL)', N'El Técnico en Marketing Digital y Ventas graduado de la Universidad Don Bosco es un profesional que diseña e implementa planes operativos de mercadeo, que generan valor para la organización y sus clientes; mediante el aprovechamiento de los recursos tecnológicos y considerando las condiciones del entorno económico, social y legal.', 20, N'2 años (2 ciclos)')
GO
ALTER TABLE [dbo].[Table_Aspirante]  WITH CHECK ADD FOREIGN KEY([IdCarrera])
REFERENCES [dbo].[Table_Carrera] ([Id])
GO
USE [master]
GO
ALTER DATABASE [Tecnico] SET  READ_WRITE 
GO
