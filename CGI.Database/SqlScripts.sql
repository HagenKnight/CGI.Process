-- a. Crear una tabla de nombre “producto” que tenga un campo “nombre”, “precio” y “fecha”.

CREATE TABLE Producto (
	ProductoId INT IDENTITY ( 1, 1 ) NOT NULL,
	Nombre VARCHAR ( 50 ) NOT NULL,
	Precio INT NOT NULL,
	Fecha DATE NOT NULL 
)

-- b. Insertar el producto leche con fecha del 15 de dciembre del 2010 y precio de $12.
INSERT INTO Producto
(Nombre, Precio, Fecha)
VALUES
('Leche', 12, '2010-12-15')

-- c. Cambiar el nombre del producto “Leche” a “Leche Entera”.
UPDATE Producto
SET Nombre = 'Leche Entera'
WHERE Nombre LIKE 'Leche'

-- d. Mostrar el nombre de todos los productos que cuesten más de $5.
SELECT Nombre, Precio, Fecha
FROM Producto
WHERE Precio > 5

-- e. Borrar todos los productos.
DELETE Producto