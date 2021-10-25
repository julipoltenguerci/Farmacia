-- Datos Insertados - BD Farmac�utica

--Provincias

Insert into Provincias (nom_provincia) values ('C�rdoba')
Insert into Provincias (nom_provincia) values ('San Luis')
Insert into Provincias (nom_provincia) values ('Santa Fe')
Insert into Provincias (nom_provincia) values ('Buenos Aires')

--Select *
--From Provincias

--Localidades

Insert into Localidades (id_provincia, nom_localidad) values (1,'C�rdoba Capital')
Insert into Localidades (id_provincia, nom_localidad) values (1, 'Villa Allende')
Insert into Localidades (id_provincia, nom_localidad) values (1, 'Alta Gracia')
Insert into Localidades (id_provincia, nom_localidad) values (1, 'Mendiolaza')

Insert into Localidades (id_provincia, nom_localidad) values (2,'San Luis Capital')
Insert into Localidades (id_provincia, nom_localidad) values (2, 'Villa Mercedes')
Insert into Localidades (id_provincia, nom_localidad) values (2, 'Villa de Merlo')
Insert into Localidades (id_provincia, nom_localidad) values (2, 'La Punta')

Insert into Localidades (id_provincia, nom_localidad) values (3,'Santa Fe Capital')
Insert into Localidades (id_provincia, nom_localidad) values (3, 'Rosario')
Insert into Localidades (id_provincia, nom_localidad) values (3, 'Rafaela')
Insert into Localidades (id_provincia, nom_localidad) values (3, 'Sunchales')

Insert into Localidades (id_provincia, nom_localidad) values (4,'CABA')
Insert into Localidades (id_provincia, nom_localidad) values (4, 'La Plata')
Insert into Localidades (id_provincia, nom_localidad) values (4, 'Avellaneda')
Insert into Localidades (id_provincia, nom_localidad) values (4, 'Mor�n')

--Select *
--From Localidades

--Barrios

Insert into Barrios (id_localidad, nom_barrio) values (1, 'Centro')
Insert into Barrios (id_localidad, nom_barrio) values (1, 'Alberdi')
Insert into Barrios (id_localidad, nom_barrio) values (1, 'Nueva C�rdoba')
Insert into Barrios (id_localidad, nom_barrio) values (1, 'Cerro de las Rosas')
Insert into Barrios (id_localidad, nom_barrio) values (2, 'San Isidro')
Insert into Barrios (id_localidad, nom_barrio) values (2, 'San Mart�n')
Insert into Barrios (id_localidad, nom_barrio) values (3, 'Parque del Virrey')
Insert into Barrios (id_localidad, nom_barrio) values (3, 'Portales del Sol')
Insert into Barrios (id_localidad, nom_barrio) values (4, 'El Talar')

Insert into Barrios (id_localidad, nom_barrio) values (5, 'Uni�n')
Insert into Barrios (id_localidad, nom_barrio) values (6, 'Jard�n del Sur')
Insert into Barrios (id_localidad, nom_barrio) values (7, 'Barranca Colorada')
Insert into Barrios (id_localidad, nom_barrio) values (8, 'La Candelaria')

Insert into Barrios (id_localidad, nom_barrio) values (9, 'Sur')
Insert into Barrios (id_localidad, nom_barrio) values (9, 'Centro')
Insert into Barrios (id_localidad, nom_barrio) values (10, 'Parque')
Insert into Barrios (id_localidad, nom_barrio) values (10, 'Abasto')
Insert into Barrios (id_localidad, nom_barrio) values (11, '2 de Abril')
Insert into Barrios (id_localidad, nom_barrio) values (11, 'Barranquitas')
Insert into Barrios (id_localidad, nom_barrio) values (12, 'Col�n')

Insert into Barrios (id_localidad, nom_barrio) values (13, 'Almagro')
Insert into Barrios (id_localidad, nom_barrio) values (13, 'Parque Avellaneda')
Insert into Barrios (id_localidad, nom_barrio) values (14, 'Carmen Oeste')
Insert into Barrios (id_localidad, nom_barrio) values (15, 'Sarand�')
Insert into Barrios (id_localidad, nom_barrio) values (16, 'Santa Laura')

--Select *
--From Barrios

--Sucursales

