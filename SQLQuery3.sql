create table Categories
(
 Categories_Id int identity (100000,1) primary key,
 Categories_Name nvarchar (50) not null,
 Categories_Description nvarchar (100) not null,
)
