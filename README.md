# EmployeeWebAPI

The API is connecting to a local SQL server DB of below name: "EmployeeDB"

You can also create a table of below structure in your own named DB and just regenerate the edmx  file and build the project before running.


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employee](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[who] [nvarchar](50) NULL,
	[phone] [nvarchar](50) NULL,
	[pic] [nvarchar](50) NULL,
	[designation] [nvarchar](50) NULL,
	[bloodgrp] [nchar](10) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
