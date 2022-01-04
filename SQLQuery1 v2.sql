create database KMS
use  KMS

drop table Questionable
drop table BillBuyDetail
drop table BillBuy
drop table BillDetail
drop table Bill
drop table ItemPrice
drop table ItemClassify
drop table item
drop table ItemType
drop table acount
drop table employee
drop table Supermarket
drop table Cost


create table Supermarket(
	id nvarchar(10) primary key,
	name nvarchar(50) not null,
	address nvarchar(100) not null,
	website nvarchar(20),
)

create table Cost(
	month int,
	year int,
	premiseCost decimal default(0),						-- Tiền mặt bằng
	electricityCost decimal default(0),					-- Tiền điện					
	waterCost decimal default(0),						-- Tiền nước
	totalFundCost decimal default(0),					-- Tổn tiền vốn hàng hóa
	bankInterestExpensePercent decimal default(1),		-- Tỉ lệ tiền lời ngân hàng
	totalTaxCost decimal default(0),					-- Tổng tiền thuế
	total decimal default(0),							-- Tổng tiền hàng bán 1 tháng
	totalIncome decimal default(0),						-- Tổng tiền lời 1 tháng
	primary key (month, year)				
)

create table ItemType(
	idType int identity primary key,
	nameType nvarchar(20) not null,	
)

create table Item (
	id int identity primary key,
	name nvarchar(50) not null,
	idType int not null,
	amountCount nvarchar(10) not null,
	status nvarchar(20) default(N'Không hoạt động'), --Không hoạt động, Hoạt động, Đã xóa
	
	foreign key(idType) references ItemType(idType)
)

create table ItemClassify(
	idItem int not null,
	amount int default(0),	
	classify nvarchar(30) not null,  -- iphone mau hong
	status nvarchar(20) default(N'Không hoạt động'),

	primary key(idItem, classify),
	foreign key(idItem) references Item(id)
)

create table ItemPrice(
	id int ,
	classify nvarchar(30) not null,
	price decimal default(0),
	tax decimal default(0),  --1 2
	status nvarchar(30),					-- Hàng bán, Hàng tặng kèm

	primary key(id,classify),
	foreign key (id, classify) references ItemClassify(idItem, classify)
)

create table Employee(
	id int identity primary key,
	name nvarchar(30) not null,
	birthDay date ,
	identityCardNumber int not null,
	startDay date default(getdate()),
	endDay date,
	status nvarchar(30) default(N'Không hoạt động'), --Không hoạt động, Hoạt động, Đã xóa
	age int not null,
	post nvarchar(20) not null,
	salary decimal default(0),
)

create table Acount(
	username nvarchar(20) primary key,
	password nvarchar(20) not null,
	idEmployee int not null,
	mailAddress nvarchar(50),
	post int default(0),
	status nvarchar(30) default(N'Không hoạt động') --Không hoạt động, Hoạt động, Đã xóa

	foreign key (idEmployee) references Employee(id)
)

create table Bill (
	id int identity primary key,
	createdDay datetime default(getdate()),
	creator nvarchar(20) not null,
	status nvarchar(30) default(N'Đã thanh toán'), --Chưa thanh toán, Đã thanh toán, Đã hủy

	foreign key (creator) references Acount(username)
)

create table BillDetail(
	idBill int not null,
	idItem int not null,
	classify nvarchar(30) not null,
	amount int not null,
	amountCount nvarchar(30) not null,
	status nvarchar(20) default(N'Đã bán'),		--Đã bán, Lỗi
	singlePrice decimal not null,	

	foreign key (idBill) references Bill(id),
	foreign key (idItem, classify) references ItemClassify(idItem, classify),
	primary key (idBill,idItem,classify,status)
)

create table BillBuy (
	id int identity primary key,
	createdDay datetime default(getdate()),
	creator nvarchar(20) not null,
	status nvarchar(10) default(N'Đang chờ'),		-- Đã nhập, Đã hủy, Thiếu hàng

	foreign key (creator) references Acount(username)
)

create table BillBuyDetail(
	idBillBuy int not null,
	idItem int not null,
	classify nvarchar(30) not null,
	amount int not null,
	remainAmount int not null,
	amountCount nvarchar(10) not null,
	status nvarchar(20) default(N'Đã nhập'),		-- Đã nhập, Đã hủy, Thiếu hàng
	note nvarchar(20), 
	singlePrice decimal not null,

	foreign key (idBillBuy) references BillBuy(id),
	foreign key (idItem, classify) references ItemClassify(idItem, classify),
	primary key (idBillBuy,idItem, classify,status)
)

create table Questionable(
	idBill int not null,
	idItem int not null,
	classify nvarchar(30) not null,
	time time default(CONVERT(time,GETDATE())),
	amount int not null,
	amountCount nvarchar(30) not null,
	status nvarchar(20) default(N'Lỗi'),		--Hủy, Lỗi
	singlePrice decimal not null,

	foreign key (idBill) references Bill(id),
	foreign key (idItem, classify) references ItemClassify(idItem, classify),
	primary key (idBill,idItem,classify,status)
)
go

