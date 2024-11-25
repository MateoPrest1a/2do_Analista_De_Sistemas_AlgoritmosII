create database Proyecto_Hilet2;
use Proyecto_Hilet2;

create table Carreras( 
id_carrera int identity primary key,
nombre_carrera varchar(50),
num_resolucion int,
anio_plan_estudio int
);

drop table Carreras

insert into Carreras values(
	'Analista de Sistemas',1,1
);

insert into Carreras values(
	'Publicidad',2,2
);

select * from Carreras

create table Alumnos(
matricula int identity primary key,
nombre varchar(20),
apellido varchar(20),
direccion_calle varchar(15),
direccion_numero int,
telefono varchar(15),
dni varchar(15),
email varchar(50),
fecha_nacimiento date,
id_carrera int,
baja BIT DEFAULT 0,
año INT,
foreign key (id_carrera) references Carreras(id_carrera)
);

create table Materias(
	id_materia int identity primary key,
	anio_cursada int,
	nombre_materia varchar(30),
	id_carrera int,
	foreign key (id_carrera) references Carreras(id_carrera)
);

select * from Alumnos

drop table Alumnos

ALTER TABLE Alumnos
ADD baja BIT DEFAULT 0;  -- 0 falso 1 verdadero, el default es 0 para decir que estan dados de alta


create table Estado_De_Alumno(
	id_estado_alumno int identity primary key,
	matricula int,
	estado_cursada nvarchar,
	foreign key (matricula) references Alumnos(matricula)
);


create table Materias(
	id_materia int identity primary key,
	anio_cursada int,
	nombre_materia varchar(30),
	id_carrera int,
	id_empleado INT NULL,
	FOREIGN KEY (id_carrera) REFERENCES Carreras(id_carrera),
	FOREIGN KEY (id_empleado) REFERENCES Empleados(id_empleado)
);



DROP TABLE Materias

INSERT INTO Materias VALUES
(
2,'Algoritmos II', 1
);

select * from Materias

create table Examenes(
	id_examen int identity primary key,
	id_carrera int,
	id_materia int,
	hora_examen varchar(10),
	fecha_examen date,
	tipo_examen int,
	libro int,
	folio int,
	foreign key (id_carrera) references Carreras(id_carrera),
	foreign key (id_materia) references Materias(id_materia),
	foreign key (tipo_examen) references tipoexamen(id_tipoexamen)
);

drop table Examenes


create table ExamenesXAlumno(
	id_examenxalumno int identity primary key,
	matricula int,
	id_examen int,
	calificacion decimal,
	foreign key (matricula) references Alumnos(matricula),
	foreign key (id_examen) references Examenes(id_examen)
);

INSERT INTO ExamenesXAlumno VALUES(
20,1,10
);

select * from Alumnos

SELECT 
    exa.id_examenxalumno, 
    a.matricula, 
    a.nombre AS Alumno,
    ex.id_examen,
    ex.fecha_examen AS Fecha,
    m.id_materia,
    m.nombre_materia AS Materia,
    c.id_carrera, 
    c.nombre_carrera AS Carrera,
    m.anio_cursada AS Año,
    te.descripcion AS TipoExamen,  -- Agregamos el tipo de examen
    exa.calificacion 
FROM 
    ExamenesXAlumno exa
INNER JOIN 
    Alumnos a ON exa.matricula = a.matricula
INNER JOIN 
    Examenes ex ON exa.id_examen = ex.id_examen
INNER JOIN 
    Materias m ON ex.id_materia = m.id_materia
INNER JOIN 
    Carreras c ON ex.id_carrera = c.id_carrera
INNER JOIN 
    tipoexamen te ON ex.tipo_examen = te.id_tipoexamen  -- Join para obtener el tipo de examen
WHERE 
    exa.matricula = 3;

select * from examenes

select * from Alumnos

select * from Carreras


INSERT INTO Examenes VALUES(
1,1,'10:20','2024-10-22',1,207,192
);

select * from Examenes

create table tipoexamen(
	id_tipoexamen int identity primary key,
	descripcion varchar(30)
);

