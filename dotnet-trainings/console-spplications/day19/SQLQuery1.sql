select * from Categories

select * from Suppliers

select CategoryID,  categoryname from Categories
union
select SupplierId,CompanyName from Suppliers

select * from [Order Details]

select * from Orders where ShipCountry='Spain'
union all
select * from orders where Freight>50 

select top 5 * from orders order by Freight desc

--get the order id, productname and quantitysold of products that have price
--greater than 15

select OrderID, ProductName, Quantity "Quantity Sold"
from [Order Details] od join Products p
on od.ProductId = p.ProductID
where p.UnitPrice>15

--get the order id, productname and quantitysold of products that are from category 'dairy'
--and within the price range of 10 to 20
