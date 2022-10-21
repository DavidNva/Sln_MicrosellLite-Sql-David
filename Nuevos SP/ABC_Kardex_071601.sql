use POS_Microsell_Lite
go

create Proc Sp_Ver_sihay_Kardex
@Id_Prod char (20)
As
select COUNT (*) from KardexProducto
where
Id_Pro =@Id_Prod 
Go

--insert:
Create procedure sp_crear_kardex(
@idkardex char (11),
@idprod char (20),
@idprovee char (6),
@fechaCre date
)
as
insert into KardexProducto values (
@idkardex ,
@idprod ,
@idprovee,
@fechaCre ,
'Activo'
)
go

--detalle del Kardex:
Create procedure Sp_registrar_detalle_kardex(
@Id_Krdx char (11),
@Item int,
@Fecha_Krdx Date,
@Doc_Soport nchar (29),
@Det_Operacion varchar (50),
--entrada
@Cantidad_In Real,
@Precio_Unt_In Real,
@Costo_Total_In Real,
--salida
@Cantidad_Out Real,
@Precio_Unt_Out Real,
@Importe_Total_Out Real,
--saldo
@Cantidad_Saldo Real,
@Promedio Real,
@Costo_Total_Saldo Real
)
as
insert into Detalle_Kardex values (
@Id_Krdx ,
@Item ,
@Fecha_Krdx ,
@Doc_Soport ,
@Det_Operacion ,
--entrada
@Cantidad_In ,
@Precio_Unt_In ,
@Costo_Total_In ,
--salida
@Cantidad_Out ,
@Precio_Unt_Out ,
@Importe_Total_Out ,
--saldo
@Cantidad_Saldo ,
@Promedio ,
@Costo_Total_Saldo 
)
go


create View V_Kardex_Detalle
AS
SELECT 
KR.Id_krdx , KR.EstadoKrdx ,
x.IDPROVEE , x.NOMBRE , x.DIRECCION , x.CONTACTO , x.TELEFONO,
DT.Item, DT.Fecha_Krdx , DT.Doc_Soporte , DT.Det_Operacion , DT.Cantidad_In , DT.Precio_In , DT.Total_In ,
DT.Cantidad_Out , DT.Precio_Out , DT.Total_Out , DT.Cantidad_Saldo , DT.Promedio , DT.Costo_Total_Saldo ,
PR.Id_Pro , PR.Descripcion_Larga , PR.Stock_Actual 
FROM KardexProducto KR , Detalle_Kardex  DT , Productos PR , Proveedor x
WHERE 
KR.Id_krdx = DT.Id_krdx AND
KR.Id_Pro = PR.Id_Pro 
GO


Create Proc Sp_Buscador_DeKardex_Principal_yDetalle
@xvalor nvarchar (150) 
As
Select * from V_Kardex_Detalle
Where
Id_Pro = @xvalor  or
Doc_Soporte = @xvalor  or
Id_krdx = @xvalor  or
Descripcion_Larga  like @xvalor + '%' or Descripcion_Larga + '%' like @xvalor  + '%'
Order by Item Asc
Go

create Proc Sp_Ver_Kardex_delDia
@Fecha date
As
Select * from V_Kardex_Detalle
Where
DATEPART (YEAR,Fecha_Krdx)= DATEPART (YEAR,@Fecha) AND
DATEPART (DAYOFYEAR,Fecha_Krdx)= DATEPART (DAYOFYEAR,@Fecha)
Go













