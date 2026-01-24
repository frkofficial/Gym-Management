USE [GYMSDB]
GO
ALTER TABLE [dbo].[UserInfo] DROP CONSTRAINT [DF_UserInfo_UserType]
GO
ALTER TABLE [dbo].[EmpInfo] DROP CONSTRAINT [DF_EmpInfo_UserType]
GO
ALTER TABLE [dbo].[AdminInfo] DROP CONSTRAINT [DF_AdminInfo_UserType]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 1/18/2026 3:19:30 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[UserInfo]') AND type in (N'U'))
DROP TABLE [dbo].[UserInfo]
GO
/****** Object:  Table [dbo].[EmpInfo]    Script Date: 1/18/2026 3:19:30 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EmpInfo]') AND type in (N'U'))
DROP TABLE [dbo].[EmpInfo]
GO
/****** Object:  Table [dbo].[AdminInfo]    Script Date: 1/18/2026 3:19:30 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AdminInfo]') AND type in (N'U'))
DROP TABLE [dbo].[AdminInfo]
GO
/****** Object:  Table [dbo].[AdminInfo]    Script Date: 1/18/2026 3:19:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AdminInfo](
	[AdminId] [int] NOT NULL,
	[AdminUserName] [nvarchar](50) NOT NULL,
	[AdminFirstName] [nvarchar](50) NOT NULL,
	[AdminLastname] [nvarchar](50) NULL,
	[AdminPass] [nvarchar](50) NOT NULL,
	[Rank] [nvarchar](50) NOT NULL,
	[UserType] [nvarchar](50) NOT NULL,
	[AdminPhone] [nvarchar](50) NOT NULL,
	[AdminEmail] [nvarchar](50) NOT NULL,
	[AdminAddress] [nvarchar](50) NOT NULL,
	[AdminDOB] [nvarchar](50) NOT NULL,
	[AdminGender] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AdminInfo] PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpInfo]    Script Date: 1/18/2026 3:19:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpInfo](
	[EmpId] [int] NOT NULL,
	[EmpName] [nvarchar](50) NOT NULL,
	[EmpFirstName] [nvarchar](50) NOT NULL,
	[EmpLastName] [nvarchar](50) NULL,
	[EmpPass] [nvarchar](50) NOT NULL,
	[EmpJob] [nvarchar](50) NOT NULL,
	[UserType] [nvarchar](50) NOT NULL,
	[EmpPhone] [nvarchar](50) NOT NULL,
	[EmpAddress] [nvarchar](50) NOT NULL,
	[EmpEmail] [nvarchar](50) NOT NULL,
	[EmpGender] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EmpInfo] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 1/18/2026 3:19:30 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[UserFirstName] [nvarchar](50) NOT NULL,
	[UserLastName] [nvarchar](50) NULL,
	[UserPass] [nvarchar](50) NOT NULL,
	[UserConPass] [nvarchar](50) NOT NULL,
	[UserType] [nvarchar](50) NOT NULL,
	[UserPhone] [nvarchar](50) NOT NULL,
	[UserEmail] [nvarchar](50) NOT NULL,
	[UserAddress] [nvarchar](50) NOT NULL,
	[UserGender] [varchar](50) NOT NULL,
	[UserAge] [int] NOT NULL,
	[UserHeight] [float] NOT NULL,
	[UserWeight] [int] NOT NULL,
	[UserWeightGoal] [int] NULL,
	[UserTrainer] [varchar](50) NOT NULL,
	[UserEmrPhone] [nvarchar](50) NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AdminInfo] ([AdminId], [AdminUserName], [AdminFirstName], [AdminLastname], [AdminPass], [Rank], [UserType], [AdminPhone], [AdminEmail], [AdminAddress], [AdminDOB], [AdminGender]) VALUES (1, N'Faruk', N'Umar', N'Faruk', N'1234', N'CEO', N'Admin', N'01786767576', N'faruk@gmail.com', N'Panthapath,Dhaka', N'12/6/1996', N'Male')
GO
INSERT [dbo].[AdminInfo] ([AdminId], [AdminUserName], [AdminFirstName], [AdminLastname], [AdminPass], [Rank], [UserType], [AdminPhone], [AdminEmail], [AdminAddress], [AdminDOB], [AdminGender]) VALUES (2, N'Anika', N'Anika', NULL, N'2345', N'CEO', N'Admin', N'01765765665', N'anika@gmail.com', N'Shatarkul,Dhaka', N'12/5/1990', N'Female')
GO
INSERT [dbo].[AdminInfo] ([AdminId], [AdminUserName], [AdminFirstName], [AdminLastname], [AdminPass], [Rank], [UserType], [AdminPhone], [AdminEmail], [AdminAddress], [AdminDOB], [AdminGender]) VALUES (3, N'Shuvo', N'AF', N'Shuvo', N'5678', N'CEO', N'Admin', N'01876765655', N'shuvo@gmail.com', N'Dhaka Cantonment', N'19/9/2001', N'Male')
GO
INSERT [dbo].[AdminInfo] ([AdminId], [AdminUserName], [AdminFirstName], [AdminLastname], [AdminPass], [Rank], [UserType], [AdminPhone], [AdminEmail], [AdminAddress], [AdminDOB], [AdminGender]) VALUES (4, N'Tariq', N'Tariq', N'Rahman', N'6789', N'Managing Director', N'Admin', N'01876776556', N'tariq@gmail.com', N'Bijoy Sharani,Dhaka', N'6/1/1996', N'Male')
GO
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [EmpFirstName], [EmpLastName], [EmpPass], [EmpJob], [UserType], [EmpPhone], [EmpAddress], [EmpEmail], [EmpGender]) VALUES (1, N'Raju', N'Raju', N'Hawlader', N'1234', N'Manager', N'Employee', N'0176576565', N'Fakrirapool,Dhaka', N'raju@gmail.com', N'Male')
GO
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [EmpFirstName], [EmpLastName], [EmpPass], [EmpJob], [UserType], [EmpPhone], [EmpAddress], [EmpEmail], [EmpGender]) VALUES (2, N'Galib', N'Galib', N'Mirza', N'Adison', N'Trainer', N'Employee', N'0165654567', N'Motijheel,Dhaka', N'galib@gmail.com', N'Male')
GO
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [EmpFirstName], [EmpLastName], [EmpPass], [EmpJob], [UserType], [EmpPhone], [EmpAddress], [EmpEmail], [EmpGender]) VALUES (3, N'Hamid', N'Hamid', N'Sarworar', N'xyzk', N'Gymboy', N'Employee', N'0187765765', N'Jatrabari,Dhaka', N'hamid@gmail.com', N'Male')
GO
INSERT [dbo].[EmpInfo] ([EmpId], [EmpName], [EmpFirstName], [EmpLastName], [EmpPass], [EmpJob], [UserType], [EmpPhone], [EmpAddress], [EmpEmail], [EmpGender]) VALUES (4, N'Tanvir', N'Tanvir', N'Karim', N'twqs', N'Manager', N'Employee', N'0176657656', N'Aftabnagar,Dhaka', N'tanvir@gmail.com', N'Male')
GO
SET IDENTITY_INSERT [dbo].[UserInfo] ON 
GO
INSERT [dbo].[UserInfo] ([UserId], [UserName], [UserFirstName], [UserLastName], [UserPass], [UserConPass], [UserType], [UserPhone], [UserEmail], [UserAddress], [UserGender], [UserAge], [UserHeight], [UserWeight], [UserWeightGoal], [UserTrainer], [UserEmrPhone]) VALUES (1, N'Fahid', N'Asif', N'Fahid', N'@1234', N'@1234', N'Member', N'01234345464', N'fahid@gmail.com', N'Dhaka Metro', N'Male', 34, 5.6, 65, 57, N'Yes', N'01445566556')
GO
INSERT [dbo].[UserInfo] ([UserId], [UserName], [UserFirstName], [UserLastName], [UserPass], [UserConPass], [UserType], [UserPhone], [UserEmail], [UserAddress], [UserGender], [UserAge], [UserHeight], [UserWeight], [UserWeightGoal], [UserTrainer], [UserEmrPhone]) VALUES (2, N'Kaiyum', N'Kayium', N'Haq', N'*2345', N'*2345', N'Member', N'01676324763', N'haq@gmail.com', N'Dhaka,Khilgaon', N'Male', 28, 5.8, 67, 55, N'Yes', N'01767677656')
GO
INSERT [dbo].[UserInfo] ([UserId], [UserName], [UserFirstName], [UserLastName], [UserPass], [UserConPass], [UserType], [UserPhone], [UserEmail], [UserAddress], [UserGender], [UserAge], [UserHeight], [UserWeight], [UserWeightGoal], [UserTrainer], [UserEmrPhone]) VALUES (3, N'Rahim', N'Rahim', N'Rahman', N'$4567', N'$4567', N'Member', N'017657657676', N'Rahmn7@gmail.com', N'Dhaka,Uttara', N'Male', 25, 6, 70, 60, N'Yes', N'01765475466')
GO
INSERT [dbo].[UserInfo] ([UserId], [UserName], [UserFirstName], [UserLastName], [UserPass], [UserConPass], [UserType], [UserPhone], [UserEmail], [UserAddress], [UserGender], [UserAge], [UserHeight], [UserWeight], [UserWeightGoal], [UserTrainer], [UserEmrPhone]) VALUES (4, N'Yousha', N'Yousha', N'Bin Salam', N'^9087', N'^9087', N'Member', N'016576576577', N'yousha11@gmail.com', N'Dhaka,Banani', N'Male', 22, 5.6, 57, 53, N'No', N'01545354343')
GO
INSERT [dbo].[UserInfo] ([UserId], [UserName], [UserFirstName], [UserLastName], [UserPass], [UserConPass], [UserType], [UserPhone], [UserEmail], [UserAddress], [UserGender], [UserAge], [UserHeight], [UserWeight], [UserWeightGoal], [UserTrainer], [UserEmrPhone]) VALUES (5, N'abul', N'Abul', NULL, N'Abc@1234', N'Abc@1234', N'Member', N'01764893470', N'abul@gmail.com', N'Pallabi, Mirpur 11', N'Male', 27, 5.5999999046325684, 55, 50, N'Yes', N'01672465890')
GO
SET IDENTITY_INSERT [dbo].[UserInfo] OFF
GO
ALTER TABLE [dbo].[AdminInfo] ADD  CONSTRAINT [DF_AdminInfo_UserType]  DEFAULT (N'Admin') FOR [UserType]
GO
ALTER TABLE [dbo].[EmpInfo] ADD  CONSTRAINT [DF_EmpInfo_UserType]  DEFAULT (N'Employee') FOR [UserType]
GO
ALTER TABLE [dbo].[UserInfo] ADD  CONSTRAINT [DF_UserInfo_UserType]  DEFAULT (N'Member') FOR [UserType]
GO
