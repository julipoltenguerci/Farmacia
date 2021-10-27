
use db_Farmacia
go
create table Provincias
(
	id_provincia int identity(1,1) not null,
	nom_provincia varchar(35),
	constraint pk_id_provincia primary key(id_provincia)
)
go
create table Localidades
(
	id_localidad int identity(1,1) not null,
	nom_localidad varchar(35),
	id_provincia int,
	constraint pk_id_localidad primary key(id_localidad),
	constraint fk_id_provincia foreign key (id_provincia) references Provincias(id_provincia)
)
go
create table Barrios
(
	id_barrio int identity(1,1) not null,
	nom_barrio varchar(40),
	id_localidad int,
	constraint pk_id_barrio primary key(id_barrio),
	constraint fk_id_localidad foreign key (id_localidad) references Localidades(id_localidad)
)
go
create table Clientes
(
	id_cliente int identity(1,1) not null,
	nom_cliente varchar(50),
	ape_cliente varchar(50),
	telefono varchar(30),
	calle varchar(40),
	altura int,
	id_barrio int
	constraint pk_id_cliente primary key (id_cliente),
	constraint fk_id_barrio_cliente foreign key (id_barrio) references Barrios(id_barrio)
)
go
create table Sucursales 
(
	id_sucursal int identity(1,1) not null,
	nom_sucursal varchar(50),
	calle varchar(40),
	altura int,
	id_barrio int
	constraint pk_id_sucursal primary key (id_sucursal),
	constraint fk_id_barrio_sucursal foreign key (id_barrio) references Barrios(id_barrio)
)
go
create table Facturas 
(
	id_factura int identity(1,1),
	id_cliente int,
	id_sucursal int,
	fecha_factura datetime,
	constraint pk_id_factura primary key (id_factura),
	constraint fk_id_factura_cl foreign key (id_cliente) references Clientes(id_cliente),
	constraint fk_id_factura_sl foreign key (id_sucursal) references Sucursales(id_sucursal)
)
go
create table Empleados 
(
	id_empleado int identity(1,1),
	nom_empleado varchar(50),
	ape_empleado varchar(50)
	constraint pk_id_empleado primary key (id_empleado)
)
go
create table Empleados_Proveedor
(
	id_empleado_prov int identity(1,1),
	nom_empleado varchar(50),
	ape_empleado varchar(50),
	constraint pk_id_empleado_prov primary key (id_empleado_prov)
)
go
create table Proveedores 
(
	id_proveedor int identity(1,1),
	nom_proveedor varchar(50),
	razon_social varchar(50),
	cuit varchar(15),
	calle varchar(40),
	altura int,
	id_barrio int
	constraint pk_id_proveedor primary key (id_proveedor),
	constraint fk_id_barrio_prov foreign key (id_barrio) references Barrios(id_barrio)
)
go
create table Pedidos 
(
	id_pedido int identity(1,1) not null,
	fecha_pedido datetime,
	fecha_entrega datetime,
	id_empleado int,
	id_sucursal int,
	id_empleado_prov int,
	id_proveedor int
	constraint pk_id_pedido primary key (id_pedido),
	constraint fk_id_pedido_empleado foreign key (id_empleado) references Empleados(id_empleado),
	constraint fk_id_pedidos_sucursal foreign key (id_sucursal) references Sucursales(id_sucursal),
	constraint fk_id_pedidos_empleado_prov foreign key (id_empleado_prov) references Empleados_Proveedor(id_empleado_prov),
	constraint fk_id_pedido_proveedor foreign key (id_proveedor) references Proveedores(id_proveedor)
)
go
create table Medicos 
(
	id_medico int identity(1,1),
	nom_medico varchar(50),
	ape_medico varchar(50),
	matricula varchar(15),
	constraint pk_id_medico primary key (id_medico),
)
go
create table Obras_Sociales 
(
	id_obra_social int identity(1,1),
	nom_obra_social varchar(50),
	constraint pk_id_obra_social primary key (id_obra_social)
)
go
create table Autorizaciones 
(
	id_autorizacion int identity(1,1),
	estado bit,
	fecha datetime,
	id_medico int,
	id_obra_social int
	constraint pk_id_autorizacione primary key (id_autorizacion),
	constraint fk_id_auto_medico foreign key (id_medico) references Medicos(id_medico),
	constraint fk_id_auto_obra_social foreign key (id_obra_social) references Obras_Sociales(id_obra_social)
)
go
create table Tipos_condiciones_venta 
(
	id_tipo_cond_vta int identity(1,1),
	tipo_cond_venta varchar(20),
	constraint pk_id_tipo_cond_vta primary key (id_tipo_cond_vta)
)
go
create table Tipos_Suministros
(
	id_tipo_sum int identity(1,1),
	tipo_suministro varchar(40),
	constraint id_tipo_sum primary key (id_tipo_sum)
)
go
create table Suministros 
(
	id_suministro int identity(1,1),
	codigo_barras int,
	nom_suministros varchar(40),
	id_tipo_sum int,
	stock int,
	precio_unitario money,
	tipo_cond_venta int
	constraint pk_id_suministros primary key (id_suministro),	
	constraint fk_id_sum_tipo_sum foreign key (id_tipo_sum) references Tipos_Suministros(id_tipo_sum),
	constraint fk_sum_tipo_cond_venta foreign key (tipo_cond_venta) references Tipos_condiciones_venta(id_tipo_cond_vta)
)
go
create table Detalles_Pedidos
(
	id_det_pedido int not null,
	id_pedido int,
	id_suministro int,
	id_medico int,
	cantidad int,
	precio_compra money
	constraint pk_id_det_pedido primary key (id_det_pedido),
	constraint fk_id_dp_pedido foreign key (id_pedido) references Pedidos(id_pedido),
	constraint fk_id_dp_suministro foreign key (id_suministro) references Suministros(id_suministro),
	constraint fk_id_dp_medico foreign key (id_medico) references Medicos(id_medico)
)
go
create table Descuentos 
(
	id_descuento int identity(1,1),
	cant_desc tinyint
	constraint pk_id_descuento primary key (id_descuento)
)
go
create table Detalles_Facturas
(
	id_det_factura int not null,
	cant_suministro int,
	precio_unitario money,
	id_factura int,
	id_suministro int,
	id_descuento int,
	id_tipo_cond_vta int,
	id_autorizacion int
	constraint pk_id_det_factura primary key (id_det_factura),
	constraint fk_id_df_factura foreign key (id_factura) references Facturas(id_factura),
	constraint fk_id_df_suministro foreign key (id_suministro) references Suministros(id_suministro),
	constraint fk_id_df_descuento foreign key (id_descuento) references Descuentos(id_descuento),
	constraint fk_id_df_tipo_cond_vta foreign key (id_tipo_cond_vta) references Tipos_condiciones_venta(id_tipo_cond_vta),
	constraint fk_id_df_autorizacion foreign key (id_autorizacion) references Autorizaciones(id_autorizacion)
)
go
create PROCEDURE PA_CONSULTA_FACTURAS_FILTRO
@nroFactura int=null,
@fechaDesde date=null,
@fechaHasta date=null,
@cliente varchar(150)=null,
@tipo int=null,
@activo varchar(1)
AS
	if @tipo=0 --filtro por numero factura
		SELECT f.id_factura,convert(varchar,
			f.fecha_factura,3) fecha,
			c.ape_cliente apellido,
			c.nom_cliente nombre,
			SUM(df.cant_suministro*df.precio_unitario) total,
			'fecha_baja' fechaB
		FROM Facturas f JOIN Clientes c ON f.id_cliente=c.id_cliente
			JOIN Detalles_Facturas df ON df.id_factura=f.id_factura
		WHERE 
		 ((@fechaDesde is null and @fechaHasta is  null) OR (f.fecha_factura between @fechaDesde and @fechaHasta))
		 AND(@nroFactura is null OR f.id_factura=@nroFactura)
		 AND (@activo is null OR (@activo = 'S') OR (@activo = 'N'))--(@activo = 'N' and 'fecha_baja' IS  NULL))
		 GROUP BY f.id_factura,convert(varchar,f.fecha_factura,3),c.ape_cliente,c.nom_cliente
	if @tipo=1 --filtro por cliente
		SELECT f.id_factura,convert(varchar,
			f.fecha_factura,3) fecha,
			c.ape_cliente apellido,
			c.nom_cliente nombre,
			SUM(df.cant_suministro*df.precio_unitario) total,
			'fecha_baja' fechaB
		FROM Facturas f JOIN Clientes c ON f.id_cliente=c.id_cliente
			JOIN Detalles_Facturas df ON df.id_factura=f.id_factura
		WHERE 
		 ((@fechaDesde is null and @fechaHasta is  null) OR (f.fecha_factura between @fechaDesde and @fechaHasta))
		 AND(@cliente is null OR (c.ape_cliente like '%' + @cliente + '%') OR(c.nom_cliente like '%' + @cliente + '%'))
		 AND (@activo is null OR (@activo = 'S') OR (@activo = 'N'))--(@activo = 'N' and 'fecha_baja' IS  NULL))
		GROUP BY f.id_factura,convert(varchar,f.fecha_factura,3),c.ape_cliente,c.nom_cliente
	if @tipo=2 --filtro por bajas
		SELECT f.id_factura,convert(varchar,
			f.fecha_factura,3) fecha,
			c.ape_cliente apellido,
			c.nom_cliente nombre,
			SUM(df.cant_suministro*df.precio_unitario) total,
			'fecha_baja' fechaB
		FROM Facturas f JOIN Clientes c ON f.id_cliente=c.id_cliente
			JOIN Detalles_Facturas df ON df.id_factura=f.id_factura
		WHERE 'fecha_baja' is not null
		GROUP BY f.id_factura,convert(varchar,f.fecha_factura,3),c.ape_cliente,c.nom_cliente
