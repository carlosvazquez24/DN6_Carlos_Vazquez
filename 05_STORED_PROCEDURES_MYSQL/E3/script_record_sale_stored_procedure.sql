USE `gym`;
DROP procedure IF EXISTS `recordSale`;

DELIMITER $$
USE `gym`$$
CREATE PROCEDURE `recordSale` (in idProduct int, in idUser int, out idSale int)
BEGIN


declare _idSale int;

select max(id_Sale) + 1 into _idSale from sales;
insert into sales ( id_Sale, date, id_ProductType, id_User) values (_idSale, now(), idProduct, idUser);

set idSale = _idSale; 

END$$

DELIMITER ;
