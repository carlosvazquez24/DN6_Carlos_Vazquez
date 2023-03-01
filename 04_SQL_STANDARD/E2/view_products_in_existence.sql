create view products_in_stock as
SELECT existence as Product_in_stock ,name as Product_Name FROM inventory 
inner join producttypes
where inventory.id_ProductType = producttypes.id_ProductType and existence > 0