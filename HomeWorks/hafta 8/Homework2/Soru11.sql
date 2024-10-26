SELECT 
    c.CompanyName AS [Musteri],
    YEAR(o.OrderDate) AS [Tarih],
    SUM(od.Quantity) AS [Siparis]


FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN OrderDetails od ON o.OrderID = od.OrderID

WHERE YEAR(OrderDate) IN (1997, 1998)
GROUP BY c.CompanyName , YEAR(o.OrderDate)


ORDER BY c.CompanyName , YEAR(o.OrderDate)


