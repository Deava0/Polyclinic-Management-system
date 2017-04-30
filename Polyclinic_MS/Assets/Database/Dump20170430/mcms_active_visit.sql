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
-- Table structure for table `active_visit`
--

DROP TABLE IF EXISTS `active_visit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `active_visit` (
  `id` int(4) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `pt_id` int(4) unsigned DEFAULT NULL,
  `rec_id` int(4) unsigned DEFAULT NULL,
  `nurse_id` int(4) unsigned DEFAULT NULL,
  `doct_id` int(4) unsigned DEFAULT NULL,
  `phrm_id` int(4) unsigned DEFAULT NULL,
  `diag` mediumtext COMMENT 'diagnosis',
  `pres` mediumtext COMMENT 'prescription',
  `remedy_state` varchar(45) DEFAULT 'Not Received' COMMENT 'recived / not recived / external',
  `height` double DEFAULT NULL,
  `weight` double DEFAULT NULL,
  `blood_pres` double DEFAULT NULL COMMENT 'blood pressure',
  `from_tm` datetime DEFAULT NULL COMMENT 'file was activated',
  `diag_end_tm` datetime DEFAULT NULL,
  `to_tm` datetime DEFAULT NULL COMMENT 'file was deactivated',
  PRIMARY KEY (`id`),
  KEY `pt_id_av_fk_idx` (`pt_id`),
  KEY `doct_id_av_fk_idx` (`doct_id`),
  KEY `nrs_id_av_fk_idx` (`nurse_id`),
  KEY `rec_id_av_fk_idx` (`rec_id`),
  KEY `phrm_id_av_fk_idx` (`phrm_id`),
  CONSTRAINT `doct_id_av_fk` FOREIGN KEY (`doct_id`) REFERENCES `staff` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `nrs_id_av_fk` FOREIGN KEY (`nurse_id`) REFERENCES `staff` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `phrm_id_av_fk` FOREIGN KEY (`phrm_id`) REFERENCES `staff` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `pt_id_av_fk` FOREIGN KEY (`pt_id`) REFERENCES `patient` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `rec_id_av_fk` FOREIGN KEY (`rec_id`) REFERENCES `staff` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `active_visit`
--

LOCK TABLES `active_visit` WRITE;
/*!40000 ALTER TABLE `active_visit` DISABLE KEYS */;
INSERT INTO `active_visit` VALUES (0024,1,5,7,1,NULL,'sefwewer','3333','Received',224,134,232,'2017-04-10 02:06:15','2017-04-10 12:06:53',NULL),(0025,5,5,7,1,NULL,'','','External',123,132,223,'2017-04-10 14:28:08','2017-04-10 14:58:36','2017-04-10 14:58:36'),(0026,1,0,0,0,NULL,'fghfghfghgf','xgdfgf','Internal',23,324,676,'2017-04-24 14:33:21','2017-04-24 14:53:05',NULL);
/*!40000 ALTER TABLE `active_visit` ENABLE KEYS */;
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
