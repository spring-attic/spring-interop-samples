USE [SpringInterop]
GO
/****** Object:  Table [dbo].[Trade]    Script Date: 10/19/2011 18:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Trade](
	[Id] [uniqueidentifier] NOT NULL,
	[Symbol] [varchar](10) NOT NULL,
	[Quantity] [int] NOT NULL,
	[ExecutionPrice] [decimal](18, 2) NOT NULL,
	[Type] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Trade] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CreditCheckFailure]    Script Date: 10/19/2011 18:45:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CreditCheckFailure](
	[Id] [uniqueidentifier] NOT NULL,
	[Symbol] [varchar](10) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Failure_Reason] [varchar](50) NOT NULL,
	[Type] [varchar](10) NOT NULL,
	[DateTime] [date] NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_Table_1_Id]    Script Date: 10/19/2011 18:45:13 ******/
ALTER TABLE [dbo].[CreditCheckFailure] ADD  CONSTRAINT [DF_Table_1_Id]  DEFAULT (newid()) FOR [Id]
GO
/****** Object:  Default [DF_Trade_Id]    Script Date: 10/19/2011 18:45:13 ******/
ALTER TABLE [dbo].[Trade] ADD  CONSTRAINT [DF_Trade_Id]  DEFAULT (newid()) FOR [Id]
GO
