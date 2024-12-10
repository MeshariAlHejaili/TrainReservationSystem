-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: localhost    Database: mydb
-- ------------------------------------------------------
-- Server version	9.1.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `class`
--

DROP TABLE IF EXISTS `class`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `class` (
  `ClassID` int NOT NULL,
  `ClassName` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`ClassID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `class`
--

LOCK TABLES `class` WRITE;
/*!40000 ALTER TABLE `class` DISABLE KEYS */;
INSERT INTO `class` VALUES (1,'First Class'),(2,'Business Class'),(3,'Economy Class');
/*!40000 ALTER TABLE `class` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dependant`
--

DROP TABLE IF EXISTS `dependant`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `dependant` (
  `PassengerID` varchar(50) NOT NULL,
  `DependantName` varchar(100) NOT NULL,
  `RelationshipType` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`PassengerID`),
  CONSTRAINT `dependant_ibfk_1` FOREIGN KEY (`PassengerID`) REFERENCES `passenger` (`IDDocument`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dependant`
--

LOCK TABLES `dependant` WRITE;
/*!40000 ALTER TABLE `dependant` DISABLE KEYS */;
INSERT INTO `dependant` VALUES ('123456789','Ali Alharbi','Child'),('456789123','Laila Alqahtani','Child'),('987654321','Sara Alshehri','Spouse');
/*!40000 ALTER TABLE `dependant` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `loyaltyprogram`
--

DROP TABLE IF EXISTS `loyaltyprogram`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `loyaltyprogram` (
  `LoyaltyClass` varchar(50) NOT NULL,
  `MilesRequired` int NOT NULL,
  `DiscountRate` decimal(5,2) NOT NULL,
  PRIMARY KEY (`LoyaltyClass`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `loyaltyprogram`
--

LOCK TABLES `loyaltyprogram` WRITE;
/*!40000 ALTER TABLE `loyaltyprogram` DISABLE KEYS */;
INSERT INTO `loyaltyprogram` VALUES ('Gold',25000,10.00),('Platinum',50000,20.00),('Silver',10000,5.00);
/*!40000 ALTER TABLE `loyaltyprogram` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `luggage`
--

DROP TABLE IF EXISTS `luggage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `luggage` (
  `ReservationID` int NOT NULL,
  `Weight` decimal(5,2) NOT NULL,
  `LuggageType` varchar(50) NOT NULL,
  PRIMARY KEY (`ReservationID`),
  CONSTRAINT `luggage_ibfk_1` FOREIGN KEY (`ReservationID`) REFERENCES `reservation` (`ReservationID`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `luggage`
--

LOCK TABLES `luggage` WRITE;
/*!40000 ALTER TABLE `luggage` DISABLE KEYS */;
INSERT INTO `luggage` VALUES (1,23.50,'Checked'),(3,10.20,'Carry-on');
/*!40000 ALTER TABLE `luggage` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `passenger`
--

DROP TABLE IF EXISTS `passenger`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `passenger` (
  `IDDocument` varchar(50) NOT NULL,
  `PassengerName` varchar(100) NOT NULL,
  `PhoneNumber` varchar(20) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `MilesTravelled` int NOT NULL DEFAULT '0',
  `LoyaltyClass` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IDDocument`),
  UNIQUE KEY `Email` (`Email`),
  KEY `LoyaltyClass` (`LoyaltyClass`),
  CONSTRAINT `passenger_ibfk_1` FOREIGN KEY (`LoyaltyClass`) REFERENCES `loyaltyprogram` (`LoyaltyClass`) ON DELETE SET NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `passenger`
--

LOCK TABLES `passenger` WRITE;
/*!40000 ALTER TABLE `passenger` DISABLE KEYS */;
INSERT INTO `passenger` VALUES ('123456789','Mohammed Alharbi','555-1234','mohammed.alharbi@example.com',12000,'Silver'),('456789123','Omar Alqahtani','555-4321','omar.alqahtani@example.com',55000,'Platinum'),('987654321','Fatima Alshehri','555-5678','fatima.alshehri@example.com',30000,'Gold');
/*!40000 ALTER TABLE `passenger` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reservation`
--

DROP TABLE IF EXISTS `reservation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `reservation` (
  `ReservationID` int NOT NULL AUTO_INCREMENT,
  `IDDocument` varchar(50) DEFAULT NULL,
  `ReservationDate` date NOT NULL,
  `TravelDate` date NOT NULL,
  `FlightNumber` varchar(20) NOT NULL,
  `SeatNumber` varchar(10) NOT NULL,
  `Status` varchar(20) NOT NULL,
  PRIMARY KEY (`ReservationID`),
  KEY `IDDocument` (`IDDocument`),
  CONSTRAINT `reservation_ibfk_1` FOREIGN KEY (`IDDocument`) REFERENCES `passenger` (`IDDocument`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=2308 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reservation`
--

LOCK TABLES `reservation` WRITE;
/*!40000 ALTER TABLE `reservation` DISABLE KEYS */;
INSERT INTO `reservation` VALUES (1,'123456789','2024-12-10','2024-12-15','XY123','12A','Confirmed'),(2,'987654321','2024-12-01','2024-12-10','AB456','5B','Cancelled'),(3,'456789123','2024-12-05','2024-12-20','CD789','7C','Confirmed');
/*!40000 ALTER TABLE `reservation` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `seats`
--

DROP TABLE IF EXISTS `seats`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `seats` (
  `SeatID` int NOT NULL,
  `SeatNumber` varchar(10) DEFAULT NULL,
  `TrainID` int DEFAULT NULL,
  `ClassID` int DEFAULT NULL,
  PRIMARY KEY (`SeatID`),
  KEY `TrainID` (`TrainID`),
  KEY `ClassID` (`ClassID`),
  CONSTRAINT `seats_ibfk_1` FOREIGN KEY (`TrainID`) REFERENCES `train` (`TrainID`),
  CONSTRAINT `seats_ibfk_2` FOREIGN KEY (`ClassID`) REFERENCES `class` (`ClassID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `seats`
--

LOCK TABLES `seats` WRITE;
/*!40000 ALTER TABLE `seats` DISABLE KEYS */;
INSERT INTO `seats` VALUES (1,'A1',1,1),(2,'A2',1,1),(3,'A3',1,1),(4,'B1',1,2),(5,'B2',1,2),(6,'B3',1,2),(7,'C1',2,3),(8,'C2',2,3),(9,'C3',2,3),(10,'D1',3,1),(11,'D2',3,1),(12,'D3',3,1),(13,'E1',4,2),(14,'E2',4,2),(15,'E3',4,2);
/*!40000 ALTER TABLE `seats` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff`
--

DROP TABLE IF EXISTS `staff`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staff` (
  `StaffID` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT NULL,
  `Role` varchar(50) DEFAULT NULL,
  `TrainID` int DEFAULT NULL,
  `AssignmentDate` date DEFAULT NULL,
  PRIMARY KEY (`StaffID`),
  KEY `TrainID` (`TrainID`),
  CONSTRAINT `staff_ibfk_1` FOREIGN KEY (`TrainID`) REFERENCES `train` (`TrainID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff`
--

LOCK TABLES `staff` WRITE;
/*!40000 ALTER TABLE `staff` DISABLE KEYS */;
INSERT INTO `staff` VALUES (1,'Mohammed Doe','Driver',1,'2024-12-10'),(2,'Jane Smith','Engineer',1,'2024-12-10'),(3,'Michael Brown','Driver',2,'2024-12-11'),(4,'Emily White','Engineer',2,'2024-12-11'),(5,'Daniel Green','Driver',3,'2024-12-12'),(6,'Laura Black','Engineer',3,'2024-12-12');
/*!40000 ALTER TABLE `staff` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `station`
--

DROP TABLE IF EXISTS `station`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `station` (
  `StationID` int NOT NULL,
  `StationName` varchar(100) DEFAULT NULL,
  `Location` varchar(200) DEFAULT NULL,
  PRIMARY KEY (`StationID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `station`
--

LOCK TABLES `station` WRITE;
/*!40000 ALTER TABLE `station` DISABLE KEYS */;
INSERT INTO `station` VALUES (1,'Riyadh Station','Riyadh'),(2,'Dammam Station','Dammam'),(3,'Qasim Station','Qasim');
/*!40000 ALTER TABLE `station` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `train`
--

DROP TABLE IF EXISTS `train`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `train` (
  `TrainID` int NOT NULL,
  `Name_EN` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`TrainID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `train`
--

LOCK TABLES `train` WRITE;
/*!40000 ALTER TABLE `train` DISABLE KEYS */;
INSERT INTO `train` VALUES (1,'Riyadh-DammamExpress'),(2,'Riyadh-QasimExpress'),(3,'Dammam-RiyadhExpress'),(4,'Qasim-RiyadhExpress');
/*!40000 ALTER TABLE `train` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trainfare`
--

DROP TABLE IF EXISTS `trainfare`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trainfare` (
  `Train_Compartment` varchar(10) NOT NULL,
  `Fare_Per_Mile` decimal(10,2) DEFAULT NULL,
  `TrainID` int DEFAULT NULL,
  `ClassID` int DEFAULT NULL,
  PRIMARY KEY (`Train_Compartment`),
  KEY `TrainID` (`TrainID`),
  KEY `ClassID` (`ClassID`),
  CONSTRAINT `trainfare_ibfk_1` FOREIGN KEY (`TrainID`) REFERENCES `train` (`TrainID`),
  CONSTRAINT `trainfare_ibfk_2` FOREIGN KEY (`ClassID`) REFERENCES `class` (`ClassID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trainfare`
--

LOCK TABLES `trainfare` WRITE;
/*!40000 ALTER TABLE `trainfare` DISABLE KEYS */;
INSERT INTO `trainfare` VALUES ('TR01',2.50,1,1),('TR02',1.50,1,2),('TR03',1.00,1,3),('TR11',3.00,2,1),('TR12',2.00,2,2),('TR13',1.20,2,3);
/*!40000 ALTER TABLE `trainfare` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `trainschedule`
--

DROP TABLE IF EXISTS `trainschedule`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `trainschedule` (
  `ScheduleID` int NOT NULL AUTO_INCREMENT,
  `TrainID` int DEFAULT NULL,
  `SequenceNo` int NOT NULL,
  `Date` date NOT NULL,
  `DepartureTime` time NOT NULL,
  `ArrivalTime` time NOT NULL,
  `From_StationID` int DEFAULT NULL,
  `To_StationID` int DEFAULT NULL,
  `Distance` int DEFAULT NULL,
  PRIMARY KEY (`ScheduleID`),
  UNIQUE KEY `TrainID` (`TrainID`,`SequenceNo`,`Date`),
  KEY `From_StationID` (`From_StationID`),
  KEY `To_StationID` (`To_StationID`),
  CONSTRAINT `trainschedule_ibfk_1` FOREIGN KEY (`TrainID`) REFERENCES `train` (`TrainID`),
  CONSTRAINT `trainschedule_ibfk_2` FOREIGN KEY (`From_StationID`) REFERENCES `station` (`StationID`),
  CONSTRAINT `trainschedule_ibfk_3` FOREIGN KEY (`To_StationID`) REFERENCES `station` (`StationID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `trainschedule`
--

LOCK TABLES `trainschedule` WRITE;
/*!40000 ALTER TABLE `trainschedule` DISABLE KEYS */;
INSERT INTO `trainschedule` VALUES (1,1,1,'2024-12-15','08:00:00','10:30:00',1,2,300),(2,1,2,'2024-12-15','11:00:00','13:30:00',2,3,250),(3,2,1,'2024-12-16','09:00:00','11:30:00',3,1,350),(4,3,1,'2024-12-17','07:30:00','10:00:00',2,1,320),(5,4,1,'2024-12-18','14:00:00','16:30:00',3,2,230);
/*!40000 ALTER TABLE `trainschedule` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `waitinglist`
--

DROP TABLE IF EXISTS `waitinglist`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `waitinglist` (
  `WaitingListID` int NOT NULL AUTO_INCREMENT,
  `IDDocument` varchar(50) DEFAULT NULL,
  `FlightNumber` varchar(20) NOT NULL,
  `Status` varchar(20) NOT NULL,
  PRIMARY KEY (`WaitingListID`),
  KEY `IDDocument` (`IDDocument`),
  CONSTRAINT `waitinglist_ibfk_1` FOREIGN KEY (`IDDocument`) REFERENCES `passenger` (`IDDocument`) ON DELETE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `waitinglist`
--

LOCK TABLES `waitinglist` WRITE;
/*!40000 ALTER TABLE `waitinglist` DISABLE KEYS */;
INSERT INTO `waitinglist` VALUES (1,'123456789','XY123','Waiting'),(2,'987654321','AB456','Confirmed');
/*!40000 ALTER TABLE `waitinglist` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-10  4:15:53
