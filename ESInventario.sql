create database ESInventario

use ESInventario

create table Localizacion(
IdLocal int primary key not null,
Departamento nvarchar(45) not null,
Municipio nvarchar(45) not null,
)

create table Clientes(
IdCliente int identity(1,1) primary key not null,
Nombres nvarchar(60) not null,
Apellidos nvarchar(60) not null,
IdLocal int foreign key references Localizacion(IdLocal) not null,
Cedula char(16) not null,
Celular char(8) check(Celular like '[2|5|7|8][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
Estado nvarchar(20),
Correo nvarchar(45)
)

create table Proveedores(
IdProveedor int identity(1,1) primary key not null,
NombrePro nvarchar(60) not null,
CargoPro nvarchar(60) not null,
Empresa nvarchar(50) not null,
IdLocal int foreign key references Localizacion(IdLocal) not null,
Correo nvarchar(45),
CelularP char(8) check(CelularP like '[2|5|7|8][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
RUC nvarchar(50)
)

Create table CategoriaProd(
IdCat int identity(1,1) primary key not null,
Nombre nvarchar(25) not null
)

create table Entradas(
IdEntrada char(4) primary key not null,
IdProveedor int foreign key references Proveedores(IdProveedor) not null,
PreCompra numeric(6,2) not null,
FechaCompra date not null,
TotalCompra numeric(6,2) not null,
Tipo nvarchar(45) not null
)

create table Productos(
IdProd char(5) primary key not null,
NombreProd nvarchar(50) not null,
Categoria int foreign key references CategoriaProd(IdCat)not null,
Especificaciones nvarchar(50) not null,
CUnitario numeric(6,2) not null,
PreVenta numeric(6,2) not null
)

create table DetalleEntrada(
IdEntrada char(4) foreign key references Entradas(IdEntrada) not null,
IdProd char(5) foreign key references Productos(IdProd) not null,
Cantidad int not null,
primary key(IdEntrada, IdProd)
)

Create table Facturas(
IdFactura char(4) primary key not null,
IdCliente int foreign key references Clientes(IdCliente) not null,
Fecha date not null,
CantTotal int not null,
Total numeric(6,2) not null,
IVA numeric(4,2) not null
)

create table Salidas(
IdProd char(5) foreign key references Productos(IdProd) not null,
IdFactura char(4) foreign key references Facturas(IdFactura) not null,
Cantidad int not null,
Total int not null,
primary key (IdProd, IdFactura)
)

create table Inventario(
IDI int identity(1,1) primary key not null,
IdProd char(5) foreign key references Productos(IdProd) not null,
Existencia int not null,
CantIng int not null,
CantRet int not null,
TEgresos numeric(6,2) not null,
TIngresos numeric(6,2) not null
)

create table Usuario(
IdUsuario int identity(1,1) primary key not null,
Username nvarchar(50) not null,
Tipo nvarchar(25) not null,
Contrasena nvarchar(50) not null
)