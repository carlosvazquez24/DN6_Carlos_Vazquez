CREATE TABLE `users` (
  `iduser` int NOT NULL,
  `username` varchar(100) NOT NULL,
  `email` varchar(500) DEFAULT NULL,
  `idcompany` int NOT NULL,
  PRIMARY KEY (`iduser`),
  KEY `company_users_idx` (`idcompany`),
  CONSTRAINT `company_users` FOREIGN KEY (`idcompany`) REFERENCES `company` (`idcompany`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
