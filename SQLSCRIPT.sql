USE [ITCenterDB]
GO

/****** Object:  Table [dbo].[Headers]    Script Date: 2019-07-09 15:57:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Headers](
	[Id] [int] IDENTITY(0,1) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[CustomerNumber] [int] NOT NULL,
	[NetPrice] [decimal](19, 2) NOT NULL,
	[GrossPrice] [decimal](19, 2) NOT NULL,
 CONSTRAINT [Headers_pk] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Rows](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HeaderId] [int] NOT NULL,
	[ArticleName] [nvarchar](50) NOT NULL,
	[Quantity] [decimal](19, 2) NOT NULL,
	[NetPrice] [decimal](19, 2) NOT NULL,
	[GrossPrice] [decimal](19, 2) NOT NULL,
 CONSTRAINT [Rows_pk] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Rows]  WITH CHECK ADD  CONSTRAINT [Rows_fk] FOREIGN KEY([HeaderId])
REFERENCES [dbo].[Headers] ([Id])
GO

ALTER TABLE [dbo].[Rows] CHECK CONSTRAINT [Rows_fk]
GO