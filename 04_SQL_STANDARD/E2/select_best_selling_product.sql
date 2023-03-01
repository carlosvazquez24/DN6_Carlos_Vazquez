SELECT "Best selling product" query_Type, producttypes.id_ProductType, name, amount from salesdetails
inner join producttypes
where salesdetails.id_ProductType = producttypes.id_ProductType and salesdetails.amount =
(
SELECT max(Amount) from
(
SELECT sum(amount) as Amount from salesdetails
group by id_ProductType
) subTable
) 
