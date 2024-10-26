SELECT 
    OrderID,
    Freight [Nakliye Tutar]

FROM Orders
 
WHERE Freight > 50
ORDER BY Freight
