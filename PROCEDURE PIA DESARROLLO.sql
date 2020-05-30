--SP PARA CONSULTAR TODO
CREATE PROCEDURE sp_Curso_Tema_ConsultarTodo
AS
BEGIN
	SELECT * FROM Curso_Tema
END

DROP PROCEDURE sp_Curso_Tema_ConsultarTodo;

--SP PARA CREAR UN CURSO_TEMA
CREATE PROCEDURE sp_Curso_Tema_Crear
@idCurso int,
@idTema int
AS
BEGIN
	INSERT INTO Curso_Tema
	VALUES(@idCurso, @idTema);
END

DROP PROCEDURE sp_Curso_Tema_Crear;

--SP PARA CONSULTAR POR ID Curso_Tema
CREATE PROCEDURE sp_Curso_Tema_ConsultarPorID
@IdCT int
AS
BEGIN
	SELECT * FROM Curso_Tema
	WHERE IdCT = @IdCT
END

--SP PARA ELIMINAR Curso_Tema
CREATE PROCEDURE sp_Curso_Tema_Eliminar
	@IdCT int
AS
BEGIN
	DELETE FROM Curso_Tema
	WHERE IdCT = @IdCT
END

--SP PARA ACTUALIZAR Curso_Tema
CREATE PROCEDURE sp_Curso_Tema_Actualizar
@IdCT int,
@IdCurso int,
@IdTema int
AS
BEGIN
	UPDATE Curso_Tema SET IdCurso=@IdCurso, IdTema=@IdTema
	WHERE IdCT=@IdCT
END

--INSERTS PARA TODAS LAS TABLAS
SELECT * FROM Empleado
--INSERT DE *EMPLEADO*
INSERT INTO Empleado
VALUES('Juan Carlos', 'Valle los Olivos 337');

INSERT INTO Empleado
VALUES('Jose Antonio', 'Lincoln 889');

INSERT INTO Empleado
VALUES('Maria Vazquez', 'Valle verde 794');

INSERT INTO Empleado
VALUES('Daniel Hernandez', 'Residencial Cumbres 761');

INSERT INTO Empleado
VALUES('Carmen Soto', 'Los campos 825');

SELECT * FROM Tema;
--INSERT DE *TEMA*
INSERT INTO Tema
VALUES('Interes compuesto');

INSERT INTO Tema
VALUES('Introduccion de MVC');

INSERT INTO Tema
VALUES('Curso Intensivo y practico sobre MySQL');

INSERT INTO Tema
VALUES('Introduccion a Macroeconomia');

INSERT INTO Tema
VALUES('Introduccion a SCRUM');

select * from Video;
--INSERT DE *VIDEO*
INSERT INTO Video
VALUES('Matemáticas Financieras (Parte 1). Interés compuesto', 'https://www.youtube.com/embed/QIIEvplcB7k', 11-06-2017);

INSERT INTO Video
VALUES('01.- Curso de ASP.NET MVC 4 C#(Csharp). Visual Studio. Introducción. MVC. Aplicación', 'https://www.youtube.com/embed/LxpsTYFanx4', 29-08-2014);

INSERT INTO Video
VALUES('Curso MySQL - Curso Intensivo y Práctico', 'https://www.youtube.com/embed/e8gaffa3Ca8', 07-05-2019);

INSERT INTO Video
VALUES('Que Es Macroeconomía ?', 'https://www.youtube.com/embed/2hOFQReroTc', 11-06-2017);

INSERT INTO Video
VALUES('¿Qué es la metodología Scrum?', 'https://www.youtube.com/embed/a33xOe9d_Dk', 25-06-2016);

SELECT * FROM Curso;
--INSERT PARA *CURSO*
INSERT INTO Curso
VALUES('Matematicas Financieras', 1);

INSERT INTO Curso
VALUES('Desarrollo De Software ASP.NET', 2);

INSERT INTO Curso
VALUES('Base de Datos 3', 3);

INSERT INTO Curso
VALUES('Economia', 4);

INSERT INTO Curso
VALUES('Sistemas de Informacion 2', 5);

SELECT * FROM Curso_Tema;
--INSERT DE *CURSO_TEMA*
EXECUTE sp_Curso_Tema_Crear 1,1;

EXECUTE sp_Curso_Tema_Crear 2,2;

EXECUTE sp_Curso_Tema_Crear 3,3;

EXECUTE sp_Curso_Tema_Crear 4,4;

EXECUTE sp_Curso_Tema_Crear 5,5;

SELECT * FROM Curso_Tema_Video;
--INSERT DE *CURSO_TEMA_VIDEO*
INSERT INTO Curso_Tema_Video
VALUES(1, 1);

INSERT INTO Curso_Tema_Video
VALUES(2, 2);

INSERT INTO Curso_Tema_Video
VALUES(3, 3);

INSERT INTO Curso_Tema_Video
VALUES(4, 4);

INSERT INTO Curso_Tema_Video
VALUES(5, 5);

CREATE PROCEDURE sp_Video_Agregar
@Nombre nvarchar(200),
@Url nvarchar(100),
@FechaPublicacion datetime
AS
BEGIN
INSERT INTO Video VALUES (@Nombre,@Url,@FechaPublicacion)
END;

