--Crear Base de datos
Create database db_Proyecto
go

--Activar Base datos
use db_Proyecto
go

--Crear tabla Empleado

Create table dbo.Empleado
(
	dniEmpleado char(8) NOT NULL,
	nombre varchar(250) not null,
	apellido varchar(250) not null,
	cargo varchar(20) not null,
	direccion text null,
	celular char(9) not null UNIQUE,
	estado char(1)
	Primary key (dniEmpleado)
)
go

--Crear tabla Paciente

Create table dbo.Paciente
(
	dni char(8) not null, -- LLVE PRIMARIA NO SE ACTUALIZA POR LO QUE NO SE PONE UNIQUE
	nombre varchar(250) not null,  
	apellido varchar(250) not null,
	sexo char(1) not null,
	direccion text null,
	celular char(9) not null UNIQUE,
	estado char(1)
	Primary key (dni)
)
go

--Crear tabla Usuario

Create table dbo.Usuario
(
	usuario_id int identity (1,1) not null,
	dniEmpleado char(8) NOT NULL, 
	usuario varchar(20) not null,
	clave varchar (20) not null,
	estado char(1),
	Primary key (usuario_id),
	foreign key (dniEmpleado) references Empleado(dniEmpleado)
)
go

--CrearTablas
--Crear tabla Diagnostico
Create table dbo.Diagnostico
(
	diagnostico_id int not null,  -- se le indica que siempre debe tener un valor. //identity hace que la variable sea autoincrementable
	dniEmpleado char(8) not null,  
	dni char(8) not null,
	fecha varchar(20) not null,
	enfermedad varchar(20) not null,
	Primary key (diagnostico_id),
	foreign key (dniEmpleado) references Empleado(dniEmpleado),
	foreign key (dni) references Paciente(dni)
)
go

--Crear tabla Detalle Diagnostico

Create table dbo.Detalle_Diagnostico
(
	diagnostico_id int not null,
	sintoma varchar(250) not null
	foreign key (diagnostico_id) references Diagnostico(diagnostico_id)
)
go

--Crear tabla Enfermedad_Posible

Create table dbo.Enfermedad_Posible
(
	diagnostico_id int not null,
	pos_enfermedad varchar(20) not null,
	foreign key (diagnostico_id) references Diagnostico(diagnostico_id)
)
go