INSERT INTO tipoexamen VALUES(
'Primer Parcial'
)



INSERT INTO tipoexamen VALUES(
'Segundo Parcial'
)

INSERT INTO tipoexamen VALUES(
'Primer Recuperatorio'
)

INSERT INTO tipoexamen VALUES(
'Segundo Recuperatorio'
)

INSERT INTO tipoexamen VALUES(
'Final'
)

INSERT INTO tipoexamen VALUES(
'Flotante'
)

SELECT * FROM tipoexamen

create table MateriasxAlumno(
	id_materiasxalumno int identity primary key,
	matricula int,
	id_materia int,
	estado nvarchar(50),
	foreign key (matricula) references Alumnos(matricula),
	foreign key (id_materia) references Materias(id_materia)
);


drop table MateriasxAlumno

select * from Perfiles

SELECT * From MateriasxAlumno

create table AlumnosxCarrera(
	id_aluxcarr int identity primary key,
	id_carrera int,
	matricula int,
	foreign key (id_carrera) references Carreras(id_carrera),
	foreign key (matricula) references Alumnos(matricula)
);

/*-------------------------------------------------------*/

create table Perfiles(
	id_perfil int identity primary key,
	tipo varchar(30)
);

select * from Perfiles

select * from empleados

INSERT INTO Perfiles VALUES(
'Personal Administrativo'
);

INSERT INTO Perfiles VALUES(
'Profesor'
);

INSERT INTO Perfiles VALUES(
'Administrador'
);

drop table Perfiles

------------------------------------------------------------------------------------


create table PerfilxAlumno(
	id_perfilxalumno int primary key identity,
	matricula int,
	nombre_usuario varchar(35),
	contrasenia varchar(35),
	foreign key (matricula) references Alumnos(matricula),
);

select * from PerfilxAlumno

create table PerfilxPersona(
    id_perfilxpers int identity primary key,
    id_perfil int,
    id_empleado int,  -- Relacionamos el perfil con el empleado
    nombre_usuario varchar(35),
    contrasenia varchar(35),
    foreign key (id_perfil) references Perfiles(id_perfil),
    foreign key (id_empleado) references Empleados(id_empleado)  -- Relación con la tabla Empleados
);

INSERT INTO PerfilxPersona VALUES(
3,4,'admin','admin'
);

select * from empleados

DROP TABLE PerfilxPersona

SELECt * from PerfilxPersona

create table Empleados(
	id_empleado int identity primary key,
	nombre varchar(30),
	apellido varchar(30),
	direccion_calle varchar(30),
	direccion_nro int,
	telefono varchar(30),
	dni varchar(30),
	email varchar(50),
	fecha_nacimiento date,
	salario int,
	tipo_perfil int,
    FOREIGN KEY (tipo_perfil) REFERENCES Perfiles(id_perfil)
);


select * from perfiles

--No lo hago con esta tabla sino que simplemente hago que en la tabla materias el profesor pueda ser null
/*
CREATE TABLE MateriasxProfesor (
    id_materiasxprofesor INT IDENTITY PRIMARY KEY,
    id_profesor INT,                
    id_materia INT,                 
    FOREIGN KEY (id_profesor) REFERENCES Empleados(id_empleado),  
    FOREIGN KEY (id_materia) REFERENCES Materias(id_materia)
);

drop table MateriasxProfesor
*/

------------------------------------------------------------------------------------------
CREATE TABLE CarrerasxProfesor (
	id_carrerasxprofesor INT IDENTITY PRIMARY KEY,
	id_profesor INT,
	id_carrera INT,
	FOREIGN KEY (id_profesor) REFERENCES Empleados(id_empleado),  
    FOREIGN KEY (id_carrera) REFERENCES Carreras(id_carrera)
);

select * from Empleados

select * from perfiles

INSERT INTO Empleados (nombre, apellido, direccion_calle, direccion_nro, telefono, dni, email, fecha_nacimiento, salario, tipo_perfil)
VALUES ('Ramiro', 'Sansillena', 'Av. Colon', 1824, '20009283', 'ramirosansi@gmail.com', 'ramirosansi@gmail.com', '1969-10-10', 240000, 3);

