insert into country (idcountry, name) values (1, "USA");
insert into country (idcountry, name) values (2, "Argentina");
insert into country (idcountry, name) values (3, "Colombia");
insert into country (idcountry, name) values (4, "México");
insert into country (idcountry, name) values (5, "Cuba");

insert into company (idcompany, companyname, location) values (1,  "Company Test", "SU" );
insert into company (idcompany, companyname, location) values (2,  "Contoso", "NO" );
insert into company (idcompany, companyname, location) values (3,  "Tesla", "AM" );

insert into users (iduser, username, email, idcompany) values (1, 'admin', 'adminfitest.com', 1);
insert into users (iduser, username, email, idcompany) values (2, 'admin', 'adminficontoso.com', 2);
insert into users (iduser, username, email, idcompany) values (3, 'admin', 'adminfitesla.com', 3);
insert into users (iduser, username, email, idcompany) values (4, 'admin', 'adminfitest.com', 1);

insert into city (idcity, name, idcountry) values (1, 'CDMX', 4);
insert into city (idcity, name, idcountry) values (2, 'Guadalajara', 4);
insert into city (idcity, name, idcountry) values (3, 'Monterrey' , 4);

insert into city (idcity, name, idcountry) values (4, 'Los angeles', 1);
insert into city (idcity, name, idcountry) values (5, 'New York', 1);
insert into city (idcity, name, idcountry) values (6, 'Washingtown DC' , 1);
insert into city (idcity, name, idcountry) values (7, 'Buenos aires', 2);
insert into city (idcity, name, idcountry) values (8, 'La habana' , 5);
insert into city (idcity, name, idcountry) values (9, 'Medeyin' , 3);
insert into city (idcity, name, idcountry) values (10, 'Barraquiya' , 3);

update city set name = "Los Ángeles" where idcity = 4;
update city set name = "La Habana" where idcity = 8;
update city set name = "Medellín" where idcity = 9;
update city set name = "Barraquilla" where idcity = 10;



