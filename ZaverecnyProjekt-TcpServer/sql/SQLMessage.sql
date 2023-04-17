use lastovka;

create table message(
id int primary key identity (1, 1),
sender_client_id int foreign key references client(id),
reciever_client_id int foreign key references client(id),
text varchar(500),
date date,
is_read int
);

-- upgrade
-- is_readable_by_serder int,
-- is_readable_by_receiver int

select * from message;

select client.username, message.text, message.date, message.is_read 
from client inner join message on client.id = message.reciever_client_id;

select sender.username, message.text, message.date, message.is_read
from client as sender inner join message on sender.id = message.sender_client_id
where message.reciever_client_id = (select id from client where username = 'Veronika123');

select reciever.username, message.date, message.text
from client as reciever inner join message on reciever.id = message.reciever_client_id
where message.sender_client_id = (select id from client where username = 'Jiri123')
order by message.id desc;

select * from client;

select client.username 
from client 
where client.username = 'Jan123';

drop table message;