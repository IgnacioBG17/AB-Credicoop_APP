Create database Practica
GO

USE Practica
Go

Create table Producto
(
	id int primary key identity(1,1),
	Nombre nvarchar(100),
	Descripcion nvarchar(100),
	Marca nvarchar(100),
	Precio float,
	Stock int
)

Insert into Producto
values ('Gaseosa', '3 litros', 'coca cola', 7.5, 25),
('Chocolate', 'Tableta 100 gramos', 'Iberica', 12.5, 25),
('Leche', 'Deslactosada', 'Lala', 5.0, 25),
('Harina', 'bolsa 1 kg', 'Standar', 3.0, 25),
('Nectar', '1 litro', 'AllJugos', 10.5, 25),
('Aceite', '1 litro', 'cocinero', 9.5, 25),
('Papel higinico', 'scott 1000 hojas', 'scott', 15.0, 25)


Select * from Producto

Create Procedure MostrarProductos
@Nombre NVARCHAR(100) = NULL
AS
BEGIN
	SET NOCOUNT ON;

    SELECT 
        Id,
        Nombre,
        Descripcion,
        Marca,
        Precio,
        Stock
    FROM dbo.Producto
    WHERE (@Nombre IS NULL OR Nombre LIKE '%' + @Nombre + '%')
    ORDER BY Id;
END

exec MostrarProductos

Create Procedure InsertarProducto
@Nombre nvarchar(100),
@Descripcion nvarchar(100),
@Marca nvarchar(100),
@Precio decimal(18,2),
@Stock int
AS
BEGIN
    SET NOCOUNT ON;
	INSERT INTO Producto
	VALUES (@Nombre, @Descripcion, @Marca, @Precio, @Stock)
END

Create Procedure EditarProducto
@Id int,
@Nombre nvarchar(100),
@Descripcion nvarchar(100),
@Marca nvarchar(100),
@Precio decimal(18,2),
@Stock int
AS
BEGIN
   SET NOCOUNT ON;

	Update Producto 
	Set Nombre = @Nombre, 
		Descripcion = @Descripcion, 
		Marca= @Marca, 
		Precio = @Precio, 
		Stock = @Stock
	where id = @Id
END

exec EditarProducto 1, 'Gaseosa Editada', '1 litro', 'Pepsi', 8.5, 90

Create procedure EliminarProducto
@Id int
AS
BEGIN
	Delete from Producto where id = @Id
END

exec EliminarProducto 11
exec MostrarProductos
