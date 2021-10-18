# Farmacia
Trabajo Integrador LCII

Sistema de Venta de una Farmacéutica

Una cadena farmacéutica necesita llevar la información de su operatoria diaria de ventas al público y contar con reportes adecuados para un funcionamiento eficaz. La farmacéutica tiene distintas sucursales dispersas a lo largo del país, las cuales son abastecidas con suministros a través de empresas de logística y distribución ajenas al sistema. Cuando se entregan suministros en alguna sucursal por parte de la empresa de logística se registra la cantidad de cada uno de ellos identificados por su código de barras, además de quién realizó dicha entrega por parte de la empresa y el responsable (empleado de la farmacéutica) que recibió los suministros.

La farmacéutica clasifica a los suministros en base a si son de venta libre o requieren una autorización o receta para poder ser entregados a los clientes. Los suministros pueden ser de diversos tipos como por ejemplo medicamentos, artículos de limpieza, higiene personal, estética, etc.

Cuando un cliente va a realizar compras en alguna sucursal, puede llevar algunos suministros que tengan cobertura por obra social (independientemente que sean de venta libre o no) por lo que deberá presentar la receta provista por el médico. Cada uno de esos productos puede o no tener algún descuento para dicha obra social en ese momento para la localidad donde se encuentra. Todos los meses las obras sociales envían la información de los descuentos que se deben ofrecer para cada tipo de producto para cada localidad del país. Las obras sociales proveen un sistema externo de validación de afiliados, por lo que la farmacia debe ingresar los datos del cliente y el o los suministros que se encuentren en la receta además del nombre del médico y su matrícula. Una vez confirmados esos datos, estos sistemas externos devuelven un código de autorización a la farmacia que indica si la solicitud está aprobada o rechazada.

A pesar de que este sistema no forma parte de la farmacéutica, se lleva un respaldo de la información ingresada en el portal de solicitud de coberturas por cuestiones de auditoría.

Todos estos descuentos realizados en suministros son facturados a la obra social que corresponda, por lo que se realiza un reporte con el listado de todos los tipos de suministros y las respectivas cantidades entregadas a los clientes para recibir el reembolso de la obra social. Una vez que este lote de suministros con descuentos ya fue reembolsado por la obra social se los marca para no ser vueltos a listar. Esto es así porque no necesariamente el listado para reembolso incluye suministros que hayan sido entregados en el mes que se está facturando.
