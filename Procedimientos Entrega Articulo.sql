--Procedimiento Listar
create procedure EntregaArticuloListar
as
begin
 select Ent.IdEntrega as Id, Art.Nombre as Articulo, Art.Modelo as Modelo, 
 Emp.Nombres + ' ' + Emp.Apellidos as Empleado, Ent.Numserie as Serie, Ent.FechaEntrega as Entrega,
 Ent.Condicion as Condicion, Usu.Nombres + ' ' + Usu.Apellidos as Responsable, 
 Ent.Estado as Estado from EntregaArticulo Ent
 inner join Articulo Art on Ent.IdArticulo = Art.IdArticulo
 inner join Empleado Emp on Ent.IdEmpleado = Emp.IdEmpleado
 inner join Usuario Usu on Ent.IdUsuario = Usu.IdUsuario
end

--Procedimiento Buscar
create procedure EntregaArticuloBuscar
@Valor varchar(100)
as
begin
 select Ent.IdEntrega as Id, Art.Nombre as Articulo, Art.Modelo as Modelo, 
 Emp.Nombres + ' ' + Emp.Apellidos as Empleado, Ent.Numserie as Serie, Ent.FechaEntrega as Entrega,
 Ent.Condicion as Condicion, Usu.Nombres + ' ' + Usu.Apellidos as Responsable, 
 Ent.Estado as Estado from EntregaArticulo Ent
 inner join Articulo Art on Ent.IdArticulo = Art.IdArticulo
 inner join Empleado Emp on Ent.IdEmpleado = Emp.IdEmpleado
 inner join Usuario Usu on Ent.IdUsuario = Usu.IdUsuario
 where Art.Nombre like '%' + @Valor + '%' or Emp.Nombres like '%' + @Valor + '%'
end

--Procedimiento Insertar
create procedure EntregaArticuloInsertar
@NumSerie varchar(200),
@FechaEntrega date,
@Condicion varchar(100),
@IdArticulo int,
@IdEmpleado int,
@IdUsuario int
as
begin
 insert into EntregaArticulo (NumSerie, Condicion, FechaEntrega, IdArticulo, IdEmpleado, IdUsuario)
 values (@NumSerie, @Condicion, @FechaEntrega,  @IdArticulo, @IdEmpleado, @IdUsuario)
end

--Procedimiento Actualizar
create procedure EntregaArticuloActualizar
@IdEntrega int,
@NumSerie varchar(200),
@FechaEntrega date,
@Condicion varchar(100),
@IdArticulo int,
@IdEmpleado int,
@IdUsuario int
as
begin
 update EntregaArticulo set Numserie = @NumSerie, Condicion = @Condicion,
 FechaEntrega = @FechaEntrega, IdArticulo = @IdArticulo, IdEmpleado = @IdEmpleado,
 IdUsuario = @IdUsuario where IdEntrega = @IdEntrega
end

--Procedimiento Activar
create procedure EntregaArticuloActivar
@IdEntrega int
as
begin
 update EntregaArticulo set Estado = 1
 where IdEntrega = @IdEntrega
end

--Procedimiento Desactivar
create procedure EntregaArticuloDesactivar
@IdEntrega int
as
begin
 update EntregaArticulo set Estado = 0
 where IdEntrega = @IdEntrega
end

--Procedimiento Existir
create procedure EntregaArticuloExistir
@Valor varchar(100),
@Existe bit output
as
 if exists(select NumSerie from EntregaArticulo where NumSerie = ltrim(rtrim(@Valor)))
begin
 set @Existe = 1
end
 else
begin
 set @Existe = 0
end

--Procedimiento Ficha Entregas
create procedure EntregaArticuloFicha
@Valor varchar(100)
as
begin
 select Ent.IdEntrega as Id, Art.Nombre as Articulo, Art.Modelo as Modelo, Mc.Nombre as Marca,
 Emp.Nombres + ' ' + Emp.Apellidos as Empleado, Ent.Numserie as Serie, Ent.FechaEntrega as Entrega,
 Ent.Condicion as Condicion, Usu.Nombres + ' ' + Usu.Apellidos as Responsable, 
 Ent.Estado as Estado from EntregaArticulo Ent
 inner join Articulo Art on Ent.IdArticulo = Art.IdArticulo
 inner join Empleado Emp on Ent.IdEmpleado = Emp.IdEmpleado
 inner join Usuario Usu on Ent.IdUsuario = Usu.IdUsuario
 inner join Marca Mc on Mc.IdMarca = Mc.IdMarca
 where Ent.IdEmpleado = Emp.IdEmpleado and Ent.NumSerie like '%' + @Valor + '%'
end