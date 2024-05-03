select * from publishers
select * from titles 
select * from authors 
select * from titleauthor
select * from sales 
select * from employee


--1) Print the storeid and number of orders for the store
select stor_id, count(*)as "no of orders" from sales group by stor_id 

--2) print the numebr of orders for every title
select title, count(*)as "no of orders" from sales s join Titles t on t.title_id = s.title_id group by t.title

--3) print the publisher name and book name
select title, pub_name from titles t join publishers p on  p.pub_id = t.pub_id

--4) Print the author full name for al the authors
select concat(au_fname,' ', au_lname) as "fullName" from authors

--5) Print the price or every book with tax (price+price*12.36/100)
select title, price+(price+price*12.36/100) as "price with tax" from titles 

--6) Print the author name, title name
select a.au_fname, t.title from titleauthor ta join authors a on a.au_id= ta.au_id join titles t on t.title_id= ta.title_id

--7) print the author name, title name and the publisher name
select a.au_fname, t.title,p.pub_name  from titleauthor ta join authors a on a.au_id= ta.au_id join titles t on t.title_id= ta.title_id
join publishers p on p.pub_id = t.pub_id

--8) Print the average price of books pulished by every publicher
select p.pub_id, avg(price) from titles t join publishers p on p.pub_id = t.pub_id group by p.pub_id

--9) print the books published by 'Marjorie'
select t.title from titles t join titleauthor ta on t.title_id= ta.title_id join authors a on a.au_id=ta.au_id where au_fname = 'Marjorie'

--10) Print the order numbers of books published by 'New Moon Books'
select p.pub_name, sa.ord_num from sales sa join titles t on t.title_id= sa.title_id join publishers p on p.pub_id = t.pub_id where pub_name = 'New Moon Books'

--11) Print the number of orders for every publisher
select p.pub_name, count(*) as "No of Orders" from sales sa join titles t on t.title_id = sa.title_id join publishers p on p.pub_id=t.pub_id group by p.pub_name

--12) print the order number , book name, quantity, price and the total price for all orders
select sa.ord_num, t.title, sa.qty, t.price, (t.price*sa.qty) as"Total price"
from sales sa join titles t on t.title_id= sa.title_id 

--13) print he total order quantity fro every book
select t.title, sum(sa.qty) from sales sa join titles t on sa.title_id = t.title_id group by t.title

--14) print the total ordervalue for every book
select t.title, sum(t.price*sa.qty) as"Total price"
from sales sa join titles t on t.title_id= sa.title_id group by t.title

--15) print the orders that are for the books published by the publisher for which 'Paolo' works for
select sa.* from sales sa join titles t on t.title_id = sa.title_id join publishers p on p.pub_id = t.pub_id join employee a on a.pub_id = p.pub_id where a.fname = 'Paolo'

