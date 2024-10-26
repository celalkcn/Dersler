SELECT 
    s.CompanyName [Kargo Şirketi],
    SUM(od.Quantity) [Miktar] 
FROM Shippers s
JOIN Suppliers su ON s.Phone = su.Phone
JOIN Products p ON su.SupplierID = p.SupplierID
JOIN OrderDetails od ON p.ProductID = od.ProductID

GROUP BY s.CompanyName
