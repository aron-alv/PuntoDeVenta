-- Creaci�n de la base de datos
CREATE DATABASE AbarrotesBD;
 USE AbarrotesBD;

-- Tabla Producto
CREATE TABLE Producto (
    ID_Producto INT PRIMARY KEY not null,
    Nombre NVARCHAR(100)not null,
    Precio DECIMAL(10, 2)not null,
    Descripcion NVARCHAR(255));

-- Tabla Proveedor
CREATE TABLE Proveedor (
    ID_Proveedor INT PRIMARY KEY not null,
    Nombre NVARCHAR(100) not null,
    Telefono NVARCHAR(15),
    Direccion NVARCHAR(255)
);

-- Tabla Cliente
CREATE TABLE Cliente (
    ID_Cliente INT IDENTITY(1,1) PRIMARY KEY not null,
    Nombre NVARCHAR(100),
    Telefono NVARCHAR(15),
    Direccion NVARCHAR(255)
);

-- Tabla Venta
CREATE TABLE Venta (
    ID_Venta INT IDENTITY(1,1) PRIMARY KEY not null,
    Fecha DATE,
    Importe DECIMAL(10, 2),
    IVA DECIMAL(10, 2),
    Total DECIMAL(10, 2),
    Metodo_Pago NVARCHAR(50),
    ID_Cliente INT,
    FOREIGN KEY (ID_Cliente) REFERENCES Cliente(ID_Cliente)
);

-- Tabla DetalleVenta
CREATE TABLE DetalleVenta (
    ID_DetalleVenta INT IDENTITY(1,1) PRIMARY KEY not null,
    ID_Venta INT,
    ID_Producto INT,
    Cantidad INT,
    Precio_Unitario DECIMAL(10, 2),
    Subtotal DECIMAL(10, 2),
    FOREIGN KEY (ID_Venta) REFERENCES Venta(ID_Venta),
    FOREIGN KEY (ID_Producto) REFERENCES Producto(ID_Producto)
);

-- Tabla Inventario
CREATE TABLE Inventario (
    ID_Inventario INT IDENTITY(1,1) PRIMARY KEY not null,
    Fecha_Registro DATE,
    Observaciones NVARCHAR(255),
    Importe DECIMAL(10, 2),
    IVA DECIMAL(10, 2),
    Total DECIMAL(10, 2)
);

-- Tabla DetalleInventario
CREATE TABLE DetalleInventario (
    ID_Detalle_Inventario INT IDENTITY(1,1) PRIMARY KEY not null,
    ID_Inventario INT,
    ID_Producto INT,
    Cantidad_Entrante INT,
    Costo_Unitario DECIMAL(10, 2),
    Subtotal DECIMAL(10, 2),
    FOREIGN KEY (ID_Inventario) REFERENCES Inventario(ID_Inventario),
    FOREIGN KEY (ID_Producto) REFERENCES Producto(ID_Producto)
);

-- Tabla Saldos
CREATE TABLE Saldos (
    ID_Saldo INT IDENTITY(1,1) PRIMARY KEY not null,
    ID_Producto INT,
    Cantidad_Entrante INT,
    Cantidad_Salida INT,
    Cantidad_Disponible AS (Cantidad_Entrante - Cantidad_Salida), -- Calculado autom�ticamente
    FOREIGN KEY (ID_Producto) REFERENCES Producto(ID_Producto)
);

CREATE TABLE Auditoria_Eliminaciones (
    ID_Auditoria INT IDENTITY(1,1) PRIMARY KEY,
    Usuario VARCHAR(100) DEFAULT SYSTEM_USER,
    Fecha_Hora DATETIME DEFAULT GETDATE(),
    Tabla_Afectada VARCHAR(50),
    Folio_Eliminado INT,
);
use AbarrotesBD;
CREATE TABLE MovimientosDinero (
    ID_Movimiento INT IDENTITY(1,1) PRIMARY KEY,
    Fecha DATETIME DEFAULT GETDATE(),
    TipoMovimiento VARCHAR(10),
    MontoTotal DECIMAL(10,2)
    
);

-- Relaci�n Producto - Proveedor (un producto tiene un proveedor)
ALTER TABLE Producto
ADD ID_Proveedor INT,
FOREIGN KEY (ID_Proveedor) REFERENCES Proveedor(ID_Proveedor);

-- Relaci�n Inventario - Proveedor (inventario se actualiza con productos de un proveedor)
ALTER TABLE Inventario
ADD ID_Proveedor INT,
FOREIGN KEY (ID_Proveedor) REFERENCES Proveedor(ID_Proveedor);


SELECT 
    dv.*,  
    p.Nombre as NombreProducto  
FROM DetalleVenta dv
INNER JOIN Venta v ON v.ID_Venta = dv.ID_Venta
INNER JOIN Producto p ON p.ID_Producto = dv.ID_Producto
WHERE v.ID_Venta = 1160; 