CREATE PROCEDURE sp_Video_Borrar
@IdVideo int
AS
BEGIN
DELETE FROM Video
WHERE IdVideo=@IdVideo
END;

CREATE PROCEDURE sp_Video_Modificar
@IdVideo int,
@Nombre nvarchar(200),
@Url nvarchar(100),
@FechaPublicacion datetime
AS
BEGIN
UPDATE Video SET Nombre=@Nombre, Url=@Url, FechaPublicacion=@FechaPublicacion
WHERE IdVideo=@IdVideo
END;

CREATE PROCEDURE sp_Video_ConsultarTodo
AS
BEGIN
SELECT * FROM Video
END

CREATE PROCEDURE sp_Video_ConsutlarPorId
@IdVideo int
AS
BEGIN
SELECT * FROM Video
WHERE IdVideo=@IdVideo
END;



CREATE PROCEDURE sp_Curso_Tema_Video_Agregar
@IdCT int,
@IdVideo int
AS
BEGIN
INSERT INTO Curso_Tema_Video VALUES (@IdCT, @IdVideo)
END;

CREATE PROCEDURE sp_Curso_Tema_Video_Borrar
@IdCTV int
AS
BEGIN
DELETE FROM Curso_Tema_Video
WHERE IdCTV=@IdCTV
END;

CREATE PROCEDURE sp_Curso_Tema_Video_Modificar
@IdCTV int,
@IdCT int,
@IdVideo int
AS
BEGIN
UPDATE Curso_Tema_Video SET IdCT=@IdCT,IdVideo= @IdVideo
WHERE IdCTV=@IdCTV
END;

CREATE PROCEDURE sp_Curso_Tema_Video_ConsultarTodo
AS
BEGIN
SELECT * FROM Curso_Tema_Video
END;

CREATE PROCEDURE sp_Curso_Tema_Video_ConsultarPorId
@IdCTV int
AS
BEGIN
SELECT * FROM Curso_Tema_Video
WHERE IdCTV=@IdCTV
END;



--sp de EMPLEADO

go
CREATE PROCEDURE sp_Empleadoo_Insertar
	@Nombre nvarchar(200),
	@Direccion nvarchar(100)
AS
BEGIN
	INSERT INTO Empleado(Nombre, Direccion)
	VALUES(@Nombre,@Direccion)
END;
GO

go
CREATE PROCEDURE sp_Empleadoo_ConsultarTodo
AS
BEGIN
	SELECT * FROM Empleado
END;
go

go
CREATE PROCEDURE sp_Empleadoo_ConsultarPorID
@IdEmpleado int
AS
BEGIN
	SELECT * FROM Empleado
	WHERE IdEmpleado = @IdEmpleado
END;
go

GO
CREATE PROCEDURE sp_Empleadoo_Eliminar
	@IdEmpleado int
AS
BEGIN
	DELETE FROM Empleado
	WHERE IdEmpleado = @IdEmpleado
END;
go

GO
CREATE PROCEDURE sp_Empleadoo_Actualizar
	@IdEmpleado int,
	@Nombre nvarchar(200),
	@Direccion nvarchar(100)
AS
BEGIN
	UPDATE Empleado SET Nombre=@Nombre,Direccion = @Direccion
	WHERE IdEmpleado = @IdEmpleado
END;
Go



--sp de CURSO
CREATE PROCEDURE sp_Curso_Agregar
@Descripcion nvarchar(200),
@IdEmpleado int
AS
BEGIN
INSERT INTO Curso VALUES (@Descripcion,@IdEmpleado)
END;

CREATE PROCEDURE sp_Curso_Borrar
@IdCurso int
AS
BEGIN
DELETE FROM Curso
WHERE IdCurso=@IdCurso
END;

CREATE PROCEDURE sp_Curso_Modificar
@IdCurso int,
@Descripcion nvarchar(200),
@IdEmpleado int
AS
BEGIN
UPDATE Curso SET Descripcion=@Descripcion, IdEmpleado=@IdEmpleado
WHERE IdCurso=@IdCurso
END;

CREATE PROCEDURE sp_Curso_ConsultarTodo
AS
BEGIN
SELECT * FROM Curso
END;

CREATE PROCEDURE sp_Curso_ConsultarPorId
@IdCurso int
AS
BEGIN
SELECT * FROM Curso
WHERE IdCurso=@IdCurso
END;

--sp Tema

CREATE PROCEDURE sp_Tema_Insertar	
	@Nombre VARCHAR(100)
AS
BEGIN
	INSERT INTO Tema
	VALUES(@Nombre)
END


CREATE PROCEDURE sp_Tema_Actualizar
	@idTema INT,
	@Nombre VARCHAR(100)
AS
BEGIN
	UPDATE Tema
	SET Nombre=@Nombre
	WHERE idTema=@idTema
END


CREATE PROCEDURE sp_Tema_Eliminar
	@idTema INT
AS
BEGIN
	DELETE FROM Tema
	WHERE idTema=@idTema
END

CREATE PROCEDURE sp_Tema_ConsultarTodo
AS
BEGIN
   select * from Tema
END

CREATE PROCEDURE sp_Tema_ConsultarPorID
    @idTema INT
AS
BEGIN
   select * from Tema
   WHERE @idTema=IdTema
END


