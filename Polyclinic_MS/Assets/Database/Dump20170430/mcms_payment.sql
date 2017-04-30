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
-- Table structure for table `payment`
--

DROP TABLE IF EXISTS `payment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `payment` (
  `id` int(4) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `by_whom` int(4) unsigned NOT NULL,
  `for_whom` int(4) unsigned NOT NULL,
  `fee_type` varchar(45) NOT NULL,
  `fee` double NOT NULL COMMENT 'commit_time <',
  `com_time` datetime NOT NULL,
  `pay_time` datetime DEFAULT NULL,
  `pay_status` varchar(45) NOT NULL DEFAULT 'Unpayed',
  PRIMARY KEY (`id`),
  KEY `pt_id_pay_fk_idx` (`for_whom`),
  KEY `stf_id_pay_fk_idx` (`by_whom`),
  CONSTRAINT `pt_id_pay_fk` FOREIGN KEY (`for_whom`) REFERENCES `patient` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `stf_id_pay_fk` FOREIGN KEY (`by_whom`) REFERENCES `staff` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `payment`
--

LOCK TABLES `payment` WRITE;
/*!40000 ALTER TABLE `payment` DISABLE KEYS */;
INSERT INTO `payment` VALUES (0004,5,6,'REG FEE',2,'2017-04-10 02:01:01',NULL,'Unpayed'),(0005,5,1,'FILE ACTV FEE',0.5,'2017-04-10 02:06:15','2017-04-10 21:49:46','Payed'),(0006,1,1,'CNSLT FEE',25,'2017-04-10 12:06:53','2017-04-10 21:49:46','Payed'),(0007,0,1,'MDCN1 FEE',2,'2017-04-10 14:21:52',NULL,'Unpayed'),(0008,0,1,'MDCN2 FEE',3,'2017-04-10 14:21:53',NULL,'Unpayed'),(0009,0,1,'MDCN2 FEE',3,'2017-04-10 14:21:53',NULL,'Unpayed'),(0010,5,5,'FILE ACTV FEE',0.5,'2017-04-10 14:28:08','2017-04-10 21:45:33','Payed'),(0011,1,5,'CNSLT FEE',25,'2017-04-10 14:58:37','2017-04-10 21:45:33','Payed'),(0012,0,1,'FILE ACTV FEE',0.5,'2017-04-24 14:33:21','2017-04-24 14:57:17','Payed'),(0013,0,1,'CNSLT FEE',25,'2017-04-24 14:53:05','2017-04-24 14:57:17','Payed'),(0014,0,1,'MDCN2 FEE',3,'2017-04-24 14:54:48',NULL,'Unpayed'),(0015,0,1,'MDCN1 FEE',2,'2017-04-24 14:54:48',NULL,'Unpayed');
/*!40000 ALTER TABLE `payment` ENABLE KEYS */;
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