Insert into Sucursales (nom_sucursal, calle, altura, id_barrio) values ('Farmaceutica del Valle - Centro', 'Rosario de Santa Fe', 105, 1)
Insert into Sucursales (nom_sucursal, calle, altura, id_barrio) values ('Farmaceutica del Valle - Nueva C�rdoba', 'Crisol', 1236, 3)
Insert into Sucursales (nom_sucursal, calle, altura, id_barrio) values ('Farmaceutica del Valle - Cerro de las Rosas', 'Luis de Tejeda', 1546, 4)
Insert into Sucursales (nom_sucursal, calle, altura, id_barrio) values ('Farmaceutica del Valle - Barranca Colorada', 'San Luis', 2124, 12)
Insert into Sucursales (nom_sucursal, calle, altura, id_barrio) values ('Farmaceutica del Valle - Carmen Oeste', 'Esquiu', 105, 23)
Insert into Sucursales (nom_sucursal, calle, altura, id_barrio) values ('Farmaceutica del Valle - Abasto', 'Rosario de Santa Fe', 105, 17)

--Select *
--From Sucursales


--Medicos

Insert into Medicos (nom_medico, ape_medico, matricula) values ('Mario', 'Villalba', '114.223 MP')
Insert into Medicos (nom_medico, ape_medico, matricula) values ('Edgardo', 'Castillo', '113.563 MP')
Insert into Medicos (nom_medico, ape_medico, matricula) values ('Mar�a Guillermina', 'L�pez', '114.540 M.P')
Insert into Medicos (nom_medico, ape_medico, matricula) values ('Silvina', 'Torres', '113.873 M.P')
Insert into Medicos (nom_medico, ape_medico, matricula) values ('Felipe', 'Barrionuevo', '110.892 M.E')
Insert into Medicos (nom_medico, ape_medico, matricula) values ('Victoria', 'Pelanda', '116.007 M.E')

--Select *
--From Medicos

--Empleados

Insert into Empleados (nom_empleado, ape_empleado) values ('Lorena', 'Fernandez')
Insert into Empleados (nom_empleado, ape_empleado) values ('Juan Ignacio', 'Perez')
Insert into Empleados (nom_empleado, ape_empleado) values ('Marcos', 'Velazquez')
Insert into Empleados (nom_empleado, ape_empleado) values ('Florencia', 'Pizarro')
Insert into Empleados (nom_empleado, ape_empleado) values ('Joaquin', 'Alvarez')
Insert into Empleados (nom_empleado, ape_empleado) values ('Facundo', 'Torres')
Insert into Empleados (nom_empleado, ape_empleado) values ('Fernanda', 'Arroyo')
Insert into Empleados (nom_empleado, ape_empleado) values ('Giselle', 'Alvarez')
Insert into Empleados (nom_empleado, ape_empleado) values ('Mauricio', 'Campos')
Insert into Empleados (nom_empleado, ape_empleado) values ('Tamara', 'Diaz')

--Select *
--From Empleados

--Empleados Proveedor

Insert into Empleados_Proveedor (nom_empleado, ape_empleado) values ('Miguel Angel', 'Ferreyra')
Insert into Empleados_Proveedor (nom_empleado, ape_empleado) values ('Ezequiel', 'Ramirez')
Insert into Empleados_Proveedor (nom_empleado, ape_empleado) values ('Mario', 'Castillo')
Insert into Empleados_Proveedor (nom_empleado, ape_empleado) values ('Agustin', 'Lopez')
Insert into Empleados_Proveedor (nom_empleado, ape_empleado) values ('Fabiola', 'Moreyra')
Insert into Empleados_Proveedor (nom_empleado, ape_empleado) values ('F�lix', '�vila')
Insert into Empleados_Proveedor (nom_empleado, ape_empleado) values ('Mariana', 'Barrera')
Insert into Empleados_Proveedor (nom_empleado, ape_empleado) values ('N�stor', 'Pereyra')
Insert into Empleados_Proveedor (nom_empleado, ape_empleado) values ('Gabriel', 'Torres')
Insert into Empleados_Proveedor (nom_empleado, ape_empleado) values ('Julia', 'Paez')

--Select *
--From Empleados_Proveedor

--Descuentos

Insert into Descuentos(cant_desc) values (0)
Insert into Descuentos(cant_desc) values (10)
Insert into Descuentos(cant_desc) values (20)
Insert into Descuentos(cant_desc) values (30)
Insert into Descuentos(cant_desc) values (40)
Insert into Descuentos(cant_desc) values (50)
Insert into Descuentos(cant_desc) values (60)
Insert into Descuentos(cant_desc) values (70)
Insert into Descuentos(cant_desc) values (80)
Insert into Descuentos(cant_desc) values (90)
Insert into Descuentos(cant_desc) values (100)

--Select *
--From Descuentos

-- Tipo Suministros

