# multifunkcni-tcp-server

Projekt používá vlastní formát zpráv pro komunikaci mezi serverem a klientskou aplikací  
Server příjímá klienty do vláken, čímž je umožněn přístup na server více uživatelským aplikacím v jeden okamžik  
Server příjímá requesty od klienstké aplikace a příslušně na ně reaguje odpovědí ve stejném formátu  
Server komunikuje s databází, ve které jsou uložena tato data  
Pro používání programu je nutné mít nainstalovaný C# framework .NET 6  

UŽIVATELÉ:  
uživatelské jméno  
hashované heslo  
salt hesla (potřebný k vytvoření stejného hashe při kontrole hesla)  

ZPRÁVY:  
odesílatel  
příjemce  
obsah  
datum a čas  
zpráva přečtena  

SKÓRE MATEMATICKÉHO KVÍZU:  
uživatel, kterému skóre patří  
body  
čas (trvání)  
datum a čas  

SKÓRE HRY KÁMEN NŮŽKY PAPÍR:  
uživatel, kterému skóre patří  
body  
čas (trvání)  
datum a čas  

VTIPY:  
obsah  

CITÁTY:  
obsah  
  
  
ÚVOD:  
Program slouží jako multifunkční aplikace, která komunikuje se serverem pomocí protokolu TCP  
V programu lze posílat zprávy, hrát matematický kvíz nebo vypisovat náhodné vtipy  
Pro vstup do aplikace je nutná registrace do systému, viz SIGN UP sekce  
Pro správný chod programu je nutné nastavit konfigurační soubor, který určuje, kde se nachází server, ke kterému se program připojuje, stejně tak, jako port  
Program uživatelská hesla ukládá do databáze šifrovaná bezpečným šifrovacím algoritmem Argon2, tudíž jsou zabezpečená  
V případě výpadku serveru vyskočí okénko s touto informací, následně se program vypne  
Pro používání programu je nutné mít nainstalovaný C# framework .NET 6  

ZAČÁTEK PROGRAMU:  
Po spuštění programu se objeví okno uprostřed obrazovky  
Pokud je server vypnutý nebo pokud je program špatně nakonfigurovaný, okno bude obsahovat chybovou hlášku a program dále nepokračuje  
Pokud je vše v pořádku, objeví se okno s možnostmi Log In a Sign Up  

SIGN UP:  
Po stisknutí Sign Up se objeví okno pro registraci nového uživatele  
Po vyplnění textových polí Username a Password a potvrzením tlačítkem OK proběhne kontrola zadaného textu  
Úspěšná registrace proběhne pouze v případě, že jsou splněny tyto podmínky:  
	Obě textová pole jsou vyplněna  
	Obě textová pole obsahují minimálně 3 a maximálně 20 znaků  
	Uživatelské jméno se neshoduje s žádným, již registrovaným, uživatelem  
Pokud nejsou splněny všechny podmínky, objeví se okno s chybovou hláškou  
Kdykoliv je možné z tohoto okna odejít stisknutím tlačítka Cancel nebo zavřením samotného okna  

LOG IN:  
Po stisknutí Log In se objeví okno pro přihlášení do programu  
Po vyplnění textových polí Username a Password a potvrzením tlačítkem OK proběhne kontrola zadaného textu  
Úspěšné přihlášení proběhne pouze v případě, že jsou splněny tyto podmínky:  
	Obě textová pole jsou vyplněna  
	Obě textová pole obsahují minimálně 3 a maximálně 20 znaků  
	Uživatelské jméno a heslo musí souhlasit se záznamem v databázi  
Pokud nejsou splněny všechny podmínky, objeví se okno s chybovou hláškou  
Kdykoliv je možné z tohoto okna odejít stisknutím tlačítka Cancel nebo zavřením samotného okna  
Po úspěšném přihlášení se objeví okno s hlavním menu  

MAIN MENU:  
Tlačítko Mail otevře mailové menu  
Tlačítko Games otevře menu s hrami  
Tlačítko Jokes & Quotes otevře okno s vtipy a citáty  
Tlačítko Log Out uživatele odhlásí a otevře okno pro přihlášení  
Zavření samotného okna má stejný účinek jako zmáčknutí tlačítka Log Out  

MAIL MENU:  
Tlačítko New Message otevře okno pro vytvoření nové zprávy  
Tlačítko Inbox otevře okno s doručenou poštou  
Tlačítko Sent otevře okno s odeslanou poštou  
Tlačítko Back vrátí zpět do hlavního menu  
Zavření samotného okna má stejný účinek jako zmáčknutí tlačítka Back  

NEW MESSAGE:  
V tomto okně lze vytvořit novou zprávu a poslat ji jednomu nebo více uživatelům včetně sebe samého  
Pro zaslání zprávy více uživatelům stačí v textovém poli dané příjemce oddělit středníkem  
Po vyplnění textových polí Receiver a Message a potvrzení tlačítkem Send proběhne kontrola zadaného textu  
Úspěšné odeslání zprávy proběhne pouze v případě, že jsou splněny tyto podmínky:  
	Obě textová pole jsou vyplněna  
	Všichni zmínění příjemci existují  
	Žádný z příjemců není zmíněný více než jednou  
