select * from Categories
select * from Products
select c.CategoryID ,c.CategoryName ,p.ProductId,p.ProductName,p.UnitPrice from Categories as c inner join Products as p  on 
c.CategoryID = p.CategoryID;