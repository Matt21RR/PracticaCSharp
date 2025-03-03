drop database if exists csharp;
create database csharp;

-- Crear la tabla Persona
drop table if exists Persona;
create table Persona (
    ID bigint primary key,
    nombres varchar(255) not null,
    apellidos varchar(255) not null,
    email varchar(255) not null
);

-- Crear la tabla Facultad
drop table if exists facultad;
create table Facultad (
    ID bigint primary key,
    nombre varchar(255) not null,
    decano_ID bigint not null,
    foreign key (decano_ID) references Persona(ID)
);

-- Crear la tabla Programa
drop table if exists Programa;
create table Programa (
    ID bigint primary key,
    nombre varchar(255) not null,
    duracion DOUBLE not null,
    registro DATE not null,
    facultad_ID bigint not null,
    foreign key (facultad_ID) references Facultad(ID)
);

-- Crear la tabla Estudiante
drop table if exists Estudiante;
create table Estudiante (
    codigo bigint primary key,
    programa_ID bigint not null,
    activo boolean not null,
    promedio bigint not null,
    ID bigint not null,
    foreign key (ID) references Persona(ID),
    foreign key (programa_ID) references Programa(ID)
);

-- Crear la tabla Profesor
drop table if exists Profesor;
create table Profesor (
    ID bigint primary key,
    TipoContrato varchar(255) not null,
    foreign key (ID) references Persona(ID)
);

-- Crear la tabla Curso
drop table if exists Curso;
create table Curso (
    ID bigint primary key,
    nombre varchar(255) not null,
    programa_ID bigint not null,
    activo boolean not null,
    foreign key (programa_ID) references Programa(ID)
);

-- Crear la tabla Inscripción
drop table if exists Inscripcion;
create table Inscripcion (
    curso_ID bigint not null,
    anio integer not null,
    semestre integer not null,
    estudiante_codigo bigint not null,
    primary key (curso_ID, anio, semestre, estudiante_codigo),
    foreign key (curso_ID) references Curso(ID),
    foreign key (estudiante_codigo) references Estudiante(codigo)
);

-- Crear la tabla CursoProfesor
drop table if exists CursoProfesor;
create table CursoProfesor (
    profesor_ID bigint not null,
    anio integer not null,
    semestre integer not null,
    curso_ID bigint not null,
    primary key (profesor_ID, anio, semestre, curso_ID),
    foreign key (profesor_ID) references Profesor(persona_ID),
    foreign key (curso_ID) references Curso(ID)
);