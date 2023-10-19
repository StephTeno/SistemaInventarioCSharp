create database ESInventario

use ESInventario

create table TipoUsuario(
IdTipoUser int identity(1,1) primary key not null,
Nombre nvarchar(15) not null
)

create table Usuario(
Username nvarchar(10) primary key not null,
Tipo int foreign key references TipoUsuario(IdTipoUser) not null,
Contrasena nvarchar(20) not null
)

create table Departamento(
IdDept char(5) primary key not null,
Nombre nvarchar(25) not null
)

Create table Municipio(
IdMun char(6) primary key not null,
Dept char(5) foreign key references Departamento(IdDept) not null
)

create table Clientes(
IdCliente int identity(1,1) primary key not null,
PNomb nvarchar(25) not null,
SNomb nvarchar(25),
PApe nvarchar(25) not null,
SApe nvarchar(25),
IdLocal char(6) foreign key references Municipio(IdMun) not null,
Cedula char(16) not null,
Celular char(8) check(Celular like '[2|5|7|8][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
Estado bit default 1,
Correo nvarchar(45)
)

create table Proveedores(
RUC char(14) primary key not null,
Empresa nvarchar(50) not null,
Representante nvarchar(60) not null,
CargoPro nvarchar(60) not null,
IdLocal char(6) foreign key references Municipio(IdMun) not null,
Correo nvarchar(45),
Telefono char(8) check(Telefono like '[2|5|7|8][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),
)

Create table CategoriaProd(
IdCat int identity(1,1) primary key not null,
Nombre nvarchar(25) not null
)

create table Productos(
IdProd char(5) primary key not null,
NombreProd nvarchar(50) not null,
Categoria int foreign key references CategoriaProd(IdCat)not null,
Especificaciones nvarchar(50) not null,
CUnitario numeric(6,2) not null,
PreVenta numeric(6,2) not null
)

create table Entradas(
IdEntrada int identity(1,1) primary key not null,
Proveedor char(14) foreign key references Proveedores(RUC) not null,
Producto char(5) foreign key references Productos(IdProd) not null,
Recibo char(10) not null,
PreCompra numeric(6,2) not null,
FechaCompra date not null,
TotalCompra numeric(6,2) not null
)

create table DetalleEntrada(
IdEntrada int foreign key references Entradas(IdEntrada) not null,
IdProd char(5) foreign key references Productos(IdProd) not null,
Cantidad int not null,
SubTotal numeric(6,2) not null,
primary key(IdEntrada, IdProd)
)

Create table Facturas(
IdFactura char(10) primary key not null,
IdCliente int foreign key references Clientes(IdCliente) not null,
IdEmpleado nvarchar(10) foreign key references Usuario(Username) not null,
Fecha date not null,
CantTotal int not null,
SubTotal numeric(6,2) not null,
IVA numeric(4,2) not null,
Total numeric(6,2) not null
)

Create table DetalleFactura(
IdFactura char(10) foreign key references Facturas(IdFactura) not null,
IdProd char(5) foreign key references Productos(IdProd) not null,
Cantidad int not null,
SubTotal numeric(6,2) not null,
primary key(IdFactura, IdProd)
)

create table Salidas(
IdSalida int identity(1,1) primary key not null,
IdProd char(5) foreign key references Productos(IdProd) not null,
Cantidad int not null,
Total int not null,
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
