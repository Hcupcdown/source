USE [Hospital]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 2019/10/12 18:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Dept_id] [int] IDENTITY(1,1) NOT NULL,
	[Dept_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_dbo.Departments] PRIMARY KEY CLUSTERED 
(
	[Dept_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 2019/10/12 18:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[Doctor_id] [int] IDENTITY(1,1) NOT NULL,
	[Doctor_name] [nvarchar](50) NOT NULL,
	[Doctor_surname] [nvarchar](50) NOT NULL,
	[Dept_id] [int] NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[User_id] [int] NOT NULL,
	[Address] [nvarchar](250) NULL,
 CONSTRAINT [PK_dbo.Doctors] PRIMARY KEY CLUSTERED 
(
	[Doctor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patient_Admissions]    Script Date: 2019/10/12 18:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient_Admissions](
	[Patient_ad_id] [int] IDENTITY(1,1) NOT NULL,
	[Patient_id] [int] NOT NULL,
	[Dept_id] [int] NOT NULL,
	[Doctor_id] [int] NOT NULL,
	[Date_in] [date] NOT NULL,
	[Complaint] [nvarchar](250) NULL,
	[Diagnosis] [nvarchar](250) NULL,
	[Prescription] [nvarchar](250) NULL,
	[Blood_analysis] [bit] NULL,
	[Urianalysis] [bit] NULL,
	[Xray] [bit] NULL,
 CONSTRAINT [PK_dbo.Patient_Admissions] PRIMARY KEY CLUSTERED 
(
	[Patient_ad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patients]    Script Date: 2019/10/12 18:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[Patient_id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Ssn] [nvarchar](20) NOT NULL,
	[Father_name] [nvarchar](50) NOT NULL,
	[Birth_place] [nvarchar](50) NOT NULL,
	[Birth_date] [date] NOT NULL,
	[Sex] [nvarchar](10) NOT NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[Address] [varchar](250) NULL,
 CONSTRAINT [PK_dbo.Patients] PRIMARY KEY CLUSTERED 
(
	[Patient_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Staffs]    Script Date: 2019/10/12 18:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staffs](
	[Staff_id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](250) NULL,
	[Phone] [nvarchar](20) NOT NULL,
	[User_id] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Staffs] PRIMARY KEY CLUSTERED 
(
	[Staff_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 2019/10/12 18:11:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[User_id] [int] IDENTITY(1,1) NOT NULL,
	[User_name] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Job] [varchar](50) NOT NULL,
	[E_mail] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED 
(
	[User_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD  CONSTRAINT [Department_Doctor] FOREIGN KEY([Dept_id])
REFERENCES [dbo].[Departments] ([Dept_id])
GO
ALTER TABLE [dbo].[Doctors] CHECK CONSTRAINT [Department_Doctor]
GO
ALTER TABLE [dbo].[Doctors]  WITH CHECK ADD  CONSTRAINT [User_Doctor] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([User_id])
GO
ALTER TABLE [dbo].[Doctors] CHECK CONSTRAINT [User_Doctor]
GO
ALTER TABLE [dbo].[Patient_Admissions]  WITH CHECK ADD  CONSTRAINT [Department_Patient_Admission] FOREIGN KEY([Dept_id])
REFERENCES [dbo].[Departments] ([Dept_id])
GO
ALTER TABLE [dbo].[Patient_Admissions] CHECK CONSTRAINT [Department_Patient_Admission]
GO
ALTER TABLE [dbo].[Patient_Admissions]  WITH CHECK ADD  CONSTRAINT [Doctor_Patient_Admission] FOREIGN KEY([Doctor_id])
REFERENCES [dbo].[Doctors] ([Doctor_id])
GO
ALTER TABLE [dbo].[Patient_Admissions] CHECK CONSTRAINT [Doctor_Patient_Admission]
GO
ALTER TABLE [dbo].[Patient_Admissions]  WITH CHECK ADD  CONSTRAINT [Patient_Patient_Admission] FOREIGN KEY([Patient_id])
REFERENCES [dbo].[Patients] ([Patient_id])
GO
ALTER TABLE [dbo].[Patient_Admissions] CHECK CONSTRAINT [Patient_Patient_Admission]
GO
ALTER TABLE [dbo].[Staffs]  WITH CHECK ADD  CONSTRAINT [User_Staff] FOREIGN KEY([User_id])
REFERENCES [dbo].[Users] ([User_id])
GO
ALTER TABLE [dbo].[Staffs] CHECK CONSTRAINT [User_Staff]
GO
