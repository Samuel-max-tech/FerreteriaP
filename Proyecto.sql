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

CREATE TABLE herramientas(
CodigoHerramienta INT PRIMARY KEY NOT NULL,
nombre VARCHAR(50), 
medida VARCHAR(50), 
marca VARCHAR(50), 
descripción VARCHAR(50));

INSERT INTO Administradores VALUES(NULL,'luis',SHA1('12345'));

delimiter //
CREATE PROCEDURE P_Validar(
IN _usuario VARCHAR(100),
IN _contrasena VARCHAR(255)
)
BEGIN
DECLARE x INT;
SELECT COUNT(*) FROM usuarios WHERE usuario=_usuario AND contrasena=_contrasena INTO X;
if X>0 then
SELECT 'C0rr3ct0' AS rs;
ELSE
SELECT 'Error' AS rs;
END if;
END;
//


Select idusuario,nombre,apellidop,apellidom,fechanacimiento,rfc from usuarios;