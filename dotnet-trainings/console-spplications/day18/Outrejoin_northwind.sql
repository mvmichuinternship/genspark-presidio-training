select * from customers where CustomerID not in (select distinct customerid from Orders)

select * from orders

select ContactName,ShipName,ShipAddress
from customers c join orders o
on c.CustomerID = o.CustomerID

select ContactName,ShipName,ShipAddress
from customers c left outer join orders o
on c.CustomerID = o.CustomerID

select * from Products where ProductID  not in (Select distinct productid from Orders)

