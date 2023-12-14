create database QLyNhaHangPizza
use QLyNhaHangPizza
create table Role (
	typeRole INT PRIMARY KEY,
	nameRole nvarchar(10)
)
CREATE TABLE tAccount(
	idAccount INT IDENTITY,
	displayname NVARCHAR (100) NOT NULL,
    username NVARCHAR (100) NOT NULL,
	password NVARCHAR (1000) NOT NULL DEFAULT 0,
	type INT NOT NULL,
	phoneNumber NVARCHAR (100) NOT NULL,
	avtAccount nvarchar(100)
	PRIMARY KEY (idAccount, username)
)
select count(*) from tAccount where username = 'admin' and password = '123'
select * from tAccount where username = 'admin' and password = '123' Or 1=1--'
select * from tAccount where username = '' Or 1=1--
CREATE TABLE tStaff (
    idStaff INT IDENTITY,
    Name NVARCHAR(100) null,
    Diachi NVARCHAR(100),
    phoneNumber NVARCHAR(100) NOT NULL,
    role INT NOT NULL,
    FOREIGN KEY (role) REFERENCES Role(typeRole),
    avtStaff NVARCHAR(100),
    PRIMARY KEY (idStaff)
)

insert into Role (typeRole, nameRole)
Values(1, N'Manager')
insert into Role (typeRole, nameRole)
Values(0, N'Waiter')
GO
select idStaff,Name from tStaff join Role on tStaff.role = Role.typeRole where Role.nameRole = N'Waiter'
--INSERT INTO dbo.tStaff(Name, Diachi, phoneNumber, role, avtStaff)
--VALUES (N'Chun Hiếu', N'Thanh Hóa', N'0344215273', 0, '');
--INSERT INTO dbo.tStaff(Name, Diachi, phoneNumber, role, avtStaff)
--VALUES (N'Đoàn Trần', N'Bắc Ninh', N'0344251616', 0, '');
--INSERT INTO dbo.tStaff(Name, Diachi, phoneNumber, role, avtStaff)
--VALUES (N'Minh Đức', N'Hà Nội', N'0344400273', 1,'');
--INSERT INTO dbo.tStaff(Name, Diachi, phoneNumber, role, avtStaff)
--VALUES (N'Hoàng Lê', N'Thanh Hóa', N'0368900273', 0,'');
select*from tStaff


CREATE TABLE tFoodCategory
( 
     idCategory INT IDENTITY PRIMARY KEY,
	 nameCategory NVARCHAR (100) NOT NULL,
	 avtCategory nvarchar(100)
)

CREATE TABLE tFood
(
     idFood INT IDENTITY PRIMARY KEY,
	 nameFood NVARCHAR (100) Not null ,
	 idCategory INT NOT NULL,
	 priceFood float NOT NULL DEFAULT 0,
	 FOREIGN KEY (idCategory) REFERENCES dbo.tFoodCategory(idCategory),
	 avtFood nvarchar(100)
)
GO
CREATE TABLE tTable
(
     idTable INT IDENTITY PRIMARY KEY,
	 nameTable NVARCHAR (100) null,
	 avtTable nvarchar(100)
)
--ALTER TABLE tblDetails
--DROP CONSTRAINT [FK_tblDetails_tblMain];
--DROP TABLE IF EXISTS tTable;
--DROP TABLE IF EXISTS tStaff;
--DROP TABLE IF EXISTS tblMain;
Create table tblMain (
	MainID int primary key identity,
	aDate date,
	aTime nvarchar(100),
	idTable int null,
	idStaff int null,
	status nvarchar(10),
	orderType nvarchar(30),
	total float,
	received float,
	change float,
	CusName nvarchar(50),
	CusPhone nvarchar(50),
	CusAddress nvarchar(50)
)
ALTER TABLE tblMain
ALTER COLUMN aDate DATETIME;

GO
create table tblDetails (
	DetailID int primary key identity,
	MainID int,
	proID int,
	qty int,
	price float,
	amount float,
	FOREIGN KEY (MainID) REFERENCES dbo.tblMain(MainID)
)