Insert into Tipos_Suministros (tipo_suministro) values ('Cuidado Bucal')
Insert into Tipos_Suministros (tipo_suministro) values ('Maquillaje')
Insert into Tipos_Suministros (tipo_suministro) values ('Dermocosm�tica')
Insert into Tipos_Suministros (tipo_suministro) values ('Medicamentos')
Insert into Tipos_Suministros (tipo_suministro) values ('Complejos Vitam�nicos')

--Select *
--From Tipos_Suministros


-- Tipos Condiciones Venta

Insert into Tipos_condiciones_venta (tipo_cond_venta) values ('Venta Libre')
Insert into Tipos_condiciones_venta (tipo_cond_venta) values ('Obra Social')


--Select *
--From Tipos_condiciones_venta


--Suministros

Insert into Suministros (codigo_barras, nom_suministros, id_tipo_sum, stock, precio_unitario, tipo_cond_venta) values (48889947293046, 'Actron Ibuprofeno Bayer 400gr 10 caps bl', 4, 125, '110.00', 1)
Insert into Suministros (codigo_barras, nom_suministros, id_tipo_sum, stock, precio_unitario, tipo_cond_venta) values (48889947293146, 'Actron Ibuprofeno Bayer 600gr 10 caps bl', 4, 684, '218.99', 1)
Insert into Suministros (codigo_barras, nom_suministros, id_tipo_sum, stock, precio_unitario, tipo_cond_venta) values (48552163465634, 'Levotiroxina Montpellier 75mcg', 4, 576, '498.99', 2)
Insert into Suministros (codigo_barras, nom_suministros, id_tipo_sum, stock, precio_unitario, tipo_cond_venta) values (48552163465734, 'Levotiroxina Montpellier 50mcg', 4, 793, '478.99', 2)
Insert into Suministros (codigo_barras, nom_suministros, id_tipo_sum, stock, precio_unitario, tipo_cond_venta) values (50935701173270, 'Ensure Plus Vainilla 220ml', 5, 146, '525.00', 1)
Insert into Suministros (codigo_barras, nom_suministros, id_tipo_sum, stock, precio_unitario, tipo_cond_venta) values (42993125045080, 'Crema Dental Colgate maxima proteccion anticaries 90gr', 5, 146, '199.90', 1)
Insert into Suministros (codigo_barras, nom_suministros, id_tipo_sum, stock, precio_unitario, tipo_cond_venta) values (42993125045180, 'Crema Dental Colgate maxima proteccion anticaries 180gr', 5, 146, '324.90', 1)
Insert into Suministros (codigo_barras, nom_suministros, id_tipo_sum, stock, precio_unitario, tipo_cond_venta) values (42993125046080, 'Crema Dental Oral-B Complete 90gr', 5, 146, '182.00', 1)
Insert into Suministros (codigo_barras, nom_suministros, id_tipo_sum, stock, precio_unitario, tipo_cond_venta) values (42993125046180, 'Crema Dental Oral-B Complete 180gr', 5, 146, '304.99', 1)

--Select *
--From Suministros


--Proveedores
--C�rdoba

Insert into Proveedores (nom_proveedor, razon_social, cuit, calle, altura, id_barrio) values ('Diaz Insumos', 'Diaz Distribuidora Insumos S.A', '29-30721184-0', 'Avenida Col�n', 1080, 1)
Insert into Proveedores (nom_proveedor, razon_social, cuit, calle, altura, id_barrio) values ('Gutierrez e Hijos Descartables S.A', 'Gutierrez e Hijos Descartables S.A', '29-31227994-0', 'Maip�', 934, 1)
Insert into Proveedores (nom_proveedor, razon_social, cuit, calle, altura, id_barrio) values ('Laboratorio Alberdi', 'Alberdi Lab S.R.L', '28-33548773-1', '9 de julio', 1260, 2)
Insert into Proveedores (nom_proveedor, razon_social, cuit, calle, altura, id_barrio) values ('Farmacia Mayorista del Sol', 'Farmacia May del Sol S.R.L', '29-12544662-0', 'Obispo Trejo', 1430, 3)
Insert into Proveedores (nom_proveedor, razon_social, cuit, calle, altura, id_barrio) values ('Laboratorio Norte S.R.L', 'Farmacia Norte SRL', '29-11548529-0', 'Avenida Rafael Nu�ez', 3106, 4)

