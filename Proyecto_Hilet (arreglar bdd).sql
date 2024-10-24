create database Proyecto_Hilet;
use Proyecto_Hilet;

create table Carreras( 
id_carrera int identity primary key,
nombre_carrera varchar(50),
num_resolucion int,
anio_plan_estudio int
);

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
foreign key (id_carrera) references Carreras(id_carrera)
);

create table Estado_De_Alumno(
	id_estado_alumno int identity primary key,
	matricula int,
	estado_cursada varchar(15),
	foreign key (matricula) references Alumnos(matricula)
);

create table Materias(
	id_materia int identity primary key,
	anio_cursada int,
	nombre_materia varchar(30),
	id_carrera int,
	foreign key (id_carrera) references Carreras(id_carrera)
);

DROP TABLE Materias

INSERT INTO Materias VALUES
(
2,'Algoritmos II', 1
);

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
	foreign key (matricula) references Alumnos(matricula),
	foreign key (id_materia) references Materias(id_materia)
);

create table MateriasxCarrera(
	id_matxcarr int identity primary key,
	id_carrera int,
	id_materia int,
	foreign key (id_carrera) references Carreras(id_carrera),
	foreign key (id_materia) references Materias(id_materia)
);

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

drop table Perfiles

create table Permisos(
	id_permiso int identity primary key,
	descripcion nvarchar,
	tipo_de_permiso int
);

create table PermisosxPerfil(
	id_permisoxperfil int identity primary key,
	id_permiso int,
	id_perfil int,
	foreign key (id_permiso) references Permisos(id_permiso),
	foreign key (id_perfil) references Perfiles(id_perfil)
);

create table PerfilxAlumno(
	id_perfilxalumno int primary key identity,
	matricula int,
	nombre_usuario varchar(35),
	contrasenia varchar(35),
	foreign key (matricula) references Alumnos(matricula),
);

create table PerfilxPersona(
	id_perfilxpers int identity primary key,
	id_perfil int,
	nombre_usuario varchar(35),
	contrasenia varchar(35),
	foreign key (id_perfil) references Perfiles(id_perfil)
); 

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
	foreign key (tipo_perfil) references Perfiles(id_perfil)
);

drop table Empleados

INSERT INTO Empleados (nombre, apellido, direccion_calle, direccion_nro, telefono, dni, email, fecha_nacimiento, salario, tipo_perfil)
VALUES ('Ramiro', 'Sansillena', 'Av. Colon', 1824, '20009283', 'ramirosansi@gmail.com', 'ramirosansi@gmail.com', '1969-10-10', 240000, 1);

insert into Alumnos values 
(
'Jose','Hernandez','Olazabal',134,'2232232233','40203040','josekpogenio@gmail.com','2024-09-30',1
);

select * from Alumnos;
select * from Carreras

UPDATE Carreras
SET anio_plan_estudio = 2024
WHERE id_carrera = 2;

insert into Perfiles values
('Profesor')

insert into Perfiles values
('Empleado Administrativo')

select * from Perfiles

select * from Empleados

CREATE PROCEDURE SP_AgregarAlumno
    @nombre VARCHAR(20),
    @apellido VARCHAR(20),
    @direccion_calle VARCHAR(15),
    @direccion_numero INT,
    @telefono VARCHAR(15),
    @dni VARCHAR(15),
    @email VARCHAR(50),
    @fecha_nacimiento DATE,
    @id_carrera INT
AS
BEGIN
    INSERT INTO Alumnos (nombre, apellido, direccion_calle, direccion_numero, telefono, dni, email, fecha_nacimiento, id_carrera)
    VALUES (@nombre, @apellido, @direccion_calle, @direccion_numero, @telefono, @dni, @email, @fecha_nacimiento, @id_carrera);
END;


CREATE PROCEDURE SP_ActualizarAlumno
    @matricula INT,
    @nombre VARCHAR(20),
    @apellido VARCHAR(20),
    @direccion_calle VARCHAR(15),
    @direccion_numero INT,
    @telefono VARCHAR(15),
    @dni VARCHAR(15),
    @email VARCHAR(50),
    @fecha_nacimiento DATE,
    @id_carrera INT
AS
BEGIN
    UPDATE Alumnos
    SET 
        nombre = @nombre,
        apellido = @apellido,
        direccion_calle = @direccion_calle,
        direccion_numero = @direccion_numero,
        telefono = @telefono,
        dni = @dni,
        email = @email,
        fecha_nacimiento = @fecha_nacimiento,
        id_carrera = @id_carrera
    WHERE matricula = @matricula;
END;


CREATE PROCEDURE SP_EliminarAlumno
    @matricula INT
AS
BEGIN
    DELETE FROM Alumnos
    WHERE matricula = @matricula;
END;


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
END;


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

select * from Materias

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

CREATE PROCEDURE SP_AgregarMateria
    @anio_cursada INT,
    @nombre_materia VARCHAR(30)
AS
BEGIN
    INSERT INTO Materias (anio_cursada, nombre_materia)
    VALUES (@anio_cursada, @nombre_materia);
END;



CREATE PROCEDURE SP_ActualizarMateria
    @id_materia INT,
    @anio_cursada INT,
    @nombre_materia VARCHAR(30)
AS
BEGIN
    UPDATE Materias
    SET 
        anio_cursada = @anio_cursada,
        nombre_materia = @nombre_materia
    WHERE id_materia = @id_materia;
END;




CREATE PROCEDURE SP_EliminarMateria
    @id_materia INT
AS
BEGIN
    DELETE FROM Materias
    WHERE id_materia = @id_materia;
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

CREATE PROCEDURE SP_BuscarAlumnosPorNombre
    @Nombre NVARCHAR,
	@Apellido NVARCHAR
AS
BEGIN
    SELECT *
    FROM Alumnos
    WHERE nombre LIKE '%' + @Nombre + '%' AND Apellido LIKE '%' + @Apellido + '%'
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




