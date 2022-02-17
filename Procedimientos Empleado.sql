--Procediniento Listar
create procedure EmpleadoListar
as
begin
 select Emp.IdEmpleado as Id, Dep.Nombre as Departamento, Pue.Nombre as Puesto, 
 Emp.Rut as Rut, Emp.Nombres as Nombres, Emp.Apellidos as Apellidos, Emp.Estado as Estado from Empleado Emp 
 inner join Puesto Pue on Emp.IdPuesto = Pue.IdPuesto
 inner join Departamento Dep on Emp.IdDepartamento = Dep.IdDepartamento
end

--Procedimiento Buscar
create procedure EmpleadoBuscar
@Valor varchar(100)
as
begin
 select Emp.IdEmpleado as Id, Dep.Nombre as Departamento, Pue.Nombre as Puesto, 
 Emp.Rut as Rut, Emp.Nombres as Nombres, Emp.Apellidos as Apellidos, Emp.Estado as Estado from Empleado Emp 
 inner join Puesto Pue on Emp.IdPuesto = Pue.IdPuesto
 inner join Departamento Dep on Emp.IdDepartamento = Dep.IdDepartamento
 where Emp.Rut like '%' + @Valor + '%' or Emp.Nombres like '%' + @Valor + '%'
end

--Procedimiento Insertar
create procedure EmpleadoInsertar
@Rut varchar(30),
@Nombres varchar(200),
@Apellidos varchar(200),
@IdDepartamento int,
@IdPuesto int
as
begin
 insert into Empleado (Rut, Nombres, Apellidos, IdDepartamento, IdPuesto)
 values (@Rut, @Nombres, @Apellidos, @IdDepartamento, @IdPuesto)
end

--Procedimiento Actualizar
create procedure EmpleadoActualizar
@IdEmpleado int,
@Rut varchar(30),
@Nombres varchar(200),
@Apellidos varchar(200),
@IdDepartamento int,
@IdPuesto int
as
begin
 update Empleado set Rut = @Rut, Nombres = @Nombres, Apellidos = @Apellidos,
 IdDepartamento = @IdDepartamento, IdPuesto = @IdPuesto
 where IdEmpleado = @IdEmpleado
end

--Procedimiento Activar
create procedure EmpleadoActivar
@IdEmpleado int
as
begin
 update Empleado set Estado = 1
 where IdEmpleado = @IdEmpleado
end

--Procedimiento Desactivar
create procedure EmpleadoDesactivar
@IdEmpleado int
as
begin
 update Empleado set Estado = 0
 where IdEmpleado = @IdEmpleado
end

--Procedimiento Existir
create procedure EmpleadoExistir
@Valor varchar(100),
@Existe bit output
as
 if exists(select Rut from Empleado where Rut = ltrim(rtrim(@Valor)))
begin
 set @Existe = 1
end
 else
begin
 set @Existe = 0
end

--Procedimiento Seleccionar 
create procedure EmpleadoSeleccionar
as
begin
 select IdEmpleado, Nombres + ' ' + Apellidos as NombreCompleto from Empleado
 where Estado = 1
end