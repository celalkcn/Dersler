SELECT 
e.FirstName AS [Calisan],
od.Quantity AS [Siparis]

FROM Employees e
JOIN Orders o ON e.EmployeeID = o.EmployeeID
JOIN OrderDetails od ON o.OrderID = od.OrderID

WHERE e.FirstName IS NULL
