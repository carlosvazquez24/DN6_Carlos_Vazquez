USE `sqltesting`;
DROP procedure IF EXISTS `getAllUsers`;

DELIMITER $$
USE `sqltesting`$$
CREATE PROCEDURE `getAllUsers` ()
BEGIN

select * from users;

END$$

DELIMITER ;

