CREATE DATABASE eleciones2018;
GO
USE eleciones2018;
GO
CREATE TABLE sector(
	id INT PRIMARY KEY IDENTITY(1,1),
	descripcion VARCHAR(50)
);
GO
CREATE TABLE partido(
	id INT PRIMARY KEY IDENTITY(1,1),
	descripcion VARCHAR(50),
	fk_Sector INT,
	FOREIGN KEY (fk_Sector) REFERENCES sector(id)
);
GO
CREATE TABLE candidato(
	id INT PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(100),
	fk_Partido INT,
	FOREIGN KEY (fk_Partido) REFERENCES partido(id)
);
GO
CREATE TABLE perfil(
	id INT PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(50)
);
GO
CREATE TABLE region(
	id INT PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(50)
);
GO
CREATE TABLE provincia(
	id INT PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(100),
	fk_Region INT,
	FOREIGN KEY (fk_Region) REFERENCES region(id)
);
GO
CREATE TABLE comuna(
	id INT PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(100),
	fk_Provincia INT,
	FOREIGN KEY (fk_Provincia) REFERENCES provincia(id)
);
GO
CREATE TABLE genero(
	id INT PRIMARY KEY IDENTITY(1,1),
	descripcion VARCHAR(50)
);
GO
CREATE TABLE persona(
	id INT PRIMARY KEY IDENTITY(1,1),
	rut VARCHAR(13),
	nombre VARCHAR(100),
	edad INT,
	fk_Genero INT,
	fk_Comuna INT,
	FOREIGN KEY (fk_Comuna) REFERENCES comuna(id),
	FOREIGN KEY (fk_Genero) REFERENCES genero(id)
);
CREATE TABLE votacion(
	id INT PRIMARY KEY IDENTITY(1,1),
	votoBlanco BIT,
	votoNulo BIT,
	votoCandidato BIT,
	fk_Candidato INT,
	fk_persona INT,
	FOREIGN KEY (fk_Candidato) REFERENCES candidato(id),
	FOREIGN KEY (fk_persona) REFERENCES persona(id)
);