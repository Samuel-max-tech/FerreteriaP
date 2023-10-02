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
nombrep VARCHAR(50),
descripcionp VARCHAR(50),
marcap VARCHAR(50));

DROP TABLE productos;
DROP TABLE herramientas;

CREATE TABLE herramientas(
CodigoHerramienta INT PRIMARY KEY NOT NULL,
nombreh VARCHAR(50), 
medidah VARCHAR(50), 
marcah VARCHAR(50), 
descripcionh VARCHAR(50));


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

DROP PROCEDURE if EXISTS p_permisos;
delimiter //
CREATE PROCEDURE p_Permisos(
IN _usuario VARCHAR(100)
)
BEGIN 
DECLARE _acceso BOOLean;
DECLARE _agregar BOOLean;
DECLARE _editar BOOLean;
DECLARE _eliminar BOOLean;
DECLARE _visualizar BOOlean;

SELECT p.acceso
FROM usuarios u 
JOIN permisos p ON  u.idusuario = p.fkidusuario 
WHERE _usuario  = u.usuario INTO _acceso;

SELECT p.agregar
FROM usuarios u 
JOIN permisos p ON  u.idusuario = p.fkidusuario 
WHERE _usuario  = u.usuario INTO _agregar;

SELECT p.editar
FROM usuarios u 
JOIN permisos p ON  u.idusuario = p.fkidusuario 
WHERE _usuario  = u.usuario INTO _editar;

SELECT p.eliminar
FROM usuarios u 
JOIN permisos p ON  u.idusuario = p.fkidusuario 
WHERE _usuario  = u.usuario INTO _eliminar;

SELECT p.visualizar
FROM usuarios u 
JOIN permisos p ON  u.idusuario = p.fkidusuario 
WHERE _usuario  = u.usuario INTO _visualizar;

SELECT CONCAT(_acceso,',',_agregar,',',_editar,',',_eliminar,',',_visualizar) AS rs;

END;
//

SELECT p.acceso,p.agregar,p.editar,p.eliminar,p.visualizar
FROM usuarios u 
JOIN permisos p ON  u.idusuario = p.fkidusuario 1
WHERE u.usuario = 'Pepe';

CALL p_permisos('Samuel');

SELECT * FROM usuarios WHERE usuario = 'LM';

SELECT * FROM permisos;

INSERT INTO permisos VALUES(true,true,true,TRUE,true,2);
INSERT INTO permisos VALUES(FALSE,FALSE,FALSE ,FALSE ,FALSE ,3);



CALL P_Validar(Admin)

SELECT usuario,contrasena FROM usuarios WHERE usuario = 'Samuel' AND contrasena = SHA1('1010');