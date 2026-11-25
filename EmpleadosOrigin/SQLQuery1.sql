CREATE TABLE HorasDiarias (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Legajo INT,
    Fecha DATE,
    HorasTrabajadas DECIMAL(5,2),
    FOREIGN KEY (Legajo) REFERENCES Empleados(Legajo)
);

CREATE TABLE HorasMensuales (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Legajo INT NOT NULL,
    Mes INT NOT NULL,
    Anio INT NOT NULL,
    TotalHoras DECIMAL(5,2) NOT NULL,
    FOREIGN KEY (Legajo) REFERENCES Empleados(Legajo)
);

SELECT * FROM HorasDiarias
SELECT * FROM HorasMensuales

