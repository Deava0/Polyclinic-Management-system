CREATE DATABASE  IF NOT EXISTS `mcms` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `mcms`;
-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: mcms
-- ------------------------------------------------------
-- Server version	5.7.17-log

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
-- Table structure for table `patient`
--

DROP TABLE IF EXISTS `patient`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `patient` (
  `id` int(4) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `civil_id` int(11) NOT NULL,
  `prefix` varchar(45) NOT NULL,
  `first_name` varchar(45) NOT NULL,
  `second_name` varchar(45) DEFAULT NULL COMMENT 'middle name',
  `third_name` varchar(45) DEFAULT NULL,
  `fourth_name` varchar(45) DEFAULT NULL,
  `tribe_name` varchar(45) NOT NULL COMMENT 'Last name or sir name',
  `dob` date NOT NULL,
  `gender` varchar(45) NOT NULL,
  `phone_no` varchar(45) NOT NULL,
  `address` varchar(45) NOT NULL,
  `nationality` varchar(45) NOT NULL,
  `email` varchar(45) DEFAULT NULL,
  `blood_type` varchar(45) DEFAULT 'UNKNOWN',
  `reg_time` datetime NOT NULL,
  `file_state` varchar(45) NOT NULL DEFAULT 'Inactive',
  PRIMARY KEY (`id`),
  UNIQUE KEY `civil_id_UNIQUE` (`civil_id`),
  KEY `pt_id_index` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient`
--

LOCK TABLES `patient` WRITE;
/*!40000 ALTER TABLE `patient` DISABLE KEYS */;
INSERT INTO `patient` VALUES (0001,123123,'Mr','Samantha','star','gobilon','strathmore','Lovegood','1985-11-06','Female','864751935','Al-Buraimi','Omani','aqqw@yrp.dk','AB-negative','2017-03-20 12:11:22','Inactive'),(0004,34543534,'Ms','Sarah','Harold','','','McCain','2000-04-09','Female','7863445','Alain','British','','UNKNOWN','2017-04-09 13:10:19','Inactive'),(0005,2331243,'Ms','Garod','Harold','','','McCain','1994-04-09','Male','23423223','Alain','British','','A-positive','2017-04-09 13:11:32','Active'),(0006,54644311,'Mr','Mat','hue','','','Newman','1906-04-10','Male','34673542345','Here','There','','O-positive','2017-04-10 02:01:01','Inactive');
/*!40000 ALTER TABLE `patient` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-04-30 22:51:49
