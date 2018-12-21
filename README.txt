README v1.0 / 21 DECEMBER 2018


#  Projekat
	Arhiva

## Uvod
	Ova aplikacija nam omogucava kreiranje i cuvanje obrazaca
	koji sadrze podatke o skolama MVC pristupom uz VS 2017 Individual 
	authorization koji formira odredjene modele, kontrolere i view-ove.
	Koriscenje ovog pomagala je ustvari veoma odmoglo:
		U pravljenju user lista i admin funkcionalnosti nad korisnicima.
		Sa brisanjem auto-generisanih modela i kontrolera
		Problemi u manipulaciji nad celom bazom
	

	Aplikacija je radjena code-first principom sa koriscenjem Entity 
	Framework-a.
	Napravljene su funkcionalnosti Skole a podaci koji se mogu cuvati su:

	Naziv skole,
	Adresa registracije skole,
	Opstina,
	Postanski broj,
	Maticni broj skole,
	PIB,
	Broj racuna skole u platnom prometu,
	Web stranica skole,
	Kontakt osoba,
	Fotografija pecata skole,
	Beleska.

	Zbog nedostatka vremena i znanja Kontakt osoba nema mogucnost liste i 
	nije moguce ubaciti fotografiju(mada imamo ideju kako bismo ovo uradili).
	

## Koriscenje
	
	Za registrovanje korisnika potrebni su Email, Username, Password i Confirm Password
	Posto se novi korisnik registruje on dobija ulogu "Guest", uloge "Admin" i "Employee" 
	su nazalost hard code-ovane zbog ranije spomenutih problema sa auto genisanom bazom.

	Registracija i prijava je potrebna za bilo koju funkcionalnost sa radom sa Skola bazom

	Radi provere funkcionalnosti softvera, dajemo Vam LogIn informacije Admina i Employee rola
	Rola admin ima username "Admin" i sifru "passW0rd?"
	Rola employee ima username "Employee" i sifru "Sifra123?"
	
	Privilegije Admina:
		Prikaz skola
		Ubacivanje skola
		Menjanje skola
		Brisanje skola
		Pregled registrovanih korisnika i njihovih rola*
		Stampanje skola

	Privilegije Employee-a:
		Prikaz skola
		Ubacivanje skola
		Menjanje skola
		Brisanje skola
		Stampaje skola

	Privilegije Guest-a:
		Prikaz skola
		Stampanje skola
		
	*Pregled registrovanih korisnika i njihovih rola
		Ova funkcionalnost je odradjena SQL Query kodom u auto generisanom 
		ManageController-u. Istim pristupom smo hteli da menjamo i manipulisemo
		korisnicima ali smo uspeli da odradimo samo ovu funkcionalnost. 
		
		Ona je prikazana na aplikaciji samo adminu kada klikne svoj Username.

	UnitTestovi nazalost nisu odradjeni.
	 
## Radili 

	Dejan Vukovic 551/16 - Product owner 

	Aleksa Saveski 210/15 - Scrum master
	
	