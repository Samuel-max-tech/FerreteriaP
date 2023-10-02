CREATE DATABASE Ferreteria;

INSERT INTO usuarios VALUES(NULL,'Samuel','Martin','Munoz','18 de Junio del 2003','asdasdas','samuel',SHA1('si'),TRUE,TRUE,TRUE,TRUE,TRUE);
CREATE TABLE usuarios(
idusuario INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
nombre VARCHAR(100), 
apellidop VARCHAR(50),
apellidom VARCHAR(50),
fechanacimiento VARCHAR(50),
rfc VARCHAR(13),
usuario VARCHAR(50),
contrasena VARCHAR(50),
acceso BOOLEAN,
agregar BOOLEAN,
editar BOOLEAN,
eliminar BOOLEAN,
visualizar BOOLEAN);

DROP TABLE usuarios;

CREATE TABLE productos(
CodigoBarras INT PRIMARY KEY NOT NULL,
nombrep VARCHAR(50),
descripcionp VARCHAR(50),
marcap VARCHAR(50));

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
DELIMITER //
CREATE PROCEDURE P_Permisos(
    IN _usuario VARCHAR(100)
)
BEGIN 
    DECLARE _acceso BOOLEAN;
    DECLARE _agregar BOOLEAN;
    DECLARE _editar BOOLEAN;
    DECLARE _eliminar BOOLEAN;
    DECLARE _visualizar BOOLEAN;

    SELECT acceso, agregar, editar, eliminar, visualizar 
    INTO _acceso, _agregar, _editar, _eliminar, _visualizar
    FROM usuarios 
    WHERE usuario = _usuario;

    SELECT CONCAT(_acceso, ',', _agregar, ',', _editar, ',', _eliminar, ',', _visualizar) AS rs;
END;
//

CALL P_Permisos('LM');

SELECT * FROM usuarios WHERE usuario = 'LM';

SELECT * FROM permisos;

INSERT 



CALL P_Validar(Admin)

SELECT usuario,contrasena FROM usuarios WHERE usuario = 'Samuel' AND contrasena = SHA1('1010');