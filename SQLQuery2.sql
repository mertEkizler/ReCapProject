create table Cars(
Id int primary key identity(1,1),BrandId int, ColorId int, ModelYear varchar(30), 
DailyPrice decimal, Descriptions varchar(50), 
Foreign Key (BrandId) references Colors(ColorId),
Foreign Key (ColorId) references Brands(BrandId)


)

create table Colors(
ColorId int primary key identity(1,1),
ColorName varchar(30)

)

create table Brands(
BrandId int primary key identity(1,1),
BrandName varchar(30)

)

insert into Cars(BrandId,ColorId,ModelYear,DailyPrice,Descriptions) 
Values 
('1','2','1903','200','Manuel'),
('2','3','1997','150','Benzin'),
('3','5','2020','300','LPG');
insert into Colors(ColorName) Values ('siyah','beyaz','mor');
insert into Brands(BrandName) Values ('Kia','MiniCooper','Jeep');