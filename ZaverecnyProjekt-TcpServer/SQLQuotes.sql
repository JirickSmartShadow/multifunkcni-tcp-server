use lastovka;

create table quote(
id int primary key identity(1, 1),
text varchar(200),
author varchar(50)
);

insert into quote(text, author) values ('„Trpìlivım èekáním se nikam nedostaneme; jen trpìlivou prací.”', 'John Ruskin');
insert into quote(text, author) values ('„Nemùeš zastavit vlny, ale mùeš se nauèit surfovat."', 'Joseph Goldstein');
insert into quote(text, author) values ('„Jestli najdeš v ivotì cestu bez pøekáek, urèitì nikam nevede."', 'Arthur Charles Clarke');
insert into quote(text, author) values ('„Pokud opravdu chcete nìèeho dosáhnout, najdete zpùsob. Pokud nechcete, najdete si vımluvu."', 'Jim Rohn');
insert into quote(text, author) values ('„Za kadou krásnou vìcí je nìjakı druh bolesti.”', 'Bob Dylan');
insert into quote(text, author) values ('„Jednej tak, abys byl šastnı, ne aby ses šastnım jen zdál.“', 'Seneca');
insert into quote(text, author) values ('„Nepøej si, aby to bylo snazší; pøej si, abys byl lepší.“', 'Jim Rohn');
insert into quote(text, author) values ('„Udìlat vìc, které se bojíme, je první krok k úspìchu."', 'Mahátma Gándhí');
insert into quote(text, author) values ('„Vèera jsem byl chytrı, proto jsem chtìl zmìnit svìt. Dnes jsem moudrı, proto mìním sám sebe.“', 'Sri Chinmoy');
insert into quote(text, author) values ('„První krok proto, abyste od ivota získali to, co chcete je rozhodnout se, co to je.“', 'Ben Stein');
insert into quote(text, author) values ('„Nejtemnìjší chvíle nastává vdy pøed úsvitem.“', 'Paulo Coelho');
insert into quote(text, author) values ('„Selhání se stane selháním, jenom pokud nastane v poslední kapitole. Jinak je to zápletka."', 'Danny Iny');
insert into quote(text, author) values ('„Nepobıvej v minulosti, nesni o budoucnosti, soustøeï mysl na pøítomnı okamik."', 'Buddha');
insert into quote(text, author) values ('„Odvaha neznamená nemít strach, nıbr schopnost nenechat se jím ochromit.“', 'Paulo Coelho');
insert into quote(text, author) values ('„Je lepší rozsvítit, by jen malou, svíèku, ne proklínat temnotu.“', 'Konfucius');
insert into quote(text, author) values ('„Èas má plné kapsy pøekvapení."', 'Jan Werich');
insert into quote(text, author) values ('„Jak dlouho iji, to nezávisí na mnì. Ale jestli skuteènì iji, to na mnì závisí.“', 'Seneca');
insert into quote(text, author) values ('„Dobré zprávy se z domu nedostanou, špatné se rozletí tisíce mil.“', 'Èínské pøísloví');
insert into quote(text, author) values ('„Nauème se ukázat èlovìku pøátelství, dokud je iv, a ne, a kdy umøe.“', 'Francis Scott Fitzgerald');
insert into quote(text, author) values ('„Je lepší bıt nenávidìn pro to, jakı jsi, ne bıt milován pro to, co nejsi.“', 'Kurt Cobain');

select * from quote;