insert into Alumnos values 
(
'Jose','Hernandez','Olazabal',134,'2232232233','40203040','josekpogenio@gmail.com','2024-09-30',1,0,2
);

select * from Alumnos;
select * from Carreras


select * from Perfiles

select * from Empleados

select * from 

--------------------------------------------------------Store Procedure Alumnos--------------------------------------------------------


CREATE PROCEDURE SP_AgregarAlumno
    @Nombre VARCHAR(20),
    @Apellido VARCHAR(20),
    @direccion_calle VARCHAR(15),
    @direccion_numero INT,
    @telefono VARCHAR(15),
    @dni VARCHAR(15),  -- El DNI será usado como nombre de usuario y contraseña
    @email VARCHAR(50),
    @fecha_nacimiento DATE,
    @id_carrera INT,
    @año INT
AS
BEGIN
    INSERT INTO Alumnos (nombre, apellido, direccion_calle, direccion_numero, telefono, dni, email, fecha_nacimiento, id_carrera, año)
    VALUES (@Nombre, @Apellido, @direccion_calle, @direccion_numero, @telefono, @dni, @email, @fecha_nacimiento, @id_carrera, @año);

    DECLARE @Matricula INT;
    SET @Matricula = SCOPE_IDENTITY();  -- SCOPE_IDENTITY() devuelve el último valor insertado en la tabla actual

    INSERT INTO PerfilxAlumno (matricula, nombre_usuario, contrasenia)
    VALUES (@Matricula, @dni, @dni); 

END;

CREATE PROCEDURE SP_EliminarAlumno
    @matricula INT
AS
BEGIN
	UPDATE Alumnos
	SET baja = 1
	WHERE matricula = @matricula;
END;



--------------------------------------------------------Store Procedure Examen X Alumno--------------------------------------------------------


CREATE PROCEDURE SP_AgregarExamenXAlumno
    @matricula INT,
    @id_examen INT,
    @calificacion DECIMAL
AS
BEGIN
    INSERT INTO ExamenesXAlumno (matricula, id_examen, calificacion)
    VALUES (@matricula, @id_examen, @calificacion);
END


CREATE PROCEDURE SP_ActualizarExamenXAlumno
    @id_examenxalumno INT,
    @id_examen INT,
    @calificacion DECIMAL
AS
BEGIN
    UPDATE ExamenesXAlumno
    SET id_examen = @id_examen,
        calificacion = @calificacion
    WHERE id_examenxalumno = @id_examenxalumno;
END


CREATE PROCEDURE SP_EliminarExamenXAlumno
    @id_examenxalumno INT
AS
BEGIN
    DELETE FROM ExamenesXAlumno
    WHERE id_examenxalumno = @id_examenxalumno;
END




--------------------------------------------------------Store Procedure Empleados--------------------------------------------------------


CREATE PROCEDURE SP_AgregarEmpleado
    @nombre VARCHAR(30),
    @apellido VARCHAR(30),
    @direccion_calle VARCHAR(30),
    @direccion_nro INT,
    @telefono VARCHAR(30),
    @dni VARCHAR(30),
    @email VARCHAR(50),
    @fecha_nacimiento DATE,
    @salario INT,
    @tipo_perfil INT
AS
BEGIN
    INSERT INTO Empleados (nombre, apellido, direccion_calle, direccion_nro, telefono, dni, email, fecha_nacimiento, salario, tipo_perfil)
    VALUES (@nombre, @apellido, @direccion_calle, @direccion_nro, @telefono, @dni, @email, @fecha_nacimiento, @salario, @tipo_perfil);

	DECLARE @id_empleado INT;
    SET @id_empleado = SCOPE_IDENTITY();  -- SCOPE_IDENTITY() devuelve el último valor insertado en la tabla actual

    INSERT INTO PerfilXPersona (id_perfil, id_empleado, nombre_usuario, contrasenia)
    VALUES (@tipo_perfil, @id_empleado, @dni, @dni); 

END;

DROP PROCEDURE SP_AgregarEmpleado



