SELECT 
c.CompanyName [Müşteri],
SUM(od.Quantity) [Sipariş Miktarı]
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID 
JOIN OrderDetails od ON o.OrderID= od.OrderID
WHERE od.Quantity >= 5

GROUP BY c.CompanyName
ORDER BY [Sipariş Miktarı]
