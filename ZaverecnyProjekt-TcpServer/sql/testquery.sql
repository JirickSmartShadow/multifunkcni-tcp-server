select * from client order by username;

select * from message;

select * from joke;

update joke set text = 'Uèitelka po mnì chtìla, abych se vystihl pìti slovy. „Dost líný.“' where id = 19;

delete from client where username = 'test';

insert into client values ('asdfASDF', 'heslo');

select * from client where username collate SQL_Latin1_General_CP1_CS_AS = 'asdfASDF';

SELECT column_name AS [name],
       IS_NULLABLE AS [null?],
       DATA_TYPE + COALESCE('(' + CASE WHEN CHARACTER_MAXIMUM_LENGTH = -1
                                  THEN 'Max'
                                  ELSE CAST(CHARACTER_MAXIMUM_LENGTH AS VARCHAR(5))
                                  END + ')', '') AS [type]
FROM   INFORMATION_SCHEMA.Columns
WHERE  table_name = 'message';

insert into rpsscore values (9, 5000, '00:00:01.0732418', getdate());

select * from rpsscore;
select * from score;

select top 20 client.username, rpsscore.points, rpsscore.time, rpsscore.date
from client inner join rpsscore on client.id = rpsscore.client_id
order by rpsscore.points desc, rpsscore.time;

select top 20 client.username, score.points, score.time, score.date
from client inner join score on client.id = score.client_id
order by score.points desc, score.time;

-- update message 
-- set is_read = 1
-- where message.receiver_client_id = (select id from client where username = 'jiri123') and
-- message.sender_client_id = (select id from client where username = 'jiri123') and
-- message.text = 'test' and (select left(convert(varchar, message.date, 120), 19)) = '2023-04-08 22:18:22';
