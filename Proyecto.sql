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

delimiter //
CREATE PROCEDURE P_ValidarPermisos(
    IN usuario_id INT,
    IN permiso_acceso BOOLEAN,
    IN permiso_agregar BOOLEAN,
    IN permiso_editar BOOLEAN,
    IN permiso_eliminar BOOLEAN,
    IN permiso_visualizar BOOLEAN,
    OUT tiene_permisos BOOLEAN
)
BEGIN 
    DECLARE acceso_permiso BOOLEAN;
    DECLARE agregar_permiso BOOLEAN;
    DECLARE editar_permiso BOOLEAN;
    DECLARE eliminar_permiso BOOLEAN;
    DECLARE visualizar_permiso BOOLEAN;
    
    SELECT acceso, agregar, editar, eliminar, visualizar
    INTO acceso_permiso, agregar_permiso, editar_permiso, eliminar_permiso, visualizar_permiso
    FROM permisos
    WHERE fkidusuario = usuario_id;

    IF (acceso_permiso = permiso_acceso AND
        agregar_permiso = permiso_agregar AND
        editar_permiso = permiso_editar AND
        eliminar_permiso = permiso_eliminar AND
        visualizar_permiso = permiso_visualizar) THEN
        SET tiene_permisos = TRUE;
    ELSE
        SET tiene_permisos = FALSE;
    END IF;
END //

CALL P_Validar(Admin)

SELECT usuario,contrasena FROM usuarios WHERE usuario = 'Samuel' AND contrasena = SHA1('1010');