SELECT 
    CategoryName [Kategori],
    ProductName [Ürün Adı] 
FROM Categories c
    JOIN Products p ON c.CategoryID = p.CategoryID
ORDER BY CategoryName
 