--Activar Base datos
use db_Proyecto
go

--PROCEDIMIENTOS ALMACENADOS
--- PROCEDIMIENTOS PARA LA TABLA EMPLEADO

--PROCEDIMIENTO INSERTAR

CREATE PROCEDURE USP_Empleado_I
@pdni char(8),
@pnombre varchar(250),
@papellido varchar(250),
@pcargo varchar(20),
@pdireccion text,
@pcelular char(9),
@pestado char(1)
AS
BEGIN
 BEGIN TRAN
  BEGIN TRY
  INSERT INTO Empleado(dniEmpleado,nombre,apellido,cargo,direccion,celular,estado)
  VALUES (@pdni, @pnombre,@papellido,@pcargo,@pdireccion,@pcelular,@pestado)
   COMMIT 
    END TRY
	 BEGIN CATCH
	 ROLLBACK
	END CATCH
   END
GO

--PROCEDIMIENTOS ACTUALIZAR
CREATE PROCEDURE USP_Empleado_U
@pdni char(8),
@pnombre varchar(250),
@papellido varchar(250),
@pcargo varchar(20),
@pdireccion text,
@pcelular char(9),
@pestado char(1)
AS
BEGIN
 BEGIN TRAN
  BEGIN TRY
  UPDATE Empleado SET
  nombre = @pnombre,
  apellido = @papellido,
  cargo = @pcargo,
  direccion = @pdireccion,
  celular = @pcelular,
  estado = @pestado
  WHERE dniEmpleado = @pdni
   COMMIT 
    END TRY
	 BEGIN CATCH
	 ROLLBACK
	END CATCH
   END
   GO



--PROCEDIMIENTO ELIMINAR
CREATE PROCEDURE USP_Empleado_D
@pdni char(8) 
AS
BEGIN
 BEGIN TRAN
  BEGIN TRY
  DELETE FROM Empleado WHERE dniEmpleado = @pdni
   COMMIT 
    END TRY
	 BEGIN CATCH
	 ROLLBACK
	END CATCH
   END
GO


--PROCEDIMIENTO LISTAR
CREATE PROCEDURE USP_Empleado_S
AS
BEGIN
  -- SELECT * FROM Semestre
SELECT * FROM Empleado
   END
GO


--PROCEDIMIENTO BUSQUEDA

CREATE PROCEDURE USP_Empleado_S_Busqueda
@pbusqueda varchar(250)
AS
BEGIN

 SELECT * FROM Empleado
 WHERE
 dniEmpleado LIKE '%'+ @pbusqueda +'%'
   END
GO

--PROCEDIMIENTO Activar

Create procedure USP_Empleado_Activar 
	@pdni int
As
BEGIN
	BEGIN TRAN
		BEGIN TRY
			update Empleado set
			estado='A'  --activo
			WHERE dniEmpleado = @pdni
		COMMIT
		END TRY
			BEGIN CATCH
			 ROLLBACK
			END CATCH
	
END
Go

--PROCEDIMIENTO Desactivar
Create procedure USP_Empleado_Desactivar 
	@pdni int
As
BEGIN
	BEGIN TRAN
		BEGIN TRY
			update Empleado set
			estado='I' --inactivo
			WHERE dniEmpleado = @pdni
		COMMIT
		END TRY
			BEGIN CATCH
			 ROLLBACK
			END CATCH
	
END
Go

--PROCEDIMIENTO Verificar si existe o no un registro
Create procedure USP_Empleado_Verificar
	@pvalor varchar(100),  -- parametro tipo entrada
	@pexiste bit output  --parametro de salida
As
BEGIN
	BEGIN TRAN
		BEGIN TRY
			
			if Exists (select dniEmpleado from Empleado where dniEmpleado= LTRIM(rtrim (@pvalor)))
			begin
				set @pexiste=1
			end
			else
				begin
					set @pexiste=0
				end
		COMMIT
		END TRY
			BEGIN CATCH
			 ROLLBACK
			END CATCH
	
END
Go


--  TABLA USUARIO
--PROCEDIMIENTO INSERTAR
CREATE PROCEDURE USP_Usuario_I
@pdni char(8),
@pusuario varchar(20),
@pclave varchar(20),
@pestado char(1)
AS
BEGIN
 BEGIN TRAN
  BEGIN TRY
  INSERT INTO Usuario(dniEmpleado,usuario,clave,estado)
  VALUES (@pdni,@pusuario,@pclave,@pestado)
   COMMIT 
    END TRY
	 BEGIN CATCH
	 ROLLBACK
	END CATCH
   END
GO

