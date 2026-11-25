CREATE TABLE empleados (
    id INT PRIMARY KEY IDENTITY(1,1),
    numero INT NOT NULL UNIQUE,
    nombre NVARCHAR(100) NOT NULL,
    precio_hora INT NOT NULL,
    fecha_nacimiento DATE NOT NULL);