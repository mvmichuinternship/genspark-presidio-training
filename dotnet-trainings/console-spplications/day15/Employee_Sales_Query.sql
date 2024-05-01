
	create table Department(
	DeptName varchar(20) constraint pk_Dname primary key,
	FloorNo int,
	PhoneNo int,
	/*Mgrid int constraint fk_dept_emp foreign key references Employee(Eid)*/
	);
	sp_help Department;
	
	create table Employee (Eid int constraint pk_Eid primary key,
	EName varchar(100), 
	Salary int,
	DeptName varchar(20) constraint fk_emp_dept foreign key references Department(DeptName),
	BossNo int constraint fk_emp_boss foreign key references Employee(Eid)
	)

	ALTER TABLE Sales
	add SalesId int constraint pk_Salesid primary key
	/*alter table Employee
	add Eid int constraint pk_Eid primary key ;*/
	/*alter table Employee
	add constraint fk_emp_boss foreign key (BossNo) references Employee(Eid)*/


	sp_help Employee;

	alter table Department 
	add Mgrid int constraint fk_dept_emp foreign key references Employee(Eid);
	add constraint fk_dept_emp foreign key (Mgrid) references Employee(Eid)
	
	sp_help Department;

	create table Items(
	ItemName varchar(100) constraint pk_Iname primary key,
	ItemColour varchar(20),
	ItemType varchar(20)
	)
	sp_help Items;

	ALTER TABLE Sales alter column ItemName VARCHAR(100) ;

	create table Sales(
	SalesId int constraint pk_Salesid primary key,
	SalesQty int,
	ItemName varchar(100) constraint fk_item_sales foreign key references Items(ItemName),
	DeptName varchar(20) constraint fk_sales_dept foreign key references Department(DeptName),
	)
	sp_help Sales;
	
	alter table Employee
	check constraint fk_emp_dept;

	alter table Sales
	add constraint fk_item_sales foreign key (ItemName) references Items(ItemName) ;

	
	/*DML*/

	 insert into Employee (EId, EName, Salary, DeptName, Bossno)
values
  (1, 'Alice', 75000, 'Management', NULL),
  (2, 'Ned', 45000, 'Marketing', 1),
  (3, 'Andrew', 25000, 'Marketing', 2),
  (4, 'Clare', 22000, 'Marketing', 2),
  (5, 'Todd', 38000, 'Accounting', 1),
  (6, 'Nancy', 22000, 'Accounting', 5),
  (7, 'Brier', 43000, 'Purchasing', 1),
  (8, 'Sarah', 56000, 'Purchasing', 7),
  (9, 'Sophile', 35000, 'Personnel', 1),
  (10, 'Sanjay', 15000, 'Navigation', 3),
  (11, 'Rita', 15000, 'Books', 4),
  (12, 'Gigi', 16000, 'Clothes', 4),
  (13, 'Maggie', 11000, 'Clothes', 4),
  (14, 'Paul', 15000, 'Equipment', 3),
  (15, 'James', 15000, 'Equipment', 3),
  (16, 'Pat', 15000, 'Furniture', 3),
  (17, 'Mark', 15000, 'Recreation', 3);

  select * from Employee

	insert into Department (DeptName, FloorNo, PhoneNo, Mgrid)
	values
  ('Management', 5, 34, 1),
  ('Books', 1, 81, 4),
  ('Clothes', 2, 24, 4),
  ('Equipment', 3, 57, 3),
  ('Furniture', 4, 14, 3),
  ('Navigation', 1, 41, 3),
  ('Recreation', 2, 29, 4),
  ('Accounting', 5, 35, 5),
  ('Purchasing', 5, 36, 7),
  ('Personnel', 5, 37, 9),
  ('Marketing', 5, 38, 2);

  select * from Department

  insert into Items (ItemName, Itemtype, ItemColour)
values
  ('Pocket Knife-Nile', 'E', 'Brown'),
  ('Pocket Knife-Avon', 'E', 'Brown'),
  ('Compass', 'N', NULL),
  ('Geo positioning system', 'N', NULL),
  ('Elephant Polo stick', 'R', 'Bamboo'),
  ('Camel Saddle', 'R', 'Brown'),
  ('Sextant', 'N', NULL),
  ('Map Measure', 'N', NULL),
  ('Boots-snake proof', 'C', 'Green'),
  ('Pith Helmet', 'C', 'Khaki'),
  ('Hat-polar Explorer', 'C', 'White'),
  ('Exploring in 10 Easy Lessons', 'B', NULL),
  ('Hammock', 'F', 'Khaki'),
  ('How to win Foreign Friends', 'B', NULL),
  ('Map case', 'E', 'Brown'),
  ('Safari Chair', 'F', 'Khaki'),
  ('Safari cooking kit', 'F', 'Khaki'),
  ('Stetson', 'C', 'Black'),
  ('Tent - 2 person', 'F', 'Khaki'),
  ('Tent -8 person', 'F', 'Khaki');

  select * from Items

  INSERT INTO sales (SalesId, SalesQty, ItemName, Deptname)
VALUES
  (101, 2, 'Boots-snake proof', 'Clothes'),
  (102, 1, 'Pith Helmet', 'Clothes'),
  (103, 1, 'Sextant', 'Navigation'),
  (104, 3, 'Hat-polar Explorer', 'Clothes'),
  (105, 5, 'Pith Helmet', 'Equipment'),
  (106, 2, 'Pocket Knife-Nile', 'Clothes'),
  (107, 3, 'Pocket Knife-Nile', 'Recreation'),
  (108, 1, 'Compass', 'Navigation'),
  (109, 2, 'Geo positioning system', 'Navigation'),
  (110, 5, 'Map Measure', 'Navigation'),
  (111, 1, 'Geo positioning system', 'Books'),
  (112, 1, 'Sextant', 'Books'),
  (113, 3, 'Pocket Knife-Nile', 'Books'),
  (114, 1, 'Pocket Knife-Nile', 'Navigation'),
  (115, 1, 'Pocket Knife-Nile', 'Equipment'),
  (116, 1, 'Sextant', 'Clothes'),
  /*(117, 1, '', 'Equipment'),/*error*/*/
  /*(118, 1, '', 'Recreation'),/*error*/*/
  /*(119, 1, '', 'Furniture'),/*error*/*/
 /* (120, 1, 'Pocket Knife-Nile', ''),/*error*/*/
  (121, 1, 'Exploring in 10 easy lessons', 'Books'),
  /*(122, 1, 'How to win foreign friends', ''),/*error*/*/
  /*(123, 1, 'Compass', ''),/*error*/*/
  /*(124, 1, 'Pith Helmet', ''),/*error*/*/
  (125, 1, 'Elephant Polo stick', 'Recreation'),
  (126, 1, 'Camel Saddle', 'Recreation');

  select * from Sales
