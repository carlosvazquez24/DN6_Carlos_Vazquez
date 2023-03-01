create view list_users_in_roles as
SELECT first_name,last_name,name as Role FROM
(
SELECT usersinroles.id_User,users.first_name, users.last_name, usersinroles.id_Role from usersinroles 
inner join users where usersinroles.id_User = users.id_User
) subTable
inner join roles where roles.id_Role = subTable.id_Role