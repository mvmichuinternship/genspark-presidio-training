use Northwind

select * from Products;

select ProductName, QuantityPerUnit from Products

select ProductName Name_Of_Product, QuantityPerUnit as Quantity_Per_Unit from Products

select ProductName 'Name Of Product', QuantityPerUnit as Quantity_Per_Unit from Products

select * from products where UnitPrice>10

--Select all the products that are out of stock
select * from Products where UnitsInStock=0

--select the products that will no more be stocked
select * from products where Discontinued =1

--Select Products that will be in clearance
select * from products where Discontinued =1 and UnitsInStock>0


--select products that are in teh range of 10 to 30
select * from products where unitprice>10 and unitprice<30
select * from products where unitprice between 10 and 30
--(or)
select * from products where unitprice<=10 and unitprice>=30


select AVG(UnitPrice) "Average" from Products where SupplierID =2

select supplierID,AVG(unitprice) "Average" from products
group by supplierID

select productName,UnitPrice from products
where UnitPrice>15
order by CategoryId

--Get the products sorted by the price. Fetch only those products that will be discontiued
select ProductName from products where Discontinued=1 order by UnitPrice