Insert into Proveedores (nom_proveedor, razon_social, cuit, calle, altura, id_barrio) values ('Laboratorio Villa Allende', 'Lab Villa Allende S.A', '28-12339845-0','Padre Luchesse KM', 2, 5)
Insert into Proveedores (nom_proveedor, razon_social, cuit, calle, altura, id_barrio) values ('Gutierrez e Hijos Descartables', 'Descartables Gutierrez S.A', '29-08337773-0',  'Maip�', 934, 6)
Insert into Proveedores (nom_proveedor, razon_social, cuit, calle, altura, id_barrio) values ('Farmaceutica del Progreso', 'Farmaceutica del Progreso S.R.L', '28-17825650-0',  '9 de julio', 782, 1)
Insert into Proveedores (nom_proveedor, razon_social, cuit, calle, altura, id_barrio) values ('Distribuidora Pop', 'Distribuidora Pop S.A.C,', '29-205729541-0', 'Principal', 10, 8)

--San Luis
Insert into Proveedores (nom_proveedor, razon_social, cuit, calle, altura, id_barrio) values ('LEM Medical', 'LEM Medical S.R.L', '28-06442507-0', 'Pringles', 464, 10)
Insert into Proveedores (nom_proveedor, razon_social, cuit, calle, altura, id_barrio) values ('Laboratorio Del Aguila', 'Del Aguila - Laboratorio S.A', '28-05742747-1', 'Edison', 2, 11)

--Santa Fe
Insert into Proveedores (nom_proveedor, razon_social, cuit, calle, altura, id_barrio) values ('Casa M�dica Distrubuidora', 'Casa M�dica Distrubuidora S.A.C', '29-24528616-1', '25 de Mayo', 3313, 15)

--Buenos Aires
Insert into Proveedores (nom_proveedor, razon_social, cuit, calle, altura, id_barrio) values ('Bacimed Insumos M�dicos', 'Bacimed S.A', '28-04586009-1', 'Bahia Blanca', 2765, 21)
Insert into Proveedores (nom_proveedor, razon_social, cuit, calle, altura, id_barrio) values ('C&G Medicinal', 'C&G Medicinal S.R.L', '28-14243604-1', 'Calle 61', 9, 23)


--Select *
--From Proveedores


--Pedidos

Insert into Pedidos (fecha_pedido, fecha_entrega, id_empleado, id_sucursal, id_empleado_prov, id_proveedor) values ('13/01/2021', '18/01/2021', 1, 1, 1, 1)
Insert into Pedidos (fecha_pedido, fecha_entrega, id_empleado, id_sucursal, id_empleado_prov, id_proveedor) values ('22/01/2021', '29/01/2021', 2, 1, 2, 3)
Insert into Pedidos (fecha_pedido, fecha_entrega, id_empleado, id_sucursal, id_empleado_prov, id_proveedor) values ('16/02/2021', '21/02/2021', 3, 2, 3, 5)
Insert into Pedidos (fecha_pedido, fecha_entrega, id_empleado, id_sucursal, id_empleado_prov, id_proveedor) values ('01/03/2021', '02/03/2021', 4, 3, 4, 5)
Insert into Pedidos (fecha_pedido, fecha_entrega, id_empleado, id_sucursal, id_empleado_prov, id_proveedor) values ('02/03/2021', '18/03/2021', 5, 4, 5, 10)
Insert into Pedidos (fecha_pedido, fecha_entrega, id_empleado, id_sucursal, id_empleado_prov, id_proveedor) values ('15/03/2021', '27/03/2021', 6, 5, 6, 12)
Insert into Pedidos (fecha_pedido, fecha_entrega, id_empleado, id_sucursal, id_empleado_prov, id_proveedor) values ('13/04/2021', '16/04/2021', 7, 5, 7, 12)
Insert into Pedidos (fecha_pedido, fecha_entrega, id_empleado, id_sucursal, id_empleado_prov, id_proveedor) values ('04/06/2021', '20/06/2021', 8, 6, 8, 14)

--Select *
--From Pedidos


--Detalles Pedidos

Insert into Detalles_Pedidos (id_det_pedido, id_pedido, id_suministro, id_medico, cantidad, precio_compra) values (1, 1, 2, 2, 5, '2494,95')
Insert into Detalles_Pedidos (id_det_pedido, id_pedido, id_suministro, id_medico, cantidad, precio_compra) values (2, 2, 2, 3, 3, '1496,97')
Insert into Detalles_Pedidos (id_det_pedido, id_pedido, id_suministro, id_medico, cantidad, precio_compra) values (3, 3, 3, 5, 4, '1915,96')
Insert into Detalles_Pedidos (id_det_pedido, id_pedido, id_suministro, id_medico, cantidad, precio_compra) values (4, 4, 3, 4, 2, '957,98')
Insert into Detalles_Pedidos (id_det_pedido, id_pedido, id_suministro, id_medico, cantidad, precio_compra) values (5, 5, 3, 1, 2, '957,98')