SELECT idAccount, displayname, username, phoneNumber, CASE WHEN type = 0 THEN 'Waiter' ELSE 'Manager' END AS Role FROM tAccount
--delete tblMain
--delete tblDetails
select*from tblMain inner join tblDetails on tblDetails.MainID = tblMain.MainID
select*from tblMain
select*from tblDetails
Select * from tblMain where status = 'pending'

--INSERT INTO dbo.tAccount (displayname, username, password, phoneNumber, type)
--VALUES (N'AdminDz', N'admin', N'123', N'0344400273', 1);
--INSERT INTO dbo.tAccount (displayname, username, password, phoneNumber, type)
--VALUES (N'Chun Hiếu', N'chunhieu', N'123', N'0352106414', 0);
--INSERT INTO dbo.tAccount (displayname, username, password, phoneNumber, type)
--VALUES (N'Hoàng Lê', N'hoangle', N'123', N'0352106414', 0);
--INSERT INTO dbo.tAccount (displayname, username, password, phoneNumber, type)
--VALUES (N'Đoàn Trần', N'doantran', N'123', N'0352106414', 0);

--delete dbo.tAccount

select*from dbo.tAccount
select idAccount, displayname, username, phoneNumber, CASE when type = 0 then 'Waiter' else 'Manager' end as Role from tAccount
--Insert dbo.tFoodCategory(nameCategory)
--Values (N'Pizza hải sản')
--Insert dbo.tFoodCategory(nameCategory)
--Values (N'Pizza gà')
--Insert dbo.tFoodCategory(nameCategory)
--Values (N'Pizza bò')
--Insert dbo.tFoodCategory(nameCategory)
--Values (N'Pizza chay')
--Insert dbo.tFoodCategory(nameCategory)
--Values (N'Món khai vị')
--Insert dbo.tFoodCategory(nameCategory)
--Values (N'Thức uống')
GO
select*from dbo.tFoodCategory

--GO
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Pizza hải sản xốt Pesto', 1, 159000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Pizza cơn lốc hải sản', 1, 139000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Pizza hải sản nhiệt đới', 1, 129000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Pizza hải sản xốt tiêu đen', 1, 129000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Pizza rau củ (xốt bơ tỏi)', 4, 89000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Pizza Haiwaiian', 4, 119000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Pizza phô mai cao cấp', 4, 89000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Pizza gà nướng nấm', 2, 119000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Pizza gà phô mai', 2, 119000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Pizza bò BBQ', 3, 119000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Pizza thịt bò và HS', 3, 119000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Bánh cuộn phô mai', 5, 69000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Salad gà Pesto', 5, 79000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Mỳ ý bò bằm xốt cà chua', 5, 120000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Cơm chiên hải sản', 5, 99000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Aquafina 500ml', 6, 20000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Pepsi lon 320ml', 6, 30000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'7up lon 320ml', 6, 30000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Mirinda lon 320ml', 6, 30000)
--Insert dbo.tFood(nameFood,idCategory,priceFood)
--Values (N'Trà đào hạt chia', 6, 39000)
--GO

select*from dbo.tFood
Select * from tFood inner join tFoodCategory on tFood.idCategory = tFoodCategory.idCategory

--Insert dbo.tTable(nameTable)
--Values (N'Bàn 1')
--Insert dbo.tTable(nameTable)
--Values (N'Bàn 2')
--Insert dbo.tTable(nameTable)
--Values (N'Bàn 3')
--Insert dbo.tTable(nameTable)
--Values (N'Bàn 4')
--Insert dbo.tTable(nameTable)
--Values (N'Bàn 5')

select*from dbo.tTable
Select * from tblMain as m
inner join tblDetails as d on m.MainID = d.MainID
inner join tFood as f on f.idFood = d.proID 
Select * from tblDetails
--delete dbo.tblMain
--delete tblDetails
select*from tblDetails
SELECT ROW_NUMBER() OVER(ORDER BY p.nameFood) AS STT, p.nameFood, SUM(d.qty) as Qty, SUM(d.amount) as Amount 
FROM tblMain as m INNER JOIN tblDetails as d ON m.MainID = d.MainID INNER JOIN tFood p ON p.idFood = d.proID 
INNER JOIN tFoodCategory c ON c.idCategory = p.idCategory where c.nameCategory = 'Appetizer' GROUP BY p.nameFood


