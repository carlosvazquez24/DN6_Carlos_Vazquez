create view companyusers
as
select * from users u
inner join company c on u.idcompany = c.idcompany