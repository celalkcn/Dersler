SELECT 
    c.Country AS [Ülke],
    
   FORMAT(SUM(od.UnitPrice * od.Quantity * (1-od.Discount)), 'N2', 'tr-TR')  AS [Toplam SAtis]

FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN OrderDetails od ON o.OrderID = od.OrderID

GROUP BY c.Country
ORDER BY c.Country