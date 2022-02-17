--Procemiento Listar
create procedure DepartamentoListar
as
begin
 select IdDepartamento as Id, Nombre as Nombre, Descripcion as Descripcion, Estado as Estado
 from Departamento 
end

--Procedimiento Buscar
create procedure DepartamentoBuscar
@Valor varchar(50)
as
begin
 select IdDepartamento, Nombre, Descripcion, Estado from Departamento
 where Nombre like '%' + @Valor + '%' 
end

--Procedimiento Insertar
create procedure DepartamentoInsertar
@Nombre varchar(100),
@Descripcion varchar(200)
as
begin
 insert into Departamento (Nombre, Descripcion) values (@Nombre, @Descripcion)
end

--Procedimiento Actualizar
create procedure DepartamentoActualizar
@IdDepartamento int,
@Nombre varchar(100),
@Descripcion varchar(200)
as
begin
 update Departamento set Nombre = @Nombre, Descripcion = @Descripcion
 where IdDepartamento = @IdDepartamento
end

--Procedimiento Activar
create procedure DepartamentoActivar
@IdDepartamento int
as
begin
 update Departamento set Estado = 1
 where IdDepartamento = @IdDepartamento
end

--Procedimiento Desactivar
create procedure DepartamentoDesactivar
@IdDepartamento int
as 
begin
 update Departamento set Estado = 0
 where IdDepartamento = @IdDepartamento
end

--Procedimiento Exitir
create procedure DepartamentoExistir
@Valor varchar(100),
@Existe bit output
as
 if exists(select Nombre from Departamento where Nombre like '%' + @Valor + '%')
begin
 set @Existe = 1
end
 else
begin
 set @Existe = 0
end

--Procedimiento Seleccionar
create procedure DepartamentoSeleccionar
as
begin
 select IdDepartamento, Nombre from Departamento
 where Estado = 1
end