ALTER TABLE [dbo].[tTable]
ADD CONSTRAINT [PK_idTable] UNIQUE  ([idTable]);
GO
ALTER TABLE [dbo].[tStaff]
ADD CONSTRAINT [PK_idStaff] UNIQUE  ([idStaff]);
GO
ALTER TABLE [dbo].[tblMain]  WITH CHECK ADD  CONSTRAINT [FK_tblMain_tTable] FOREIGN KEY([idTable])
REFERENCES [dbo].[tTable] ([idTable])
GO
ALTER TABLE [dbo].[tblMain] CHECK CONSTRAINT [FK_tblMain_tTable]

GO
ALTER TABLE [dbo].[tblDetails] CHECK CONSTRAINT [FK_tblDetails_tblMain]
go
ALTER TABLE [dbo].[tblDetails]  WITH CHECK ADD  CONSTRAINT [FK_tblDetails_tFood] FOREIGN KEY([proID])
REFERENCES [dbo].[tFood] ([idFood])
GO
ALTER TABLE [dbo].[tblMain] CHECK CONSTRAINT [FK_tblMain_tTable]
go
ALTER TABLE [dbo].[tblMain]  WITH CHECK ADD  CONSTRAINT [FK_tblMain_tStaff] FOREIGN KEY([idStaff])
REFERENCES [dbo].[tStaff] ([idStaff])
GO
ALTER TABLE [dbo].[tblMain] CHECK CONSTRAINT [FK_tblMain_tStaff]
go
ALTER TABLE [dbo].[tAccount]  WITH CHECK ADD  CONSTRAINT [FK_tAccount_tRole] FOREIGN KEY([type])
REFERENCES [dbo].[Role] ([typeRole])
GO
ALTER TABLE [dbo].[tAccount] CHECK CONSTRAINT [FK_tAccount_tRole]
select m.MainID, t.nameTable, s.Name, m.orderType, m.status, m.total from tblMain as m inner join tTable as t on t.idTable = m.idTable inner join tStaff as s on s.idStaff = m.idStaff
select MainID, idTable, idStaff, orderType, status, total from tblMain where orderType = 'Delivery' or orderType = 'TakeAway'
select top 5 f.nameFood as namefood, Sum(dt.qty) as qty from tblDetails as dt inner join tFood as f on dt.proID= f.idFood join tblMain as m on m.MainID= dt.MainID  group by f.nameFood, dt.qty order by dt.qty desc
SELECT f.NameFood, f.priceFood, fc.nameCategory, f.avtFood FROM tFood as f join tFoodCategory as fc on f.idCategory = fc.idCategory

select top 5 f.nameFood as namefood, SUM(dt.qty) as qty from tblDetails as dt inner join tFood as f on dt.proID= f.idFood join tblMain as m on m.MainID= dt.MainID  group by f.nameFood, dt.qty order by dt.qty desc

SELECT CAST(aDate AS DATETIME) AS date,CAST(SUM(total) AS DECIMAL) AS totalmoney FROM tblmain GROUP BY aDate
Select p.nameFood , sum(qty) as Qty, sum(amount) as Total from tblMain as m inner join tblDetails as d on m.MainID = d.MainID inner join tFood p on p.idFood = d.proID
inner join tFoodCategory c on c.idCategory = p.idCategory group by p.nameFood
Select sum(total) as Total, sum(received) as Received, sum(change) as Change from tblMain

Select * from tblMain

SELECT CAST(aDate AS DATETIME) AS date,CAST(SUM(total) AS DECIMAL) AS totalmoney FROM tblmain GROUP BY aDate

Select sum(amount) as Total from tblMain as m inner join tblDetails as d on m.MainID = d.MainID inner join tFood p on p.idFood = d.proID
inner join tFoodCategory c on c.idCategory = p.idCategory where c.nameCategory = 'Seafood Pizza'

ALTER TABLE tblMain
ALTER COLUMN aDate DATETIME;

select*from dbo.tblMain as m inner join dbo.tTable as t on t.idTable = m.idTable where m.status = 'pending' or m.status = 'complete'  

SELECT MainID, idTable, idStaff, orderType, status, total
FROM tblMain AS m
WHERE CAST(m.aDate AS DATE) = '2023-11-24' AND orderType = 'TakeAway';

