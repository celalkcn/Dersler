SELECT 
e.FirstName AS [Calisan],
SUM(OD.Quantity) AS [Siparis],
AVG(DATEDIFF(DAY, o.RequiredDate, o.ShippedDate))


FROM Employees e
JOIN Orders o ON e.EmployeeID = o.EmployeeID
JOIN OrderDetails od ON o.OrderID = od.OrderID

GROUP BY e.FirstName , DATEDIFF(DAY, o.RequiredDate, o.ShippedDate)


ORDER BY e.FirstName
