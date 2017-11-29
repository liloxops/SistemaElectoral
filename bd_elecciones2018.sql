-- DROP DATABASE eleciones2018

CREATE DATABASE eleciones2018; 
GO
USE eleciones2018;
GO
CREATE TABLE candidato(
	id INT PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(100)
);
GO
CREATE TABLE usuario(
	id INT PRIMARY KEY IDENTITY(1,1),
	nombre VARCHAR(50),
	pass varchar(50)
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
CREATE TABLE votacion(
	id INT PRIMARY KEY IDENTITY(1,1),
	votoBlanco BIT,
	votoNulo BIT,
	votoCandidato BIT,
	fk_Candidato INT,
	fk_comuna INT,
	FOREIGN KEY (fk_Candidato) REFERENCES candidato(id),
	FOREIGN KEY (fk_comuna) REFERENCES comuna(id)
);
GO

--Insert--
INSERT INTO partido VALUES('Chile Vamos');
INSERT INTO partido VALUES('Unión Patriótica');
INSERT INTO partido VALUES('Partido Por la Democracia');
INSERT INTO partido VALUES('Independiente');
INSERT INTO partido VALUES('Partido Demócrata Cristiano');
INSERT INTO partido VALUES('Partido Progresista');
INSERT INTO partido VALUES('Frente Amplio');
INSERT INTO partido VALUES('Partido Pais');

insert into candidato values('Carolina Goic');
insert into candidato values('Jose Antonio Kast');
insert into candidato values('Sebastian Piñera');
insert into candidato values('Alejandro Guillier');
insert into candidato values('Beatriz Sanchez');
insert into candidato values('Marco Enriquez-Ominami');
insert into candidato values('Eduardo Artes');
insert into candidato values('Alejandro Navarro');

INSERT INTO genero VALUES('Masculino');
INSERT INTO genero VALUES('Femenino');


INSERT INTO region VALUES('Sexta Region');


INSERT INTO provincia VALUES('Cachapoal',1);
INSERT INTO provincia VALUES('Cardenal Caro',1);
INSERT INTO provincia VALUES('Colchagua',1);


INSERT INTO comuna VALUES('Rancagua',1);
INSERT INTO comuna VALUES('Codegua',1);
INSERT INTO comuna VALUES('Coinco',1);
INSERT INTO comuna VALUES('Coltauco',1);
INSERT INTO comuna VALUES('Doñihue',1);
INSERT INTO comuna VALUES('Graneros',1);
INSERT INTO comuna VALUES('Las Cabras',1);
INSERT INTO comuna VALUES('Machalí',1);
INSERT INTO comuna VALUES('Malloa',1);
INSERT INTO comuna VALUES('Mostazal',1);
INSERT INTO comuna VALUES('Olivar',1);
INSERT INTO comuna VALUES('Peumo',1);
INSERT INTO comuna VALUES('Pichidegua',1);
INSERT INTO comuna VALUES('Quinta de Tilcoco',1);
INSERT INTO comuna VALUES('Rengo',1);
INSERT INTO comuna VALUES('Requinoa',1);
INSERT INTO comuna VALUES('San Vicente de Tagua Tagua',1);


INSERT INTO comuna VALUES('Pichilemu',2);
INSERT INTO comuna VALUES('La Estrella',2);
INSERT INTO comuna VALUES('Litueche',2);
INSERT INTO comuna VALUES('Marchigüe',2);
INSERT INTO comuna VALUES('Navidad',2);
INSERT INTO comuna VALUES('Paredones',2);


INSERT INTO comuna VALUES('San Fernando',3);
INSERT INTO comuna VALUES('Chépica',3);
INSERT INTO comuna VALUES('Chimbarongo',3);
INSERT INTO comuna VALUES('lolol',3);
INSERT INTO comuna VALUES('Nancagua',3);
INSERT INTO comuna VALUES('Palmilla',3);
INSERT INTO comuna VALUES('Peralillo',3);
INSERT INTO comuna VALUES('Placilla',3);
INSERT INTO comuna VALUES('Pumanque',3);
INSERT INTO comuna VALUES('Santa Cruz',3);


select comuna.nombre from comuna where fk_Provincia = 2;

