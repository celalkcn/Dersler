SELECT 
    e.FirstName AS [CalisanIsim],
    YEAR(o.OrderDate) AS [Tarih],
    SUM(od.Quantity) [Satis]

FROM Employees e
JOIN Orders o ON e.EmployeeID = o.EmployeeID
JOIN OrderDetails od ON o.OrderID = od.OrderID

GROUP BY  e.FirstName, YEAR(o.OrderDate)

ORDER BY  YEAR(o.OrderDate) , SUM(od.Quantity) DESC  ,e.FirstName
