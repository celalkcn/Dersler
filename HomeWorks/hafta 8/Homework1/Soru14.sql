SELECT
    c.CompanyName [Müşteri],
   SUM(od.Quantity)  [Sipariş Miktarı]
FROM Customers c

    JOIN Orders o ON c.CustomerID=o.CustomerID
    JOIN OrderDetails od ON o.OrderID = od.OrderID
GROUP BY c.CompanyName
ORDER BY c.CompanyName