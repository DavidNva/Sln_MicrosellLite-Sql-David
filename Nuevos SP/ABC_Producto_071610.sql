use POS_Microsell_Lite
go

--insert:
create procedure Sp_registrar_Producto (
@idpro char (20),
@idprove char (6),
@descripcion varchar (150),
@frank real,
@Pre_compraSol real,
@pre_CompraDolar real,
@StockActual real,
@idCat int,
@idMar int,
@Foto varchar (180),
@Pre_Venta_Menor real,
@Pre_Venta_Mayor real,
@Pre_Venta_Dolar real,
@UndMdida char (6),
@PesoUnit real,
@Utilidad real,
@TipoProd varchar (12),
@ValorporProd real
)
As
Insert into Productos values (
@idpro ,
@idprove ,
@descripcion ,
@frank ,
@Pre_compraSol ,
@pre_CompraDolar ,
@StockActual ,
@idCat ,
@idMar ,
@Foto ,
@Pre_Venta_Menor ,
@Pre_Venta_Mayor ,
@Pre_Venta_Dolar ,
@UndMdida ,
@PesoUnit ,
@Utilidad ,
@TipoProd ,
@ValorporProd ,
'Activo'
)
go


--update:
create procedure Sp_Editar_Producto (
@idpro char (20),
@idprove char (6),
@descripcion varchar (150),
@frank real,
@Pre_compraSol real,
@pre_CompraDolar real,
@idCat int,
@idMar int,
@Foto varchar (180),
@Pre_Venta_Menor real,
@Pre_Venta_Mayor real,
@Pre_Venta_Dolar real,
@UndMdida char (6),
@PesoUnit real,
@Utilidad real,
@TipoProd varchar (12)
)
As
Update Productos set
IDPROVEE=@idprove ,
Descripcion_Larga=@descripcion ,
Frank=@frank ,
Pre_CompraS=@Pre_compraSol ,
Pre_Compra$=@pre_CompraDolar ,
Id_Cat=@idCat ,
Id_Marca=@idMar ,
Foto=@Foto ,
Pre_vntaxMenor=@Pre_Venta_Menor ,
Pre_vntaxMayor=@pre_venta_Mayor,
Pre_Vntadolar =@Pre_Venta_Dolar ,
UndMedida=@UndMdida ,
PesoUnit =@PesoUnit ,
UtilidadUnit =@Utilidad ,
TipoProdcto=@TipoProd 
where
Id_Pro =@idpro 
go

--Unimos Las Tablas en Vistas:
Create view v_Productos_yDependientes
As
select 
p.Id_Pro , p.Descripcion_Larga , p.Frank , p.Pre_CompraS , p.Pre_Compra$ , p.Stock_Actual , p.Foto , p.Pre_vntaxMenor , p.Pre_vntaxMayor , p.Pre_Vntadolar ,
p.UndMedida , p.PesoUnit , p.UtilidadUnit , p.TipoProdcto , p.Valor_porCant , p.Estado_Pro ,
x.IDPROVEE , x.NOMBRE , x.DIRECCION, x.TELEFONO ,
c.Id_Cat , c.Categoria , m.Id_Marca , m.Marca 
from Productos p, Proveedor x, Categorias c, Marcas m
where
p.IDPROVEE =x.IDPROVEE and
p.Id_Cat = c.Id_Cat and
p.Id_Marca =m.Id_Marca 
go


--Todoslos productos:
create procedure sp_cargar_Todos_Productos
As
select * from v_Productos_yDependientes
where
Estado_Pro ='Activo'
order by Descripcion_Larga Asc
go

--Busar:
Create Procedure Sp_buscador_Productos(
@valor varchar (150)
)
As
Select * from v_Productos_yDependientes Where
Estado_Pro ='Activo' and
Id_Pro =@valor or
Marca =@valor or
Categoria =@valor or
Descripcion_Larga like '%' + @valor or
Descripcion_Larga like @valor + '%'
order by Descripcion_Larga Asc
go

--Eliminar:
Create Procedure Sp_Darbaja_Producto (
@idpro char (20)
)
as
update Productos set
Estado_Pro ='Eliminado'
where
Id_Pro =@idpro 
go

create procedure sp_Eliminar_Producto(
@idpro char (20)
)
As
Delete from Productos 
where
Id_Pro =@idpro 
go

--Para el Control de Inventario:
Create procedure sp_SumarStock (
@idpro char (20),
@stock real
)
as
update Productos set
Stock_Actual = Stock_Actual + @stock 
where
Id_Pro =@idpro 
go

Create procedure sp_Restar_Stock (
@idpro char (20),
@stock real
)
as
update Productos set
Stock_Actual = Stock_Actual - @stock 
where
Id_Pro =@idpro 
go

--Cuando hacemos el Ingreso de nuevos Productos..  Es Posible que el Precio de compra tenga variacioens.. y tenemos que hacer que
--el sistema actualice esos precios..de forma automatica:
Create procedure Sp_Actulizar_Precios_CompraVenta_Producto  
(
@Id_Pro char (20),
@Pre_CompraS real,
@Pre_vntaxMenor real,
@Utilidad real,
@ValorAlmacen Real
)
as
update  Productos   set 
Pre_CompraS =@Pre_CompraS ,
Pre_vntaxMenor =@Pre_vntaxMenor ,
UtilidadUnit =@Utilidad 
where Id_Pro =@Id_Pro 
go











