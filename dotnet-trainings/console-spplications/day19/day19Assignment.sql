use pubs

select au_fname from authors
select *from sales
select * from authors
select * from titles

--1) Create a stored procedure that will take the author firstname and print all the books polished by him with the publisher's name
GO
create proc PAuthorsandBooks(@name varchar(10))
as
begin
    select t.title , pub_name as "Pub Name" from titles t
	join publishers p  on t.pub_id = p.pub_id
	join titleauthor ta on ta.title_id = t.title_id
	join authors a on a.au_id = ta.au_id
	where a.au_fname = @name
end
exec PAuthorsandBooks 'Albert'

--2) Create a sp that will take the employee's firtname and print all the titles sold by him/her, price, quantity and the cost.
GO
create proc PSalesByAuthor(@name varchar(10))
as
begin
	select t.title, sum(t.price) as "Total Price", sum(sa.qty) "Total Quantity", sum((t.price * sa.qty)) "Total Amount"
	from titles t join sales sa on t.title_id = sa.title_id
	join employee e on e.pub_id = t.pub_id
	where e.fname = @name
	group by t.title
end
exec PSalesByAuthor 'Paolo'

--3) Create a query that will print all names from authors and employees
select au_fname from authors union all select fname from employee;
 
--4) Create a  query that will float the data from sales,titles, publisher and authors table to print title name, Publisher's name, author's full name with quantity ordered and price for the order for all orders,print first 5 orders after sorting them based on the price of order
select top 5 t.title, p.pub_name, CONCAT(a.au_fname, ' ', a.au_lname) as "author name", sa.qty, (sa.qty*t.price) as "Order Price"
from sales sa join titles t on sa.title_id= t.title_id join publishers p on t.pub_id = p.pub_id join titleauthor ta on ta.title_id = t.title_id join authors a on a.au_id= ta.au_id order by (sa.qty * t.price)  
 
--5) Please learn grant and revoke