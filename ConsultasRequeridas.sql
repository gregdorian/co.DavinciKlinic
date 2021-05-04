
-- **** Obtener la lista de precios de todos los productos
SELECT   NombreProducto, PrecioUnitario
FROM   Productos AS p

--Obtener la lista de productos cuya existencia en el inventario haya llegado al
--mínimo permitido (5 unidades) 

SELECT IdProducto, CodigoProducto, NombreProducto, PrecioUnitario, PrecioCosto, Stock, StockMinimo, FechaIngreso
FROM  Productos AS p
WHERE        (StockMinimo < 5)

-- Obtener una lista de clientes no mayores de 35 años que hayan realizado compras entre
--el 1 de febrero de 2000 y el 25 de mayo de 2000

SELECT c.NombreCliente, c.Edad, f.FechaFactura
FROM   Clientes AS c 
	INNER JOIN
    FacturaVenta AS f ON c.IdCliente = f.IdCliente
WHERE   (c.Edad < 35) 
   AND (f.FechaFactura BETWEEN CONVERT(datetime, '2000-02-01') AND CONVERT(datetime, '2000-05-25'))

 --Obtener el valor total vendido por cada producto en el año 2000
SELECT  p.NombreProducto, f.FechaFactura, f.Total
FROM    FacturaVenta AS f 
     INNER JOIN
       ItemFactura AS i ON f.IdFacturaVenta = i.IdFacturaVenta 
	 INNER JOIN
       Productos AS p ON p.IdProducto = i.IdProducto
WHERE  (YEAR(f.FechaFactura) = 2000)

-- Obtener la última fecha de compra de un cliente y según su frecuencia de compra
--estimar en qué fecha podría volver a comprar. 

SELECT  COUNT(c.NombreCliente) AS ClienteFrecuente, MAX(f.FechaFactura) AS UltimaFecha
FROM  Clientes AS c 
INNER JOIN
      FacturaVenta AS f ON c.IdCliente = f.IdCliente