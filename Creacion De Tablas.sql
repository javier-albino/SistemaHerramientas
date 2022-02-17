--Tabla Marca 
create table Marca
(IdMarca int identity(1,1), Nombre varchar(100) not null, Descripcion varchar(200) null, Estado bit default(1),
constraint pk_Marca primary key(IdMarca))

--Tabla Articulo
create table Articulo
(IdArticulo int identity(1,1), Nombre varchar(100) not null, Modelo varchar(100) not null, 
Cantidad int not null, PrecioCompra int not null, FechaCompra date not null, CodigoBarras varchar(100) null,
Estado bit default(1), IdMarca int not null, constraint pk_Articulo primary key(IdArticulo),
constraint fk_MarcaArti foreign key(IdMarca) references Marca(IdMarca))

--Tabla Departamento
create table Departamento 
(IdDepartamento int identity(1,1), Nombre varchar(100) not null, Descripcion varchar(200) null, Estado bit default(1),
constraint pk_Departamento primary key(IdDepartamento))

--Tabla Puesto
create table Puesto
(IdPuesto int identity(1,1), Nombre varchar(100) not null, Descripcion varchar(200) null, Estado bit default(1),
constraint pk_Puesto primary key(IdPuesto))

--Tabla Empleado
create table Empleado
(IdEmpleado int identity(1,1), Rut varchar(30) not null, Nombres varchar(200) not null,
Apellidos varchar(200), Estado bit default(1),
IdDepartamento int not null, IdPuesto int not null, constraint pk_Empleado primary key(IdEmpleado),
constraint fk_DepEmp foreign key(IdDepartamento) references Departamento(IdDepartamento),
constraint fk_PueEmp foreign key(IdPuesto) references Puesto(IdPuesto))

--Tabla Rol
create table Rol
(IdRol int identity(1,1), Nombre varchar(200) not null, Estado bit default(1),
constraint pk_Rol primary key(IdRol))

--Tabla Usuario
create table Usuario
(IdUsuario int identity(1,1), Rut varchar(100), Nombres varchar(200) not null, Apellidos varchar(200) not null,
Telefono varchar(100) null, Email varchar(200) not null, Clave varbinary(MAX) not null, Estado bit default(1),
IdRol int not null, constraint pk_Usuario primary key(IdUsuario),
constraint fk_RlUsu foreign key(IdRol) references Rol(IdRol))

--Tabla Entrega Articulo
create table EntregaArticulo
(IdEntrega int identity(1,1), NumSerie varchar(200) not null, Condicion varchar(100) not null, 
FechaEntrega date not null, Estado bit default(1),
IdArticulo int not null,IdEmpleado int not null, IdUsuario int not null,
constraint pk_Entrega primary key(IdEntrega),
constraint fk_EntArti foreign key(IdArticulo) references Articulo(IdArticulo),
constraint fk_EntEmp foreign key(IdEmpleado) references Empleado(IdEmpleado),
constraint fk_EntUsu foreign key(IdUsuario) references Usuario(IdUsuario))

--Tabla Devolucion Articulo
create table DevolucionArticulo
(IdDevolucion int identity(1,1), NumSerie varchar(200) not null,
MotivoDevolucion varchar(100) not null, FechaDevolucion date not null, Estado bit default(1),
IdArticulo int not null, IdEmpleado int not null, IdUsuario int not null, 
constraint pk_Devolucion primary key(IdDevolucion),
constraint fk_DevArti foreign key(IdArticulo) references Articulo(IdArticulo),
constraint fk_DevEmp foreign key(IdEmpleado) references Empleado(IdEmpleado),
constraint fk_DevUsu foreign key(IdUsuario)references Usuario(IdUsuario))
