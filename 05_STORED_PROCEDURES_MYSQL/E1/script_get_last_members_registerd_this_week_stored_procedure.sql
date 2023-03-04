USE `gym`;
DROP procedure IF EXISTS `getLastMembersRegistered`;

DELIMITER $$
USE `gym`$$
CREATE PROCEDURE `getLastMembersRegistered` ()
BEGIN

SELECT id_Member, members.created_on, membershiptypes.name FROM members
inner join membershiptypes where members.id_Membership_Type = membershiptypes.id_Membership_Type
and members.created_on BETWEEN 
adddate(curdate(), INTERVAL 2-DAYOFWEEK(curdate()) DAY) and curdate();

END$$

DELIMITER ;

