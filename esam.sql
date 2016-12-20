-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: esam
-- ------------------------------------------------------
-- Server version	5.7.10-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `area`
--

DROP TABLE IF EXISTS `area`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `area` (
  `Cod` int(11) NOT NULL AUTO_INCREMENT,
  `NombreArea` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Cod`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `area`
--

LOCK TABLES `area` WRITE;
/*!40000 ALTER TABLE `area` DISABLE KEYS */;
INSERT INTO `area` VALUES (1,'Baño');
/*!40000 ALTER TABLE `area` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `Cod` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) DEFAULT NULL,
  `Rut` varchar(45) NOT NULL,
  `Clasificacion` varchar(45) DEFAULT NULL,
  `LugardeTratamiento` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Cod`,`Rut`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'Wats','7788','Cautivo','Osorno'),(2,'IST','668','Cautivo','PuertoMontt');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `lugartratamiento`
--

DROP TABLE IF EXISTS `lugartratamiento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `lugartratamiento` (
  `CodNT` int(11) NOT NULL AUTO_INCREMENT,
  `NombreTratamiento` varchar(45) DEFAULT NULL,
  `cliente_Cod` int(11) DEFAULT NULL,
  `cliente_Rut` varchar(45) NOT NULL,
  `Telefono` varchar(45) DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `TipoContacto` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`CodNT`),
  KEY `fk_lugartratamiento_cliente1_idx` (`cliente_Cod`,`cliente_Rut`),
  CONSTRAINT `fk_lugartratamiento_cliente1` FOREIGN KEY (`cliente_Cod`, `cliente_Rut`) REFERENCES `cliente` (`Cod`, `Rut`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `lugartratamiento`
--

LOCK TABLES `lugartratamiento` WRITE;
/*!40000 ALTER TABLE `lugartratamiento` DISABLE KEYS */;
INSERT INTO `lugartratamiento` VALUES (1,'PuertoMontt',2,'668','87123302','IST@gmail.com','Contacto Lugar');
/*!40000 ALTER TABLE `lugartratamiento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `periodicidad`
--

DROP TABLE IF EXISTS `periodicidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `periodicidad` (
  `Cod` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` varchar(45) DEFAULT NULL,
  `planilla_Cod` int(11) NOT NULL,
  PRIMARY KEY (`Cod`),
  KEY `fk_Periodicidad_planilla1_idx` (`planilla_Cod`),
  CONSTRAINT `fk_Periodicidad_planilla1` FOREIGN KEY (`planilla_Cod`) REFERENCES `planilla` (`Cod`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `periodicidad`
--

LOCK TABLES `periodicidad` WRITE;
/*!40000 ALTER TABLE `periodicidad` DISABLE KEYS */;
INSERT INTO `periodicidad` VALUES (1,'01-01-2016',1),(2,'01-07-2016',1);
/*!40000 ALTER TABLE `periodicidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `planilla`
--

DROP TABLE IF EXISTS `planilla`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `planilla` (
  `Cod` int(11) NOT NULL AUTO_INCREMENT,
  `Tecnicos_Cod` int(11) NOT NULL,
  `Servicio_Cod` int(11) NOT NULL,
  `cliente_Rut` varchar(45) NOT NULL,
  `Area_Cod` int(11) NOT NULL,
  `Consumo` varchar(45) DEFAULT NULL,
  `Numero` int(99) DEFAULT NULL,
  `cliente_Cod` int(11) NOT NULL,
  `lugartratamiento_CodNT` int(11) NOT NULL,
  PRIMARY KEY (`Cod`),
  KEY `fk_Planilla_Tecnicos1_idx` (`Tecnicos_Cod`),
  KEY `fk_Planilla_Servicio1_idx` (`Servicio_Cod`),
  KEY `fk_planilla_Area1_idx` (`Area_Cod`),
  KEY `fk_planilla_cliente1_idx` (`cliente_Cod`,`cliente_Rut`),
  KEY `fk_planilla_lugartratamiento1_idx` (`lugartratamiento_CodNT`),
  CONSTRAINT `fk_Planilla_Servicio1` FOREIGN KEY (`Servicio_Cod`) REFERENCES `servicio` (`Cod`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_Planilla_Tecnicos1` FOREIGN KEY (`Tecnicos_Cod`) REFERENCES `tecnicos` (`Cod`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_planilla_Area1` FOREIGN KEY (`Area_Cod`) REFERENCES `area` (`Cod`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_planilla_cliente1` FOREIGN KEY (`cliente_Cod`, `cliente_Rut`) REFERENCES `cliente` (`Cod`, `Rut`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_planilla_lugartratamiento1` FOREIGN KEY (`lugartratamiento_CodNT`) REFERENCES `lugartratamiento` (`CodNT`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `planilla`
--

LOCK TABLES `planilla` WRITE;
/*!40000 ALTER TABLE `planilla` DISABLE KEYS */;
INSERT INTO `planilla` VALUES (1,3,5,'668',1,'50',0,2,1);
/*!40000 ALTER TABLE `planilla` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `plano`
--

DROP TABLE IF EXISTS `plano`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `plano` (
  `Codplano` varchar(45) NOT NULL,
  `lugartratamiento_CodNT` int(99) NOT NULL,
  `Contador` int(11) DEFAULT NULL,
  PRIMARY KEY (`Codplano`),
  KEY `fk_plano_lugartratamiento1_idx` (`lugartratamiento_CodNT`),
  CONSTRAINT `fk_plano_lugartratamiento1` FOREIGN KEY (`lugartratamiento_CodNT`) REFERENCES `lugartratamiento` (`CodNT`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `plano`
--

LOCK TABLES `plano` WRITE;
/*!40000 ALTER TABLE `plano` DISABLE KEYS */;
INSERT INTO `plano` VALUES ('90',1,90);
/*!40000 ALTER TABLE `plano` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `servicio`
--

DROP TABLE IF EXISTS `servicio`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `servicio` (
  `Cod` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(45) NOT NULL,
  `Sigla` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Cod`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `servicio`
--

LOCK TABLES `servicio` WRITE;
/*!40000 ALTER TABLE `servicio` DISABLE KEYS */;
INSERT INTO `servicio` VALUES (5,'Desratizacion','S-1');
/*!40000 ALTER TABLE `servicio` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tecnicos`
--

DROP TABLE IF EXISTS `tecnicos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tecnicos` (
  `Cod` int(11) NOT NULL AUTO_INCREMENT,
  `Rut` varchar(45) DEFAULT NULL,
  `Nombre` varchar(45) NOT NULL,
  `Apellido` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Cod`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tecnicos`
--

LOCK TABLES `tecnicos` WRITE;
/*!40000 ALTER TABLE `tecnicos` DISABLE KEYS */;
INSERT INTO `tecnicos` VALUES (3,'18231773-k','Diego','Bustamante'),(4,'18231778-0','Hector','Barria');
/*!40000 ALTER TABLE `tecnicos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `veiculos`
--

DROP TABLE IF EXISTS `veiculos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `veiculos` (
  `Patente` varchar(8) NOT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Patente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `veiculos`
--

LOCK TABLES `veiculos` WRITE;
/*!40000 ALTER TABLE `veiculos` DISABLE KEYS */;
INSERT INTO `veiculos` VALUES ('RE2792','Dewood');
/*!40000 ALTER TABLE `veiculos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-03-08 18:12:53
