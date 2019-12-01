USE [lab360]
GO

/****** Object:  Table [dbo].[Cryptocurrency]    Script Date: 01.12.2019 14:30:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cryptocurrency](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CryptocurrencyName] [nvarchar](255) NULL,
	[CryptocurrencySymbol] [nvarchar](255) NULL,
	[CryptocurrencyRank] [nvarchar](255) NULL,
	[CirculatingSupply] [nvarchar](255) NULL,
	[TotalSupply] [nvarchar](255) NULL,
	[MaxSupply] [nvarchar](255) NULL,
	[Price] [nvarchar](255) NULL,
	[Volume24h] [nvarchar](255) NULL,
	[MarketCap] [nvarchar](255) NULL,
	[PercentChange1h] [nvarchar](255) NULL,
	[PercentChange24h] [nvarchar](255) NULL,
	[PercentChange7d] [nvarchar](255) NULL,
	[LastUpdateTime] [nvarchar](255) NULL,
 CONSTRAINT [PK_Cryptocureency] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