CREATE PROCEDURE SP_ModificarEmpleado
    @id_empleado INT,
    @nombre VARCHAR(30),
    @apellido VARCHAR(30),
    @direccion_calle VARCHAR(30),
    @direccion_nro INT,
    @telefono VARCHAR(30),
    @dni VARCHAR(30),
    @email VARCHAR(50),
    @fecha_nacimiento DATE,
    @salario INT,
    @tipo_perfil INT
AS
BEGIN
    UPDATE Empleados
    SET 
        nombre = @nombre,
        apellido = @apellido,
        direccion_calle = @direccion_calle,
        direccion_nro = @direccion_nro,
        telefono = @telefono,
        dni = @dni,
        email = @email,
        fecha_nacimiento = @fecha_nacimiento,
        salario = @salario,
        tipo_perfil = @tipo_perfil
    WHERE id_empleado = @id_empleado;
END;


CREATE PROCEDURE SP_EliminarEmpleado
    @id_empleado INT
AS
BEGIN
    DELETE FROM Empleados
    WHERE id_empleado = @id_empleado;
END;




--------------------------------------------------------Store Procedure Carreras--------------------------------------------------------


CREATE PROCEDURE SP_AgregarCarrera
    @nombre_carrera VARCHAR(50),
    @num_resolucion INT,
    @anio_plan_estudio INT
AS
BEGIN
    INSERT INTO Carreras (nombre_carrera, num_resolucion, anio_plan_estudio)
    VALUES (@nombre_carrera, @num_resolucion, @anio_plan_estudio);
END;

CREATE PROCEDURE SP_ModificarCarrera
    @id_carrera INT,
    @nombre_carrera VARCHAR(50),
    @num_resolucion INT,
    @anio_plan_estudio INT
AS
BEGIN
    UPDATE Carreras
    SET nombre_carrera = @nombre_carrera,
        num_resolucion = @num_resolucion,
        anio_plan_estudio = @anio_plan_estudio
    WHERE id_carrera = @id_carrera;
END;

CREATE PROCEDURE SP_EliminarCarrera
    @id_carrera INT
AS
BEGIN
    DELETE FROM Carreras
    WHERE id_carrera = @id_carrera;
END;


--------------------------------------------------------Store Procedure Materias--------------------------------------------------------


CREATE PROCEDURE SP_AgregarMateria
    @anio_cursada INT,
    @nombre_materia VARCHAR(30),
    @id_carrera INT,
	@id_empleado INT = NULL 
AS
BEGIN
    
    INSERT INTO Materias (anio_cursada, nombre_materia, id_carrera, id_empleado)
    VALUES (@anio_cursada, @nombre_materia,@id_carrera,@id_empleado);

END;

drop procedure SP_AgregarMateria


CREATE PROCEDURE SP_ActualizarMateria
    @id_materia INT,
    @anio_cursada INT,
    @nombre_materia VARCHAR(30),
    @id_carrera INT,  -- El id de la carrera con la que se debe actualizar la materia
    @id_empleado INT  -- El id del profesor que se debe asociar con la materia
AS
BEGIN
    -- Actualizar la materia en la tabla Materias
    UPDATE Materias
    SET 
        anio_cursada = @anio_cursada,
        nombre_materia = @nombre_materia,
		id_carrera = @id_carrera,
		id_empleado = @id_empleado
    WHERE id_materia = @id_materia;

END;

drop procedure SP_ActualizarMateria


CREATE PROCEDURE SP_EliminarMateria
    @id_materia INT
AS
BEGIN
    -- Eliminar la materia de la tabla Materias
    DELETE FROM Materias
    WHERE id_materia = @id_materia;
END;

drop procedure SP_EliminarMateria

--------------------------------------------------------Store Procedure Materias x Alumnos--------------------------------------------------------

CREATE PROCEDURE SP_AgregarMateriasxAlumno
    @matricula INT,
    @id_materia INT,
    @estado NVARCHAR(50)
AS
BEGIN
    INSERT INTO MateriasxAlumno (matricula, id_materia, estado)
    VALUES (@matricula, @id_materia, @estado);
END;

select * from MateriasxAlumno

drop procedure SP_AgregarMateriasxAlumno


