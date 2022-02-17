--Procedimiento Listar
create procedure PuestoListar
as
begin
 select IdPuesto as Id, Nombre, Descripcion, Estado from Puesto 
end

--Procemiento Buscar
create procedure PuestoBuscar
@Valor varchar(50)
as
begin
 select IdPuesto, Nombre, Descripcion, Estado from Puesto
 where Nombre like '%' + @Valor + '%'
end

--Procedimiento Insertar
create procedure PuestoInsertar
@Nombre varchar(100),
@Descripcion varchar(200)
as
begin
 insert into Puesto (Nombre, Descripcion) values (@Nombre, @Descripcion)
end

--Procedimiento Actualizar
create procedure PuestoActualizar
@IdPuesto int,
@Nombre varchar(100),
@Descripcion varchar(200)
as
begin
  update Puesto set Nombre = @Nombre, Descripcion = @Descripcion
  where IdPuesto = @IdPuesto
end

--Procedimiento Activar
create procedure PuestoActivar
@IdPuesto int
as
begin
 update Puesto set Estado = 1
 where IdPuesto = @IdPuesto
end

--Procedimiento Desactivar
create procedure PuestoDesactivar
@IdPuesto int
as
begin
 update Puesto set Estado = 0
 where IdPuesto = @IdPuesto
end

--Procedimiento Existe
create procedure PuestoExistir
@Valor varchar(100),
@Existe bit output
as
 if exists(select Nombre from Puesto where Nombre like '%' + @Valor + '%')
begin
 set @Existe = 1
end
 else
begin
 set @Existe = 0
end

--Procedimiento Seleccionar
create procedure PuestoSeleccionar
as
begin
 select IdPuesto, Nombre from Puesto
 where Estado = 1
end