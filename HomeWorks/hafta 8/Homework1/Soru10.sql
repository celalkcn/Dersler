SELECT DISTINCT
    FirstName [Çalışan],
    SUM(od.Quantity) [Sipariş Miktar]

FROM Employees e
    JOIN Orders o ON e.EmployeeID = o.EmployeeID
        JOIN OrderDetails od ON o.OrderID = od.OrderID
GROUP BY e.FirstName
ORDER BY [Çalışan]