go
CREATE PROCEDURE PA_CONSULTA_PEDIDO_FILTRO
@nroPedido int=null,
@fechaDesde date=null,
@fechaHasta date=null,
@Proveedor varchar(150)=null,
@tipo int=null,
@activo varchar(1)
AS
	 if @tipo=0 --filtro por numero Pedido

	select p.id_pedido, convert(varchar,
			fecha_pedido,3) fecha, 
			nom_proveedor, 
			sum(precio_compra*cantidad)Total, 
			'fecha_baja' fechaB
	from Pedidos p  join Detalles_Pedidos dp  on dp.id_pedido=p.id_pedido
      join Proveedores pr on p.id_proveedor=pr.id_proveedor
	WHERE  ((@fechaDesde is null and @fechaHasta is  null) OR (fecha_pedido between @fechaDesde and @fechaHasta))
		 AND(@nroPedido is null OR p.id_pedido=@nroPedido)
		 AND (@activo is null OR (@activo = 'S') OR (@activo = 'N'))--(@activo = 'N' and 'fecha_baja' IS  NULL))
		 GROUP BY p.id_pedido, convert(varchar,fecha_pedido,3), nom_proveedor       
     
	 if @tipo=1 --filtro por Proveedor
		 select p.id_pedido, convert(varchar,
			fecha_pedido,3) fecha, 
			nom_proveedor, 
			sum(precio_compra*cantidad)Total, 
			'fecha_baja' fechaB
	     from Pedidos p  join Detalles_Pedidos dp  on dp.id_pedido=p.id_pedido
         join Proveedores pr on p.id_proveedor=pr.id_proveedor
		 WHERE 
		 ((@fechaDesde is null and @fechaHasta is  null) OR (fecha_pedido between @fechaDesde and @fechaHasta))
		 AND(@Proveedor is null OR (nom_proveedor like '%' + @Proveedor + '%'))
		 AND (@activo is null OR (@activo = 'S') OR (@activo = 'N'))--(@activo = 'N' and 'fecha_baja' IS  NULL))
		 GROUP BY p.id_pedido, convert(varchar,fecha_pedido,3), nom_proveedor   

    if @tipo=2 --filtro por bajas
	     select p.id_pedido, convert(varchar,
			fecha_pedido,3) fecha, 
			nom_proveedor, 
			sum(precio_compra*cantidad)Total , 
			'fecha_baja' fechaB
	     from Pedidos p  join Detalles_Pedidos dp  on dp.id_pedido=p.id_pedido
         join Proveedores pr on p.id_proveedor=pr.id_proveedor
		 WHERE 'fecha_baja' is not null
	    GROUP BY p.id_pedido, convert(varchar,fecha_pedido,3), nom_proveedor   
go