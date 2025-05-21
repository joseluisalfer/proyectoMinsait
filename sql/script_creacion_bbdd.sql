CREATE DATABASE eco_eventos CHARACTER SET UTF8;
USE eco_eventos;

CREATE TABLE Categorias (
	id INT AUTO_INCREMENT PRIMARY KEY,
	nombre VARCHAR(100) NOT NULL
);

CREATE TABLE Ubicaciones (
	id INT AUTO_INCREMENT PRIMARY KEY,
	tipo 	ENUM('online', 'presencial') NOT NULL,
	direccion VARCHAR(255) NOT NULL
);

CREATE TABLE Organizadores(
	id INT AUTO_INCREMENT PRIMARY KEY,
	nombre VARCHAR(100) NOT NULL,
	email VARCHAR(255) NOT NULL,
	telefono VARCHAR(20)
);

CREATE TABLE Usuarios (
	id INT AUTO_INCREMENT PRIMARY KEY,
	nombre VARCHAR(100) NOT NULL,
	email VARCHAR(255) NOT NULL,
	contraseña VARCHAR(255) NOT NULL
);

CREATE TABLE Eventos (
	id INT AUTO_INCREMENT PRIMARY KEY,
	nombre VARCHAR(200) NOT NULL,
	descripcion VARCHAR(255),
	fecha DATE NOT NULL,
	duracion_horas INT NOT NULL,
	id_ubicacion INT NOT NULL,
	id_organizador INT NOT NULL,
	id_categoria INT NOT NULL,
	estado BOOL NOT NULL,
	FOREIGN KEY (id_ubicacion) REFERENCES Ubicaciones(id),
	FOREIGN KEY (id_categoria) REFERENCES Categorias(id),
   FOREIGN KEY (id_organizador) REFERENCES Organizadores(id)
);

CREATE TABLE Inscripciones (
	id INT AUTO_INCREMENT PRIMARY KEY,
	id_usuario INT NOT NULL,
   id_evento INT NOT NULL,
   fecha_inscripcion DATETIME NOT NULL,
   FOREIGN KEY (id_usuario) REFERENCES Usuarios(id),
   FOREIGN KEY (id_evento) REFERENCES Eventos(id)
);