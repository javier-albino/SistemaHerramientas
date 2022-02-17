--Procedimiento Listar
create procedure MarcaListar
as
begin
 select IdMarca as Id, Nombre, Descripcion, Estado from Marca
end

--Procedimiento Buscar
create procedure MarcaBuscar
@Valor varchar(50)
as
begin
 select IdMarca, Nombre, Descripcion, Estado from Marca
 where Nombre like '%' + @Valor + '%' 
end

--Procedimiento Insertar
create procedure MarcaInsertar
@Nombre varchar(100),
@Descripcion varchar(200)
as
begin
 insert into Marca (Nombre, Descripcion) values (@Nombre, @Descripcion)
end

--Procedimiento Actualizar
create procedure MarcaActualizar
@IdMarca int,
@Nombre varchar(100),
@Descripcion varchar(200)
as
begin
 update Marca set Nombre =  @Nombre, Descripcion = @Descripcion
 where IdMarca = @IdMarca
end

--Procedimiento Activar
create procedure MarcaActivar
@IdMarca int
as
begin
 update Marca set Estado = 1
 where IdMarca = @IdMarca
end

--Procedimiento Desactivar
create procedure MarcaDesactivar
@IdMarca int
as
begin
 update Marca set Estado = 0
 where IdMarca = @IdMarca
end

--Procedimiento Existir
create procedure MarcaExistir
@Valor varchar(100),
@Existe bit output
as
 if exists(select Nombre from Marca where Nombre like '%' + @Valor + '%')
begin
 set @Existe = 1
end
 else
begin
 set @Existe = 0
end

--Procedimiento Seleccionar
create procedure MarcaSeleccionar
as
begin
 select IdMarca, Nombre from Marca
 where Estado = 1
end