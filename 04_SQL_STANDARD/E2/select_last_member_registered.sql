select "Last member registered" query_type, members.fisrt_name, members.last_name, 
membershiptypes.name as Membership, members.created_on 
from members 
inner join membershiptypes
 where membershiptypes.id_Membership_Type = members.id_Membership_Type and members.created_on =
 (
 select max(created_on) from members
)
