CREATE DATABASE Ferreteria;

CREATE TABLE usuarios(
idusuario INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
nombre VARCHAR(100), 
apellidop VARCHAR(50),
apellidom VARCHAR(50),
fechanacimiento VARCHAR(50),
rfc VARCHAR(13),
usuario VARCHAR(50),
contrasena VARCHAR(50));

CREATE TABLE permisos(
acceso BOOLEAN,
agregar BOOLEAN,
editar BOOLEAN,
eliminar BOOLEAN,
visualizar BOOLEAN,
fkidusuario INT PRIMARY KEY,FOREIGN KEY(fkidusuario) REFERENCES usuarios(idusuario));

CREATE TABLE productos(
CodigoBarras INT PRIMARY KEY NOT NULL,
nombre VARCHAR(50),
descripción VARCHAR(50),
marca VARCHAR(50));
DROP TABLE productos;
CREATE TABLE herramientas(
CodigoHerramienta INT PRIMARY KEY NOT NULL,
nombre VARCHAR(50), 
medida VARCHAR(50), 
marca VARCHAR(50), 
descripción VARCHAR(50));
Select idusuario,nombre,apellidop,apellidom,fechanacimiento,rfc from usuarios;