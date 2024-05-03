use Northwind

select * from Categories

select CategoryId from Categories where CategoryName = 'Confections'

--All the products from 'Confections'
select * from products where CategoryID = 
(select CategoryId from Categories where CategoryName = 'Confections')

select * from Suppliers

--select product names from the supplier Tokyo Traders
select ProductName from Products where SupplierID = 
(select SupplierID from Suppliers where CompanyName = 'Tokyo Traders')

--get all the products that are supplied by suppliers from USA
select ProductName from products where SupplierID in 
(select SupplierID from Suppliers where Country = 'USA')

--get all the products from the category that has 'ea' in the description
select ProductName from products where CategoryID in
(select CategoryID from Categories where Description like '%ea%')

select * from customers
select * from Products

--select the product id and the quantity ordered by customrs from France
select ProductID, Quantity from [Order Details] where OrderID in
(select OrderID from Orders where CustomerID in
(select CustomerID from Customers where Country ='France')
)

--Get the products that are priced above the average price of all the products
select * from Products where UnitPrice>(select avg(Unitprice) from products)

--select the latest order by every employee
--select top 1 * from Orders group by EmployeeID order by OrderDate desc

-- correlated subqueries --
select * from orders o1
where orderdate = 
(select max(orderdate) from orders o2
where o2.EmployeeID = o1.employeeid)
order by o1.EmployeeID

--Select the maximum priced product in every category
select * from products p1 where unitprice = (select max(unitprice) from products p2 where p1.CategoryID = p2.CategoryID)

--select the order number for the maximum fright paid by every customer
Select OrderId from Orders o1 where freight =
(select max(freight) from Orders o2 where o1.CustomerID=o1.CustomerID)

--cross join
select * from Categories,customers

--Inner join
select * from categories where CategoryID 
not in (select distinct categoryid from products)

select * from Suppliers where SupplierID 
not in (select distinct SupplierID from products)

--Get teh categoryId and teh productname
select CategoryId,ProductName from products

--Get teh categoryname and the productname
select categoryName,ProductName from Categories 
join Products on Categories.CategoryID = Products.CategoryID

--Get the Supplier company name, contact person name, Product name and the stock ordered
select companyname,ContactName,ProductName,UnitsOnOrder
 from Suppliers s join Products p
 on s.SupplierID = p.SupplierID
 order by UnitsOnOrder desc

 --Print the order id, customername and the fright cost for all teh orders
 select orderID, ContactName, Freight from Orders o join Customers c on o.CustomerID=c.CustomerID

 --product name, quantity sold, Discount Price, Order Id, Fright for all orders
 select o.OrderID "Order ID",p.Productname, od.Quantity "Quantity Sold",
 (p.UnitPrice*od.Quantity) "Base Price", 
 ((p.UnitPrice*od.Quantity)-((p.UnitPrice*od.Quantity)* od.Discount/100)) "Discounted price",
 Freight "Freight Charge"
 from Orders o join [Order Details] od
 on o.OrderID = od.OrderID
 join Products p on p.ProductID = od.ProductID
 order by o.OrderID

 --select customer name, product name, quantity sold and the frieght, 
 --total price(unitpice*quantity+freight)
select c.ContactName, p.ProductName, o.Freight, od.Quantity, (od.UnitPrice*od.Quantity+o.Freight) as "total price"
from Orders o join [Order Details] od on o.OrderID=od.OrderID
join Products p on p.ProductID = od.ProductID
join Customers c on c.CustomerID = o.CustomerID

--Print the product name and the total quantity sold
 select productName,sum(quantity) "Total quantity sold"
 from products p join [Order Details] od
 on p.ProductID = od.ProductID
 group by ProductName
 order by 2 desc

 --customer name and number of products for every order
select c.ContactName, o.OrderId, count(*) 
from customers c join orders o on c.customerid = o.CustomerID
join [Order Details] od on o.OrderID = od.OrderID
group by c.ContactName,o.OrderID

-- select the employee name, customer name, product name and total price of product
select e.FirstName, c.ContactName, p.ProductName, (od.Quantity*od.UnitPrice) as "total price"
from [Order Details] od join Orders o on o.OrderID = od.OrderID
join Products p on od.ProductID = p.ProductID
join Customers c on c.CustomerID = o.CustomerID
join Employees e on e.EmployeeID = o.EmployeeID
order by 1