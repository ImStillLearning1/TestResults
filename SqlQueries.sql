--Baza
USE [master]
GO

/****** Object:  Database [ScanFil]    Script Date: 29.11.2022 13:38:08 ******/
CREATE DATABASE [ScanFil]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ScanFil', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ScanFil.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ScanFil_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\ScanFil_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ScanFil].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [ScanFil] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [ScanFil] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [ScanFil] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [ScanFil] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [ScanFil] SET ARITHABORT OFF 
GO

ALTER DATABASE [ScanFil] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [ScanFil] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [ScanFil] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [ScanFil] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [ScanFil] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [ScanFil] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [ScanFil] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [ScanFil] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [ScanFil] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [ScanFil] SET  DISABLE_BROKER 
GO

ALTER DATABASE [ScanFil] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [ScanFil] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [ScanFil] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [ScanFil] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [ScanFil] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [ScanFil] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [ScanFil] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [ScanFil] SET RECOVERY FULL 
GO

ALTER DATABASE [ScanFil] SET  MULTI_USER 
GO

ALTER DATABASE [ScanFil] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [ScanFil] SET DB_CHAINING OFF 
GO

ALTER DATABASE [ScanFil] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [ScanFil] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [ScanFil] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [ScanFil] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [ScanFil] SET QUERY_STORE = ON
GO

ALTER DATABASE [ScanFil] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

ALTER DATABASE [ScanFil] SET  READ_WRITE 
GO


-- Tabele


USE [ScanFil]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 29.11.2022 13:34:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestsDetails]    Script Date: 29.11.2022 13:34:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestsDetails](
	[Id] [uniqueidentifier] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[SerialNumber] [nvarchar](max) NOT NULL,
	[TestResult] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_TestsDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
