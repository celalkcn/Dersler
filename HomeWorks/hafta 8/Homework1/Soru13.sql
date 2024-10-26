SELECT TOP 5
    p.ProductName [Ürün],
   od.Quantity [Satış]
FROM OrderDetails od
JOIN Products p ON od.ProductID = p.ProductID

ORDER BY od.Quantity DESC