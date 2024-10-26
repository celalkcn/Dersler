SELECT 
Country [Ülke],
COUNT(CustomerID) [Müşteri Sayısı]

FROM Customers
GROUP BY Country
ORDER BY COUNT(CustomerID) DESC

