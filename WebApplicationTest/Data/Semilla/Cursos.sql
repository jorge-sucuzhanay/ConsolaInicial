﻿insert into Curso(Nombre,NumeroCreditos) values ('POO',80);
insert into Curso(Nombre,NumeroCreditos) values ('Asp.Net core 5.0',110);
insert into Curso(Nombre,NumeroCreditos) values ('Angular',90);

--opcion 2 
SET IDENTITY_INSERT Curso ON
insert into Curso(Nombre,NumeroCreditos) values ('POO',80);
insert into Curso(Nombre,NumeroCreditos) values ('Asp.Net core 5.0',110);
insert into Curso(Nombre,NumeroCreditos) values ('Angular',90);
SET IDENTITY_INSERT Curso OFF
SET IDENTITY_INSERT Empleados ON
insert into Empleados(EmpleadoId,Nombre,Apellido,Salario,Nacimiento) values (1,'Josue','Mosquera',500,'09/11/1998');
SET IDENTITY_INSERT Empleados OFF
insert into CursoEmpleado(CursosTomadosCursoId,ParticipantesEmpleadoId) values (1,1);