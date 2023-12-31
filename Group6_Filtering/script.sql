USE [master]
GO
/****** Object:  Database [Student]    Script Date: 12/6/2023 10:21:12 AM ******/
CREATE DATABASE [Student]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Student', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Student.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Student_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Student_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Student].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Student] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Student] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Student] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Student] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Student] SET ARITHABORT OFF 
GO
ALTER DATABASE [Student] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Student] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Student] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Student] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Student] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Student] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Student] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Student] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Student] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Student] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Student] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Student] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Student] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Student] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Student] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Student] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Student] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Student] SET RECOVERY FULL 
GO
ALTER DATABASE [Student] SET  MULTI_USER 
GO
ALTER DATABASE [Student] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Student] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Student] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Student] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Student] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Student', N'ON'
GO
USE [Student]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 12/6/2023 10:21:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentId] [int] NULL,
	[StudentName] [nvarchar](max) NULL,
	[GradeId] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Students] ([StudentId], [StudentName], [GradeId]) VALUES (1, N'Pham van a', N'.net 8')
INSERT [dbo].[Students] ([StudentId], [StudentName], [GradeId]) VALUES (2, N'Pham van b', N'.net 8')
INSERT [dbo].[Students] ([StudentId], [StudentName], [GradeId]) VALUES (3, N'Pham van a', N'.net 8')
INSERT [dbo].[Students] ([StudentId], [StudentName], [GradeId]) VALUES (4, N'Pham van c', N'.net 8')
INSERT [dbo].[Students] ([StudentId], [StudentName], [GradeId]) VALUES (5, N'Pham van d', N'.net 8')
INSERT [dbo].[Students] ([StudentId], [StudentName], [GradeId]) VALUES (6, N'Pham van a', N'.net 8')
INSERT [dbo].[Students] ([StudentId], [StudentName], [GradeId]) VALUES (7, N'Pham van a', N'.net 8')
INSERT [dbo].[Students] ([StudentId], [StudentName], [GradeId]) VALUES (8, N'Pham van a', N'.net 8')
INSERT [dbo].[Students] ([StudentId], [StudentName], [GradeId]) VALUES (9, N'Pham van a', N'.net 8')
INSERT [dbo].[Students] ([StudentId], [StudentName], [GradeId]) VALUES (10, N'Pham van a', N'.net 8')
GO
USE [master]
GO
ALTER DATABASE [Student] SET  READ_WRITE 
GO
