USE `gym`;
DROP procedure IF EXISTS `consultInventory`;

USE `gym`;
DROP procedure IF EXISTS `gym`.`consultInventory`;
;

DELIMITER $$
USE `gym`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `consultInventory`(in idProduct int)
BEGIN

select inventory.existence as Products_in_stock, producttypes.name, producttypes.id_ProductType from inventory
inner join producttypes
where inventory.id_ProductType = producttypes.id_ProductType and producttypes.id_ProductType = idProduct;

END$$

DELIMITER ;
;
