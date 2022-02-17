--Procedimiento Listar
create procedure DevolucionArticuloListar
as
begin
 select Dev.IdDevolucion as Id, Art.Nombre as Articulo, Art.Modelo as Modelo, 
 Emp.Nombres + ' ' + Emp.Apellidos as Empleado, Dev.NumSerie as Serie, Dev.FechaDevolucion as Devolucion,
 Dev.MotivoDevolucion as Motivo, Usu.Nombres + ' ' + Usu.Apellidos as Responsable,
 Dev.Estado as Estado from DevolucionArticulo Dev
 inner join Articulo Art on Dev.IdArticulo = Art.IdArticulo
 inner join Empleado Emp on Dev.IdEmpleado = Emp.IdEmpleado
 inner join Usuario Usu on Dev.IdUsuario = Usu.IdUsuario
end

--Procedimiento Buscar
create procedure DevolucionArticuloBuscar
@Valor varchar(100)
as
begin
 select Dev.IdDevolucion as Id, Art.Nombre as Articulo, Art.Modelo as Modelo, 
 Emp.Nombres + ' ' + Emp.Apellidos as Empleado, Dev.NumSerie as Serie, Dev.FechaDevolucion as Devolucion,
 Dev.MotivoDevolucion as Motivo, Usu.Nombres + ' ' + Usu.Apellidos as Responsable, 
 Dev.Estado as Estado from DevolucionArticulo Dev
 inner join Articulo Art on Dev.IdArticulo = Art.IdArticulo
 inner join Empleado Emp on Dev.IdEmpleado = Emp.IdEmpleado
 inner join Usuario Usu on Dev.IdUsuario = Usu.IdUsuario
 where Art.Nombre like '%' + @Valor + '%' or Emp.Nombres like '%' + @Valor + '%'
end

--Procedimiento Insertar
create procedure DevolucionArticuloInsertar
@NumSerie varchar(200),
@FechaDevolucion date,
@MotivoDevolucion varchar(100),
@IdArticulo int,
@IdEmpleado int,
@IdUsuario int
as
begin
 insert into DevolucionArticulo (NumSerie, FechaDevolucion, MotivoDevolucion, IdArticulo, IdEmpleado, IdUsuario)
 values (@NumSerie, @FechaDevolucion, @MotivoDevolucion, @IdArticulo, @IdEmpleado, @IdUsuario)
end

--Procedimiento Actualizar
create procedure DevolucionArticuloActualizar
@IdDevolucion int,
@NumSerie varchar(200),
@FechaDevolucion date,
@MotivoDevolucion varchar(100),
@IdArticulo int,
@IdEmpleado int,
@IdUsuario int
as
begin
 update DevolucionArticulo set NumSerie = @NumSerie, FechaDevolucion = @FechaDevolucion,
 MotivoDevolucion = @MotivoDevolucion, IdArticulo = @IdArticulo, IdEmpleado = @IdEmpleado,
 IdUsuario = @IdUsuario where IdDevolucion = @IdDevolucion
end

--Procedimiento Activar
create procedure DevolucionArticuloActivar
@IdDevolucion int
as
begin
 update DevolucionArticulo set Estado = 1
 where IdDevolucion = @IdDevolucion
end

--Procedimiento Desactivar
create procedure DevolucionArticuloDesactivar
@IdDevolucion int
as
begin
 update DevolucionArticulo set Estado = 0
 where IdDevolucion = @IdDevolucion
end

--Procedimiento Existir
create procedure DevolucionArticuloExistir
@Valor varchar(100),
@Existe bit output
as
 if exists(select NumSerie from DevolucionArticulo where NumSerie = ltrim(rtrim(@Valor)))
begin
 set @Existe = 1
end
 else
begin
 set @Existe = 0
end

--Procedimiento Ficha Devoluciones
create procedure DevolucionArticuloFicha
@Valor varchar(100)
as
begin
 select Dev.IdDevolucion as Id, Art.Nombre as Articulo, Art.Modelo as Modelo, Mc.Nombre as Marca,
 Emp.Nombres + ' ' + Emp.Apellidos as Empleado, Dev.NumSerie as Serie, Dev.FechaDevolucion as Devolucion,
 Dev.MotivoDevolucion as Motivo, Usu.Nombres + ' ' + Usu.Apellidos as Responsable, 
 Dev.Estado as Estado from DevolucionArticulo Dev
 inner join Articulo Art on Dev.IdArticulo = Art.IdArticulo
 inner join Empleado Emp on Dev.IdEmpleado = Emp.IdEmpleado
 inner join Usuario Usu on Dev.IdUsuario = Usu.IdUsuario
 inner join Marca Mc on Mc.IdMarca = Mc.IdMarca
 where Dev.IdEmpleado = Emp.IdEmpleado and Dev.NumSerie like '%' + @Valor + '&'
end