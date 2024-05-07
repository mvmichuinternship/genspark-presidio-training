use pubs

select au_fname from authors

--1) Create a stored procedure that will take the author firstname and print all the books polished by him with the publisher's name
 
--2) Create a sp that will take the employee's firtname and print all the titles sold by him/her, price, quantity and the cost.
 
--3) Create a query that will print all names from authors and employees
select au_fname from authors union all select fname from employee;
 
--4) Create a  query that will float the data from sales,titles, publisher and authors table to print title name, Publisher's name, author's full name with quantity ordered and price for the order for all orders,print first 5 orders after sorting them based on the price of order
select top 5 t.title, p.pub_name, CONCAT(a.au_fname, ' ', a.au_lname) as "author name", sa.qty, (sa.qty*t.price) as "Order Price"
from sales sa join titles t on sa.title_id= t.title_id join publishers p on t.pub_id = p.pub_id join titleauthor ta on ta.title_id = t.title_id join authors a on a.au_id= ta.au_id order by (sa.qty * t.price)  
 
--5) Please learn grant and revoke