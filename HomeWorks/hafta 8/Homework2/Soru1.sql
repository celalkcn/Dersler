SELECT 
    c.CompanyName , od.OrderID
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN OrderDetails od ON o.OrderID = od.OrderID
WHERE od.OrderID = NULL