create trigger BillDetail_Insert
on dbo.BillDetail
for Insert
as
begin
	declare @amountBuy INT = (select amount from Inserted)
	declare @idBuy INT = (select idItem from Inserted)
	declare @classify nvarchar(30) = (select classify from Inserted)
	declare @i INT
	declare @fundPrice DECIMAL
	declare @price DECIMAL = ( select singlePrice from Inserted)
	declare @tax decimal = (select tax from ItemPrice where id=@idBuy and classify=@classify)
	IF ((select status from Inserted) <> N'Lỗi')
	BEGIN
		WHILE (select count(*) from BillBuyDetail where idItem=@idBuy and classify=@classify and remainAmount>0)>0
			and
			  (@amountBuy>0)	
		BEGIN
			SET @i = ( select Top 1 remainAmount from BillBuyDetail where idItem=@idBuy and classify=@classify and amount>0)					
			SET @fundPrice = (select Top 1 singlePrice from BillBuyDetail where idItem=@idBuy and classify=@classify and amount>0)
			IF @amountBuy >= @i
				BEGIN	
					UPDATE Cost 
						SET totalFundCost = totalFundCost + @i*@fundPrice,
							totalTaxCost = totalTaxCost + @i*@price*@tax/100,
							total = total + @i*@price
						WHERE month = MONTH(GETDATE()) and year = YEAR(GETDATE());
					UPDATE Cost
						SET totalIncome = (total-totalFundCost-totalTaxCost-premiseCost-electricityCost-waterCost)
								- (totalFundCost+premiseCost+electricityCost+waterCost)*bankInterestExpensePercent/100
						WHERE month = MONTH(GETDATE()) and year = YEAR(GETDATE());
					UPDATE Top(1) BillBuyDetail
						SET remainAmount = 0
						WHERE idItem = @idBuy and amount>0
					UPDATE ItemClassify
						SET amount = amount - @i
						WHERE idItem = @idBuy and classify=@classify
					SET @amountBuy = @amountBuy - @i
				END
			ELSE
				BEGIN	
					UPDATE Cost 
						SET totalFundCost = totalFundCost + @amountBuy*@fundPrice,
							totalTaxCost = totalTaxCost + @amountBuy*@price*@tax/100,
							total = total + @amountBuy*@price
						WHERE month = MONTH(GETDATE()) and year = YEAR(GETDATE());
					UPDATE Cost
						SET totalIncome = total-totalFundCost-totalTaxCost-premiseCost-electricityCost-waterCost
								-(totalFundCost+premiseCost+electricityCost+waterCost)*bankInterestExpensePercent/100				
						WHERE month = MONTH(GETDATE()) and year = YEAR(GETDATE());
					UPDATE Top(1) BillBuyDetail
						SET remainAmount = remainAmount - @amountBuy
						WHERE idItem=@idBuy and classify=@classify and amount>0	
					UPDATE ItemClassify	
						SET amount = amount - @amountBuy
						WHERE idItem = @idBuy and classify=@classify
					SET @amountBuy = 0
				END
		END

		IF  @amountBuy > 0
		BEGIN	
			insert into Questionable(idBill, idItem, classify,amount, amountCount, singlePrice) 
				values( (select idBill from Inserted)
					, @idBuy, @classify, @amountBuy, (select amountCount from Inserted), 600)
			UPDATE Cost 
					SET 
						totalTaxCost = totalTaxCost + @amountBuy*@price*@tax/100,
						total = total + @amountBuy*@price
					WHERE month = MONTH(GETDATE()) and year = YEAR(GETDATE());
			UPDATE Cost
				SET totalIncome = total-totalFundCost-totalTaxCost-premiseCost-electricityCost-waterCost
						-(totalFundCost+premiseCost+electricityCost+waterCost)*bankInterestExpensePercent/100				
				WHERE month = MONTH(GETDATE()) and year = YEAR(GETDATE());
			SET @amountBuy = 0
		END
	END
end
go

create trigger Cost_Update 
on Cost
AFTER Update 
as
BEGIN
	UPDATE Cost
		SET totalIncome = (total-totalFundCost-totalTaxCost-premiseCost-electricityCost-waterCost)
				- (totalFundCost+premiseCost+electricityCost+waterCost)*bankInterestExpensePercent/100
		WHERE month = (select month from Inserted) and year = (select year from Inserted);
	
END
go

create trigger BillBuyDetail_Insert
on BillBuyDetail
AFTER Insert
AS
BEGIN
	UPDATE ItemClassify
		SET amount = amount + (select remainAmount from Inserted)
		WHERE idItem = (select idItem from Inserted) and classify = (select classify from Inserted)
END
go

