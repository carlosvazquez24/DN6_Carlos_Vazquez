select "Best selling product" description, producttypes.id_ProductType, name from
producttypes
inner join
(
	SELECT Count(*) as Amount, id_ProductType from sales
	group by id_ProductType
	having Amount = 
	(
		select max(Amount) as max from
		(
			SELECT Count(*) as Amount, id_ProductType from sales
			group by id_ProductType
		) subTable
	) 
) finalTable where producttypes.id_ProductType = finalTable.id_ProductType;