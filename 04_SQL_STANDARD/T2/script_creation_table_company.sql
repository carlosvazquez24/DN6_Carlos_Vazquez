CREATE TABLE `company` (
  `idcompany` int NOT NULL,
  `companyname` varchar(100) NOT NULL,
  `location` char(2) DEFAULT NULL,
  PRIMARY KEY (`idcompany`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
