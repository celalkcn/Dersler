SELECT c.CompanyName AS [Musteri], 
o.OrderDate AS [Tarih],
od.Quantity [Miktar]
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN OrderDetails od ON o.OrderID = od.OrderID
GROUP BY c.CompanyName, o.OrderDate, od.Quantity
HAVING od.Quantity > 1

ORDER BY Musteri, Tarih, Miktar