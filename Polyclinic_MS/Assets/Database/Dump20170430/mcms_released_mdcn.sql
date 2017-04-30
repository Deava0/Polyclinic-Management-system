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
-- Table structure for table `released_mdcn`
--

DROP TABLE IF EXISTS `released_mdcn`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `released_mdcn` (
  `id` int(4) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `actv_vst_id` int(4) unsigned DEFAULT NULL,
  `pt_id` int(4) unsigned NOT NULL,
  `mdcn_id` int(4) unsigned NOT NULL,
  `pharm_id` int(4) unsigned NOT NULL,
  `rel_time` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `pt_id_fk_idx` (`pt_id`),
  KEY `mdcn_id_fk_idx` (`mdcn_id`),
  KEY `pharm_id_fk_idx` (`pharm_id`),
  KEY `actv_vst_id_rel_mdcn_fk_idx` (`actv_vst_id`),
  CONSTRAINT `actv_vst_id_rel_mdcn_fk` FOREIGN KEY (`actv_vst_id`) REFERENCES `active_visit` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `mdcn_id_rel_mdcn_fk` FOREIGN KEY (`mdcn_id`) REFERENCES `pharma` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `pharm_id_rel_mdcn_fk` FOREIGN KEY (`pharm_id`) REFERENCES `staff` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `pt_id_rel_mdcn_fk` FOREIGN KEY (`pt_id`) REFERENCES `patient` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `released_mdcn`
--

LOCK TABLES `released_mdcn` WRITE;
/*!40000 ALTER TABLE `released_mdcn` DISABLE KEYS */;
INSERT INTO `released_mdcn` VALUES (0002,24,1,1,0,'2017-04-10 14:21:52'),(0003,24,1,2,0,'2017-04-10 14:21:52'),(0004,24,1,2,0,'2017-04-10 14:21:53'),(0005,26,1,2,0,'2017-04-24 14:54:47'),(0006,26,1,1,0,'2017-04-24 14:54:48');
/*!40000 ALTER TABLE `released_mdcn` ENABLE KEYS */;
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
