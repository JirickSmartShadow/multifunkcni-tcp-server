create table client(
id int primary key identity(1, 1),
username varchar(20) not null,
password varchar(20) not null
);

insert into client values ('Jiri123', 'jiri');
insert into client values ('Vladislav123', 'vladislav');
insert into client values ('Borek123', 'borek');
insert into client values ('Jan123', 'jan');
insert into client values ('Petr123', 'petr');

select * from client;

create table score(
id int primary key identity(1, 1),
client_id int foreign key references client(id),
points int not null,
time time,
date date
);

select * from score inner join client on score.client_id = client.id;

select * from score;

select username from client;

select client.username, score.points
from client inner join score on client.id = score.client_id
where score.points = (select max(points) from score);

select client.username, max(score.points)
from client inner join score on client.id = score.client_id
group by client.username;

select top 20 client.username, score.points
from client inner join score on client.id = score.client_id
order by score.points desc;

select top 20 client.username, score.points, score.time
from client inner join score on client.id = score.client_id
order by score.points desc, score.time;

drop table score;

create table rpsscore(
id int primary key identity(1, 1),
client_id int foreign key references client(id),
points int not null,
time time,
date date
);

select * from rpsscore inner join client on rpsscore.client_id = client.id;

select * from rpsscore;

select username from client;

select client.username, rpsscore.points
from client inner join rpsscore on client.id = rpsscore.client_id
where rpsscore.points = (select max(points) from rpsscore);

select client.username, max(rpsscore.points)
from client inner join rpsscore on client.id = rpsscore.client_id
group by client.username;

select top 20 client.username, rpsscore.points
from client inner join rpsscore on client.id = rpsscore.client_id
order by rpsscore.points desc;

select top 20 client.username, rpsscore.points, rpsscore.time
from client inner join rpsscore on client.id = rpsscore.client_id
order by rpsscore.points desc, rpsscore.time;

drop table rpsscore;