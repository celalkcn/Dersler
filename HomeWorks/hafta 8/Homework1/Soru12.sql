SELECT OrderID [Sipariş],
SUM(UnitPrice * Quantity) [Sipariş Tutar]
FROM OrderDetails
GROUP BY OrderID