--Select *
--From Detalles_Pedidos


--Clientes

Insert into Clientes (nom_cliente, ape_cliente, telefono, calle, altura, id_barrio) values ('Ismael', 'Rodriguez', '3512498709', 'Rodriguez del Busto', 2040, 4)
Insert into Clientes (nom_cliente, ape_cliente, telefono, calle, altura, id_barrio) values ('Rosalia', 'Suarez', '3516598223', 'Tucuman', 348, 1)
Insert into Clientes (nom_cliente, ape_cliente, telefono, calle, altura, id_barrio) values ('Francisco', 'Flores', '3512498709', 'San Martin', 4134, 10)

--Select *
--From Clientes

-- Obras Sociales

Insert into Obras_Sociales (nom_obra_social) values ('Osde')
Insert into Obras_Sociales (nom_obra_social) values ('Swiss Medical')
Insert into Obras_Sociales (nom_obra_social) values ('Daspu')
Insert into Obras_Sociales (nom_obra_social) values ('Sancor Salud')
Insert into Obras_Sociales (nom_obra_social) values ('Galeno')
Insert into Obras_Sociales (nom_obra_social) values ('Medif�')
Insert into Obras_Sociales (nom_obra_social) values ('Federada Salud')
Insert into Obras_Sociales (nom_obra_social) values ('Omint')
Insert into Obras_Sociales (nom_obra_social) values ('Prevenci�n Salud')
Insert into Obras_Sociales (nom_obra_social) values ('Aca Salud')

--Select *
--From Obras_Sociales

--Autorizaciones

Insert into Autorizaciones (estado, fecha, id_medico, id_obra_social) values (1, '02/03/2021', 1, 1)
Insert into Autorizaciones (estado, fecha, id_medico, id_obra_social) values (1, '06/01/2021', 2, 4)
Insert into Autorizaciones (estado, fecha, id_medico, id_obra_social) values (1, '27/05/2021', 3, 3)
Insert into Autorizaciones (estado, fecha, id_medico, id_obra_social) values (1, '21/04/2021', 4, 2)
Insert into Autorizaciones (estado, fecha, id_medico, id_obra_social) values (0, '11/02/2021', 5, 5)
Insert into Autorizaciones (estado, fecha, id_medico, id_obra_social) values (1, '19/02/2021', 5, 6)

--Select *
--From Autorizaciones

--Facturas

Insert into Facturas (id_cliente, id_sucursal, fecha_factura) values (1, 3, '02/03/2021')
Insert into Facturas (id_cliente, id_sucursal, fecha_factura) values (2, 1, '06/01/2021')
Insert into Facturas (id_cliente, id_sucursal, fecha_factura) values (2, 1, '27/05/2021')
Insert into Facturas (id_cliente, id_sucursal, fecha_factura) values (1, 2, '21/04/2021')
Insert into Facturas (id_cliente, id_sucursal, fecha_factura) values (3, 4, '19/02/2021')

--Select *
--From Facturas

--Detalles Facturas

Insert into Detalles_Facturas (id_det_factura, cant_suministro, precio_unitario, id_factura, id_suministro, id_descuento, id_tipo_cond_vta, id_autorizacion)
values (1, 2, '498.99', 1, 3, 4, 2, 1)

Insert into Detalles_Facturas (id_det_factura, cant_suministro, precio_unitario, id_factura, id_suministro, id_descuento, id_tipo_cond_vta, id_autorizacion)
values (2, 1, '498.99', 2, 3, 5, 2, 2)

Insert into Detalles_Facturas (id_det_factura, cant_suministro, precio_unitario, id_factura, id_suministro, id_descuento, id_tipo_cond_vta, id_autorizacion)
values (3, 1, '304.99', 3, 9, 1, 1, 3)

Insert into Detalles_Facturas (id_det_factura, cant_suministro, precio_unitario, id_factura, id_suministro, id_descuento, id_tipo_cond_vta, id_autorizacion)
values (4, 3, '339.99', 4, 7, 1, 1, 4)

Insert into Detalles_Facturas (id_det_factura, cant_suministro, precio_unitario, id_factura, id_suministro, id_descuento, id_tipo_cond_vta, id_autorizacion)
values (5, 1, '478.99', 4, 4, 3, 2, 5)

Insert into Detalles_Facturas (id_det_factura, cant_suministro, precio_unitario, id_factura, id_suministro, id_descuento, id_tipo_cond_vta, id_autorizacion)
values (6, 1, '478.99', 5, 3, 11, 2, 6)

--Select *
--From Detalles_Facturas












