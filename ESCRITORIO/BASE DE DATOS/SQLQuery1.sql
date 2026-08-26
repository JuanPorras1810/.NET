	create database Practica;
	use Practica;

	create table Productos 
	(
	Id int identity (1,1) primary key,
	Nombre nvarchar (100),
	Descripcion nvarchar (100),
	Marca nvarchar (100),
	Precio float,
	Stock int
	);

	INSERT INTO Productos (Nombre, Descripcion, Marca, Precio, Stock) VALUES
	('Laptop Inspiron 15', 'Laptop 15 pulgadas 8GB RAM 512GB SSD', 'Dell', 750.50, 15),
	('Smartphone Galaxy S23', 'Telefono inteligente 256GB 8GB RAM', 'Samsung', 899.99, 25),
	('iPhone 14', 'Telefono inteligente 128GB', 'Apple', 999.00, 18),
	('Televisor 55 OLED', 'Smart TV 4K UHD 55 pulgadas', 'LG', 1200.75, 10),
	('Audifonos WH-1000XM5', 'Audifonos inalambricos con cancelacion de ruido', 'Sony', 349.99, 30),
	('Tablet iPad Air', 'Tablet 10.9 pulgadas 64GB', 'Apple', 599.99, 20),
	('Monitor UltraSharp 27', 'Monitor 27 pulgadas 4K', 'Dell', 450.00, 12),
	('Teclado MX Keys', 'Teclado inalambrico retroiluminado', 'Logitech', 120.50, 40),
	('Mouse G502', 'Mouse gamer con sensor HERO', 'Logitech', 79.99, 35),
	('Impresora LaserJet Pro', 'Impresora laser monocromatica', 'HP', 199.99, 22),
	('Camara EOS Rebel T7', 'Camara DSLR 24MP', 'Canon', 549.00, 8),
	('Bocina Flip 6', 'Bocina portatil bluetooth resistente al agua', 'JBL', 129.95, 27),
	('Reloj Watch Series 8', 'Reloj inteligente GPS 45mm', 'Apple', 429.99, 14),
	('Consola PlayStation 5', 'Consola de videojuegos 825GB SSD', 'Sony', 499.99, 9),
	('Xbox Series X', 'Consola de videojuegos 1TB SSD', 'Microsoft', 499.99, 11),
	('Router Archer AX50', 'Router WiFi 6 doble banda', 'TP-Link', 149.99, 19),
	('Disco Duro Externo 2TB', 'Almacenamiento externo USB 3.0', 'Seagate', 89.99, 26),
	('Memoria USB 128GB', 'Memoria flash USB 3.1', 'Kingston', 19.99, 60),
	('Silla Gamer Racing', 'Silla ergonomica reclinable', 'Razer', 299.99, 7),
	('Proyector Home Cinema', 'Proyector Full HD 1080p', 'Epson', 650.00, 6);

	---PROCEDIMIENTOS ALMACENADOS
	create proc MostrarProductos 
	as 
	select * from Productos

	execute MostrarProductos;

	---INSERTAR
	create proc InsertarProductos
	@Nombre nvarchar (100),
	@Descripcion nvarchar (100),
	@Marca nvarchar (100),
	@Precio float,
	@Stock int
	as
	insert into Productos values (@Nombre,@Descripcion,@Marca,@Precio,@Stock);

	---ELIMINAR
	create proc EliminarProducto
	@Id int
	as
	delete from Productos where Id = @Id

	---EDITAR
	create proc EditarProductos
	@Nombre nvarchar (100),
	@Descripcion nvarchar (100),
	@Marca nvarchar (100),
	@Precio float,
	@Stock int,
	@Id int
	as 
	update Productos set Nombre=@Nombre, Descripcion=@Descripcion, Marca=@Marca, Precio=@Precio, Stock=@Stock where Id=@Id