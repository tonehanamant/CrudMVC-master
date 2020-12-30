# CrudMVC
CRUD operations for a Employee table using Asp.NET MVC and ADO.NET 

SQL for creating Employee table:


CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[City] [varchar](50) NULL,
	[Address] [varchar](200) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]



Any questions you can contact me in hudsonlima.ti@gmail.com
