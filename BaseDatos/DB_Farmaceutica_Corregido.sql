--Realizar reporte de las sucursales que han facturado este año en curso y su promedio de facturación

SELECT 
s.nom_sucursal AS 'Sucursal',
SUM(df.precio_unitario*df.cant_suministro) AS 'Total Sucursal Sin Descuento',
d.cant_desc AS '% Descuento Aplicado',
SUM(df.precio_unitario*df.cant_suministro)*(100-d.cant_desc)/100 AS 'Total Factura',
SUM(df.precio_unitario*df.cant_suministro)/COUNT(df.id_factura) AS 'Promedio de Facturación Sucursal'
FROM Facturas f
	JOIN Sucursales s ON f.id_sucursal=s.id_sucursal
	JOIN Detalles_facturas  df ON f.id_factura=df.id_factura
	JOIN Descuentos d ON df.id_descuento=d.id_descuento
WHERE year(f.fecha_factura)=year(getdate())
GROUP BY s.nom_sucursal,d.cant_desc
ORDER BY s.nom_sucursal