CREATE PROCEDURE SP_ModificarMateriasxAlumno
    @id_materiasxalumno INT,
    @matricula INT,
    @id_materia INT,
    @estado NVARCHAR
AS
BEGIN
    UPDATE MateriasxAlumno
    SET 
        matricula = @matricula,
        id_materia = @id_materia,
        estado = @estado
    WHERE id_materiasxalumno = @id_materiasxalumno;
    
END;



CREATE PROCEDURE SP_EliminarMateriasxAlumno
    @id_materiasxalumno INT
AS
BEGIN
    DELETE FROM MateriasxAlumno
    WHERE id_materiasxalumno = @id_materiasxalumno;
END;
--------------------------------------------------------Store Procedure Examenes--------------------------------------------------------

CREATE PROCEDURE SP_AgregarExamen
    @id_carrera INT,
    @id_materia INT,
    @hora_examen VARCHAR(10),
    @fecha_examen DATE,
    @tipo_examen INT,
    @libro INT,
    @folio INT
AS
BEGIN
    INSERT INTO Examenes (id_carrera, id_materia, hora_examen, fecha_examen, tipo_examen, libro, folio)
    VALUES (@id_carrera, @id_materia, @hora_examen, @fecha_examen, @tipo_examen, @libro, @folio);
END;


CREATE PROCEDURE SP_ActualizarExamen
    @id_examen INT,
    @id_carrera INT,
    @id_materia INT,
    @hora_examen VARCHAR(10),
    @fecha_examen DATE,
    @tipo_examen INT,
    @libro INT,
    @folio INT
AS
BEGIN
    UPDATE Examenes
    SET 
        id_carrera = @id_carrera,
        id_materia = @id_materia,
        hora_examen = @hora_examen,
        fecha_examen = @fecha_examen,
        tipo_examen = @tipo_examen,
        libro = @libro,
        folio = @folio
    WHERE id_examen = @id_examen;
END;

CREATE PROCEDURE SP_EliminarExamen
    @id_examen INT
AS
BEGIN
    DELETE FROM Examenes
    WHERE id_examen = @id_examen;
END;

--------------------------------------------------------Store Procedure Busqueda Alumnos--------------------------------------------------------


CREATE PROCEDURE SP_BuscarAlumnoPorNombreApellido
    @NombreApellido VARCHAR(40)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT matricula, nombre, apellido, direccion_calle, direccion_numero,
           telefono, dni, email, fecha_nacimiento, id_carrera, baja, año
    FROM Alumnos
    WHERE (nombre + ' ' + apellido LIKE '%' + @NombreApellido + '%'
           OR apellido + ' ' + nombre LIKE '%' + @NombreApellido + '%')
      AND baja = 0;  -- Incluye solo alumnos activos
END;


CREATE PROCEDURE SP_FiltrarAlumnosPorAño
    @Año INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT matricula, nombre, apellido, direccion_calle, direccion_numero,
           telefono, dni, email, fecha_nacimiento, id_carrera, baja, año
    FROM Alumnos
    WHERE año = @Año
    AND baja = 0;  -- Incluye solo alumnos activos
END;


CREATE PROCEDURE SP_FiltrarAlumnosPorCarrera
    @IdCarrera INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT matricula, nombre, apellido, direccion_calle, direccion_numero,
           telefono, dni, email, fecha_nacimiento, id_carrera, baja, año
    FROM Alumnos
    WHERE id_carrera = @IdCarrera
    AND baja = 0;  -- Incluye solo alumnos activos
END;

--------------------------------------------------------Store Procedure Busqueda Empleados--------------------------------------------------------

CREATE PROCEDURE SP_BuscarEmpleadosPorNombre
    @Nombre NVARCHAR,
	@Apellido NVARCHAR
AS
BEGIN
    SELECT *
    FROM Empleados
    WHERE nombre LIKE '%' + @Nombre + '%' AND apellido LIKE '%' + @Apellido + '%'
END;


--------------------------------------------------------Filtro por Materia--------------------------------------------------------
CREATE PROCEDURE SP_FiltrarMateriasPorAño
    @año INT
