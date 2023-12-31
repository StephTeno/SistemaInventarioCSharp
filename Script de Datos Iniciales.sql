Use ESInventario

Insert into TipoUsuario Values('Administrador')
Insert into TipoUsuario Values('Bodeguero')
Insert into TipoUsuario Values('Cajero')

Select * from TipoUsuario

Insert into Usuario Values ('admin',1,'admin')
Insert into Usuario Values ('bodega',2,'bodega')
Insert into Usuario Values ('venta',3,'venta')

Select * from Usuario

Insert into Departamento Values ('NI-BO', 'Boaco')
Insert into Departamento Values ('NI-CA', 'Carazo')
Insert into Departamento Values ('NI-CI', 'Chinandega')
Insert into Departamento Values ('NI-CO','Chontales')
Insert into Departamento Values ('NI-CN', 'Costa Caribe Norte')
Insert into Departamento Values ('NI-CS', 'Costa Caribe Sur')
Insert into Departamento Values ('NI-ES', 'Estelí')
Insert into Departamento Values ('NI-GR', 'Granada')
Insert into Departamento Values ('NI-JI', 'Jinotega')
Insert into Departamento Values ('NI-LE', 'León')
Insert into Departamento Values ('NI-MD', 'Madriz')
Insert into Departamento Values ('NI-MN', 'Managua')
Insert into Departamento Values ('NI-MS', 'Masaya')
Insert into Departamento Values ('NI-MT', 'Matagalpa')
Insert into Departamento Values ('NI-NS', 'Nueva Segovia')
Insert into Departamento Values ('NI-SJ', 'Río San Jua')
Insert into Departamento Values ('NI-RI', 'Rivas')

Select * from Departamento

Insert into Municipio Values ('MN-MAN', 'NI-MN')
Insert into Municipio Values ('MS-NIN','NI-MS')

Select * from Municipio

Insert into CategoriaProd Values('Producto terminado')
Insert into CategoriaProd Values('Materia Prima')

Select * from CategoriaProd

Insert into Clientes Values ('Stephanie', 'Carolina', 'Tenorio', 'Orozco', 1, '001-190205-1004L', '75064049', 1, 'stephteno2005@gmail.com')
Insert into Clientes Values ('Axa', 'Carolina', 'Orozco', 'Jimenexz', 1, '001-161278-1720X', '82855247', 1, 'axitaorozco@gmail.com')
Insert into Clientes Values ('Fernando', 'Enrique', 'Tenorio', 'Orozco', 1, '001-120502-1960E', '72624037', 1, 'tenorioorozco@gmail.com')

Select * from Clientes

Insert into Proveedores Values ('J0310000002371', 'CASA PELLAS S. A.', 'Rigoberto Pérez', 'Ventas', 1, 'ventas@casapellas.com.ni', '73046283')
Insert into Proveedores Values ('J0310000193169', 'Compañia Distribuidora de Nicaragua S. A.', 'Alma Castillo', 'Ventas', 1, 'ventas@cdn.com.ni', '89365036')
Insert into Proveedores Values ('J0310000006580','Deli Pollo','María Flores','Ventas',2,'ventas@tiptop.com.ni','83465937')

Select * from Proveedores

Insert into Productos Values ('00001', 'D`Frutta Pera',1,'330 ML', 30.50, 35.00, 'J0310000193169')
Insert into Productos Values ('00002', 'YUPI KIWI FRESA', 1, '235 ML', 5.00, 7.00, 'J0310000193169')

Select * from Productos

Select * from Inventario

Insert into Inventario Values ('00001', 50, 120, 70, 3660 ,2450)
Insert into Inventario Values ('00002', 50, 120, 70, 600, 490)