

insert into Bill (TimeCheckIn,TableID,BillStatus,AccountID)
values (GETDATE(),1,N'Ch?a thanh to�n',1)


insert into [Bill] (TimeCheckIn,TableID,BillStatus,AccountID)
values (GETDATE(),4,N'Ch?a thanh to�n',1)

select BillID
from Bill 
Where TableID = 4 and BillStatus = N'Ch?a thanh to�n'

delete Bill
where BillID = 8

delete BillInfo
where BillID = 8

select *from Bill

update Bill
set BillStatus = N'?� thanh to�n'
where BillID