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
