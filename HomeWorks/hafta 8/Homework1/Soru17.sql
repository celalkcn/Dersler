SELECT 
    c.CategoryName [Kategori],
   -- p.ProductName [Ürün],
    AVG(p.UnitPrice) [Ortalama Fiyat]

FROM Categories c
JOIN Products p ON c.CategoryID=p.CategoryID

GROUP BY  CategoryName
