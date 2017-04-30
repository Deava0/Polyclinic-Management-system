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

-- Dump completed on 2017-04-30 22:51:49
