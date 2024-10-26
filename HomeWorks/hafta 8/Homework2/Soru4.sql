SELECT 
    s.CompanyName AS [Tedarikçi], 
    AVG(p.UnitPrice) AS [Ortalama Fiyat],
    COUNT( p.ProductID) 

FROM Suppliers s
JOIN Products p ON s.SupplierID = p.SupplierID


GROUP BY s.CompanyName
