SELECT 
    c.CompanyName,
    COUNT(DISTINCT od.ProductID),

   SUM(od.UnitPrice * od.Quantity * (1-od.Discount)) 
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN OrderDetails od ON o.OrderID = od.OrderID

GROUP BY c.CompanyName
HAVING COUNT(DISTINCT od.ProductID) >= 5 AND  SUM(od.UnitPrice * od.Quantity * (1-od.Discount)) > 10000


