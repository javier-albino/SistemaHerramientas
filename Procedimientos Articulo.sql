--Procedimiento Listar
create procedure ArticuloListar
as
begin
 select Art.IdArticulo as Id, Mc.Nombre as Marca, Art.Nombre as Articulo, Art.Modelo as Modelo,
 Art.Cantidad as Stock,(Art.Cantidad - ISNULL((select COUNT(IdArticulo)as Cantidad from EntregaArticulo
 where IdArticulo = Art.IdArticulo group by IdArticulo),0))as Disponibles,
 Art.PrecioCompra as Precio, Art.FechaCompra as Fecha, Art.CodigoBarras as Codigo,
 Art.Estado as Estado from Articulo Art
 inner join Marca Mc on Art.IdMarca = Mc.IdMarca
end

--Procedimiento Buscar
create procedure ArticuloBuscar
@Valor varchar(50)
as
begin
 select Art.IdArticulo as Id, Mc.Nombre as Marca, Art.Nombre as Articulo, Art.Modelo as Modelo,
 Art.Cantidad as Stock,(Art.Cantidad - ISNULL((select COUNT(IdArticulo)as Cantidad from EntregaArticulo
 where IdArticulo = Art.IdArticulo group by IdArticulo),0))as Disponibles,
 Art.PrecioCompra as Precio, Art.FechaCompra as Fecha, Art.CodigoBarras as Codigo,
 Art.Estado as Estado from Articulo Art
 inner join Marca Mc on Art.IdMarca = Mc.IdMarca
 where Art.Nombre like '%' + @Valor + '%' or Mc.Nombre like '%' + @Valor + '%'
end

--Procedimiento Insertar
create procedure ArticuloInsertar
@Nombre varchar(100),
@Modelo varchar(100),
@Cantidad int,
@PrecioCompra int,
@FechaCompra date,
@CodigoBarras varchar(100),
@IdMarca int
as
begin
 insert into Articulo (Nombre, Modelo, Cantidad, PrecioCompra, FechaCompra, CodigoBarras, IdMarca)
 values (@Nombre, @Modelo, @Cantidad, @PrecioCompra, @FechaCompra, @CodigoBarras, @IdMarca)
end

--Procedimiento Actualizar
create procedure ArticuloActualizar
@IdArticulo int,
@Nombre varchar(100),
@Modelo varchar(100),
@Cantidad int,
@PrecioCompra int,
@FechaCompra date,
@CodigoBarras varchar(100),
@IdMarca int
as
begin
 update Articulo set Nombre = @Nombre, Modelo = @Modelo, Cantidad = @Cantidad,
 PrecioCompra = @PrecioCompra, FechaCompra = @FechaCompra, CodigoBarras = @CodigoBarras, IdMarca = @IdMarca
 where IdArticulo = @IdArticulo
end

--Procedimiento Activar
create procedure ArticuloActivar
@IdArticulo int
as
begin
 update Articulo set Estado = 1
 where IdArticulo = @IdArticulo
end

--Procedimiento Desactivar
create procedure ArticuloDesactivar
@IdArticulo int
as
begin
 update Articulo set Estado = 0
 where IdArticulo = @IdArticulo
end

--Procedimiento Existir
create procedure ArticuloExistir
@Valor varchar(100),
@Existe bit output
as
if exists(select CodigoBarras from Articulo where CodigoBarras like '%' + @Valor + '%')
begin
 set @Existe = 1
end
 else
begin
 set @Existe = 0
end

--Procedimiento Seleccionar Nombre
create procedure ArticuloNombreSeleccionar
as
begin
 select IdArticulo, Nombre from Articulo
 where Estado = 1
end



