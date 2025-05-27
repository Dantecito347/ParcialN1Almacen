CREATE DATABASE Almacen;
GO

USE Almacen;
GO

CREATE TABLE Productos_Alimentos (
ProductosID INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(100) NOT NULL,
Precio DECIMAL(10,2) NOT NULL,
Stock INT NOT NULL,
);

INSERT INTO Productos_Alimentos (Nombre, Precio, Stock) VALUES
('Fideos Sol Pampeano Tallarínes', 800.00, 50),
('Fideos Sol Pampeano Spaggueti', 800.00, 50),
('Fideos Sol Pampeano Tirabuzón', 800.00, 50),
('Fideos Sol Pampeano Dedal', 800.00, 50),
('Fideos Sol Pampeano Codo', 800.00, 50),
('Fideos Sol Pampeano Mostachol', 800.00, 50),
('Arroz Máximo 1kg', 1900.00, 50),
('Arrpz Molinos ALA', 2500.00, 20),
('Aceite Natura 900ml', 2300.00, 25),
('Aceite Cocinero 900ml', 2700.00, 15),
('Sal Fina Celusal 500g', 1290.00, 15),
('Puré de Tomate Mora 520g', 730.00, 25),
('Puré de Tomate INCAA 520g', 1000.00, 25),
('Mayonesa Hellmans 500ml', 2850.00, 30),
('Mayonesa Hellmans 250ml', 1450.00, 50),
('Mayonesa CadaDia 250ml', 950.00, 25),
('Yerba Unión 500g', 2200.00, 15),
('Yerba Chamigo 500g', 1900.00, 15),
('Yerba Amanda 500g', 2350.00, 15),
('Yerba Rosamonte 500g', 2100.00, 15),
('Yerba Mañanita 500g', 2200.00, 15),
('Yerba Taraguí 500g', 2200.00, 15),
('Harina Leudante Morixe 1kg', 1200.00, 20),
('Harina Leudante Pureza 1kg', 1650.00, 15),
('Azúcar Común Doña Inés 1kg', 1100.00, 35),
('Polenta S&P 500g', 750.00, 40),
('Chocolatada en polvo Nesquik 360g', 3400.00, 25),
('Chocolatada en polvo Chocolino 180g', 1800.00, 35);

CREATE TABLE Productos_Bebidas (
ID INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(100) NOT NULL,
Precio DECIMAL(10,2) NOT NULL,
Stock INT NOT NULL
);

INSERT INTO Productos_Bebidas (Nombre, Precio, Stock) VALUES
('Gaseosa Secco 3l', 2000.00, 50),
('Gaseosa Manaos 3l', 3000.00, 50),
('Gaseosa Baggio 2.25l', 1400.00, 50),
('Sprite 1.75l', 3400.00, 50),
('Jugo de Uva Brio Villa del Sur', 950.00, 30),
('Jugo de Naranja Brio Villa del Sur', 920.00, 60),
('Jugo de Pomelo Brio Villa del Sur', 920.00, 60),
('Jugo Multifruta Brio Villa del Sur', 920.00, 60);

CREATE TABLE Productos_Lacteos (
ID INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(100) NOT NULL,
Precio DECIMAL(10,2) NOT NULL,
Stock INT NOT NULL
);

INSERT INTO Productos_Lacteos (Nombre, Precio, Stock) VALUES
('Leche Entera Ilolay 1l', 2200.00, 50),
('Leche Entera Milkout 1l', 1950.00, 50),
('Leche Entera Apostoles 1l', 1700.00, 50),
('Leche Entera 7 Vidas 1l', 1750.00, 50),
('Leche Entera La Familia 1l', 1400.00, 50),
('Queso Cremoso 200g', 1900.00, 20),
('Manteca La Familia 200ml', 2100.00, 25),
('Crema de Leche La Familia', 2100.00, 15),
('Dulce de Leche Tonadita 400g', 2100.00, 15),
('Dulce de Leche Milkout 400g', 2600.00, 15),
('Dulce de Leche La Paulina 400g', 3200.00, 15);


CREATE TABLE Repartidores (
PersonaID INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(50) NOT NULL,
Apellido VARCHAR(50) NOT NULL,
Email VARCHAR(100) UNIQUE NOT NULL,
Celular VARCHAR(20) UNIQUE NOT NULL,
Localidad VARCHAR(100) NOT NULL,
TipoDeVehiculo VARCHAR(100) NOT NULL,
);

INSERT INTO Repartidores (Nombre, Apellido, Email, Celular, Localidad, TipoDeVehiculo) VALUES
('Carlos', 'Gómez', 'carlos.gomez@example.com', '1234567890', 'Buenos Aires', 'Auto'),
('Lucia', 'Martínez', 'lucia.martinez@example.com', '9876543210', 'Rosario', 'Bicicleta'),
('Juan', 'Peréz', 'juan,perez@example.com', '1357924680', 'Córdoba', 'Auto'),
('Sofía', 'López', 'sofia.lopez@example.com', '1482593760', 'Mendoza', 'Moto'),
('Diego', 'Ramírez', 'diego.ramirez@example.com', '2468013579', 'La Plata', 'Camioneta');


CREATE TABLE Carrito (
ID INT PRIMARY KEY IDENTITY(1,1),
ProductoID INT NOT NULL,
NombreProducto VARCHAR(100) NOT NULL,
Precio DECIMAL(10,2) NOT NULL,
Cantidad INT NOT NULL
);
