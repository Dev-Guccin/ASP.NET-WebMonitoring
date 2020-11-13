create table tblBrd(
num					int identity(1,1) primary key,
name					nvarchar(10),
pass					nvarchar(10),
email					varchar(20),
title						nvarchar(50),
contents			ntext,
writedate			varchar(20),
readcnt				int
)

select * from tblBrd

create table tblUser(
id	char(30),
salt int,
passwd char(256),
name char(20),
deviceid char(20)
)

drop table tblUser;
select * from tblUser