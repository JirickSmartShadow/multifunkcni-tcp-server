use lastovka;

create table joke(
id int primary key identity(1, 1),
text varchar(200)
);

insert into joke (text) values ('Chuck Norris chytil koronavirus. Bylo mu ho líto, tak ho zase pustil.');
insert into joke (text) values ('Kdy Abraham Bell vynalezl telefon zjistil, e má 2 zmeškané hovory od Chucka Norrise.');
insert into joke (text) values ('Chuck Norris rychleji sedí, ne ty bìíš.');
insert into joke (text) values ('Chucku Norrisovi se jednou pøi seskoku z letadla neotevøel padák. Hned druhı den ho šel reklamovat.');
insert into joke (text) values ('Èas na nikoho neèeká… pokud to není Chuck Norris.');
insert into joke (text) values ('Kdo se smìje naposledy, má nejvìtší ping.');
insert into joke (text) values ('Proè Bùh jako první stvoøil Adama a a pak Evu? Protoe nechtìl poslouchat, jak pøesnì má toho Adama udìlat.');
insert into joke (text) values ('Sešly se 4 kamarádky, ale nemají si o èem povídat, protoe pøišly všechny.');
insert into joke (text) values ('Švıcarská pošta zkouší doruèovat balíky dronem. Èeská pošta zkouší doruèovat balíky…');
insert into joke (text) values ('„Jean, bì zalít trávník!“ „Ale pane, vdy prší…“ „Nevadí, vezmi si deštník!“');
insert into joke (text) values ('Chuck Norris nehladí zvíøata. Kdy se k nim pøiblíí, zaènou se zvíøata hladit sama.');
insert into joke (text) values ('Chuck Norris kdysi závodil s èasem. A kdo vyhrál? No, èas poøád ještì bìí, ne?');
insert into joke (text) values ('Poèítaè Chucka Norrise nemá Backspace. Chuck Norris nedìlá ádné chyby.');
insert into joke (text) values ('Chuck Norris si jednou v Burger Kingu objednal Big Mac. Dostal ho bez jediného komentáøe.');
insert into joke (text) values ('Chuck Norris je jedinı èlovìk na svìtì, kterı dokáe skuteènì zabíjet èas.');
insert into joke (text) values ('Kdy se Chuck Norris zahledí pøímo do slunce, musí slunce pøimhouøit oèi.');
insert into joke (text) values ('Chuck Norris jednou rozplakal Veselou krávu.');
insert into joke (text) values ('Ne jde bubák spát, zkontroluje, jestli nemá pod postelí Chucka Norrise.');
insert into joke (text) values ('Uèitelka po mnì chtìla, abych se vystihl pìti slovy. „Dost línı.“');
insert into joke (text) values ('Bezzubı dìda pøijde k zubaøi, usedne na køeslo, otevøe ústa a zahaleká: „Apríl!“');

select * from joke where id = 1;
