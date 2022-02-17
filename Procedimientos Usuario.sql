--Procedimiento Listar
create procedure UsuarioListar
as
begin
 select Usu.IdUsuario as Id, Usu.Rut as Rut, Usu.Nombres as Nombres, Usu.Apellidos as Apellidos,
 Rl.Nombre as Rol,Telefono as Telefono, Usu.Email as Email, Usu.Estado as Estado from Usuario Usu
 inner join Rol Rl on Usu.IdRol = Rl.IdRol
end

--Procedimiento Buscar
create procedure UsuarioBuscar
@Valor varchar(100)
as
begin
 select Usu.IdUsuario as Id, Usu.Rut as Rut, Usu.Nombres as Nombres, Usu.Apellidos as Apellidos,
 Rl.Nombre as Rol,Telefono as Telefono, Usu.Email as Email, Usu.Estado as Estado from Usuario Usu
 inner join Rol Rl on Usu.IdRol = Rl.IdRol
 where Usu.Rut like '%' + @Valor + '%' or Usu.Nombres like '%' + @Valor + '%'
end

--Procedimiento Insertar
create procedure UsuarioInsertar
@Rut varchar(100),
@Nombres varchar(200),
@Apellidos varchar(200),
@Telefono varchar(100),
@Email varchar(200),
@Clave varchar(200),
@IdRol int
as
begin
 insert into Usuario (Rut, Nombres, Apellidos, Telefono, Email, Clave, IdRol)
 values (@Rut, @Nombres, @Apellidos, @Telefono, @Email, HASHBYTES('SHA2_256',@Clave), @IdRol)
end

--Procedimiento Actualizar
create procedure UsuarioActualizar
@IdUsusario int,
@Rut varchar(100),
@Nombres varchar(200),
@Apellidos varchar(200),
@Telefono varchar(100),
@Email varchar(200),
@Clave varchar(200),
@IdRol int
as
begin
 if @Clave<>''
 update Usuario set Rut = @Rut, Nombres = @Nombres, Apellidos = @Apellidos, Telefono = @Telefono,
 Email = @Email, Clave = HASHBYTES('SHA2_256',@Clave), IdRol = @IdRol
 where IdUsuario = @IdUsusario
 else
 update Usuario set Rut = @Rut, Nombres = @Nombres, Apellidos = @Apellidos, Telefono = @Telefono,
 Email = @Email, IdRol = @IdRol
 where IdUsuario = @IdUsusario
end

--Procedimiento Activar
create procedure UsuarioActivar
@IdUsuario int
as
begin
 update Usuario set Estado = 1
 where IdUsuario = @IdUsuario
end

--Procedimiento Desactivar
create procedure UsuarioDesactivar
@IdUsuario int
as
begin
 update Usuario set Estado = 0
 where IdUsuario = @IdUsuario
end

--Procedimiento Existir
create procedure UsuarioExistir
@Valor varchar(100),
@Existe bit output
as
 if exists(select Rut from Usuario where Rut = ltrim(rtrim(@Valor)))
begin
 set @Existe = 1
end
 else
begin
 set @Existe = 0
end

--Procedimiento Login
create procedure UsuarioLogin
@Email varchar(200),
@Clave varchar(200)
as
begin
 select Usu.IdUsuario, Rl.Nombre as Rol, Usu.Nombres , 
 Usu.Estado, Usu.IdRol from Usuario Usu inner join Rol Rl on Usu.IdRol = Rl.IdRol
 where Usu.Email = @Email and Usu.Clave = HASHBYTES('SHA2_256',@Clave)
end

--Procedimiento Seleccionar
create procedure UsuarioSeleccionar
as
begin
 select IdUsuario, Nombres + ' ' + Apellidos as NombreCompleto from Usuario
 where Estado = 1
end