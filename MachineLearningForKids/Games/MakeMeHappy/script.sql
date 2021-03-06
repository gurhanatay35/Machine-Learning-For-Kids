USE [DBmakemehappy]
GO
/****** Object:  Table [dbo].[tblKelimeler]    Script Date: 5.06.2020 17:00:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKelimeler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Kelime] [nvarchar](500) NULL,
	[KelimeDurumu] [bit] NULL,
 CONSTRAINT [PK_tblKelimeler] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tblKelimeler] ON 

INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (1, N'iyi', 1)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (2, N'kötü', 0)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (3, N'Furkan', 1)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (4, N'Küfür', 0)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (5, N'Gavat', 0)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (6, N'Güzel', 1)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (7, N'Anne', 1)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (8, N'Baba', 1)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (9, N'Abi', 1)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (10, N'Fuck', 0)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (11, N'Bad', 0)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (12, N'Pezevenk', 0)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (13, N'Karaktersiz', 0)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (14, N'Haysiyetsiz', 0)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (15, N'Hakaret', 0)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (16, N'Çok güzelsin', 1)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (17, N'Seni Seviyorum', 1)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (18, N'Seni seviyorum', 1)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (19, N'seni seviyorum', 1)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (20, N'Orospu', 0)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (21, N'Serdar', 1)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (22, N'ibrahim', 1)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (23, N'beyza', 1)
INSERT [dbo].[tblKelimeler] ([id], [Kelime], [KelimeDurumu]) VALUES (24, N'ümit', 1)
SET IDENTITY_INSERT [dbo].[tblKelimeler] OFF
GO