--PROCEDIMIENTOS ACTUALIZAR
CREATE PROCEDURE USP_Usuario_U
@pusuario_id int,
@pdni int,
@pusuario varchar(20),
@pclave varchar(20),
@pestado char(1)
AS
BEGIN
 BEGIN TRAN
  BEGIN TRY
  UPDATE Usuario SET
	dniEmpleado = @pdni,
	usuario = @pusuario,
	clave = @pclave,
	estado = @pestado
  WHERE usuario_id = @pusuario_id
   COMMIT 
    END TRY
	 BEGIN CATCH
	 ROLLBACK
	END CATCH
   END
   GO

--PROCEDIMIENTO ELIMINAR
CREATE PROCEDURE USP_Usuario_D

@pusuario_id int
AS
BEGIN
 BEGIN TRAN
  BEGIN TRY
  DELETE FROM Usuario WHERE usuario_id = @pusuario_id
   COMMIT 
    END TRY
	 BEGIN CATCH
	 ROLLBACK
	END CATCH
  END
GO

----PROCEDIMIENTO LISTAR
CREATE PROCEDURE USP_Usuario_S
AS
BEGIN
  -- SELECT * FROM Usuario
SELECT * FROM Usuario
   END
   GO

--PROCEDIMIENTO BUSQUEDA
CREATE PROCEDURE USP_Usuario_S_Busqueda
@pbusqueda varchar(250)
AS
BEGIN

 SELECT * FROM Usuario
 WHERE
 dniEmpleado LIKE '%'+ @pbusqueda +'%'
  END
GO

--PROCEDIMIENTO Activar
Create procedure USP_Usuario_Activar 
	@pusuario_id int
As
BEGIN
	BEGIN TRAN
		BEGIN TRY
			update Usuario set
			estado='A'  --activo
			WHERE usuario_id = @pusuario_id
		COMMIT
		END TRY
			BEGIN CATCH
			 ROLLBACK
			END CATCH
	
END
Go

--PROCEDIMIENTO Desactivar
Create procedure USP_Usuario_Desactivar 
	@pusuario_id int
As
BEGIN
	BEGIN TRAN
		BEGIN TRY
			update Usuario set
			estado='I' --inactivo
			WHERE usuario_id = @pusuario_id
		COMMIT
		END TRY
			BEGIN CATCH
			 ROLLBACK
			END CATCH
END
Go

--PROCEDIMIENTO Verificar si existe o no un registro
Create procedure USP_Usuario_Verificar
	@pvalor varchar(100),  -- parametro tipo entrada
	@pexiste bit output  --parametro de salida
As
BEGIN
	BEGIN TRAN
		BEGIN TRY
			
			if Exists (select dniEmpleado from Usuario where dniEmpleado= LTRIM(rtrim (@pvalor)))
			begin
				set @pexiste=1
			end
			else
				begin
					set @pexiste=0
				end
		COMMIT
		END TRY
			BEGIN CATCH
			 ROLLBACK
			END CATCH
	
END
Go



--  TABLA PACIENTE
--PROCEDIMIENTO INSERTAR
CREATE PROCEDURE USP_Paciente_I
@pdni char(8),
@pnombre varchar(250),
@papellido varchar(250),
@psexo char(1),
@pdireccion text,
@pcelular char(9),
@pestado char(1)
AS
BEGIN
 BEGIN TRAN
  BEGIN TRY
  INSERT INTO Paciente(dni,nombre,apellido,sexo,direccion,celular,estado)
  VALUES (@pdni,@pnombre,@papellido,@psexo,@pdireccion,@pcelular,@pestado)
   COMMIT 
    END TRY
	 BEGIN CATCH
	 ROLLBACK
	END CATCH
   END
GO

--PROCEDIMIENTOS ACTUALIZAR
CREATE PROCEDURE USP_Paciente_U
@pdni char(8),
@pnombre varchar(250),
@papellido varchar(250),
@psexo char(1),
@pdireccion text,
@pcelular char(9),
@pestado char(1)
AS
BEGIN
 BEGIN TRAN
  BEGIN TRY
  UPDATE Paciente SET
	nombre = @pnombre,
	apellido = @papellido,
	sexo = @psexo,
	direccion = @pdireccion,
	celular = @pcelular,
	estado = @pestado
  WHERE dni = @pdni
   COMMIT 
    END TRY
	 BEGIN CATCH
	 ROLLBACK
	END CATCH
   END
GO

--PROCEDIMIENTO ELIMINAR
CREATE PROCEDURE USP_Paciente_D
@pdni char (8)
AS
BEGIN
 BEGIN TRAN
  BEGIN TRY
  DELETE FROM Paciente WHERE dni = @pdni
   COMMIT 
    END TRY
	 BEGIN CATCH
	 ROLLBACK
	END CATCH
   END
GO

