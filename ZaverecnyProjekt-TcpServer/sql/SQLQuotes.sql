use lastovka;

create table quote(
id int primary key identity(1, 1),
text varchar(200),
author varchar(50)
);

insert into quote(text, author) values ('�Trp�liv�m �ek�n�m se nikam nedostaneme; jen trp�livou prac�.�', 'John Ruskin');
insert into quote(text, author) values ('�Nem��e� zastavit vlny, ale m��e� se nau�it surfovat."', 'Joseph Goldstein');
insert into quote(text, author) values ('�Jestli najde� v �ivot� cestu bez p�ek�ek, ur�it� nikam nevede."', 'Arthur Charles Clarke');
insert into quote(text, author) values ('�Pokud opravdu chcete n��eho dos�hnout, najdete zp�sob. Pokud nechcete, najdete si v�mluvu."', 'Jim Rohn');
insert into quote(text, author) values ('�Za ka�dou kr�snou v�c� je n�jak� druh bolesti.�', 'Bob Dylan');
insert into quote(text, author) values ('�Jednej tak, abys byl ��astn�, ne aby ses ��astn�m jen zd�l.�', 'Seneca');
insert into quote(text, author) values ('�Nep�ej si, aby to bylo snaz��; p�ej si, abys byl lep��.�', 'Jim Rohn');
insert into quote(text, author) values ('�Ud�lat v�c, kter� se boj�me, je prvn� krok k �sp�chu."', 'Mah�tma G�ndh�');
insert into quote(text, author) values ('�V�era jsem byl chytr�, proto jsem cht�l zm�nit sv�t. Dnes jsem moudr�, proto m�n�m s�m sebe.�', 'Sri Chinmoy');
insert into quote(text, author) values ('�Prvn� krok proto, abyste od �ivota z�skali to, co chcete je rozhodnout se, co to je.�', 'Ben Stein');
insert into quote(text, author) values ('�Nejtemn�j�� chv�le nast�v� v�dy p�ed �svitem.�', 'Paulo Coelho');
insert into quote(text, author) values ('�Selh�n� se stane selh�n�m, jenom pokud nastane v posledn� kapitole. Jinak je to z�pletka."', 'Danny Iny');
insert into quote(text, author) values ('�Nepob�vej v minulosti, nesni o budoucnosti, soust�e� mysl na p��tomn� okam�ik."', 'Buddha');
insert into quote(text, author) values ('�Odvaha neznamen� nem�t strach, n�br� schopnost nenechat se j�m ochromit.�', 'Paulo Coelho');
insert into quote(text, author) values ('�Je lep�� rozsv�tit, by� jen malou, sv��ku, ne� prokl�nat temnotu.�', 'Konfucius');
insert into quote(text, author) values ('��as m� pln� kapsy p�ekvapen�."', 'Jan Werich');
insert into quote(text, author) values ('�Jak dlouho �iji, to nez�vis� na mn�. Ale jestli skute�n� �iji, to na mn� z�vis�.�', 'Seneca');
insert into quote(text, author) values ('�Dobr� zpr�vy se z domu nedostanou, �patn� se rozlet� tis�ce mil.�', '��nsk� p��slov�');
insert into quote(text, author) values ('�Nau�me se uk�zat �lov�ku p��telstv�, dokud je �iv, a ne, a� kdy� um�e.�', 'Francis Scott Fitzgerald');
insert into quote(text, author) values ('�Je lep�� b�t nen�vid�n pro to, jak� jsi, ne� b�t milov�n pro to, co nejsi.�', 'Kurt Cobain');

select * from quote;