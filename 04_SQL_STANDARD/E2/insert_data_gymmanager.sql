

insert into cities (id_City,name) values (1,"CDMX");
insert into cities (id_City,name) values (2,"Chetumal");
insert into cities (id_City,name) values (3,"Merida");
insert into cities (id_City,name) values (4,"Bacalar");
insert into cities (id_City,name) values (5,"Cancún");

insert into equipmenttype (id_EquipmentType,name) values (1,"Dumbbells");
insert into equipmenttype (id_EquipmentType,name) values (2,"Chest bar and brench");
insert into equipmenttype (id_EquipmentType,name) values (3,"Leg bar");
insert into equipmenttype (id_EquipmentType,name) values (4,"press");
insert into equipmenttype (id_EquipmentType,name) values (5,"treadmill");



insert into users (id_User, first_name,last_name,birthday,email,shift,phone_number,id_City) values (1,"Carlos", "Vázquez", "2001-10-24 18:00:00", "carlos@gmail.com","M", 98399977,4);
insert into users (id_User, first_name,last_name,birthday,email,shift,phone_number,id_City) values (2,"José", "José", "1994-02-04 14:30:00", "tacos123@gmail.com","M", 98399333,4); 
insert into users (id_User, first_name,last_name,birthday,email,shift,phone_number,id_City) values (3,"Daniel", "Sosa", "2002-06-10 10:14:00", "daniel@hotmail.com","V", 55532521,1); 
insert into users (id_User, first_name,last_name,birthday,email,shift,phone_number,id_City) values (4,"Juan", "Rodriguez", "1988-06-29 19:00:00", "juan@outlook.com","M", 99834521,5); 
insert into users (id_User, first_name,last_name,birthday,email,shift,phone_number,id_City) values (5,"María", "Velazquez", "2004-12-30 02:00:00", "cvlaz@yahoo.com","V", 999236759,3);  

insert into roles (id_Role, name, salary) values (1,"manager",13000);
insert into roles (id_Role, name, salary) values (2,"coach",8000);
insert into roles (id_Role, name, salary) values (3,"porter",6000);
insert into roles (id_Role, name, salary) values (4,"security",7000);
insert into roles (id_Role, name, salary) values (5,"janitor",6000);

insert into usersinroles (id_User, id_Role) values (1,1);
insert into usersinroles (id_User, id_Role) values (1,2);
insert into usersinroles (id_User, id_Role) values (2,4);
insert into usersinroles (id_User, id_Role) values (3,3);
insert into usersinroles (id_User, id_Role) values (3,5);
insert into usersinroles (id_User, id_Role) values (4,2);
insert into usersinroles (id_User, id_Role) values (5,5);

insert into membershiptypes (id_Membership_Type, name, cost, created_on, duration) values (1, "Standard", 300, "2022-04-03 12:00:00", 1);
insert into membershiptypes (id_Membership_Type, name, cost, created_on, duration) values (2, "Plus", 500, "2022-04-13 16:00:00", 3);
insert into membershiptypes (id_Membership_Type, name, cost, created_on, duration) values (3, "Premium", 800, "2022-10-03 18:00:00", 6);
insert into membershiptypes (id_Membership_Type, name, cost, created_on, duration) values (4, "Super premium plus max", 1600, "2022-04-03 22:30:00", 12);
insert into membershiptypes (id_Membership_Type, name, cost, created_on, duration) values (5, "Trial", 100, "2022-08-01 12:15:00", 1);

