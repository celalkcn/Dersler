SELECT o.OrderDate , 
FORMAT(SUM(UnitPrice * Quantity * (1-Discount)), 'N2', 'tr-TR') AS [Ciro]
FROM OrderDetails od 
JOIN Orders o ON od.OrderID = o.OrderID

WHERE o.OrderDate BETWEEN '1997-1-1' AND '1997-12-31'

GROUP BY o.OrderDate
ORDER BY 2 DESC