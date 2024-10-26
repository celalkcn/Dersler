SELECT TOP 5

        c.Country AS [Ulke],

    --AVG(od.UnitPrice * od.Quantity * (1-od.Discount))
    SUM(od.UnitPrice * od.Quantity * (1-od.Discount)) 

FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN OrderDetails od ON o.OrderID = od.OrderID

GROUP BY c.Country   
HAVING SUM(od.UnitPrice * od.Quantity * (1-od.Discount)) > 5000

ORDER BY c.Country  

