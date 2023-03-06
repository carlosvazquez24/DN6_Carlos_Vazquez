USE `sqltesting`;
DROP procedure IF EXISTS `GetAllUsers`;

DELIMITER $$
USE `sqltesting`$$
CREATE PROCEDURE `getAllUsers` ()
BEGIN

select * from users;

END$$

DELIMITER ;

