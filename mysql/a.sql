create table TPais (
	nPaisID numeric (3,0) not null unique,
	cNombre varchar (30) not null,
	primary key (nPaisID)
);
create table TEditorial (
	nEditorialID serial primary key,--Serial: id auto incremental
	cNombre varchar (40) not null,
	nPaisID numeric (3,0) default 170,
	foreign key (nPaisId) references TPais (nPaisID)
		on update cascade,--si el codigo de colombia cambia a 174, tambien cambiara a 174 aqui
		on delete no action --Si un registro esta usando una clave foranea de otra tabla
	--Se impedirá el borrado en la tabla referenciada si la clave está siendo usada en esta tabla
);
create table TSocio ( 
	cNIF char (9) primary key, --char:cadena de caracteres de longitu
	cNombre varchar (30) not null,--varchar: cadena de longitud variable
	cApellidos varchar (60) not null,
	cDireccion varchar (100),
	cTelefono char (12) not null,
	dNacimiento date not null,
	dAlta date not null check (dAlta >= '2010-01-01')
	--check: comprobar que el valor este campo sea mayor o igual a
);
create table TLibro (
	nLibroID numeric (4,0) primary key,
	cTitulo varchar (100) not null,
	nAnioPublicacion numeric (4,0) not null,
	nEditorialID int not null, -- int/integer: numero entero de 4 bytes
	foreign key (nEditorialID) references TEditorial (nEditorialID)	
);
create table TEjemplar (
	cSignatura varchar (15) primary key,
	nLibroID numeric (4,0) not null,
	foreign key (nLibroID) references TLibro (nLibroID)
);
create table TPrestamo (
	cSignatura varchar (15) not null,
	cNIF char (9) not null,
	dPrestamo date not null,
	primary key (cSignatura, cNIF, dPrestamo),--Clave compuesta de  los valores de 3 campos
	foreign key (cSignatura) references TEjemplar (cSignatura),
	foreign key (cNIF) references TSocio (cNIF)
);

create table TTema (
	nTemaID numeric (4,0) primary key,
	cNombre varchar (30) not null
);

create table TLibroTema (
	nLibroID numeric (4,0) not null,
	nTemaID numeric (4,0) not null,
	primary key (nLibroID, nTemaID),
	foreign key (nLibroID) references TLibro (nLibroID),
	foreign key (nTemaID) references TTema (nTemaID)
);

create table TAutor (
	nAutorID numeric (4,0) primary key,
	cNombre varchar (30) not null,
	cApellidos varchar (60) not null
);

create table TAutorPais (
	nAutorID numeric (4,0) not null,
	nPaisID numeric (3,0) not null,
	primary key(nAutorID, nPaisID),
	foreign key (nAutorID) references TAutor (nAutorID),
	foreign key (nPaisID) references TPais (nPaisID)
);

create table TLibroAutor (
	nLibroID numeric (4,0) not null,
	nAutorID numeric (4,0) not null,
	primary key(nLibroID, nAutorID),
	foreign key (nLibroID) references TLibro (nLibroID),
	foreign key (nAutorID) references TAutor (nAutorID)
);