create trigger BillBuyDetail_Update
on BillBuyDetail
INSTEAD OF UPDATE
AS
BEGIN
	declare @a INT = (select remainAmount from BillBuyDetail 
					where idBillBuy = (select idBillBuy from Inserted) 
					and idItem = (select idItem from Inserted)
					and classify = (select classify from Inserted)
					and status <> N'Đã hủy')
	declare @b INT = (select remainAmount from Inserted)
	IF @b != @a
	BEGIN
		UPDATE ItemClassify
			SET	amount = amount + @b - @a
			WHERE idItem = (select idItem from Inserted) and classify = (select classify from inserted)
	END

	UPDATE BillBuyDetail
		SET amount = (select amount from INserted),
			remainAmount = (select remainAmount from Inserted),
			amountCount = (select amountCount from INserted),
			note = (select note from Inserted),
			singlePrice = (select singlePrice from Inserted)
		WHERE idBillBuy = (select idBillBuy from Inserted) 
			and idItem = (select idItem from Inserted)
			and classify = (select classify from Inserted)
			and status = (select status from Inserted)

END
go


insert into Cost(month, year, bankInterestExpensePercent) values(12,2021,1.5)

insert into Employee(name, identityCardNumber, age, post, salary) values(N'Toàn', 1, 21, N'Nhân viên', 1000)
insert into Employee(name, identityCardNumber, age, post, salary) values(N'Tiến', 2, 21, N'Nhân viên', 1000)
insert into Employee(name, identityCardNumber, age, post, salary) values(N'VanTiennn', 3, 21, N'Nhân viên', 1000)

insert into Acount(username,password, idEmployee, mailAddress) values(N'minhtoan', N'1',1, 'nguyenvantiennn0910@gmail.com')
insert into Acount(username,password, idEmployee, mailAddress) values(N'vantiennn', N'1',2, 'nguyenvantiennncolab@gmail.com')
insert into Acount(username,password, idEmployee, mailAddress) values(N'Nguyễn Ông Nội', N'1',3, 'nguyenvantiennnimage@gmail.com')
 

 
insert into ItemType(nameType) values(N'Laptop')
insert into ItemType(nameType) values(N'Máy tính bàn')

insert into Item( name, amountCount, idType) values( N'Laptop', N'Cái', 1)
insert into Item( name, amountCount,idType) values( N'Máy tính bàn', 'Cái', 2)

insert into ItemClassify(idItem, classify) values(1, N'Xanh')
insert into ItemClassify(idItem, classify) values(1, N'Đỏ')
insert into ItemClassify(idItem,  classify) values(2, N'Hồng')

insert into ItemPrice(id, classify, price, tax) values (1, N'Xanh', 1000, 2)
insert into ItemPrice(id, classify, price, tax) values (1, N'Đỏ', 1100, 1.5)
insert into ItemPrice(id, classify, price, tax) values (2, N'Hồng', 500, 1.5)

insert into BillBuy(creator) values(N'minhtoan')

insert into BillBuyDetail(idBillBuy, idItem, classify, amount, remainAmount, amountCount, singlePrice) 
	values(1,1, N'Xanh', 5, 5, N'Cái', 500)

	UPDATE BIllBUYDETAIL
		SET	remainAmount = 2
		WHERE idBIllBUy = 1 and idItem = 1 and classify = N'Đỏ'
insert into BillBuyDetail(idBillBuy, idItem, classify, amount, remainAmount, amountCount, singlePrice) 
	values(1,1, N'Đỏ', 3, 3, N'Cái', 500)
insert into BillBuyDetail(idBillBuy, idItem, classify, amount, remainAmount, amountCount, singlePrice) 
	values(1,2, N'Hồng', 3, 3, N'Cái', 300)

insert into Bill(creator) values(N'minhtoan')

insert into BillDetail(idBill, idItem, classify,amount, amountCount, status,singlePrice) 
	values(1, 1, N'Xanh', 3, N'Cái', N'Đã bán', 1000)
insert into BillDetail(idBill, idItem, classify,amount, amountCount, singlePrice) 
	values(1, 1, N'Đỏ', 5, N'Cái', 1000)	
insert into BillDetail(idBill, idItem, classify,amount, amountCount, singlePrice) 
	values(1, 2, N'Hồng', 5, N'Cái', 600)

select * from Item
select * from ItemPrice
select * from ItemClassify
select * from Cost
select * from BillBuyDetail
select * from BillDetail
select * from BillBuyDetail
select * from Questionable
select * from Bill
select * from Acount
go
--displayname item, classify, amount, remainAmount, amountCount, status, note, singlePrice

select * i.name, bd.classify, bd.amount, bd.remainAmount, bd.singlePrice, bd.status, bd.note, bd.amountCount
from BillBuy as b, BillBuyDetail as bd, Item as i, ItemType it,
where b.id=bd.idBillBuy AND bd.idItem = i.id 