insert into members (id_Member,fisrt_name, last_name, email, birthday, last_payment, id_City, id_Membership_Type, created_on) values (1,"Juan", "Perez","chano@hotmail.com", "1998-06-23 14:00:00", "2023-02-05 14:00:00",1,1, "2023-01-20 15:00:00");
insert into members (id_Member,fisrt_name, last_name, email, birthday, last_payment, id_City, id_Membership_Type, created_on) values (2,"Reyna", "Rodriguez","rmrr@hotmail.com", "2001-12-23 14:00:00", "2023-02-10 14:00:00",4,1, "2023-01-28 19:00:00");
insert into members (id_Member,fisrt_name, last_name, email, birthday, last_payment, id_City, id_Membership_Type, created_on) values (3,"Adrian", "Torres","adri123@gmail.com", "1998-06-23 14:00:00", "2023-02-15 14:00:00",3,5, "2023-02-20 15:00:00");
insert into members (id_Member,fisrt_name, last_name, email, birthday, last_payment, id_City, id_Membership_Type, created_on) values (4,"Itzel", "Hernández","chano@hotmail.com", "2005-02-23 15:00:00", "2023-02-05 14:00:00",2,4, "2023-02-24 18:00:00");
insert into members (id_Member,fisrt_name, last_name, email, birthday, last_payment, id_City, id_Membership_Type, created_on) values (5,"Blanca", "Luna","chano@hotmail.com", "1988-06-07 18:00:00", "2023-02-22 14:00:00",2,4, "2023-02-24 19:00:00");


insert into measuretype (id_Measure_Type, measure) values (1,"liters");
insert into measuretype (id_Measure_Type, measure) values (2,"grams");
insert into measuretype (id_Measure_Type, measure) values (3,"milliliters");
insert into measuretype (id_Measure_Type, measure) values (4,"kilograms");
insert into measuretype (id_Measure_Type, measure) values (5,"milligrams");

insert into producttypes (id_ProductType, name, brand, cost, price, id_Measure_Type) values(1, "Protein max power", "whey",1500, 2000, 4);
insert into producttypes (id_ProductType, name, brand, cost, price, id_Measure_Type) values(2, "Protein", "optimum nutrition",700, 1000, 2);
insert into producttypes (id_ProductType, name, brand, cost, price, id_Measure_Type) values(3, "Creatine", "Bio Tech",500, 800, 2);
insert into producttypes (id_ProductType, name, brand, cost, price, id_Measure_Type) values(4, "Mass efect", "whey",1900, 2500, 4);
insert into producttypes (id_ProductType, name, brand, cost, price, id_Measure_Type) values(5, "Steroid", "unknown",250, 500, 5);


insert into inventory (id_Inventory, existence, id_ProductType) values (1,12,1);
insert into inventory (id_Inventory, existence, id_ProductType) values (2,5,2);
insert into inventory (id_Inventory, existence, id_ProductType) values (3,7,3);
insert into inventory (id_Inventory, existence, id_ProductType) values (4,2,4);
insert into inventory (id_Inventory, existence, id_ProductType) values (5,20,5);

insert into sales (id_Sale, date, total) values (1,"2023-02-21 14:00:00", 3000);
insert into sales (id_Sale, date, total) values (2,"2023-02-22 14:00:00", 1000);
insert into sales (id_Sale, date, total) values (3,"2023-02-23 15:00:00", 2400);
insert into sales (id_Sale, date, total) values (4,"2023-02-23 16:00:00", 2500);
insert into sales (id_Sale, date, total) values (5,"2023-02-23 17:00:00", 800);

insert into salesdetails ( id_SalesDetails, id_Sale, id_ProductType,amount,subtotal) values (1,1,1,1,2000);
insert into salesdetails ( id_SalesDetails, id_Sale, id_ProductType,amount,subtotal) values (2,1,2,1,1000);
insert into salesdetails ( id_SalesDetails, id_Sale, id_ProductType,amount,subtotal) values (3,2,2,1,1000);
insert into salesdetails ( id_SalesDetails, id_Sale, id_ProductType,amount,subtotal) values (4,3,3,3,2400);
insert into salesdetails ( id_SalesDetails, id_Sale, id_ProductType,amount,subtotal) values (5,4,1,1,2000);
insert into salesdetails ( id_SalesDetails, id_Sale, id_ProductType,amount,subtotal) values (6,4,5,1,500);
insert into salesdetails ( id_SalesDetails, id_Sale, id_ProductType,amount,subtotal) values (7,5,5,1,800);