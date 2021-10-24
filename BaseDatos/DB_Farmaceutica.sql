 --Totales de facturación, discriminados por tipos de suministros, si fueron o no autorizados por obra social, y realizados hace 6 meses atrás.

Select f.id_factura as 'Nro Factura', cant_suministro*df.precio_unitario as 'Total Factura', a.estado as Autorizado, f.fecha_factura 'Fecha Factura',
nom_suministros as 'Nombre Suministro', ts.tipo_suministro Tipo_suministro 
From Facturas f join Detalles_Facturas df on f.id_factura=df.id_factura 
join Suministros s on df.id_suministro=s.id_suministro
join Tipos_Suministros ts on ts.id_tipo_sum=s.id_tipo_sum
join Autorizaciones a on a.id_autorizacion=df.id_autorizacion
Where datediff(month,fecha_factura,getdate())=6