USE [isTakip]
GO
/****** Object:  Table [dbo].[tb_projeler]    Script Date: 01/20/2021 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_projeler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[projeismi] [varchar](50) NOT NULL,
	[musteri] [varchar](50) NOT NULL,
	[bilgi] [varchar](400) NOT NULL,
 CONSTRAINT [PK_tb_projeler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_projeler] ON
INSERT [dbo].[tb_projeler] ([ID], [projeismi], [musteri], [bilgi]) VALUES (1, N'proje1', N'musteri1', N'proje1 test')
INSERT [dbo].[tb_projeler] ([ID], [projeismi], [musteri], [bilgi]) VALUES (2, N'proje2', N'musteri2', N'proje2 deneme')
SET IDENTITY_INSERT [dbo].[tb_projeler] OFF
/****** Object:  Table [dbo].[tb_kullanicilar]    Script Date: 01/20/2021 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_kullanicilar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[kullaniciAdi] [varchar](20) NULL,
	[adi] [varchar](30) NULL,
	[soyadi] [varchar](30) NULL,
	[parola] [varchar](50) NULL,
 CONSTRAINT [PK_tb_kullanicilar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_kullanicilar] ON
INSERT [dbo].[tb_kullanicilar] ([ID], [kullaniciAdi], [adi], [soyadi], [parola]) VALUES (1, N'naz', N'Nazlýcan', N'Öztürk', N'vWsLCDtDYc6UnqCLENXbMA==')
INSERT [dbo].[tb_kullanicilar] ([ID], [kullaniciAdi], [adi], [soyadi], [parola]) VALUES (2, N'ays', N'Ayþe', N'Özkan', N'vWsLCDtDYc6UnqCLENXbMA==')
INSERT [dbo].[tb_kullanicilar] ([ID], [kullaniciAdi], [adi], [soyadi], [parola]) VALUES (3, N'dyg', N'Duygu', N'Yýlmaz', N'vWsLCDtDYc6UnqCLENXbMA==')
SET IDENTITY_INSERT [dbo].[tb_kullanicilar] OFF
/****** Object:  Table [dbo].[tb_durum]    Script Date: 01/20/2021 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_durum](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[durumAdi] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tb_Durum] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_durum] ON
INSERT [dbo].[tb_durum] ([ID], [durumAdi]) VALUES (1, N'To Do')
INSERT [dbo].[tb_durum] ([ID], [durumAdi]) VALUES (2, N'In Progress')
INSERT [dbo].[tb_durum] ([ID], [durumAdi]) VALUES (3, N'Done')
SET IDENTITY_INSERT [dbo].[tb_durum] OFF
/****** Object:  Table [dbo].[tb_projeSorumlu]    Script Date: 01/20/2021 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_projeSorumlu](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[projeId] [int] NULL,
	[kullaniciId] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_projeSorumlu] ON
INSERT [dbo].[tb_projeSorumlu] ([ID], [projeId], [kullaniciId]) VALUES (2, 1, 1)
INSERT [dbo].[tb_projeSorumlu] ([ID], [projeId], [kullaniciId]) VALUES (3, 1, 2)
INSERT [dbo].[tb_projeSorumlu] ([ID], [projeId], [kullaniciId]) VALUES (5, 2, 1)
INSERT [dbo].[tb_projeSorumlu] ([ID], [projeId], [kullaniciId]) VALUES (6, 2, 3)
SET IDENTITY_INSERT [dbo].[tb_projeSorumlu] OFF
/****** Object:  Table [dbo].[tb_gorevler]    Script Date: 01/20/2021 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_gorevler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[projeId] [int] NOT NULL,
	[baslik] [varchar](50) NOT NULL,
	[gorevliId] [int] NOT NULL,
	[aciklama] [varchar](250) NOT NULL,
	[baslama] [datetime] NULL,
	[bitirme] [datetime] NULL,
	[durum] [int] NOT NULL,
 CONSTRAINT [PK_tb_gorevler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_gorevler] ON
INSERT [dbo].[tb_gorevler] ([ID], [projeId], [baslik], [gorevliId], [aciklama], [baslama], [bitirme], [durum]) VALUES (1, 1, N'gorev1', 1, N'', CAST(0x0000ACB60133B389 AS DateTime), CAST(0x0000ACB601386FA7 AS DateTime), 3)
INSERT [dbo].[tb_gorevler] ([ID], [projeId], [baslik], [gorevliId], [aciklama], [baslama], [bitirme], [durum]) VALUES (2, 1, N'gorev2', 2, N'', CAST(0x0000ACB60133B821 AS DateTime), CAST(0x0000ACB6013AB196 AS DateTime), 3)
INSERT [dbo].[tb_gorevler] ([ID], [projeId], [baslik], [gorevliId], [aciklama], [baslama], [bitirme], [durum]) VALUES (3, 1, N'gorev3', 1, N'', CAST(0x0000ACB601387459 AS DateTime), CAST(0x0000ACB6013AB592 AS DateTime), 3)
INSERT [dbo].[tb_gorevler] ([ID], [projeId], [baslik], [gorevliId], [aciklama], [baslama], [bitirme], [durum]) VALUES (4, 1, N'gorev4', 2, N'', CAST(0x0000ACB6013ABC26 AS DateTime), CAST(0x0000ACB6013D8997 AS DateTime), 3)
INSERT [dbo].[tb_gorevler] ([ID], [projeId], [baslik], [gorevliId], [aciklama], [baslama], [bitirme], [durum]) VALUES (5, 1, N'gorev5', 1, N'', CAST(0x0000ACB6013ABEF6 AS DateTime), CAST(0x0000ACB6013D8C11 AS DateTime), 3)
INSERT [dbo].[tb_gorevler] ([ID], [projeId], [baslik], [gorevliId], [aciklama], [baslama], [bitirme], [durum]) VALUES (6, 2, N'gorev1', 1, N'', CAST(0x0000ACB60133F499 AS DateTime), CAST(0x0000ACB601387B8B AS DateTime), 3)
INSERT [dbo].[tb_gorevler] ([ID], [projeId], [baslik], [gorevliId], [aciklama], [baslama], [bitirme], [durum]) VALUES (7, 2, N'gorev2', 3, N'', CAST(0x0000ACB601387E1B AS DateTime), CAST(0x0000ACB6013ACB00 AS DateTime), 3)
INSERT [dbo].[tb_gorevler] ([ID], [projeId], [baslik], [gorevliId], [aciklama], [baslama], [bitirme], [durum]) VALUES (8, 2, N'gorev3', 3, N'', CAST(0x0000ACB601388077 AS DateTime), CAST(0x0000ACB6013ACF23 AS DateTime), 3)
INSERT [dbo].[tb_gorevler] ([ID], [projeId], [baslik], [gorevliId], [aciklama], [baslama], [bitirme], [durum]) VALUES (9, 2, N'gorev4', 3, N'', CAST(0x0000ACB6013AE864 AS DateTime), CAST(0x0000ACB6013D9267 AS DateTime), 3)
SET IDENTITY_INSERT [dbo].[tb_gorevler] OFF
/****** Object:  Table [dbo].[tb_gorevHareket]    Script Date: 01/20/2021 19:27:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_gorevHareket](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[gorevId] [int] NOT NULL,
	[durumId] [int] NOT NULL,
	[kullaniciId] [int] NULL,
	[tarih] [datetime] NOT NULL,
 CONSTRAINT [PK_tbl_gorevHareketleri] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_gorevHareket] ON
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (1, 1, 1, 1, CAST(0x0000ACB6012ED50A AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (2, 2, 1, 1, CAST(0x0000ACB6012EE0DB AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (3, 3, 1, 1, CAST(0x0000ACB6012EED27 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (4, 4, 1, 1, CAST(0x0000ACB6012EF503 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (5, 5, 1, 1, CAST(0x0000ACB6012EFDD9 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (6, 1, 2, 1, CAST(0x0000ACB60133B388 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (7, 2, 2, 1, CAST(0x0000ACB60133B820 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (8, 6, 1, 1, CAST(0x0000ACB60133DFD5 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (9, 7, 1, 1, CAST(0x0000ACB60133E7B8 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (10, 8, 1, 1, CAST(0x0000ACB60133F00C AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (11, 6, 2, 1, CAST(0x0000ACB60133F498 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (12, 1, 3, 1, CAST(0x0000ACB601386FA5 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (13, 3, 2, 1, CAST(0x0000ACB601387459 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (14, 6, 3, 1, CAST(0x0000ACB601387B8A AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (15, 7, 2, 1, CAST(0x0000ACB601387E1A AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (16, 8, 2, 1, CAST(0x0000ACB601388077 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (17, 2, 3, 1, CAST(0x0000ACB6013AB195 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (18, 3, 3, 1, CAST(0x0000ACB6013AB591 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (19, 4, 2, 1, CAST(0x0000ACB6013ABC24 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (20, 5, 2, 1, CAST(0x0000ACB6013ABEF5 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (21, 7, 3, 1, CAST(0x0000ACB6013ACB00 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (22, 8, 3, 1, CAST(0x0000ACB6013ACF22 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (23, 9, 1, 1, CAST(0x0000ACB6013AE248 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (24, 9, 2, 1, CAST(0x0000ACB6013AE862 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (25, 4, 3, 1, CAST(0x0000ACB6013D8997 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (26, 5, 3, 1, CAST(0x0000ACB6013D8C10 AS DateTime))
INSERT [dbo].[tb_gorevHareket] ([ID], [gorevId], [durumId], [kullaniciId], [tarih]) VALUES (27, 9, 3, 1, CAST(0x0000ACB6013D9267 AS DateTime))
SET IDENTITY_INSERT [dbo].[tb_gorevHareket] OFF
/****** Object:  Default [DF_tb_gorevler_durum]    Script Date: 01/20/2021 19:27:11 ******/
ALTER TABLE [dbo].[tb_gorevler] ADD  CONSTRAINT [DF_tb_gorevler_durum]  DEFAULT ((1)) FOR [durum]
GO
/****** Object:  ForeignKey [FK_tb_gorevHareket_tb_Durum]    Script Date: 01/20/2021 19:27:11 ******/
ALTER TABLE [dbo].[tb_gorevHareket]  WITH CHECK ADD  CONSTRAINT [FK_tb_gorevHareket_tb_Durum] FOREIGN KEY([durumId])
REFERENCES [dbo].[tb_durum] ([ID])
GO
ALTER TABLE [dbo].[tb_gorevHareket] CHECK CONSTRAINT [FK_tb_gorevHareket_tb_Durum]
GO
/****** Object:  ForeignKey [FK_tb_gorevHareket_tb_gorevler]    Script Date: 01/20/2021 19:27:11 ******/
ALTER TABLE [dbo].[tb_gorevHareket]  WITH CHECK ADD  CONSTRAINT [FK_tb_gorevHareket_tb_gorevler] FOREIGN KEY([gorevId])
REFERENCES [dbo].[tb_gorevler] ([ID])
GO
ALTER TABLE [dbo].[tb_gorevHareket] CHECK CONSTRAINT [FK_tb_gorevHareket_tb_gorevler]
GO
/****** Object:  ForeignKey [FK_tb_gorevler_tb_kullanicilar]    Script Date: 01/20/2021 19:27:11 ******/
ALTER TABLE [dbo].[tb_gorevler]  WITH CHECK ADD  CONSTRAINT [FK_tb_gorevler_tb_kullanicilar] FOREIGN KEY([gorevliId])
REFERENCES [dbo].[tb_kullanicilar] ([ID])
GO
ALTER TABLE [dbo].[tb_gorevler] CHECK CONSTRAINT [FK_tb_gorevler_tb_kullanicilar]
GO
/****** Object:  ForeignKey [FK_tb_gorevler_tb_projeler]    Script Date: 01/20/2021 19:27:11 ******/
ALTER TABLE [dbo].[tb_gorevler]  WITH CHECK ADD  CONSTRAINT [FK_tb_gorevler_tb_projeler] FOREIGN KEY([projeId])
REFERENCES [dbo].[tb_projeler] ([ID])
GO
ALTER TABLE [dbo].[tb_gorevler] CHECK CONSTRAINT [FK_tb_gorevler_tb_projeler]
GO
/****** Object:  ForeignKey [FK_tb_projeSorumlu_tb_kullanicilar]    Script Date: 01/20/2021 19:27:11 ******/
ALTER TABLE [dbo].[tb_projeSorumlu]  WITH CHECK ADD  CONSTRAINT [FK_tb_projeSorumlu_tb_kullanicilar] FOREIGN KEY([kullaniciId])
REFERENCES [dbo].[tb_kullanicilar] ([ID])
GO
ALTER TABLE [dbo].[tb_projeSorumlu] CHECK CONSTRAINT [FK_tb_projeSorumlu_tb_kullanicilar]
GO
/****** Object:  ForeignKey [FK_tb_projeSorumlu_tb_projeler]    Script Date: 01/20/2021 19:27:11 ******/
ALTER TABLE [dbo].[tb_projeSorumlu]  WITH CHECK ADD  CONSTRAINT [FK_tb_projeSorumlu_tb_projeler] FOREIGN KEY([projeId])
REFERENCES [dbo].[tb_projeler] ([ID])
GO
ALTER TABLE [dbo].[tb_projeSorumlu] CHECK CONSTRAINT [FK_tb_projeSorumlu_tb_projeler]
GO