----PROCEDIMIENTO LISTAR
CREATE PROCEDURE USP_Paciente_S
AS
BEGIN
  -- SELECT * FROM Persona
SELECT * FROM Paciente
   END
GO

--PROCEDIMIENTO BUSQUEDA
CREATE PROCEDURE USP_Paciente_S_Busqueda
@pbusqueda varchar(250)
AS
BEGIN

 SELECT * FROM Paciente
 WHERE
 dni LIKE '%'+ @pbusqueda +'%'
  END
GO

--PROCEDIMIENTO BUSQUEDA
CREATE PROCEDURE USP_Paciente_S_Busqueda_PD
@pbusqueda varchar(250)
AS
BEGIN

 SELECT dni,nombre,apellido,direccion,celular,estado FROM Paciente
 WHERE
 dni = @pbusqueda
 END
GO



--PROCEDIMIENTO Activar
Create procedure USP_Paciente_Activar 
	@pdni char (8)
As
BEGIN
	BEGIN TRAN
		BEGIN TRY
			update Paciente set
			estado='A'  --activo
			WHERE dni = @pdni
		COMMIT
		END TRY
			BEGIN CATCH
			 ROLLBACK
			END CATCH
END
Go

--PROCEDIMIENTO Desactivar
Create procedure USP_Paciente_Desactivar 
	@pdni char (8)
As
BEGIN
	BEGIN TRAN
		BEGIN TRY
			update Paciente set
			estado='I' --inactivo
			WHERE dni = @pdni
		COMMIT
		END TRY
			BEGIN CATCH
			 ROLLBACK
			END CATCH
END
Go

--PROCEDIMIENTO Verificar si existe o no un registro
Create procedure USP_Paciente_Verificar
	@pvalor varchar(100),  -- parametro tipo entrada
	@pexiste bit output  --parametro de salida
As
BEGIN
	BEGIN TRAN
		BEGIN TRY
			
			if Exists (select dni from Paciente where dni= LTRIM(rtrim (@pvalor)))
			begin
				set @pexiste=1
			end
			else
				begin
					set @pexiste=0
				end
		COMMIT
		END TRY
			BEGIN CATCH
			 ROLLBACK
			END CATCH
	
END
Go

--- PROCEDIMIENTOS PARA LA TABLA DIAGNOSTICO
--PROCEDIMIENTO INSERTAR
CREATE PROCEDURE USP_Diagnostico_I
@diagnostico_id int,
@pdniempleado char(8),
@pdni char(8),
@pfecha varchar(20),
@penfermedad varchar(20)
AS
BEGIN
 BEGIN TRAN
  BEGIN TRY
  INSERT INTO Diagnostico(diagnostico_id,dniEmpleado, dni, fecha,enfermedad)
  VALUES (@diagnostico_id,@pdniempleado,@pdni,@pfecha,@penfermedad)
   COMMIT 
    END TRY
	 BEGIN CATCH
	 ROLLBACK
	END CATCH
   END
GO

--PROCEDIMIENTO ELIMINAR
CREATE PROCEDURE USP_Diagnostico_D
@pdiagnostico_id int
AS
BEGIN
 BEGIN TRAN
  BEGIN TRY
  DELETE FROM Diagnostico WHERE diagnostico_id = @pdiagnostico_id
   COMMIT 
    END TRY
	 BEGIN CATCH
	 ROLLBACK
	END CATCH
   END
GO

--Procedimiento Listar -- Empleado
CREATE PROCEDURE USP_Diagnostico_S
@pestado char(1)
AS
BEGIN
    select D.diagnostico_id, E.cargo, E.nombre, E.apellido, P.dni, P.apellido, P.nombre, D.fecha from Diagnostico D, Empleado E, Paciente P 
where D.dniEmpleado = E.dniEmpleado and D.dni = P.dni 
END
GO


--Procedimiento Listar -- Administrador
CREATE PROCEDURE USP_Diagnostico_S_A
AS
BEGIN
select D.diagnostico_id, E.cargo, E.nombre, E.apellido, P.dni, P.apellido, P.nombre, D.fecha from Diagnostico D, Empleado E, Paciente P 
where D.dniEmpleado = E.dniEmpleado and D.dni = P.dni 
END
GO


--- PROCEDIMIENTOS PARA LA TABLA ENFERMEDAD_POSIBLE
--PROCEDIMIENTO INSERTAR
CREATE PROCEDURE USP_Enfermedad_Posible_I
@pdiagnostico_id int,
@ppos_enfermedad varchar(20)

AS
BEGIN
 BEGIN TRAN
  BEGIN TRY
  INSERT INTO Enfermedad_Posible(diagnostico_id,pos_enfermedad)
  VALUES (@pdiagnostico_id,@ppos_enfermedad)
   COMMIT 
    END TRY
	 BEGIN CATCH
	 ROLLBACK
	END CATCH
   END
