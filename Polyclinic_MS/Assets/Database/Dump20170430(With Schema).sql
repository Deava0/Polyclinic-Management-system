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

--
-- Table structure for table `appointment`
--

DROP TABLE IF EXISTS `appointment`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `appointment` (
  `id` int(4) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `pt_id` int(4) unsigned NOT NULL,
  `doct_id` int(4) unsigned DEFAULT NULL,
  `reason` text NOT NULL,
  `apt_time` datetime NOT NULL,
  `apt_status` varchar(45) NOT NULL DEFAULT 'OnHold' COMMENT 'OnHold / Waiting / Concluded',
  PRIMARY KEY (`id`),
  KEY `pt_id_fk_idx` (`pt_id`),
  KEY `doct_id_fk_idx` (`doct_id`),
  CONSTRAINT `doct_id_fk` FOREIGN KEY (`doct_id`) REFERENCES `staff` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `pt_id_fk` FOREIGN KEY (`pt_id`) REFERENCES `patient` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointment`
--

LOCK TABLES `appointment` WRITE;
/*!40000 ALTER TABLE `appointment` DISABLE KEYS */;
/*!40000 ALTER TABLE `appointment` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `logs`
--

DROP TABLE IF EXISTS `logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `logs` (
  `id` int(4) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `who` int(4) unsigned NOT NULL,
  `when_tm` datetime NOT NULL,
  `what` text NOT NULL,
  `where_nm` varchar(45) NOT NULL,
  `where_ip` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `stf_id_fk_idx` (`who`),
  CONSTRAINT `stf_id_fk` FOREIGN KEY (`who`) REFERENCES `staff` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=197 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `logs`
--

LOCK TABLES `logs` WRITE;
/*!40000 ALTER TABLE `logs` DISABLE KEYS */;
INSERT INTO `logs` VALUES (0084,5,'2017-04-10 02:06:07','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0085,5,'2017-04-10 02:06:15','PT1 FILE ACTV ','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0086,5,'2017-04-10 02:06:20','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0087,7,'2017-04-10 02:07:04','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0088,1,'2017-04-10 02:09:57','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0089,7,'2017-04-10 02:10:42','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0090,5,'2017-04-10 11:53:31','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0091,5,'2017-04-10 11:53:44','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0092,5,'2017-04-10 11:57:02','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0093,5,'2017-04-10 11:57:06','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0094,5,'2017-04-10 11:57:07','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0095,5,'2017-04-10 11:57:08','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0096,5,'2017-04-10 11:57:24','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0097,5,'2017-04-10 11:57:26','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0098,7,'2017-04-10 11:57:34','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0099,7,'2017-04-10 11:57:38','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0100,7,'2017-04-10 11:57:38','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0101,7,'2017-04-10 11:57:40','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0102,7,'2017-04-10 11:59:15','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0103,7,'2017-04-10 12:00:27','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0104,7,'2017-04-10 12:01:41','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0105,7,'2017-04-10 12:01:56','PT1 SENT IN TO DCT1 ','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0106,7,'2017-04-10 12:02:08','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0107,7,'2017-04-10 12:05:30','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0108,1,'2017-04-10 12:06:31','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0109,1,'2017-04-10 12:06:53','PT1 DIAG ENDED','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0110,1,'2017-04-10 12:06:57','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0111,4,'2017-04-10 12:09:06','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0112,4,'2017-04-10 12:09:57','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0113,4,'2017-04-10 12:09:58','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0114,4,'2017-04-10 12:11:01','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0115,4,'2017-04-10 12:11:40','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0116,4,'2017-04-10 12:11:42','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0117,0,'2017-04-10 12:23:28','MDCN ENTRY MODI','',''),(0118,0,'2017-04-10 12:24:50','MDCN ENTRY MODI','',''),(0119,0,'2017-04-10 14:21:52','PT1 VST ENDED(INTERNAL) ','',''),(0120,0,'2017-04-10 14:21:53','PT1 VST ENDED(INTERNAL) ','',''),(0121,0,'2017-04-10 14:21:53','PT1 VST ENDED(INTERNAL) ','',''),(0122,5,'2017-04-10 14:27:58','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0123,5,'2017-04-10 14:28:08','PT5 FILE ACTV ','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0124,5,'2017-04-10 14:28:12','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0125,7,'2017-04-10 14:28:18','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0126,1,'2017-04-10 14:43:19','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0127,1,'2017-04-10 14:43:29','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0128,5,'2017-04-10 14:43:33','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0129,5,'2017-04-10 14:43:42','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0130,7,'2017-04-10 14:43:57','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0131,7,'2017-04-10 14:44:42','PT5 SENT IN TO DCT1 ','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0132,7,'2017-04-10 14:44:56','PT5 SENT IN TO DCT1 ','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0133,7,'2017-04-10 14:45:03','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0134,1,'2017-04-10 14:48:57','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0135,7,'2017-04-10 14:50:02','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0136,7,'2017-04-10 14:50:14','PT5 SENT IN TO DCT1 ','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0137,7,'2017-04-10 14:50:33','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0138,7,'2017-04-10 14:54:18','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0139,7,'2017-04-10 14:54:51','PT5 SENT IN TO DCT1 ','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0140,7,'2017-04-10 14:56:07','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0141,1,'2017-04-10 14:58:00','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0142,1,'2017-04-10 14:58:36','PT5 DIAG ENDED','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0143,1,'2017-04-10 14:58:36','PT5 VST ENDED(EXTERNAL)','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0144,1,'2017-04-10 14:58:43','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0145,0,'2017-04-10 21:45:33','PYMNT10 CMPLTD ','',''),(0146,0,'2017-04-10 21:45:33','PYMNT11 CMPLTD ','',''),(0147,0,'2017-04-10 21:49:46','PYMNT5 CMPLTD ','',''),(0148,0,'2017-04-10 21:49:46','PYMNT6 CMPLTD ','',''),(0149,0,'2017-04-10 23:41:53','VST24 RCRD MODI ','',''),(0150,0,'2017-04-10 23:56:25','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0151,0,'2017-04-10 23:58:21','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0152,0,'2017-04-10 23:58:31','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0153,0,'2017-04-10 23:59:15','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0154,0,'2017-04-10 23:59:18','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0155,0,'2017-04-11 00:00:54','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0156,0,'2017-04-11 00:00:56','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0157,0,'2017-04-11 00:01:21','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0158,0,'2017-04-11 00:01:22','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0159,0,'2017-04-11 00:01:23','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0160,0,'2017-04-11 00:01:40','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0161,0,'2017-04-11 00:03:23','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0162,0,'2017-04-11 00:03:24','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0163,0,'2017-04-11 00:26:08','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0164,0,'2017-04-11 00:29:16','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0165,0,'2017-04-11 00:30:05','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0166,0,'2017-04-11 00:30:06','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0167,0,'2017-04-11 00:30:55','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0168,0,'2017-04-11 00:31:57','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0169,0,'2017-04-11 00:31:58','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0170,0,'2017-04-11 00:32:39','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0171,0,'2017-04-11 00:32:58','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0172,0,'2017-04-11 00:32:59','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0173,0,'2017-04-11 03:40:06','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0174,0,'2017-04-11 03:41:47','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0175,0,'2017-04-11 03:41:49','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0176,7,'2017-04-11 10:33:06','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0177,7,'2017-04-11 10:33:42','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0178,0,'2017-04-11 10:33:50','LOG IN','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0179,0,'2017-04-11 10:36:43','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0180,0,'2017-04-11 10:36:45','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0181,0,'2017-04-11 10:36:45','LOG OUT','DELL-Gaming','fe80::a91f:1634:edc9:a646%7'),(0182,1,'2017-04-24 14:20:55','LOG IN','DELL-Gaming','fe80::5d1d:c8:7c31:c24a%2'),(0183,1,'2017-04-24 14:21:14','LOG OUT','DELL-Gaming','fe80::5d1d:c8:7c31:c24a%2'),(0184,5,'2017-04-24 14:21:19','LOG IN','DELL-Gaming','fe80::5d1d:c8:7c31:c24a%2'),(0185,5,'2017-04-24 14:22:41','LOG OUT','DELL-Gaming','fe80::5d1d:c8:7c31:c24a%2'),(0186,0,'2017-04-24 14:22:46','LOG IN','DELL-Gaming','fe80::5d1d:c8:7c31:c24a%2'),(0187,0,'2017-04-24 14:33:21','PT1 FILE ACTV ','DELL-Gaming','fe80::5d1d:c8:7c31:c24a%2'),(0188,0,'2017-04-24 14:44:51','PT1 SENT IN TO DCT0 ','DELL-Gaming','fe80::5d1d:c8:7c31:c24a%2'),(0189,0,'2017-04-24 14:53:05','PT1 DIAG ENDED','DELL-Gaming','fe80::5d1d:c8:7c31:c24a%2'),(0190,0,'2017-04-24 14:54:48','PT1 VST ENDED(INTERNAL) ','DELL-Gaming','fe80::5d1d:c8:7c31:c24a%2'),(0191,0,'2017-04-24 14:54:48','PT1 VST ENDED(INTERNAL) ','DELL-Gaming','fe80::5d1d:c8:7c31:c24a%2'),(0192,0,'2017-04-24 14:57:17','PYMNT13 CMPLTD ','DELL-Gaming','fe80::5d1d:c8:7c31:c24a%2'),(0193,0,'2017-04-24 14:57:17','PYMNT12 CMPLTD ','DELL-Gaming','fe80::5d1d:c8:7c31:c24a%2'),(0194,0,'2017-04-24 14:57:37','LOG OUT','DELL-Gaming','fe80::5d1d:c8:7c31:c24a%2'),(0195,0,'2017-04-24 14:57:54','LOG OUT','DELL-Gaming','fe80::5d1d:c8:7c31:c24a%2'),(0196,0,'2017-04-24 14:57:56','LOG OUT','DELL-Gaming','fe80::5d1d:c8:7c31:c24a%2');
/*!40000 ALTER TABLE `logs` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `pharma`
--

DROP TABLE IF EXISTS `pharma`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pharma` (
  `id` int(4) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `type` varchar(45) NOT NULL,
  `qt` varchar(45) NOT NULL,
  `manu_date` date NOT NULL,
  `exp_date` date NOT NULL,
  `price` double NOT NULL,
  `reg_time` datetime NOT NULL,
  PRIMARY KEY (`id`),
  KEY `mdcn_id_index` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COMMENT='Pharmaceuticals';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pharma`
--

LOCK TABLES `pharma` WRITE;
/*!40000 ALTER TABLE `pharma` DISABLE KEYS */;
INSERT INTO `pharma` VALUES (0001,'Mdcn1','Pill','14','2017-03-29','2017-06-29',2,'2017-03-31 01:27:11'),(0002,'mdcn2','Supplement','16','2010-04-10','2018-04-10',3,'2017-04-10 12:29:02');
/*!40000 ALTER TABLE `pharma` ENABLE KEYS */;
UNLOCK TABLES;

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

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `staff` (
  `id` int(4) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `civil_id` int(11) NOT NULL,
  `prefix` varchar(45) NOT NULL,
  `first_name` varchar(45) NOT NULL,
  `second_name` varchar(45) NOT NULL,
  `third_name` varchar(45) DEFAULT NULL,
  `fourth_name` varchar(45) DEFAULT NULL,
  `tribe_name` varchar(45) NOT NULL,
  `dob` date NOT NULL,
  `gender` varchar(45) NOT NULL,
  `phone_no` varchar(45) NOT NULL,
  `address` varchar(45) NOT NULL,
  `nationality` varchar(45) NOT NULL,
  `email` varchar(45) NOT NULL,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `job` varchar(45) NOT NULL,
  `login_state` varchar(45) NOT NULL DEFAULT 'Offline',
  `reg_time` datetime NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `civil_id_UNIQUE` (`civil_id`),
  KEY `stf_id_index` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (0000,8690337,'Mr','Asad','Muslem','Salim','Humaid','Al-Badi','1995-10-12','Male','97777777','Al-Buraimi','Omani','m120130303017','Admin','Admin','Admin','Offline','2017-03-15 12:29:02'),(0001,3245342,'Dr','Star','Hall','go','ga','Gardian','1985-11-02','Female','82133421','LA','American','2131@qqq.aqw','str1','star','Doctor','Offline','2017-03-16 19:19:29'),(0003,24242342,'Mr','Khalid','Mohamed','','','Al-Badi','1996-01-09','Male','242134121','Al-Buraimi','Omani','aaa@eee.rr','Kh19','aaa','Manager','Offline','2017-03-16 23:11:43'),(0004,3412421,'Mr','Anas','someone','','','Al-Shidi','1994-10-10','Male','243123123','Al-Burami','omani','wee@rrr.ff','ana','ana','Pharmacist','Offline','2017-03-16 23:17:10'),(0005,8734552,'Mr','Sultan','maliek','','','AlMarony','1998-04-09','Male','9852352','AlBuraimi','Omani','Sul@gm.com','Rec','rec','Receptionist','Offline','2017-04-09 13:20:19'),(0007,33422572,'Ms','Alexis','Nora','','','Sisona','1994-04-03','Female','234123','AlBuraimi','Canadian','Sul@gm.com','nur','nur','Nurse','Offline','2017-04-09 13:23:20'),(0008,8962334,'Mr','Zex','Orlax','','','Plaxis','1990-02-02','Male','12372789','Sohar','Austrailian','zel@gm.com','acc','acc','Accountant','Offline','2017-04-09 13:25:40');
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-04-30 22:50:19
