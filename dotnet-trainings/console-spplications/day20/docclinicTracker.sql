create table Doctor
(DId int identity(100,1) constraint pk_Did primary key,
DName varchar(50),
DSpecialization varchar(50),
Dexp int,
DSalary int)

create table Patient
(PId int identity(200,1) constraint pk_Pid primary key,
PName varchar(50),
PGender varchar(20),
PNumber varchar(20),
PEmail varchar(20),
PDob date )

create table Appointment
(AId int identity(300,1) constraint pk_Aid primary key,
ADate datetime,
PId int constraint fk_P_Appt foreign key references Patient(PId))

