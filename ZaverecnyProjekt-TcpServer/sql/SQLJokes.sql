use lastovka;

create table joke(
id int primary key identity(1, 1),
text varchar(200)
);

insert into joke (text) values ('Chuck Norris chytil koronavirus. Bylo mu ho l�to, tak ho zase pustil.');
insert into joke (text) values ('Kdy� Abraham Bell vynalezl telefon zjistil, �e m� 2 zme�kan� hovory od Chucka Norrise.');
insert into joke (text) values ('Chuck Norris rychleji sed�, ne� ty b��.');
insert into joke (text) values ('Chucku Norrisovi se jednou p�i seskoku z letadla neotev�el pad�k. Hned druh� den ho �el reklamovat.');
insert into joke (text) values ('�as na nikoho ne�ek� pokud to nen� Chuck Norris.');
insert into joke (text) values ('Kdo se sm�je naposledy, m� nejv�t�� ping.');
insert into joke (text) values ('Pro� B�h jako prvn� stvo�il Adama a a� pak Evu? Proto�e necht�l poslouchat, jak p�esn� m� toho Adama ud�lat.');
insert into joke (text) values ('Se�ly se 4 kamar�dky, ale nemaj� si o �em pov�dat, proto�e p�i�ly v�echny.');
insert into joke (text) values ('�v�carsk� po�ta zkou�� doru�ovat bal�ky dronem. �esk� po�ta zkou�� doru�ovat bal�ky�');
insert into joke (text) values ('�Jean, b� zal�t tr�vn�k!� �Ale pane, v�dy� pr�텓 �Nevad�, vezmi si de�tn�k!�');
insert into joke (text) values ('Chuck Norris nehlad� zv��ata. Kdy� se k nim p�ibl��, za�nou se zv��ata hladit sama.');
insert into joke (text) values ('Chuck Norris kdysi z�vodil s �asem. A kdo vyhr�l? No, �as po��d je�t� b��, ne?');
insert into joke (text) values ('Po��ta� Chucka Norrise nem� Backspace. Chuck Norris ned�l� ��dn� chyby.');
insert into joke (text) values ('Chuck Norris si jednou v Burger Kingu objednal Big Mac. Dostal ho bez jedin�ho koment��e.');
insert into joke (text) values ('Chuck Norris je jedin� �lov�k na sv�t�, kter� dok�e skute�n� zab�jet �as.');
insert into joke (text) values ('Kdy� se Chuck Norris zahled� p��mo do slunce, mus� slunce p�imhou�it o�i.');
insert into joke (text) values ('Chuck Norris jednou rozplakal Veselou kr�vu.');
insert into joke (text) values ('Ne� jde bub�k sp�t, zkontroluje, jestli nem� pod postel� Chucka Norrise.');
insert into joke (text) values ('U�itelka po mn� cht�la, abych se vystihl p�ti slovy. �Dost l�n�.�');
insert into joke (text) values ('Bezzub� d�da p�ijde k zuba�i, usedne na k�eslo, otev�e �sta a zahalek�: �Apr�l!�');

select * from joke where id = 1;
