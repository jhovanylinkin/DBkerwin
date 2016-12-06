-- MySQL Script generated by MySQL Workbench
-- 12/05/16 14:11:26
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Proveedores`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`Proveedores` ;

CREATE TABLE IF NOT EXISTS `mydb`.`Proveedores` (
  `idProveedor` INT NOT NULL AUTO_INCREMENT,
  `nombreProveedor` VARCHAR(45) NULL,
  `rfcProveedor` VARCHAR(45) NULL,
  `direccionProveedor` VARCHAR(45) NULL,
  `telefonoProveedor` VARCHAR(15) NULL,
  PRIMARY KEY (`idProveedor`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`compras`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`compras` ;

CREATE TABLE IF NOT EXISTS `mydb`.`compras` (
  `idcompras` INT NOT NULL,
  `totalCompras` VARCHAR(45) NULL,
  `fechaCompras` VARCHAR(25) NULL,
  `idProveedor` INT NOT NULL,
  PRIMARY KEY (`idcompras`),
  INDEX `fk_compras_Proveedores1_idx` (`idProveedor` ASC),
  CONSTRAINT `fk_compras_Proveedores1`
    FOREIGN KEY (`idProveedor`)
    REFERENCES `mydb`.`Proveedores` (`idProveedor`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Producto`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`Producto` ;