AS
BEGIN
    SELECT  
        m.id_materia AS ID, 
        m.anio_cursada AS Año, 
        m.nombre_materia AS Materia,
        c.nombre_carrera AS Carrera,
        c.id_carrera,
        CONCAT(e.apellido, ', ', e.nombre) AS Profesor,
        e.id_empleado AS ID_Empleado
    FROM 
        Materias AS m
    JOIN 
        Carreras AS c ON m.id_carrera = c.id_carrera
    LEFT JOIN 
        Empleados AS e ON m.id_empleado = e.id_empleado
    WHERE
        m.anio_cursada = @año;  -- Filtra solo por año
END;




CREATE PROCEDURE SP_FiltrarMateriasPorCarrera
    @id_carrera INT
AS
BEGIN
    SELECT  
        m.id_materia AS ID, 
        m.anio_cursada AS Año, 
        m.nombre_materia AS Materia,
        c.nombre_carrera AS Carrera,
        c.id_carrera,
        CONCAT(e.apellido, ', ', e.nombre) AS Profesor,
        e.id_empleado AS ID_Empleado
    FROM 
        Materias AS m
    JOIN 
        Carreras AS c ON m.id_carrera = c.id_carrera
    LEFT JOIN 
        Empleados AS e ON m.id_empleado = e.id_empleado
    WHERE
        c.id_carrera = @id_carrera;  -- Filtra solo por carrera
END;


--------------------------------------------------------Funciones Estadisticas--------------------------------------------------------

CREATE FUNCTION F_CantEmplTot()
RETURNS INT
AS
BEGIN
	DECLARE @CantTot INT;
	SELECT @CantTot = COUNT(id_empleado) from Empleados;
	RETURN @CantTot;
END;

/*
CREATE FUNCTION F_CantProfADS()
RETURNS INT
AS
BEGIN
	DECLARE @CantTot INT;
		SELECT @CantTot = COUNT(id_empleado) 
		FROM Empleados AS e 
		inner join 
		Perfiles as p 
		ON 
		e.tipo_perfil = p.id_perfil
		WHERE

	RETURN
END;*/

CREATE FUNCTION F_CantProf()
RETURNS INT
AS
BEGIN
	DECLARE @CantTot INT;
		SELECT @CantTot = COUNT(id_empleado) 
		FROM Empleados e
		inner join
		Perfiles as p
		ON
		e.tipo_perfil = p.id_perfil
		WHERE
		p.id_perfil = 2;
	RETURN @CantTot;
END;

CREATE FUNCTION F_CantMateTotADS()
RETURNS INT
AS
BEGIN
	DECLARE @CantTot INT;
	SELECT @CantTot = COUNT(id_materia) 
	FROM Materias m
	inner join
	Carreras c
	ON
	m.id_carrera = c.id_carrera
	WHERE c.id_carrera = 1;
	RETURN @CantTot;
END;

CREATE FUNCTION F_CantMateTotPub()
RETURNS INT
AS
BEGIN
	DECLARE @CantTot INT;
	SELECT @CantTot = COUNT(id_materia) 
	FROM Materias m
	inner join
	Carreras c
	ON
	m.id_carrera = c.id_carrera
	WHERE c.id_carrera = 2;
	RETURN @CantTot;
END;

CREATE FUNCTION F_CantAlumTotADS()
RETURNS INT
AS
BEGIN
	DECLARE @CantTot INT;
	SELECT @CantTot = COUNT(matricula) 
	FROM Alumnos
	WHERE
	id_carrera = 1;
	RETURN @CantTot;
END;

CREATE FUNCTION F_CantAlumTotPub()
RETURNS INT
AS
BEGIN
	DECLARE @CantTot INT;
	SELECT @CantTot = COUNT(matricula)
	FROM Alumnos
	WHERE
	id_carrera = 2;
	RETURN @CantTot;
END;

CREATE FUNCTION F_CantAlum()
RETURNS INT
AS
BEGIN
	DECLARE @CantTot INT;
	SELECT @CantTot = COUNT(matricula)
	FROM Alumnos;
	RETURN @CantTot;
END;