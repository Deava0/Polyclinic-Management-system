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
-- Table structure for table `doct_work_q`
--

DROP TABLE IF EXISTS `doct_work_q`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `doct_work_q` (
  `id` int(2) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `doct_id` int(4) unsigned NOT NULL,
  `work_state` varchar(45) NOT NULL DEFAULT 'Waiting' COMMENT 'Waiting / Processing / Offline',
  `crnt_pt` int(4) unsigned DEFAULT NULL,
  `actv_vst_id` int(4) unsigned DEFAULT NULL,
  `time` datetime DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `pt_id_doct_wrk_q_fk_idx` (`crnt_pt`),
  KEY `doct_id_doct_wrk_q_fk_idx` (`doct_id`),
  KEY `actv_vst_id_doct_wrk_q_fk_idx` (`actv_vst_id`),
  CONSTRAINT `actv_vst_id_doct_wrk_q_fk` FOREIGN KEY (`actv_vst_id`) REFERENCES `active_visit` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `doct_id_doct_wrk_q_fk` FOREIGN KEY (`doct_id`) REFERENCES `staff` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `pt_id_doct_wrk_q_fk` FOREIGN KEY (`crnt_pt`) REFERENCES `patient` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doct_work_q`
--

LOCK TABLES `doct_work_q` WRITE;
/*!40000 ALTER TABLE `doct_work_q` DISABLE KEYS */;
/*!40000 ALTER TABLE `doct_work_q` ENABLE KEYS */;
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
