GO
CREATE DATABASE [ABCAutomotive]

GO
USE [ABCAutomotive]

GO
/****** Object:  Table [dbo].[Image]    Script Date: 11/29/2019 5:50:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Image](
	[ImageID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](250) NULL,
	[ImagePath] [varchar](max) NULL,
 CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED 
(
	[ImageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loan]    Script Date: 11/29/2019 5:50:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loan](
	[LoanID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [varchar](8) NOT NULL,
	[ResourceID] [varchar](8) NOT NULL,
	[CheckOutDate] [date] NOT NULL,
	[DueDate] [date] NOT NULL,
	[LoanStatusID] [int] NOT NULL,
 CONSTRAINT [PK_Loan] PRIMARY KEY CLUSTERED 
(
	[LoanID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoanStatus]    Script Date: 11/29/2019 5:50:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanStatus](
	[LoanStatusID] [int] NOT NULL,
	[LoanStatus] [varchar](50) NOT NULL,
 CONSTRAINT [PK_LoanStatus] PRIMARY KEY CLUSTERED 
(
	[LoanStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 11/29/2019 5:50:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[UserID] [varchar](8) NOT NULL,
	[UserPassword] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 11/29/2019 5:50:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[PaymentAmount] [money] NOT NULL,
	[PaymentDate] [date] NOT NULL,
	[PaymentId] [int] IDENTITY(1,1) NOT NULL,
	[StudentId] [varchar](8) NOT NULL,
	[StudentName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Program]    Script Date: 11/29/2019 5:50:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Program](
	[ProgramID] [int] NOT NULL,
	[ProgramType] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Program] PRIMARY KEY CLUSTERED 
(
	[ProgramID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Resource]    Script Date: 11/29/2019 5:50:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resource](
	[ResourceID] [varchar](8) NOT NULL,
	[ResourceTypeID] [int] NOT NULL,
	[PublisherReference] [int] NULL,
	[ResourceStatusID] [int] NOT NULL,
	[ReserveStatus] [bit] NOT NULL,
	[DateRemoved] [date] NULL,
	[ResourceImage] [varchar](50) NULL,
	[ResourcePrice] [money] NOT NULL,
	[ReserveStudentID] [varchar](8) NULL,
	[Title] [varchar](20) NULL,
	[ReserveStudentName] [varchar](50) NULL,
 CONSTRAINT [PK_Resource] PRIMARY KEY CLUSTERED 
(
	[ResourceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResourceStatus]    Script Date: 11/29/2019 5:50:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResourceStatus](
	[ResourceStatusID] [int] NOT NULL,
	[ResourceStatusType] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ResourceStatus] PRIMARY KEY CLUSTERED 
(
	[ResourceStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ResourceType]    Script Date: 11/29/2019 5:50:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResourceType](
	[ResourceTypeID] [int] NOT NULL,
	[ResourceType] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ResourceType] PRIMARY KEY CLUSTERED 
(
	[ResourceTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 11/29/2019 5:50:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [varchar](8) NOT NULL,
	[StudentStatus] [bit] NOT NULL,
	[FirstName] [varchar](30) NOT NULL,
	[LastName] [varchar](30) NOT NULL,
	[StartDate] [date] NOT NULL,
	[EndDate] [date] NOT NULL,
	[ProgramID] [int] NOT NULL,
	[AmountDue] [money] NOT NULL,
	[TimeStamp] [timestamp] NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[City] [varchar](20) NOT NULL,
	[PostalCode] [varchar](6) NOT NULL,
	[PhoneNumber] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Loan] ON 

INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (1, N'20179874', N'11114321', CAST(N'2019-11-05' AS Date), CAST(N'2019-11-07' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (2, N'20179874', N'11114321', CAST(N'2019-11-06' AS Date), CAST(N'2019-11-08' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (3, N'20181234', N'22221234', CAST(N'2019-11-06' AS Date), CAST(N'2019-11-08' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (4, N'20179874', N'11114321', CAST(N'2019-11-06' AS Date), CAST(N'2019-11-08' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (5, N'20179874', N'33339876', CAST(N'2019-11-06' AS Date), CAST(N'2019-11-08' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (6, N'20181234', N'11114321', CAST(N'2019-11-06' AS Date), CAST(N'2019-11-08' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (7, N'20181234', N'22221234', CAST(N'2019-11-06' AS Date), CAST(N'2019-11-08' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (8, N'20181234', N'33339876', CAST(N'2019-11-06' AS Date), CAST(N'2019-11-08' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (9, N'20181234', N'11114321', CAST(N'2019-11-06' AS Date), CAST(N'2019-11-08' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (32, N'20181234', N'11114321', CAST(N'2019-11-06' AS Date), CAST(N'2019-11-08' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (33, N'20181234', N'11114321', CAST(N'2019-11-06' AS Date), CAST(N'2019-11-08' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (36, N'20181234', N'33331234', CAST(N'2019-11-06' AS Date), CAST(N'2019-11-08' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (39, N'20181234', N'22221234', CAST(N'2019-11-12' AS Date), CAST(N'2019-11-14' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (50, N'20181234', N'11114321', CAST(N'2019-11-12' AS Date), CAST(N'2019-11-14' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (58, N'20181234', N'11114321', CAST(N'2019-11-13' AS Date), CAST(N'2019-11-15' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (59, N'20181234', N'22221234', CAST(N'2019-11-13' AS Date), CAST(N'2019-11-15' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (60, N'20181234', N'11114321', CAST(N'2019-11-13' AS Date), CAST(N'2019-11-15' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (61, N'20181234', N'22221234', CAST(N'2019-11-13' AS Date), CAST(N'2019-11-15' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (62, N'20181234', N'33331234', CAST(N'2019-11-13' AS Date), CAST(N'2019-11-15' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (63, N'20181234', N'11114321', CAST(N'2019-11-13' AS Date), CAST(N'2019-11-15' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (64, N'20181234', N'22221234', CAST(N'2019-11-13' AS Date), CAST(N'2019-11-15' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (65, N'20181234', N'33331234', CAST(N'2019-11-13' AS Date), CAST(N'2019-11-15' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (66, N'20181234', N'11114321', CAST(N'2019-11-13' AS Date), CAST(N'2019-11-15' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (67, N'20181234', N'11114321', CAST(N'2019-11-13' AS Date), CAST(N'2019-11-15' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (68, N'20181234', N'11114321', CAST(N'2019-11-14' AS Date), CAST(N'2019-11-16' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (69, N'20181234', N'11114321', CAST(N'2019-11-14' AS Date), CAST(N'2019-11-16' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (70, N'20181234', N'22221234', CAST(N'2019-11-14' AS Date), CAST(N'2019-11-16' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (71, N'20181234', N'11114321', CAST(N'2019-11-14' AS Date), CAST(N'2019-11-16' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (72, N'20181234', N'22221234', CAST(N'2019-11-14' AS Date), CAST(N'2019-11-16' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (73, N'20181234', N'11114321', CAST(N'2019-11-14' AS Date), CAST(N'2019-11-16' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (74, N'20181234', N'11114321', CAST(N'2019-11-14' AS Date), CAST(N'2019-11-16' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (75, N'20181234', N'22221234', CAST(N'2019-11-14' AS Date), CAST(N'2019-11-16' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (94, N'20194321', N'11114321', CAST(N'2019-11-17' AS Date), CAST(N'2019-11-19' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (95, N'20194321', N'11114321', CAST(N'2019-11-17' AS Date), CAST(N'2019-11-19' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (96, N'20181234', N'11119876', CAST(N'2019-11-17' AS Date), CAST(N'2019-11-19' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (97, N'20181234', N'11114321', CAST(N'2019-11-17' AS Date), CAST(N'2019-11-19' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (98, N'20194321', N'11114321', CAST(N'2019-11-17' AS Date), CAST(N'2019-11-19' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (99, N'20194321', N'11119876', CAST(N'2019-11-17' AS Date), CAST(N'2019-11-19' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (100, N'20181234', N'22221234', CAST(N'2019-11-17' AS Date), CAST(N'2019-11-19' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (101, N'20181234', N'22224321', CAST(N'2019-11-17' AS Date), CAST(N'2019-11-19' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (102, N'20181234', N'11114321', CAST(N'2019-11-17' AS Date), CAST(N'2019-11-19' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (103, N'20181234', N'22221234', CAST(N'2019-11-17' AS Date), CAST(N'2019-11-19' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (104, N'20181234', N'22221234', CAST(N'2019-11-18' AS Date), CAST(N'2019-11-20' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (105, N'20181234', N'11114321', CAST(N'2019-11-18' AS Date), CAST(N'2019-11-20' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (106, N'20181234', N'11114321', CAST(N'2019-11-19' AS Date), CAST(N'2019-11-21' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (107, N'20181234', N'22221234', CAST(N'2019-11-19' AS Date), CAST(N'2019-11-21' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (108, N'20181234', N'11114321', CAST(N'2019-11-16' AS Date), CAST(N'2019-11-18' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (109, N'20194321', N'11119876', CAST(N'2019-11-20' AS Date), CAST(N'2019-11-22' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (110, N'20194321', N'11119876', CAST(N'2019-11-20' AS Date), CAST(N'2019-11-22' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (111, N'20194321', N'11119876', CAST(N'2019-11-20' AS Date), CAST(N'2019-11-22' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (112, N'20181234', N'11114321', CAST(N'2019-11-23' AS Date), CAST(N'2019-11-25' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (113, N'20181234', N'11114321', CAST(N'2019-11-25' AS Date), CAST(N'2019-11-27' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (114, N'20181234', N'11114321', CAST(N'2019-11-25' AS Date), CAST(N'2019-11-27' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (115, N'20181234', N'11114321', CAST(N'2019-11-28' AS Date), CAST(N'2019-11-30' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (116, N'20181234', N'11114321', CAST(N'2019-11-28' AS Date), CAST(N'2019-11-30' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (117, N'20181234', N'11114321', CAST(N'2019-11-29' AS Date), CAST(N'2019-12-01' AS Date), 2)
INSERT [dbo].[Loan] ([LoanID], [StudentID], [ResourceID], [CheckOutDate], [DueDate], [LoanStatusID]) VALUES (118, N'20181234', N'11114321', CAST(N'2019-11-29' AS Date), CAST(N'2019-12-01' AS Date), 2)
SET IDENTITY_INSERT [dbo].[Loan] OFF
INSERT [dbo].[LoanStatus] ([LoanStatusID], [LoanStatus]) VALUES (1, N'On Loan')
INSERT [dbo].[LoanStatus] ([LoanStatusID], [LoanStatus]) VALUES (2, N'Returned')
INSERT [dbo].[LoanStatus] ([LoanStatusID], [LoanStatus]) VALUES (3, N'Returned damaged')
INSERT [dbo].[LoanStatus] ([LoanStatusID], [LoanStatus]) VALUES (4, N'Not Returned')
INSERT [dbo].[Login] ([UserID], [UserPassword]) VALUES (N'testuser', N'password')
SET IDENTITY_INSERT [dbo].[Payment] ON 

INSERT [dbo].[Payment] ([PaymentAmount], [PaymentDate], [PaymentId], [StudentId], [StudentName]) VALUES (1.0000, CAST(N'2019-11-20' AS Date), 1, N'20194561', N'Will Smi')
INSERT [dbo].[Payment] ([PaymentAmount], [PaymentDate], [PaymentId], [StudentId], [StudentName]) VALUES (1.0000, CAST(N'2019-11-25' AS Date), 2, N'20179874', N'Eddie Mu')
INSERT [dbo].[Payment] ([PaymentAmount], [PaymentDate], [PaymentId], [StudentId], [StudentName]) VALUES (25.0000, CAST(N'2019-11-29' AS Date), 3, N'20181234', N'Test Stu')
SET IDENTITY_INSERT [dbo].[Payment] OFF
INSERT [dbo].[Program] ([ProgramID], [ProgramType]) VALUES (1, N'Regular program')
INSERT [dbo].[Program] ([ProgramID], [ProgramType]) VALUES (2, N'Block release')
INSERT [dbo].[Resource] ([ResourceID], [ResourceTypeID], [PublisherReference], [ResourceStatusID], [ReserveStatus], [DateRemoved], [ResourceImage], [ResourcePrice], [ReserveStudentID], [Title], [ReserveStudentName]) VALUES (N'11114321', 1, NULL, 1, 0, NULL, N'picture1', 25.0000, NULL, N'a', NULL)
INSERT [dbo].[Resource] ([ResourceID], [ResourceTypeID], [PublisherReference], [ResourceStatusID], [ReserveStatus], [DateRemoved], [ResourceImage], [ResourcePrice], [ReserveStudentID], [Title], [ReserveStudentName]) VALUES (N'11119876', 1, NULL, 1, 0, NULL, N'picture2', 50.0000, NULL, N'b', NULL)
INSERT [dbo].[Resource] ([ResourceID], [ResourceTypeID], [PublisherReference], [ResourceStatusID], [ReserveStatus], [DateRemoved], [ResourceImage], [ResourcePrice], [ReserveStudentID], [Title], [ReserveStudentName]) VALUES (N'22221234', 2, NULL, 1, 0, NULL, N'picture3', 75.0000, NULL, N'c', NULL)
INSERT [dbo].[Resource] ([ResourceID], [ResourceTypeID], [PublisherReference], [ResourceStatusID], [ReserveStatus], [DateRemoved], [ResourceImage], [ResourcePrice], [ReserveStudentID], [Title], [ReserveStudentName]) VALUES (N'22224321', 2, NULL, 1, 0, NULL, N'picture4', 55.0000, NULL, N'd', NULL)
INSERT [dbo].[Resource] ([ResourceID], [ResourceTypeID], [PublisherReference], [ResourceStatusID], [ReserveStatus], [DateRemoved], [ResourceImage], [ResourcePrice], [ReserveStudentID], [Title], [ReserveStudentName]) VALUES (N'33331234', 3, NULL, 1, 0, NULL, N'picture5', 40.0000, NULL, N'e', NULL)
INSERT [dbo].[Resource] ([ResourceID], [ResourceTypeID], [PublisherReference], [ResourceStatusID], [ReserveStatus], [DateRemoved], [ResourceImage], [ResourcePrice], [ReserveStudentID], [Title], [ReserveStudentName]) VALUES (N'33339876', 3, NULL, 1, 0, NULL, N'picture6', 45.0000, NULL, N'f', NULL)
INSERT [dbo].[ResourceStatus] ([ResourceStatusID], [ResourceStatusType]) VALUES (1, N'Available')
INSERT [dbo].[ResourceStatus] ([ResourceStatusID], [ResourceStatusType]) VALUES (2, N'On Loan')
INSERT [dbo].[ResourceStatus] ([ResourceStatusID], [ResourceStatusType]) VALUES (3, N'Not Available for Loan')
INSERT [dbo].[ResourceType] ([ResourceTypeID], [ResourceType]) VALUES (1, N'Manufacturer’s DVD')
INSERT [dbo].[ResourceType] ([ResourceTypeID], [ResourceType]) VALUES (2, N'Manufacturer’s reference manual')
INSERT [dbo].[ResourceType] ([ResourceTypeID], [ResourceType]) VALUES (3, N'Non-manufacturer Reference book')
INSERT [dbo].[Student] ([StudentID], [StudentStatus], [FirstName], [LastName], [StartDate], [EndDate], [ProgramID], [AmountDue], [Address], [City], [PostalCode], [PhoneNumber]) VALUES (N'20179874', 0, N'Eddie', N'Murphy', CAST(N'2017-01-01' AS Date), CAST(N'2017-12-31' AS Date), 1, 1.0000, N'road 1', N'city 1', N'A1A1A1', N'5061234567')
INSERT [dbo].[Student] ([StudentID], [StudentStatus], [FirstName], [LastName], [StartDate], [EndDate], [ProgramID], [AmountDue], [Address], [City], [PostalCode], [PhoneNumber]) VALUES (N'20181112', 0, N'bq', N'dd', CAST(N'2019-11-29' AS Date), CAST(N'2019-11-30' AS Date), 1, 0.0000, N'a', N'b', N'X1X1X1', N'9051111111')
INSERT [dbo].[Student] ([StudentID], [StudentStatus], [FirstName], [LastName], [StartDate], [EndDate], [ProgramID], [AmountDue], [Address], [City], [PostalCode], [PhoneNumber]) VALUES (N'20181234', 1, N'Test', N'Student', CAST(N'2018-01-01' AS Date), CAST(N'2018-12-31' AS Date), 1, 0.0000, N'road22', N'city2', N'B1B1B1', N'5061234567')
INSERT [dbo].[Student] ([StudentID], [StudentStatus], [FirstName], [LastName], [StartDate], [EndDate], [ProgramID], [AmountDue], [Address], [City], [PostalCode], [PhoneNumber]) VALUES (N'20182244', 1, N'B', N'C', CAST(N'2018-11-01' AS Date), CAST(N'2019-11-01' AS Date), 1, 0.0000, N'asd', N'asv', N'B1B1B1', N'5061212123')
INSERT [dbo].[Student] ([StudentID], [StudentStatus], [FirstName], [LastName], [StartDate], [EndDate], [ProgramID], [AmountDue], [Address], [City], [PostalCode], [PhoneNumber]) VALUES (N'20184455', 0, N'a', N'bbb', CAST(N'2019-11-29' AS Date), CAST(N'2019-11-30' AS Date), 1, 0.0000, N'c', N'cs', N'A1A1A1', N'5061111111')
INSERT [dbo].[Student] ([StudentID], [StudentStatus], [FirstName], [LastName], [StartDate], [EndDate], [ProgramID], [AmountDue], [Address], [City], [PostalCode], [PhoneNumber]) VALUES (N'20194321', 1, N'Fred', N'Chicago', CAST(N'2019-09-03' AS Date), CAST(N'2020-06-16' AS Date), 1, 0.0000, N'road3', N'city3', N'C1C1C1', N'5061234567')
INSERT [dbo].[Student] ([StudentID], [StudentStatus], [FirstName], [LastName], [StartDate], [EndDate], [ProgramID], [AmountDue], [Address], [City], [PostalCode], [PhoneNumber]) VALUES (N'20194561', 1, N'Will', N'Smith', CAST(N'2019-10-01' AS Date), CAST(N'2019-12-31' AS Date), 2, 0.0000, N'road4', N'city4', N'E1E1E1', N'5061234567')
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD  CONSTRAINT [FK_Loan_LoanStatus] FOREIGN KEY([LoanStatusID])
REFERENCES [dbo].[LoanStatus] ([LoanStatusID])
GO
ALTER TABLE [dbo].[Loan] CHECK CONSTRAINT [FK_Loan_LoanStatus]
GO
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD  CONSTRAINT [FK_Loan_Resource] FOREIGN KEY([ResourceID])
REFERENCES [dbo].[Resource] ([ResourceID])
GO
ALTER TABLE [dbo].[Loan] CHECK CONSTRAINT [FK_Loan_Resource]
GO
ALTER TABLE [dbo].[Loan]  WITH CHECK ADD  CONSTRAINT [FK_Loan_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
GO
ALTER TABLE [dbo].[Loan] CHECK CONSTRAINT [FK_Loan_Student]
GO
ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_ResourceStatus] FOREIGN KEY([ResourceStatusID])
REFERENCES [dbo].[ResourceStatus] ([ResourceStatusID])
GO
ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_ResourceStatus]
GO
ALTER TABLE [dbo].[Resource]  WITH CHECK ADD  CONSTRAINT [FK_Resource_ResourceType] FOREIGN KEY([ResourceStatusID])
REFERENCES [dbo].[ResourceType] ([ResourceTypeID])
GO
ALTER TABLE [dbo].[Resource] CHECK CONSTRAINT [FK_Resource_ResourceType]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Program] FOREIGN KEY([ProgramID])
REFERENCES [dbo].[Program] ([ProgramID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Program]
GO
/****** Object:  StoredProcedure [dbo].[Delete_Student]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE     procedure [dbo].[Delete_Student]
	@SID VARCHAR(8)
AS

BEGIN


	DELETE FROM Student WHERE StudentID = @SID;

END;

GO
/****** Object:  StoredProcedure [dbo].[Loan_Insert]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[Loan_Insert]

@SID VARCHAR(8),
@RID VARCHAR(8),
@ChDate	DATETIME,
@DDate DATETIME,
@LoanStatus INT

AS
BEGIN

	BEGIN TRY				

		INSERT INTO Loan
			(StudentID, ResourceID, CheckOutDate, DueDate, LoanStatusID)
		VALUES
			(@SID, @RID, @ChDate, @DDate, @LoanStatus);

		UPDATE Resource
		SET ReserveStatus = 0, ReserveStudentName = NULL, ReserveStudentID = NULL
		WHERE ResourceID = @RID		


	END TRY

	BEGIN CATCH
		;THROW
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[Loan_Update]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[Loan_Update]

@LID VARCHAR(8),
@STS INT

AS

BEGIN
	BEGIN TRY


			if(@STS <= 2)
			begin
				UPDATE Loan
				SET LoanStatusID = 2
				WHERE LoanID = @LID		
			end
			else
			begin
				UPDATE Loan
				SET LoanStatusID = @STS
				WHERE LoanID = @LID		
			end

	END TRY
	BEGIN CATCH
		;THROW
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Payment_Insert]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE     PROC [dbo].[Payment_Insert]

@SID VARCHAR(8),
@FuName VARCHAR(50),
@DateAdded DATETIME,
@Pay Money

AS
BEGIN

	BEGIN TRY				

		INSERT INTO Payment
			(StudentId, StudentName, PaymentDate, PaymentAmount)
		VALUES
			(@SID, @FuName, @DateAdded, @Pay);

		UPDATE Student
		SET AmountDue = AmountDue - @Pay
		WHERE StudentID = @SID		


	END TRY

	BEGIN CATCH
		;THROW
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[Reserve_Resource]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE     PROC [dbo].[Reserve_Resource]

@RID VARCHAR(8),
@SID VARCHAR(8),
@FuName VARCHAR(50)
AS

BEGIN
	BEGIN TRY

			UPDATE Resource
			SET ReserveStatus = 'TRUE', ReserveStudentID = @SID, ReserveStudentName = @FuName
			WHERE ResourceID = @RID		

	END TRY
	BEGIN CATCH
		;THROW
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Retrieve_LoanStu]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Retrieve_LoanStu]

@SID VARCHAR(8)

AS

BEGIN
	BEGIN TRY


		SELECT LoanID,Loan.ResourceID, CheckOutDate, DueDate, ResourceImage, Title ,ResourceType, ResourceStatusType, Resource.ResourceTypeID FROM Loan INNER JOIN Resource ON Resource.ResourceID = Loan.ResourceID INNER JOIN ResourceType ON Resource.ResourceTypeID = ResourceType.ResourceTypeID INNER JOIN ResourceStatus ON Resource.ResourceStatusID = ResourceStatus.ResourceStatusID WHERE StudentID = @SID AND LoanStatusID = 1
	

	END TRY
	BEGIN CATCH
		;THROW
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Retrieve_Resource]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[Retrieve_Resource]

@RID VARCHAR(8)

AS

BEGIN
	BEGIN TRY

	SELECT  Title ,ResourceID,ResourceStatusType,ResourceType, resource.ResourceTypeID , ReserveStatus, ResourceImage ,ReserveStudentID, ReserveStudentName FROM Resource INNER JOIN ResourceType ON Resource.ResourceTypeID = ResourceType.ResourceTypeID INNER JOIN ResourceStatus ON Resource.ResourceStatusID = ResourceStatus.ResourceStatusID  WHERE ResourceID = @RID
		
				
	END TRY
	BEGIN CATCH
		;THROW
	END CATCH

END

GO
/****** Object:  StoredProcedure [dbo].[Retrieve_Student]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[Retrieve_Student]

@SID VARCHAR(8)

AS

BEGIN
	BEGIN TRY

	SELECT StudentID, FirstName, LastName, student.ProgramID, Program.ProgramType, AmountDue, StudentStatus, StartDate, EndDate FROM Student INNER JOIN Program ON Student.ProgramID = Program.ProgramID WHERE StudentID = @SID

	END TRY
	BEGIN CATCH
		;THROW
	END CATCH

END

GO
/****** Object:  StoredProcedure [dbo].[Retrieve_Student_Conc]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE     PROC [dbo].[Retrieve_Student_Conc]

@SID VARCHAR(8)

AS

BEGIN
	BEGIN TRY

	SELECT StudentID, FirstName, LastName, TimeStamp, Address, PostalCode, PhoneNumber, City,student.ProgramID, Program.ProgramType, AmountDue, StudentStatus, StartDate, EndDate FROM Student INNER JOIN Program ON Student.ProgramID = Program.ProgramID WHERE StudentID = @SID
	END TRY
	BEGIN CATCH
		;THROW
	END CATCH

END

GO
/****** Object:  StoredProcedure [dbo].[Retrieve_Student_Via_Resource]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[Retrieve_Student_Via_Resource]

@RID VARCHAR(8)

AS
BEGIN

	BEGIN TRY
		
		SELECT Student.StudentID, StudentStatus, FirstName, Student.ProgramID,LastName, StartDate, EndDate, ProgramType, AmountDue FROM Student INNER JOIN Program ON Student.ProgramID = Program.ProgramID INNER JOIN Loan ON Student.StudentID = Loan.StudentID WHERE ResourceID = @RID AND Loan.LoanStatusID = 1
	END TRY

	BEGIN CATCH
		;THROW
	END CATCH

END

GO
/****** Object:  StoredProcedure [dbo].[Set_Resource_Status]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[Set_Resource_Status]

@RID VARCHAR(8)

AS

BEGIN
	BEGIN TRY	

		UPDATE Resource
		SET ResourceStatusID = 2
		WHERE ResourceID = @RID		
				
	END TRY
	BEGIN CATCH
		;THROW
	END CATCH
END

GO
/****** Object:  StoredProcedure [dbo].[Set_Resource_Status_2]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[Set_Resource_Status_2]

@RID VARCHAR(8),
@RSTAT INT
AS

BEGIN
	BEGIN TRY

		IF(@RSTAT = 3)
		BEGIN
			UPDATE Resource
			SET ResourceStatusID = 3
			WHERE ResourceID = @RID		
		END	
		IF(@RSTAT != 3)
		BEGIN
			UPDATE Resource
			SET ResourceStatusID = 1
			WHERE ResourceID = @RID		
		END

	END TRY
	BEGIN CATCH
		;THROW
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[Student_Insert]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE     PROCEDURE [dbo].[Student_Insert]
	@TimeStamp TIMESTAMP = NULL OUTPUT,
	@SID VARCHAR(8),
	@Status BIT,
	@Fname VARCHAR(30),
	@Lname VARCHAR(30),
	@Start DATETIME,
	@End DATETIME,
	@PID INT,
	@Address VARCHAR(50),
	@City VARCHAR(20),
	@PostalCode VARCHAR(6),
	@Phone VARCHAR(10)
AS
BEGIN


	BEGIN TRY
		IF EXISTS(SELECT * FROM Student WHERE StudentID = @SID)
			THROW 51000, 'A student with that id already exists.', 1;

		
		IF (@Start > @End)
			THROW 51001, 'Start Date cannot be greater than end date', 1;

		INSERT INTO Student
			(StudentID,StudentStatus, FirstName, LastName, StartDate, EndDate, ProgramID, AmountDue, Address, City, PostalCode, PhoneNumber)
		VALUES
			(@SID, @Status, @Fname, @LName, @Start, @End, @PID, 0, @Address, @City, @PostalCode, @Phone);

			SET @TimeStamp = (SELECT TimeStamp FROM Student WHERE StudentID = @SID)

	END TRY
	BEGIN CATCH
		;THROW
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[Student_Lookup]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Student_Lookup]

@LName VARCHAR(15),
@SID VARCHAR(8)

AS

BEGIN
	BEGIN TRY

	IF NOT EXISTS(SELECT * FROM Student WHERE StudentID = @SID) AND @SID <> ''
			THROW 51000, 'This ID does not exist in our database', 1
	IF NOT EXISTS(SELECT * FROM Student WHERE LastName LIKE '%'+ @LName +'%') AND @LName <> ''
			THROW 51000, 'There are no students with that match the search', 1

	
	if(@LName = '')
	SELECT * FROM Student WHERE StudentID = @SID
	else
	SELECT * FROM Student WHERE LastName LIKE '%'+ @LName +'%'
				
	END TRY
	BEGIN CATCH
		;THROW
	END CATCH

END

GO
/****** Object:  StoredProcedure [dbo].[Student_Update]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE       PROCEDURE [dbo].[Student_Update]
	@TimeStamp TIMESTAMP OUTPUT,
	@SID VARCHAR(8),
	@Status BIT,
	@Fname VARCHAR(30),
	@Lname VARCHAR(30),
	@Start DATETIME,
	@End DATETIME,
	@PID INT,
	@AMTD MONEY,
	@Address VARCHAR(50),
	@City VARCHAR(20),
	@PostalCode VARCHAR(6),
	@Phone VARCHAR(10)
AS
BEGIN


	BEGIN TRY
		
		IF (@Start > @End)
			THROW 51001, 'Start Date cannot be greater than end date', 1;

		IF (SELECT [TimeStamp] FROM Student WHERE StudentID = @SID) <> @TimeStamp
		THROW 51005, 'The record has been updated by someone since you last retrieved it. Retrieve the record again before you make updates', 1

		UPDATE Student SET
			FirstName = @FName,
			LastName = @LName,
			StudentStatus = @Status,
			EndDate = @End,
			StartDate = @Start,
			ProgramID = @PID,
			AmountDue = @AMTD,
			Address = @Address,
			City = @City,
			PostalCode = @PostalCode,
			PhoneNumber = @Phone
		WHERE
			StudentID = @SID;

			SET @TimeStamp = (SELECT [TimeStamp] FROM Student WHERE StudentID = @SID)


	END TRY
	BEGIN CATCH
		;THROW
	END CATCH

END

select * from Student
GO
/****** Object:  StoredProcedure [dbo].[Update_Loan]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[Update_Loan]

@LID VARCHAR(8)

AS

BEGIN
	BEGIN TRY

			UPDATE Loan
		SET LoanStatusID = 2
		WHERE LoanID = @LID		

	END TRY
	BEGIN CATCH
		;THROW
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Student_Due]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[Update_Student_Due]

@LID VARCHAR(8),
@Now DATETIME

AS

BEGIN
	BEGIN TRY

			UPDATE Student
		SET AmountDue += 5 * DATEDIFF(DAY, DueDate, @Now)
		FROM Student
		INNER JOIN Loan ON Student.StudentID = Loan.StudentID WHERE LoanID = @LID	

	END TRY
	BEGIN CATCH
		;THROW
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Student_Due_Missing]    Script Date: 11/29/2019 5:50:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[Update_Student_Due_Missing]

@LID VARCHAR(8)

AS

BEGIN
	BEGIN TRY

			UPDATE Student
		SET AmountDue += ResourcePrice
		FROM Student
		INNER JOIN Loan ON Student.StudentID = Loan.StudentID INNER JOIN Resource ON Loan.ResourceID = Resource.ResourceID WHERE LoanID = @LID	

		UPDATE Resource
		SET ResourceStatusID = 3, DateRemoved = GETDATE()
		FROM Student
		INNER JOIN Loan ON Student.StudentID = Loan.StudentID INNER JOIN Resource ON Loan.ResourceID = Resource.ResourceID WHERE LoanID = @LID	
		
		UPDATE Loan
		SET LoanStatusID = 4	
		FROM Student
		INNER JOIN Loan ON Student.StudentID = Loan.StudentID INNER JOIN Resource ON Loan.ResourceID = Resource.ResourceID WHERE LoanID = @LID	

	END TRY
	BEGIN CATCH
		;THROW
	END CATCH
END

GO
