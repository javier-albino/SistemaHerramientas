--Datos de Rol
insert into Rol (Nombre) values ('Administrador');
insert into Rol (Nombre) values ('Empleado');
insert into Rol (Nombre) values ('Usuario');

--Procedimiento Listar
create procedure RolListar
as
begin
 select IdRol, Nombre, Estado from Rol
end

--Procedimiento Seleccionar
create procedure RolSeleccionar
as
begin
 select IdRol, Nombre from Rol
 where Estado = 1
end