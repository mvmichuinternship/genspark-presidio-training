create table Skills (Skill varchar(20) constraint pk_skill primary key, SkillDescription varchar(20));

sp_help Skills

create Table Areas
(Area varchar(20) constraint pk_Area primary key,
Zipcode char(5))

sp_help Areas

create table Employee (Eid int identity(100,1) constraint pk_Eid primary key,
	name varchar(100), 
	Area varchar(200),
	DateOfBirth datetime constraint check_DOB Check(DateOfBirth < GetDate()),
	Phone varchar(15),
	Email varchar(20) not null,
	EmpArea varchar(20) constraint fk_Area references Areas(Area)
	);

	sp_help Employee;

	create table EmployeeSkill(
	Employee_id int constraint fk_skill_Eid foreign key references Employee(Eid),
	Skill varchar(20) constraint fk_skill_Eskill foreign key references Skills(Skill),
	SkillLevel float constraint check_skillLvl Check(SkillLevel >=0),
	constraint pk_emp_skill primary key(Employee_id, Skill)
	);

	sp_help EmployeeSkill;

	/*DML*/

	Insert into Areas(Area,Zipcode) values('Kodambakkam','12345')
	Insert into Areas(Zipcode,Area) values('12333','Parrys')
	insert into Areas values('Perambur','12222')

	select * from Areas

