USE [SchoolActivity]
GO
/****** Object:  Table [dbo].[Classroom]    Script Date: 13/03/2024 5:28:45 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classroom](
	[ClassroomId] [varchar](10) NOT NULL,
	[Month] [int] NOT NULL,
	[Week] [int] NOT NULL,
	[ActivityPoints] [int] NULL,
	[MinusPoints] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassroomId] ASC,
	[Month] ASC,
	[Week] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Classroom] ([ClassroomId], [Month], [Week], [ActivityPoints], [MinusPoints]) VALUES (N'6A1', 1, 1, 90, 4)
GO
INSERT [dbo].[Classroom] ([ClassroomId], [Month], [Week], [ActivityPoints], [MinusPoints]) VALUES (N'6A1', 1, 2, 85, 10)
GO
INSERT [dbo].[Classroom] ([ClassroomId], [Month], [Week], [ActivityPoints], [MinusPoints]) VALUES (N'6A1', 1, 3, 100, 5)
GO
INSERT [dbo].[Classroom] ([ClassroomId], [Month], [Week], [ActivityPoints], [MinusPoints]) VALUES (N'6A1', 1, 4, 95, 2)
GO
INSERT [dbo].[Classroom] ([ClassroomId], [Month], [Week], [ActivityPoints], [MinusPoints]) VALUES (N'7A2', 1, 1, 100, 2)
GO
INSERT [dbo].[Classroom] ([ClassroomId], [Month], [Week], [ActivityPoints], [MinusPoints]) VALUES (N'7A2', 1, 2, 95, 12)
GO
INSERT [dbo].[Classroom] ([ClassroomId], [Month], [Week], [ActivityPoints], [MinusPoints]) VALUES (N'7A2', 1, 3, 90, 10)
GO
INSERT [dbo].[Classroom] ([ClassroomId], [Month], [Week], [ActivityPoints], [MinusPoints]) VALUES (N'7A2', 1, 4, 100, 0)
GO
