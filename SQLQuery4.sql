create table Customers
(
 Customers_Id int identity (100000,1) primary key,
 Customers_DocNum nvarchar (50) not null,
 Customers_FirstName nvarchar (50) not null,
 Customers_LastName nvarchar (50) not null,
 Customers_Address nvarchar (50) not null,
 CustomersBirthday nvarchar (50) not null,
 CustomersPhoneNumber nvarchar (50) not null,
 CustomersEmail nvarchar (50) not null,
)
