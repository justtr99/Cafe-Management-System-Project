use master

drop database QuanLyCafe


create database QuanLyCafe
Go

use QuanLyCafe
Go

--Food
--Table
--FoodCategory
--Account
--Bill
--BillInfo
--Role
--Room


create table Room(
 RoomID int identity primary key,
 RoomName nvarchar(100) UNIQUE
)


create table [Table](
   TableID int identity primary key,
   TableName nvarchar(100) Default N'Chưa đặt tên',
   TableStatus nvarchar (100) Default N'Trống',
   RoomID int,

   foreign key (RoomID) references Room(RoomID)
)

create table TakeAway(
   TakeAwayID int identity primary key,
   TakeAwayStatus nvarchar (100) Default N'Chưa thanh toán',
   TakeAwayCode nvarchar(100) 
)


create table [Role](
   RoleID int primary key,
   RoleName nvarchar(50) not null
)

create table Account(
   AccountID int identity primary key,
   FullName nvarchar(100) not null Default N'Quán của trường',
   Phone nvarchar(100) UNIQUE not null,
   Username nvarchar(100) UNIQUE not null,
   [Password] nvarchar(100) not null Default 0,
    RoleID int not null

   foreign key (RoleID) references [Role](RoleID)
)



create table FoodCategory(
   FoodCategoryID int identity primary key,
   FoodCategoryName nvarchar(100) not null Default N'Chưa đặt tên'
)

create table Food(
   FoodID int identity primary key,
   FoodName nvarchar(100) not null UNIQUE Default N'Chưa đặt tên',
   FoodPrice float not null,
   FoodCategoryID int not null,
   Quantity int,
   foreign key (FoodCategoryID) references FoodCategory(FoodCategoryID)
)

create table Bill(
  BillID int identity primary key,
  TimeCheckIn DateTime not null Default getdate(),
  TimeCheckOut DateTime,
  TableID int,
  TakeAwayID int,
  BillStatus nvarchar(50) not null Default N'Chưa thanh toán',
  AccountID int not null,
  Total float not null Default 0

  FOREIGN KEY (AccountID) REFERENCES Account(AccountID),
  FOREIGN KEY (TableID) REFERENCES [Table](TableID),
  FOREIGN KEY (TakeAwayID) REFERENCES TakeAway(TakeAwayID)
)

create table BillInfo(
  BillInfoID int identity primary key,
  BillID int not null,
  FoodID int not null,
  Quantity int not null Default 0,
  foreign key (BillID) references Bill(BillID),
  foreign key (FoodID) references Food(FoodID)
)

SELECT SUM(Total) AS Total
FROM (
    SELECT (BillInfo.Quantity * Food.FoodPrice) AS Total
    FROM BillInfo
    JOIN Food ON Food.FoodID = BillInfo.FoodID
    WHERE BillInfo.BillID = 2
) TongTien;

update Bill 
set Total = 300000 where BillID =2



insert into Role 
values(0,N'Quản lý'),(1,N'Nhân viên')


insert into Account 
values(N'Phạm Xuân Trường',0822289135,'just','123',0)

insert into FoodCategory
values (N'Đồ ăn'), (N'Đồ uống')


insert into Food
values (N'Bò khô',50000,1,10),(N'Gà khô',50000,1,10),(N'Cafe nâu',25000,2,50),(N'Cafe đen',25000,2,50),
(N'Bạc xỉu',30000,2,50),(N'Sinh tố bơ',35000,2,30)

insert into Room 
values (N'Phòng ngoài'),(N'Phòng giữa'),(N'Phòng trong'),(N'Tầng 2')

insert into [Table] (TableName,RoomID)
values (N'Bàn 1',1),(N'Bàn 2',1),(N'Bàn 3',1),(N'Bàn 4',1),(N'Bàn 1',2),(N'Bàn 2',2),
(N'Bàn 1',3),(N'Bàn 2',3),(N'Bàn 3',3),(N'Bàn 1',4),(N'Bàn 2',4)

insert into [Bill] (TimeCheckIn,TimeCheckOut,TableID,BillStatus,AccountID)
values ('2024-03-08 19:06', '2024-03-08 20:06',2,N'Đã thanh toán',1),
('2024-03-09 18:06', '2024-03-09 20:06',4,N'Chưa thanh toán',1)

insert into BillInfo values
(2,3,8),(2,2,1),(2,4,2)

select * from BillInfo where BillID = 1 
update Bill
set BillStatus = N'Chưa thanh toán'
where BillID =10


SELECT * FROM Bill WHERE (CAST(TimeCheckIn AS DATE) between '2024-03-04' and '2024-03-09')
and (CAST(TimeCheckOut AS DATE) between '2024-03-04' and '2024-03-09')
order by TimeCheckIn
Offset ? rows fetch next 15 rows only

SELECT sum(Total) as doanhThu FROM (
    SELECT Total 
    FROM Bill 
    WHERE (CAST(TimeCheckIn AS DATE) BETWEEN '2024-03-04' AND '2024-03-09') 
    AND (CAST(TimeCheckOut AS DATE) BETWEEN '2024-03-04' AND '2024-03-09')
) AS bill;



SELECT LEFT(CONVERT(varchar, GETDATE(), 120), 16) AS ngay_thang_gio_phut_hien_tai;



//
select * from Bill
where TableID = 2 and BillStatus = N'Chưa thanh toán'

select * from BillInfo 
where BillID = 10 and FoodID = 3

delete Bill
where BillID = 21

update BillInfo
set Quantity = 9
where BillID = 10 and FoodID = 3

delete BillInfo
where BillID = 10 and FoodID = 3

select FoodID
from Food where FoodName = ''

insert into BillInfo values
(11,3,8),(11,2,1),(11,4,2)

update Bill
set BillStatus = N'Chưa thanh toán'
where BillID =11

//