Tlačítko Clear vymaže text z obou textových polí  
Tlačítko Back vrátí zpět do mailového menu  
Zavření samotného okna má stejný účinek jako zmáčknutí tlačítka Back  

INBOX:  
V tomto okně se zobrazí veškeré doručené zprávy  
Nové (nepřečtené) zprávy mají tučný text  
Náhledy obsahují odesílatele, prvních 20 znaků obsahu zprávy, datum a čas  
Jednotlivé náhledy lze rozkliknout, čímž se otevře nové okno s detaily zprávy  
Tlačítko Refresh načte doručené zprávy znovu  
Tlačítko Back vrátí do mailového menu  
Zavření samotného okna má stejný účinek jako zmáčknutí tlačítka Back  

SENT:  
V tomto okně se zobrazí všechny odeslané zprávy  
Náhledy obsahují příjemce, prvních 20 znaků obsahu zprávy, datum a čas  
Jednotlivé náhledy lze rozkliknout, čímž se otevře nové okno s detaily zprávy  
Tlačítko Refresh načte odeslané zprávy znovu  
Tlačítko Back vrátí do mailového menu  
Zavření samotného okna má stejný účinek jako zmáčknutí tlačítka Back  

MESSAGE DETAIL:  
Okno obsahuje detail zprávy, která byla otevřena  
Pokud se jedná o doručenou zprávu, detaily zprávy jsou - odesílatel, obsah, datum a čas  
Zároveň se zpráva označí jako přečtená  
Pokud se jedná o odeslanou zprávu, detaily zprávy jsou - příjemce, obsah, datum a čas  
Tlačítko Back vrátí zpět do doručených respektive odeslaných zpráv  
Zavření samotného okna má stejný účinek jako zmáčknutí tlačítka Back  

GAMES MENU:  
V tomto okně se zobrazí hry, které lze hrát  
Tlačítko Math Quiz otevře okno s matematickým kvízem  
Tlačítko Rock Paper Scissors otevře okno s hrou kámen, nůžky, papír  
Tlačítko Back vrátí zpět do hlavního menu  
Zavření samotného okna má stejný účinek jako zmáčknutí tlačítka Back  

MATH QUIZ:  
V tomto okně lze hrát matematický kvíz  
Tlačítko Start spustí nový kvíz a zobrazí ovládání  
Kvíz obsahuje 20 otázek, 4 stupně obtížnosti, které se každých 5 otázek navýší  
Každá otázka má v nabídce 4 odpovědi, přičemž pouze jedna možnost je správná  
Při správné odpovědi se přičtou body, jejichž počet se odvíjí od aktuální obtížnosti  
Při špatné odpovědi se body neodečtou  
Po dokončení kvízu se zobrazí finální detailní výsledek  
Tlačítko Highscores zobrazí 20 nejlepších výsledků  
Tlačítko Back vrátí zpět do herního menu  
Zavření samotného okna má stejný účinek jako zmáčknutí tlačítka Back  
Při zavření okna s rozehraným kvízem se kvíz resetuje a výsledek se neuloží  
Na nejlepší výsledky se ale lze podívat i při rozehrané hře  

ROCK PAPER SCISSORS:  
V tomto okně lze hrát hru kámen nůžky papír  
Tlačítko Start spustí novou hru a zobrazí ovládání  
Hra se skládá z 20 kol, kde počítač a uživatel vybere kámen, nůžky nebo papír  
Podle pravidla, které říká, že kámen porazí nůžky, nůžky porazí papír a papír porazí kámen, se určí vítěz kola  
Pokud vyhrál uživatel, získá body, jejichž množství se exponencionálně navyšuje  
Po odehrání 20 kol se zobrazí finální detailní výsledek  
Tlačítko Highscores zobrazí 20 nejlepších výsledků  
Tlačítko Back vrátí zpět do herního menu  
Zavření samotného okna má stejný účinek jako zmáčknutí tlačítka Back  
Při zavření okna s rozehranou hrou se hra resetuje a výsledek se neuloží  
Na nejlepší výsledky se ale lze podívat i při rozehrané hře  

HIGHSCORES:  
V tomto okně se zobrazují výsledky hry, ze které bylo toto okno otevřeno  
Zobrazí 20 nejlepších výsledků dané hry  
Zobrazené informace - uživatel, skóre, čas (trvání kvízu), datum a čas  
Tlačítko Refresh načte výsledky znovu  
Tlačítko Back vrátí do okna s danou hrou  
Zavření samotného okna má stejný účinek jako zmáčknutí tlačítka Back  

JOKES & QUOTES:  
V tomto okně lze vypsat nádodný vtip nebo citát  
Tlačítko Joke zobrazí náhodný vtip  
Tlačítko Quote zobrazí náhodný citát a jeho autora  
Tlačítko Back vrátí zpět do hlavního menu  
Zavření samotného okna má stejný účinek jako zmáčknutí tlačítka Back  

EXTRA INFORMACE:  
Program lze ovládat pouze klávesnicí pomocí klávesy TAB, kterou lze označovat tlačitka, která se následně potvrdí klávesou ENTER  
Případně lze místo klávesy TAB použít šipky  
