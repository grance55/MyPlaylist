# MyPlaylist
PIN_Project

Aplikacija koju sam predao za projekt iz kolegija PIN, napisana je pomoću Visual Studia u programskom jeziku C#. ASP.NET je web framework koji nam pomaže da jednostavno kreiramo stranice koristeći C#, HTML, CSS, JS...
MVC(Models-Views-Controllers) je obrazac softverske arhitekture u kojem se odvajaju pojedini dijelovi aplikacije u komponente ovisno o njihovoj namjeni.
MVC se sastoji od tri cjeline: 
Model - to su zapravo podaci tj. baza podataka
View - je ono što klijent vidi na ekranu
Controller - prihvaća ulazne naputke i pretvara ih u naloge prema modelu ili pogledu.
Znači u Modelu se nalaze podadaci tj. naša baza podataka koja je napravljena pomoću entity frameworka-a. HomeController.cs je zapravo mozak naše aplikacije. On je zadužen za spajanje modela i viewa, npr. očitava uneseno ime i lozinku od korisnika, te sprema te podatke u bazu podataka. Folder View se sastoji od cshtml fileova, koji su obični html kod uz mogučnost korištenja C#. _Layout.cshtml i Error.cshtml predstavljaju dio koda kojeg dijele sve stranice koje se nalaze u Homeu.
MusicApp je u biti web aplikacija pomoću koje stvaramo svoju playlistu omiljene glazbe. Za svaku pjesmu koju dodamo u našu playlistu moramo dodati i ime glazbenika/grupe, ime pjesme, naziv albuma, žanr i datum izdavanja. Baza podataka MusicDB.mdf se sastoji od tih entiteta, svakim dodavanjem pjesme preko stranice ona se automatski dodaje u našu bazu podataka. Preko Create New dodajemo novi element u našu listu, moramo ispuniti sve podatke da bi se element uspiješno dodao. Također svaki element koji dodamo u listu, možemo naknadno mijenjati ili brisati.