GO


--PROCEDIMIENTO ELIMINAR
CREATE PROCEDURE USP_Enfermedad_Posible_D
@pdiagnostico_id int
AS
BEGIN
 BEGIN TRAN
  BEGIN TRY
  DELETE FROM Enfermedad_Posible WHERE diagnostico_id = @pdiagnostico_id
   COMMIT 
    END TRY
	 BEGIN CATCH
	 ROLLBACK
	END CATCH
   END
GO

--- PROCEDIMIENTOS PARA LA TABLA DETALLE_DIAGNOSTICO
--PROCEDIMIENTO INSERTAR
CREATE PROCEDURE USP_Detalle_Diagnostico_I
@pdiagnostico_id int,
@psintoma varchar(20)
AS
BEGIN
 BEGIN TRAN
  BEGIN TRY
  INSERT INTO Detalle_Diagnostico(diagnostico_id,sintoma)
  VALUES (@pdiagnostico_id,@psintoma)
   COMMIT 
    END TRY
	 BEGIN CATCH
	 ROLLBACK
	END CATCH
   END
GO

--PROCEDIMIENTO ACTUALIZAR
CREATE PROCEDURE USP_Detalle_Diagnostico_U
@pdiagnostico_id int,
@psintoma varchar(20)
AS
BEGIN
 BEGIN TRAN
  BEGIN TRY
    UPDATE Detalle_Diagnostico SET
	sintoma = @psintoma
	WHERE diagnostico_id = @pdiagnostico_id
  COMMIT
  END TRY
   BEGIN CATCH
    ROLLBACK
   END CATCH
END
GO

--PROCEDIMIENTO ELIMINAR
CREATE PROCEDURE USP_Detalle_Diagnostico_D
@pdiagnostico_id int
AS
BEGIN
 BEGIN TRAN
  BEGIN TRY
  DELETE FROM Detalle_Diagnostico WHERE diagnostico_id = @pdiagnostico_id
   COMMIT 
    END TRY
	 BEGIN CATCH
	 ROLLBACK
	END CATCH
   END
GO



--Procedimiento Login
CREATE PROCEDURE USP_Usuario_Login
	@pusuario varchar(50),
	@ppassword varchar(50)

AS
BEGIN
	BEGIN TRAN
		BEGIN TRY
		SELECT u.usuario_id, e.apellido, e.nombre, e.cargo, u.estado, u.dniEmpleado
		FROM Usuario as u
		INNER JOIN Empleado as e
		ON u.dniEmpleado = e.dniEmpleado
		WHERE u.usuario = @pusuario AND u.clave = @ppassword
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO


--Procedimiento Verificar Login
CREATE PROCEDURE USP_Usuario_Login_V
	@pbusqueda varchar(50)
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY		
			SELECT dniEmpleado FROM Usuario
			WHERE dniempleado = @pbusqueda
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO


CREATE PROCEDURE USP_Grafico
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY		
			select count(*) from Diagnostico 
			where enfermedad = 'anemia'
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO


CREATE PROCEDURE USP_Grafico2
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY		
			select count(*) from Diagnostico 
			where enfermedad = 'gripe'
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO


CREATE PROCEDURE USP_Grafico3
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY		
			select count(*) from Diagnostico 
			where enfermedad = 'A-H1N1'
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO


CREATE PROCEDURE USP_Grafico4
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY		
			select count(*) from Diagnostico 
			where enfermedad = 'rubeola'
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO


CREATE PROCEDURE USP_Grafico5
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY		
			select count(*) from Diagnostico 
			where enfermedad = 'dengue'
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO


CREATE PROCEDURE USP_Grafico6
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY		
			select count(*) from Diagnostico 
			where enfermedad = 'neumonia'
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO



CREATE PROCEDURE USP_Grafico7
AS
BEGIN
	BEGIN TRAN
		BEGIN TRY		
			select count(*) from Diagnostico 
			where enfermedad = 'covid-19'
	COMMIT
	END TRY
	BEGIN CATCH
		ROLLBACK
	END CATCH
END
GO

--PROCEDIMIENTO BUSQUEDA - Diagnostico
CREATE PROCEDURE USP_Diagnostico_S_Busqueda
@pbusqueda varchar(250)
AS
BEGIN
select D.diagnostico_id, E.cargo, E.nombre, E.apellido, P.dni, P.apellido, P.nombre, D.fecha from Diagnostico D, Empleado E, Paciente P 
where D.dniEmpleado = E.dniEmpleado and D.dni = P.dni and P.dni = @pbusqueda
 END
GO
