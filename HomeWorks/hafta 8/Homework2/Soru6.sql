SELECT 
e.FirstName AS [İsim], 
t.TerritoryDescription AS [Bölge],
FORMAT(SUM(od.UnitPrice * od.Quantity*(1-od.Discount)), 'N2' , 'tr-TR') AS [Toplam Tutar]

FROM Employees e
JOIN EmployeeTerritories et ON e.EmployeeID = et.EmployeeID
JOIN Territories t ON et.TerritoryID = t.TerritoryID 
JOIN Orders o ON e.EmployeeID = o.EmployeeID
JOIN OrderDetails od ON o.OrderID = od.OrderID

GROUP BY e.FirstName, t.TerritoryDescription
ORDER BY e.FirstName
