--Creamos la base de datos
Create database PruebaTec02LLVG
--hacemos uso de la base de datos
use PruebaTec02LLVG

-- Creación de la tabla "departamentos"
CREATE TABLE departamentos (
    dept_no int Identity (1,1) PRIMARY KEY  NOT NULL,
    dnombre varchar(15) NOT NULL,
    loc varchar(15) NOT NULL,
);
---Creación de la tabla "Empleados"
CREATE TABLE empleados (
    emp_no int Identity (1,1) PRIMARY KEY  NOT NULL,
    apellido varchar(10) DEFAULT NULL,
    oficio varchar(10) DEFAULT NULL,
    dir smallint DEFAULT NULL,
    fecha_alt date DEFAULT NULL,
    salario decimal DEFAULT NULL,
    comision decimal DEFAULT NULL,
    dept_no int NOT NULL,
	imagen image,
    FOREIGN KEY (dept_no) REFERENCES departamentos (dept_no)
);