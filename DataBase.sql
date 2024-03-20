use master
IF EXISTS (SELECT name from master.dbo.sysdatabases WHERE name = 'QuanLyCafe')
DROP DATABASE QuanLyCafe;
GO
Create database QuanLyCafe
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
   ImageLink nvarchar (max),
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

GO
--====================INSERT ROLE
insert into Role values(0,N'Quản lý')
insert into Role values(1,N'Nhân viên')

--====================INSERT Account
insert into Account values(N'Phạm Xuân Trường',0822289135,'just','123',0)


--====================INSERT FoodCategory
insert into FoodCategory values (N'Đồ ăn')
insert into FoodCategory values (N'Đồ uống')

--====================INSERT Food
insert into Food values (N'Bò khô',50000,1,10,N'https://cdn-i.vtcnews.vn/resize/th/upload/2020/10/06/2-00222890.jpg')
insert into Food values (N'Gà khô',50000,1,10,N'https://cdn.eva.vn/upload/3-2023/images/2023-07-21/1689925842-538-cach-lam-kho-ga-la-chanh-bang-noi-chien-khong-dau-tuyet-ngon-1-1689925831-622-width1000height800-1689925842-width1000height800.jpg')
insert into Food values (N'Cafe nâu',25000,2,50,N'https://caphekhoanbetong.com/wp-content/uploads/2021/08/ca-phe-nau-da-ha-noi-giao-hang-nhanh-1.jpg')
insert into Food values (N'Cafe đen',25000,2,50,N'https://neomartpro.com/wp-content/uploads/2020/05/cafedenda-1.jpg')
insert into Food values (N'Bạc xỉu',30000,2,50,N'https://classiccoffee.com.vn/files/news/cach-uong-bac-xiu-ngon-dung-chat-sai-gon-xua-njqlymst.jpg')
insert into Food values (N'Sinh tố bơ',35000,2,30,N'https://beptruong.edu.vn/wp-content/uploads/2021/03/sinh-to-bo-dua.jpg')


--====================INSERT Room 
insert into Room values (N'Phòng ngoài')
insert into Room values (N'Phòng giữa')
insert into Room values (N'Phòng trong')
insert into Room values (N'Tầng 2')

--====================INSERT Table
insert into [Table] (TableName,RoomID) values (N'Bàn 1',1) 
insert into [Table] (TableName,RoomID) values (N'Bàn 2',1) 
insert into [Table] (TableName,RoomID) values (N'Bàn 3',1) 
insert into [Table] (TableName,RoomID) values (N'Bàn 4',1) 
insert into [Table] (TableName,RoomID) values (N'Bàn 1',2) 
insert into [Table] (TableName,RoomID) values (N'Bàn 2',2) 
insert into [Table] (TableName,RoomID) values (N'Bàn 1',3) 
insert into [Table] (TableName,RoomID) values (N'Bàn 2',3) 
insert into [Table] (TableName,RoomID) values (N'Bàn 2',3) 
insert into [Table] (TableName,RoomID) values (N'Bàn 3',3) 
insert into [Table] (TableName,RoomID) values (N'Bàn 1',4) 
insert into [Table] (TableName,RoomID) values (N'Bàn 2',4) 











