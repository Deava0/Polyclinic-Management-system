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
-- Table structure for table `pt_queue`
--

DROP TABLE IF EXISTS `pt_queue`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pt_queue` (
  `id` int(2) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `pt_id` int(4) unsigned NOT NULL,
  `doct_id` int(4) unsigned DEFAULT NULL,
  `apt_state` varchar(45) NOT NULL DEFAULT 'Without',
  `actv_vst_id` int(4) unsigned DEFAULT NULL,
  `apt_id` int(4) unsigned DEFAULT NULL,
  `q_state` varchar(45) NOT NULL DEFAULT 'Waiting' COMMENT 'waiting / processing / processed / On Hold',
  `ariv_time` datetime NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `pt_id_UNIQUE` (`pt_id`),
  KEY `pt_id_cons_q_fk_idx` (`pt_id`),
  KEY `apt_id_cons_q_fk_idx` (`apt_id`),
  KEY `actv_vst_id_cons_q_fk_idx` (`actv_vst_id`),
  KEY `doct_id_cons_q_fk_idx` (`doct_id`),
  CONSTRAINT `actv_vst_id_cons_q_fk` FOREIGN KEY (`actv_vst_id`) REFERENCES `active_visit` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `apt_id_cons_q_fk` FOREIGN KEY (`apt_id`) REFERENCES `appointment` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `doct_id_cons_q_fk` FOREIGN KEY (`doct_id`) REFERENCES `appointment` (`doct_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `pt_id_cons_q_fk` FOREIGN KEY (`pt_id`) REFERENCES `patient` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Doctor Consultation Queue';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pt_queue`
--

LOCK TABLES `pt_queue` WRITE;
/*!40000 ALTER TABLE `pt_queue` DISABLE KEYS */;
/*!40000 ALTER TABLE `pt_queue` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-04-30 22:51:48
