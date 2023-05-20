# Zad1-winform
C# primer1 sa lab vezbi.pdf: Na programskom jeziku C# kreira% aplikaciju za rad sa podacima o automobilima čija je glavna forma prikazana na slici. 
Uputstvo za implementaciju: Kreira% klasu Automobil koja ima privatne atribute
proizvođač, model, zapremina motora u litrima (realni broj), datum proizvodnje (DateTime
struktura), vrsta goriva (definisa% enumeraciju za taj atribut) i bool atribut koji označava da
li automobil ima atest za gasni uređaj. Definisa% javne property-je za svaki od atributa.
Klasa Automobil sadrži i sta%čku metodu za snimanje liste automobila u tekstualni fajl.
Način rada aplikacije: Korisnik popunjava podatke u kontrolama. Klik na dugme „Dodaj“
dodaje novi automobil u listu automobila i osvežava prikaz liste. Za automobile sa pogonom
na benzin ili dizel ne prikaziva% informaciju o atestu u lis%.
Kontrola za zapreminu motora može da prikaže vrednos% između 0.5 i 10 sa 3 decimalna
mesta.
Kontrola za atest je ak%vna (Enabled) samo ako je selektovan pogon na gas. Ako je
selektovan pogon na benzin ili dizel atribut atest ima vrednost false.
Izborom opcije Fajl->Snimi u meniju prikazuje se dijalog za snimanje fajlova i lista
automobila se snima u izabranom tekstualnom fajlu. Dijalog za snimanje fajlova filtrira
prikazane fajlove tako da su vidljivi samo fajlovi sa ekstenzijom .txt.
<img width="194" alt="image" src="https://github.com/arsenic02/Zad1-winform/assets/119541854/c01bbcd3-5d5b-4a9b-a92d-717b505aef14">
