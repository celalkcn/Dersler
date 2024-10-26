SELECT
    e.FirstName+' ' +e.LastName  AS [Çalışan],
   FORMAT(SUM(od.UnitPrice*od.Quantity* (1-od.Discount))  , 'N2', 'tr-TR') AS [Toplam Tutar]
FROM Employees e
    JOIN Orders o ON e.EmployeeID= o.EmployeeID
    JOIN OrderDetails od ON o.OrderID = od.OrderID

GROUP BY  e.FirstName+' ' +e.LastName 
