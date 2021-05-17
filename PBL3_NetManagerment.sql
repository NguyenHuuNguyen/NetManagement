CREATE DATABASE NetManagement
GO
USE NetManagement
GO

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 1,
	Type BIT NOT NULL DEFAULT 0,   -- khach || admin
	Balance FLOAT NOT NULL DEFAULT 0,
	AccountStatus BIT NOT NULL DEFAULT 0 -- not using || using
)
GO

CREATE TABLE Computer
(
	idComputer NVARCHAR(100) PRIMARY KEY,
	ComputerName INT IDENTITY(1000000, 1),
	ComputerPrice FLOAT NOT NULL DEFAULT 0,
	ComputerStatus BIT NOT NULL DEFAULT 0, -- not using || using
)
GO

CREATE TABLE ComputerLog
(
	idLog INT IDENTITY(2000000, 1) PRIMARY KEY,
	DateLogin DATE NOT NULL DEFAULT GETDATE(),
	DateLogout DATE NOT NULL DEFAULT GETDATE(),
	idComputer NVARCHAR(100) FOREIGN KEY REFERENCES dbo.Computer(idComputer),
	UserName NVARCHAR(100) FOREIGN KEY REFERENCES dbo.Account(UserName)
)
GO

CREATE TABLE Good
(
	idGood INT IDENTITY(3000000, 1) PRIMARY KEY,
	GoodName NVARCHAR(100) NOT NULL DEFAULT N'Unnamed',
	GoodPrice FLOAT NOT NULL DEFAULT 0
)

CREATE TABLE Bill
(
	idBill INT IDENTITY(4000000, 1) PRIMARY KEY,
	Date DATE NOT NULL DEFAULT GETDATE(),
	UserName NVARCHAR(100) FOREIGN KEY REFERENCES dbo.Account(UserName)
)
GO

CREATE TABLE BillInfo
(
	idBillInfo INT IDENTITY(5000000, 1) PRIMARY KEY,
	idBill INT FOREIGN KEY REFERENCES dbo.Bill(idBill),
	idGood INT FOREIGN KEY REFERENCES dbo.Good(idGood),
	Count INT NOT NULL DEFAULT 0
)
GO

insert into Bill values('12/12/12','user1')
insert into Computer values('asdasd','233','0')


