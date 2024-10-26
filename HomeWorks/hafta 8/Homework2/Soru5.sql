SELECT 
    
    c.CompanyName AS [Müşteri],
    ca.CategoryName AS [Kategori],
    COUNT(ca.CategoryID) [Sipariş sayısı]


FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN OrderDetails od ON o.OrderID = od.OrderID
JOIN Products p ON od.ProductID = p.ProductID
JOIN Categories ca ON p.CategoryID = ca.CategoryID


GROUP BY  c.CompanyName , ca.CategoryName
HAVING COUNT(ca.CategoryID) >= 3
ORDER BY c.CompanyName