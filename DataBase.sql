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

SELECT SUM(Total) AS Total
FROM (
    SELECT (BillInfo.Quantity * Food.FoodPrice) AS Total
    FROM BillInfo
    JOIN Food ON Food.FoodID = BillInfo.FoodID
    WHERE BillInfo.BillID = 2
) TongTien;

update Bill 
set Total = 300000 where BillID =2

select * from Bill





insert into Role 
values(0,N'Quản lý'),(1,N'Nhân viên')


insert into Account 
values(N'Phạm Xuân Trường',0822289135,'just','123',0)

insert into FoodCategory
values (N'Đồ ăn'), (N'Đồ uống')


insert into Food
values (N'Bò khô',50000,1,10,N'https://cdn-i.vtcnews.vn/resize/th/upload/2020/10/06/2-00222890.jpg'),(N'Gà khô',50000,1,10,N'https://cdn.eva.vn/upload/3-2023/images/2023-07-21/1689925842-538-cach-lam-kho-ga-la-chanh-bang-noi-chien-khong-dau-tuyet-ngon-1-1689925831-622-width1000height800-1689925842-width1000height800.jpg'),(N'Cafe nâu',25000,2,50,N'https://caphekhoanbetong.com/wp-content/uploads/2021/08/ca-phe-nau-da-ha-noi-giao-hang-nhanh-1.jpg'),(N'Cafe đen',25000,2,50,N'https://neomartpro.com/wp-content/uploads/2020/05/cafedenda-1.jpg'),
(N'Bạc xỉu',30000,2,50,N'https://classiccoffee.com.vn/files/news/cach-uong-bac-xiu-ngon-dung-chat-sai-gon-xua-njqlymst.jpg'),(N'Sinh tố bơ',35000,2,30,N'https://beptruong.edu.vn/wp-content/uploads/2021/03/sinh-to-bo-dua.jpg')

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

select * from Bill

update Bill
set TimeCheckOut = GETDATE() where BillID in (11,16)

SELECT sum(Total) as doanhThu FROM (
    SELECT Total 
    FROM Bill 
    WHERE (CAST(TimeCheckIn AS DATE) BETWEEN '2029-03-17' AND '2029-03-19') 
) AS bill;

update Bill
set Total = (select total from (
select Sum (Food.FoodPrice * BillInfo.Quantity) as total,BillInfo.BillID
from BillInfo
join Food on BillInfo.FoodID = Food.FoodID
where BillInfo.BillID = 11
group by BillInfo.BillID ) tinhTien )
where BillID = 11  

delete BillInfo
delete Bill

select Food.* from Food
join FoodCategory on Food.FoodCategoryID = FoodCategory.FoodCategoryID
where FoodName like '%%' and FoodCategory.FoodCategoryName like '%%'

 update Bill 
 set BillStatus = N'Đã thanh toán', TimeCheckOut = GETDATE() 
 where BillID = 21

select * from Food

select * from Bill

SELECT LEFT(CONVERT(varchar, GETDATE(), 120), 16) AS ngay_thang_gio_phut_hien_tai;



//
select * from BillInfo
delete Bill
where BillID = 7




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