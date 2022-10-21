use POS_Microsell_Lite
go

--insert:
INSERT INTO Tipo_Doc values (1, 'Factura','F00','0000001','Activo')
INSERT INTO Tipo_Doc values (2, 'Boleta','B00','0000001','Activo')
INSERT INTO Tipo_Doc values (3, 'Nota Venta','NV0','0000001','Activo')
INSERT INTO Tipo_Doc values (4, 'Productos','P','00001','Activo')
INSERT INTO Tipo_Doc values (5, 'Proveedor','X','00001','Activo')
INSERT INTO Tipo_Doc values (6, 'Kardex','KRD','0000001','Activo')
go

------update tipo_doc
create proc Sp_Editar_Tipo_Doc
(
@idtipo int,
@documento nvarchar(50),
@serie nvarchar(3),
@numero nvarchar (7)
)
as
if not exists (select * from Tipo_Doc where Id_Tipo = @idtipo)
begin
print 'El Municipio no existe'
return
end
begin tran
update tipo_doc set 
Documento  = @documento ,
Serie = @serie ,
Numero = @numero   
where Id_Tipo = @idtipo    
if @@ERROR <> 0
begin
print @@error
rollback tran
return
end
commit tran
go

--especial para tipo de documento
create proc SP_Listar_Tipo_Doc
as
select * from Tipo_Doc 
where Estado_tiDoc='Activo'
go

create Proc Sp_Tipod_Doc_Spcial
As
Select * from Tipo_Doc 
Where Id_Tipo = '1' or Id_Tipo ='2' or Id_Tipo ='3'
order by Id_Tipo desc
Go

--Para los Correlativos:
Create Procedure Sp_Listado_Tipo
	@Id_Tipo as Int	
AS
	Select Serie + '-' + Numero as Nro from Tipo_Doc 
	Where Id_Tipo=@Id_Tipo
Go

exec Sp_Listado_Tipo 2;
go

----=============================================================
---- FUNCION QUE GENERA CODIGO DE DOCUMENTOS
----=============================================================
CREATE FUNCTION Auto_Genera_Doc(@Id_Tipo int)
Returns Char(7)
Begin 
	Declare @Nro as varchar(7)
	Select @Nro=RIGHT('0000000' + convert(varchar,Cast(Numero AS INT)+1),7)  From Tipo_Doc  
	Where Id_Tipo=@Id_tipo
	
	Return(@Nro)
End
Go

CREATE FUNCTION Auto_Genera_Prodcto(@Id_Tipo int)
Returns Char(5)
Begin 
	Declare @Nro as varchar(5)
	Select @Nro=RIGHT('00000' + convert(varchar,Cast(Numero AS INT)+1),5)  From Tipo_Doc  
	Where Id_Tipo=@Id_tipo
	
	Return(@Nro)
End
Go

------=============================================================
------ ACTUALIZA NUMERO CORRELATIVO DE DOCUMENTOS
------=============================================================
Create Procedure Sp_Actualiza_Tipo_Doc(
@Id_Tipo int
)
As

IF NOT EXISTS(SELECT * FROM TIPO_DOC
		WHERE Id_Tipo =@Id_Tipo)
	BEGIN		
		RETURN
	END

Begin
	Declare @NuevoNum char(7)
	Set @NuevoNum = dbo.Auto_Genera_Doc(@Id_Tipo)
End

BEGIN TRANSACTION

UPDATE TIPO_DOC SET	
	Numero = @NuevoNum
WHERE 
	Id_Tipo=@Id_Tipo
	
IF @@ERROR<>0
	BEGIN
		ROLLBACK TRAN
		RETURN
	END
COMMIT TRANSACTION
Go

------Actualiza correlativo de producto
Create Procedure Sp_Actualiza_Tipo_Prodcto(
@Id_Tipo int
)
As

IF NOT EXISTS(SELECT * FROM TIPO_DOC
		WHERE Id_Tipo =@Id_Tipo)
	BEGIN		
		RETURN
	END

Begin
	Declare @NuevoNum char(5)
	Set @NuevoNum = dbo.Auto_Genera_Prodcto(@Id_Tipo)
End

BEGIN TRANSACTION

UPDATE TIPO_DOC SET	
	Numero = @NuevoNum
WHERE 
	Id_Tipo=@Id_Tipo
	
IF @@ERROR<>0
	BEGIN
		ROLLBACK TRAN
		RETURN
	END
COMMIT TRANSACTION
Go