CREATE TABLE IF NOT EXISTS `mydb`.`Producto` (
  `idProducto` INT NOT NULL,
  `nombre` VARCHAR(45) NULL,
  `unidades` VARCHAR(45) NULL,
  `precio` DECIMAL(3) NULL,
  PRIMARY KEY (`idProducto`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Cliente`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`Cliente` ;

CREATE TABLE IF NOT EXISTS `mydb`.`Cliente` (
  `idCliente` INT NOT NULL AUTO_INCREMENT,
  `nombreCliente` VARCHAR(45) NULL,
  `telefonoCliente` VARCHAR(80) NULL,
  `direccionCliente` VARCHAR(45) NULL,
  PRIMARY KEY (`idCliente`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Ventas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`Ventas` ;

CREATE TABLE IF NOT EXISTS `mydb`.`Ventas` (
  `idVentas` INT NOT NULL AUTO_INCREMENT,
  `totalVentas` VARCHAR(45) NULL,
  `fechaVentas` VARCHAR(25) NULL,
  `idCliente` INT NOT NULL,
  PRIMARY KEY (`idVentas`),
  INDEX `fk_Ventas_Cliente1_idx` (`idCliente` ASC),
  CONSTRAINT `fk_Ventas_Cliente1`
    FOREIGN KEY (`idCliente`)
    REFERENCES `mydb`.`Cliente` (`idCliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Producto_has_compras`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`Producto_has_compras` ;

CREATE TABLE IF NOT EXISTS `mydb`.`Producto_has_compras` (
  `idProducto` INT NOT NULL,
  `idcompras` INT NOT NULL,
  `cantidad` INT NULL,
  PRIMARY KEY (`idProducto`, `idcompras`),
  INDEX `fk_Producto_has_compras_compras1_idx` (`idcompras` ASC),
  INDEX `fk_Producto_has_compras_Producto_idx` (`idProducto` ASC),
  CONSTRAINT `fk_Producto_has_compras_Producto`
    FOREIGN KEY (`idProducto`)
    REFERENCES `mydb`.`Producto` (`idProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Producto_has_compras_compras1`
    FOREIGN KEY (`idcompras`)
    REFERENCES `mydb`.`compras` (`idcompras`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Ventas_has_Producto`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `mydb`.`Ventas_has_Producto` ;

CREATE TABLE IF NOT EXISTS `mydb`.`Ventas_has_Producto` (
  `idVentas` INT NOT NULL,
  `idProducto` INT NOT NULL,
  `cantidad` INT NULL,
  PRIMARY KEY (`idVentas`, `idProducto`),
  INDEX `fk_Ventas_has_Producto_Producto1_idx` (`idProducto` ASC),
  INDEX `fk_Ventas_has_Producto_Ventas1_idx` (`idVentas` ASC),
  CONSTRAINT `fk_Ventas_has_Producto_Ventas1`
    FOREIGN KEY (`idVentas`)
    REFERENCES `mydb`.`Ventas` (`idVentas`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Ventas_has_Producto_Producto1`
    FOREIGN KEY (`idProducto`)
    REFERENCES `mydb`.`Producto` (`idProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

USE `mydb`;

DELIMITER $$

USE `mydb`$$
DROP TRIGGER IF EXISTS `mydb`.`Producto_BEFORE_INSERT` $$
USE `mydb`$$
CREATE DEFINER = CURRENT_USER TRIGGER `mydb`.`Producto_BEFORE_INSERT` BEFORE INSERT ON `Producto` FOR EACH ROW
BEGIN

END
$$


USE `mydb`$$
DROP TRIGGER IF EXISTS `mydb`.`Producto_AFTER_INSERT` $$
USE `mydb`$$
CREATE DEFINER = CURRENT_USER TRIGGER `mydb`.`Producto_AFTER_INSERT` AFTER INSERT ON `Producto` FOR EACH ROW
BEGIN

END
$$


USE `mydb`$$
DROP TRIGGER IF EXISTS `mydb`.`Producto_BEFORE_UPDATE` $$
USE `mydb`$$
CREATE DEFINER = CURRENT_USER TRIGGER `mydb`.`Producto_BEFORE_UPDATE` BEFORE UPDATE ON `Producto` FOR EACH ROW
BEGIN

END
$$


DELIMITER ;

SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `mydb`.`Proveedores`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`Proveedores` (`idProveedor`, `nombreProveedor`, `rfcProveedor`, `direccionProveedor`, `telefonoProveedor`) VALUES (1, 'Super de Chiapas S.A. de C.V', '2343232SUPERDECHIAPAS3245', 'Tuxtla Gtz ,Chiapas', '9611223432');
INSERT INTO `mydb`.`Proveedores` (`idProveedor`, `nombreProveedor`, `rfcProveedor`, `direccionProveedor`, `telefonoProveedor`) VALUES (2, 'TuxExpancion S.A de C.V.', '2343234TUXEXPANCION3223', 'Tuxtla Gtz, Chiapas', '9611223433');
INSERT INTO `mydb`.`Proveedores` (`idProveedor`, `nombreProveedor`, `rfcProveedor`, `direccionProveedor`, `telefonoProveedor`) VALUES (3, 'Pitico', '234323PITICO3232', 'Comitán de Dominguez, Chiapas', '9631223433');

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`compras`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`compras` (`idcompras`, `totalCompras`, `fechaCompras`, `idProveedor`) VALUES (001, '2', '12/ene/2016', 2 );
INSERT INTO `mydb`.`compras` (`idcompras`, `totalCompras`, `fechaCompras`, `idProveedor`) VALUES (002, '1', '12/ene/2016', 1);
INSERT INTO `mydb`.`compras` (`idcompras`, `totalCompras`, `fechaCompras`, `idProveedor`) VALUES (003, '1', '17/feb/2016', 2);
INSERT INTO `mydb`.`compras` (`idcompras`, `totalCompras`, `fechaCompras`, `idProveedor`) VALUES (004, '2', '24/abr/2016', 1);
INSERT INTO `mydb`.`compras` (`idcompras`, `totalCompras`, `fechaCompras`, `idProveedor`) VALUES (005, '2', '10/jun/2016', 3);
INSERT INTO `mydb`.`compras` (`idcompras`, `totalCompras`, `fechaCompras`, `idProveedor`) VALUES (6, '232', '12/ene/2016', 3);

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`Producto`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`Producto` (`idProducto`, `nombre`, `unidades`, `precio`) VALUES (001, 'Jabon Zote', '35g', 7.5);
INSERT INTO `mydb`.`Producto` (`idProducto`, `nombre`, `unidades`, `precio`) VALUES (002, 'Cereal Chocolate', '120g', 35);
INSERT INTO `mydb`.`Producto` (`idProducto`, `nombre`, `unidades`, `precio`) VALUES (003, 'Azucar', '1kg', 14);
INSERT INTO `mydb`.`Producto` (`idProducto`, `nombre`, `unidades`, `precio`) VALUES (004, 'Sal', '1kg', 7.5);
INSERT INTO `mydb`.`Producto` (`idProducto`, `nombre`, `unidades`, `precio`) VALUES (005, 'Galletas Marias', '35g', 8);

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`Cliente`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`Cliente` (`idCliente`, `nombreCliente`, `telefonoCliente`, `direccionCliente`) VALUES (101, 'Neyser Gómez', '9612346543', 'Conocida');
INSERT INTO `mydb`.`Cliente` (`idCliente`, `nombreCliente`, `telefonoCliente`, `direccionCliente`) VALUES (102, 'Jhovany Morales', '9612346542', 'Conocida');
INSERT INTO `mydb`.`Cliente` (`idCliente`, `nombreCliente`, `telefonoCliente`, `direccionCliente`) VALUES (103, 'Sacarías Hernández', '9612346541', 'Conocida');
INSERT INTO `mydb`.`Cliente` (`idCliente`, `nombreCliente`, `telefonoCliente`, `direccionCliente`) VALUES (104, 'David Gaspard', '9612346523', 'Conocida');
INSERT INTO `mydb`.`Cliente` (`idCliente`, `nombreCliente`, `telefonoCliente`, `direccionCliente`) VALUES (105, 'Pino Ocho', '9612346547', 'Conocida');

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`Ventas`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`Ventas` (`idVentas`, `totalVentas`, `fechaVentas`, `idCliente`) VALUES (1, '243', '2016/12/5', 101);
INSERT INTO `mydb`.`Ventas` (`idVentas`, `totalVentas`, `fechaVentas`, `idCliente`) VALUES (2, '233', '2016/12/5', 102);
INSERT INTO `mydb`.`Ventas` (`idVentas`, `totalVentas`, `fechaVentas`, `idCliente`) VALUES (3, '233', '2016/12/5', 103);
INSERT INTO `mydb`.`Ventas` (`idVentas`, `totalVentas`, `fechaVentas`, `idCliente`) VALUES (4, '123', '2016/12/5', 104);

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`Producto_has_compras`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`Producto_has_compras` (`idProducto`, `idcompras`, `cantidad`) VALUES (2, 1, 22);
INSERT INTO `mydb`.`Producto_has_compras` (`idProducto`, `idcompras`, `cantidad`) VALUES (1, 2, 23);

COMMIT;


-- -----------------------------------------------------
-- Data for table `mydb`.`Ventas_has_Producto`
-- -----------------------------------------------------
START TRANSACTION;
USE `mydb`;
INSERT INTO `mydb`.`Ventas_has_Producto` (`idVentas`, `idProducto`, `cantidad`) VALUES (1, 1, 10);
INSERT INTO `mydb`.`Ventas_has_Producto` (`idVentas`, `idProducto`, `cantidad`) VALUES (2, 2, 1);
INSERT INTO `mydb`.`Ventas_has_Producto` (`idVentas`, `idProducto`, `cantidad`) VALUES (3, 3, 2);
INSERT INTO `mydb`.`Ventas_has_Producto` (`idVentas`, `idProducto`, `cantidad`) VALUES (4, 4, 3);

COMMIT;
