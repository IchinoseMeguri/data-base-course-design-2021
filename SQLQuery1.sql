use HotelMS;

drop table if exists Room;
create table Room(
Roomid int primary key,
Roomtype char(10) not null check(Roomtype in('��׼��','�󴲼�','���˼�','���˼�')),
Roomstate char(4) not null check(Roomstate in('����','ռ��')),
);

drop table if exists UserInfo;
create table UserInfo(
Userid char(20) primary key,
Userpsw char(20) not null,
Usertype char(6) not null check(Usertype in('����Ա','�û�')),
Username char(20) not null,
Useridcard char(20) not null,
Usertell char(15) not null,
);

drop table if exists OrderTable;
create table OrderTable(
Orderid int identity(1,1) primary key,
Orderroom int not null,
Orderuser char(20) not null,
Orderstate char(6) not null check(Orderstate in('������','�ѽ���')),
foreign key (Orderroom) references Room(Roomid),
foreign key (Orderuser) references UserInfo(Userid),
);

drop view if exists OrderInfo;
go
create view OrderInfo(Orderid,Orderroom,Orderuser,Orderusername,Orderusertell,Orderstate)
as
select OrderTable.Orderid,OrderTable.Orderroom,OrderTable.Orderuser,UserInfo.Username,UserInfo.Usertell,OrderTable.Orderstate
from OrderTable,UserInfo
where OrderTable.Orderuser=UserInfo.Userid
with check option;
go

insert into UserInfo
values ('AdminTerminal','AdminTerminal','����Ա','����Ա�ն�','AdminTerminal','AdminTerminal');