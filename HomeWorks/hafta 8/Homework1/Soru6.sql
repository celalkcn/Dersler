SELECT 
    CategoryName [Kategori],  
    COUNT (p.ProductID) [Ürün Adet]
FROM Products p
JOIN Categories c ON c.CategoryID = p.CategoryID
GROUP BY  CategoryName