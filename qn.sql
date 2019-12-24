-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: localhost    Database: questionnaire_survey_system
-- ------------------------------------------------------
-- Server version	8.0.16

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `administrator`
--

DROP TABLE IF EXISTS `administrator`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `administrator` (
  `AID` varchar(10) NOT NULL,
  `Aname` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`AID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `administrator`
--

LOCK TABLES `administrator` WRITE;
/*!40000 ALTER TABLE `administrator` DISABLE KEYS */;
INSERT INTO `administrator` VALUES ('A1','没有名字');
/*!40000 ALTER TABLE `administrator` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `option`
--

DROP TABLE IF EXISTS `option`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `option` (
  `OID` varchar(10) NOT NULL,
  `context` varchar(45) DEFAULT NULL,
  `op_num` int(11) DEFAULT NULL,
  `QuID` varchar(10) DEFAULT NULL,
  `remark` varchar(4) DEFAULT NULL,
  PRIMARY KEY (`OID`),
  KEY `QuID_idx` (`QuID`),
  CONSTRAINT `QuID` FOREIGN KEY (`QuID`) REFERENCES `question` (`QuID`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci KEY_BLOCK_SIZE=1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `option`
--

LOCK TABLES `option` WRITE;
/*!40000 ALTER TABLE `option` DISABLE KEYS */;
INSERT INTO `option` VALUES ('O0001','A.今天天气真好',0,'Qu0001','A'),('O0002','B.阳光明媚',0,'Qu0001','B'),('O0003','C.鸟语花香',0,'Qu0001','C'),('O0004','D.月色真美',0,'Qu0001','D'),('O0005','A.你真漂亮',0,'Qu0002','A'),('O0006','B.你真好吃',0,'Qu0002','B'),('O0007','C.毒',0,'Qu0002','C'),('O0008','D.哈哈哈哈',0,'Qu0002','D'),('O0009','A.哎哟不错哦',0,'Qu0003','A'),('O0010','B.你是我的优乐美',0,'Qu0003','B'),('O0011','C.听妈妈的话',0,'Qu0003','C'),('O0012','D.哒哒哒',0,'Qu0003','D'),('O0013','A.今天天气真好',0,'Qu0004','A'),('O0014','B.阳光明媚',0,'Qu0004','B'),('O0015','C.鸟语花香',0,'Qu0004','C'),('O0016','D.月色真美',0,'Qu0004','D'),('O0017','A.你真漂亮',0,'Qu0005','A'),('O0018','B.你真好吃',0,'Qu0005','B'),('O0019','C.毒',0,'Qu0005','C'),('O0020','D.哈哈哈哈',0,'Qu0005','D'),('O0021','A.哎哟不错哦',0,'Qu0006','A'),('O0022','B.你是我的优乐美',0,'Qu0006','B'),('O0023','C.听妈妈的话',0,'Qu0006','C'),('O0024','D.哒哒哒',0,'Qu0006','D');
/*!40000 ALTER TABLE `option` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `question`
--

DROP TABLE IF EXISTS `question`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `question` (
  `QuID` varchar(10) NOT NULL,
  `type` varchar(45) DEFAULT NULL,
  `remarks` varchar(45) DEFAULT NULL,
  `context` varchar(45) DEFAULT NULL,
  `QID` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`QuID`),
  KEY `QID_idx` (`QID`),
  CONSTRAINT `QID1` FOREIGN KEY (`QID`) REFERENCES `questionnaire` (`QID`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `question`
--

LOCK TABLES `question` WRITE;
/*!40000 ALTER TABLE `question` DISABLE KEYS */;
INSERT INTO `question` VALUES ('Qu0001','单选','必填','问题1','Q0001'),('Qu0002','多选','选填','这是个问题','Q0001'),('Qu0003','单选','必选','华农兄弟喜欢说什么','Q0002'),('Qu0004','单选','必填','zjl唱过的歌曲','Q0001'),('Qu0005','多选','必填','这是个问题5','Q0002'),('Qu0006','多选','选填','这是个问题6','Q0002');
/*!40000 ALTER TABLE `question` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `questionnaire`
--

DROP TABLE IF EXISTS `questionnaire`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `questionnaire` (
  `QID` varchar(10) NOT NULL,
  `Qname` varchar(45) DEFAULT NULL,
  `Qnum` int(11) DEFAULT NULL,
  `deadline` date DEFAULT NULL,
  `finish_time` datetime(1) DEFAULT NULL,
  `release_time` datetime(1) DEFAULT NULL,
  `release_way` varchar(10) DEFAULT NULL,
  `AID` varchar(10) DEFAULT NULL,
  `Qstatus` int(11) DEFAULT NULL,
  PRIMARY KEY (`QID`),
  KEY `AID_idx` (`AID`),
  CONSTRAINT `AID` FOREIGN KEY (`AID`) REFERENCES `administrator` (`AID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `questionnaire`
--

LOCK TABLES `questionnaire` WRITE;
/*!40000 ALTER TABLE `questionnaire` DISABLE KEYS */;
INSERT INTO `questionnaire` VALUES ('Q0001','没有',3,'2019-02-03','2019-02-04 00:00:00.0','2019-01-01 00:00:00.0','定时','A1',1),('Q0002','吃藕吗',3,'2019-03-02','2019-03-01 00:00:00.0','2019-01-04 00:00:00.0','非定时','A1',1);
/*!40000 ALTER TABLE `questionnaire` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `user` (
  `UserID` int(11) NOT NULL,
  `gender` varchar(45) DEFAULT NULL,
  `Username` varchar(45) DEFAULT NULL,
  `QID` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`UserID`),
  KEY `QID_idx` (`QID`),
  CONSTRAINT `QID` FOREIGN KEY (`QID`) REFERENCES `questionnaire` (`QID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'男','吴亦凡','Q0001'),(2,'女','郝健','Q0001'),(3,'女','菜虚鲲','Q0002'),(4,'男','篮球','Q0002');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-12-24 12:39:46
