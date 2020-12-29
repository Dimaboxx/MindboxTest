use test

DROP TABLE IF EXISTS [dbo].[Products]
DROP TABLE IF EXISTS [dbo].[Category]
DROP TABLE IF EXISTS [dbo].[ProductCategory]



CREATE TABLE [dbo].[Products]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1) ,
	[ProductName] nvarchar(52) not null 
)



create table [dbo].[Category]
(
	[Id] int not null IDENTITY(1,1) PRIMARY KEY,
	[CategoryName] nvarchar(52) not null

)

create table [dbo].[ProductCategory]
(
	[ProductId] int not null,
	[CategoryId] int not null,
	 CONSTRAINT [FK_ProductCategory_ProductId] FOREIGN KEY (ProductId) REFERENCES [dbo].Products ([id]) ,
	 CONSTRAINT [FK_ProductCategory_CategoryId] FOREIGN KEY (CategoryId) REFERENCES [dbo].Products ([id])
)


insert into Products (ProductName) Values (N'Продукт 1'),(N'Продукт 2'),(N'Продукт 3'),(N'Продукт 4')
select * from dbo.Products

insert into Category(CategoryName) Values (N'Категория 1'),(N'Категория 2'),(N'Категория 3')
select * from dbo.Category

insert into ProductCategory(ProductId,CategoryId) Values (1,1),(1,3),(2,2)
select * from dbo.ProductCategory


select 
	p.ProductName,
	pc2.CategoryName 
from dbo.Products as p 
	left outer join (select pc.ProductId, c.CategoryName from ProductCategory as pc  
	join Category as c on pc.CategoryId = c.Id) as pc2 on p.Id = pc2.ProductId