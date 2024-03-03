# InstrumenteMuzicale


Aplicație Visual Studio C#
Pentru obținerea atestatului de competențe profesionale la informatică



CUPRINS

1.	Motivul alegerii temei	3
2.	Structura lucrării	3
3.	Descrierea lucrării	6
4.	Resurse hardware și software necesare	8
5.	Posibilități de dezvoltare și concluzii	8
6.	Bibliografie	9



 
**1.	Motivul alegerii temei**

Alegerea temei a fost inspirată din pasiunea pentru muzică și, în special, sunetele armonioase ale instrumentelor muzicale. Există numeroase aplicații pentru acordare sau identificarea notelor pe baza unor sunete, însă, nu am întâlnit o aplicație care să conțină majoritatea instrumentelor, împreună cu anumite detalii legate de notele fiecăruia. În plus, faptul că detaliile relevante se află în același loc, aduce  un aspect plăcut aplicației. 

**2.	Structura lucrării**

Aplicația este compusă din patru form-uri:  form-ul principal („Instrumente Muzicale”) care este format din trei checkbox-uri cu aspect de buton, două etichete („label”), una cu titlul aplicației și una cu titlul categoriei de instrumente. Checkbox-urile, respectiv etichetele și câteva pictograme de tipul „picturebox” se află într-un panou. În același timp, celelalte form-uri prezintă detalii despre un anumit instrument, în funcție de butonul apăsat.

![image](https://github.com/nataliadanci/InstrumenteMuzicale/assets/161059973/e04f21b5-8f45-4a82-803a-6734fed8c1bc)


 	Form-urile secundare au fiecare câte șase, respectiv patru și patru checkbox-uri (la fel, cu aspect de buton) reprezentând notele instrumentului (în cazul nostru corzile), plus un buton de ajutor la fiecare form pentru explicarea notelor (acestea fiind notate literal nu cu denumirile silabice ale sunetelor).

  ![image](https://github.com/nataliadanci/InstrumenteMuzicale/assets/161059973/9d254917-6a96-4988-b663-136677d3e512)
  ![image](https://github.com/nataliadanci/InstrumenteMuzicale/assets/161059973/e3004e38-c890-4466-9fe2-65ddf37418b9)
  ![image](https://github.com/nataliadanci/InstrumenteMuzicale/assets/161059973/ee79f9d0-eccd-4863-92bc-34019f0b8da2)
  ![image](https://github.com/nataliadanci/InstrumenteMuzicale/assets/161059973/bc98eb29-b1f4-4ace-ad0d-efcc1537ea56)
  ![image](https://github.com/nataliadanci/InstrumenteMuzicale/assets/161059973/830eb38d-2e9e-43af-b44e-99d969aa7b02)
  ![image](https://github.com/nataliadanci/InstrumenteMuzicale/assets/161059973/65ff0563-72c6-401e-8515-d7ffcd8ee663)

 
**3.	Descrierea lucrării**

Aplicația se deschide odată cu apariția primului form („Intrumente Muzicale”) – de aici, utilizatorul poate alege unul dintre cele trei butoane („Chitară”, „Vioară”, „Violoncel”) dacă dorește să asculte sunetele unuia dintre cele trei instrumente”).

![image](https://github.com/nataliadanci/InstrumenteMuzicale/assets/161059973/053d061a-7de9-4ef2-b44f-94e68a6a169d)
![image](https://github.com/nataliadanci/InstrumenteMuzicale/assets/161059973/a8022ec2-9ef0-4e24-94ca-bf679f53daff)



Fiecare checkbox, din fiecare form, are atașat un fișier de tip „wav”, în acest fel, la apăsarea unui buton se aude nota dorită. Deși unele checkbox-uri au aceeași denumire, în funcție de instrument și notă, sunetul este diferit. Sunetele sunt păstrate în variabile de tip „SoundPlayer”.

![image](https://github.com/nataliadanci/InstrumenteMuzicale/assets/161059973/eebf1c4d-31c5-4741-8d55-d12640ef6da8)
![image](https://github.com/nataliadanci/InstrumenteMuzicale/assets/161059973/671dc45e-5c64-47c7-b08a-974a28f386ce)


De asemenea, checkbox-urile au o proprietate: când se dorește ascultarea unei note, la prima apăsare se pornește sunetul și apare mesajul „Stop”, astfel încât la a doua apăsare sunetul se oprește. Fiecare checkbox, indiferent de form sau notă are această proprietate.


**4.	Resurse hardware și software necesare**

Pentru a putea utiliza această aplicație, utilizatorul are nevoie de un calculator cu:
•	Sistem de operare: Windows 10
•	Mediul de dezvoltare: Microsoft Visual Studio 2019
•	Tastatură;
•	Mouse;
•	Placă de bază cu un procesor de minim 1.80GHz;
•	Placă de sunet;
•	Minim 8.00 GB RAM.

**5.	Posibilități de dezvoltare și concluzii**

 	Aplicația ar putea fi îmbunătățită prin adăugarea altor tipuri de instrumente și, ulterior, adăugarea unor informații de la diferite instituții, unde să existe profesori sau persoane cu anumite studii în domeniul muzicii care pot desfășura meditații pentru posibili elevi doritori să studieze unul sau mai multe instrumente. În cadrul acestor informații ar trebui să existe o listă cu modalitățiile de contactare a instituției, și eventual imagini cu mediul unde se vor desfășura meditațiile sau posibile activități în grup.
	La un nivel mai mare de dezvoltare a aplicației, fiecare form ar putea să conțină informații despre un anumit instrument, structurate pe categorii. Spre exemplu, form-ul chitarei poate avea informații legate de instrumentul în sine, despre instituții unde este posibilă învățarea și practicarea instrumentului și imagini sau contacte personale ale profesorilor care practică acel instrument.

**6.	Bibliografie**

,,Programarea Orientată pe Obiecte și Programarea Vizuală”, Microsoft
https://www.dailycal.org/2020/08/07/music-is-the-universal-language-how-musical-notation-and-language-are-linked/
-poza folosită pentru form-ul principal („Instrumente Muzicale”)
https://www.freepik.com/iwat1929 
-pozele folosite la form-urile instrumentelor („Chitară”, „Vioară”, „Violoncel”)

https://www.youtube.com/watch?v=ZpN6l0SuNeI
https://www.youtube.com/watch?v=-JY8UxCjZoY
-pentru sunetele corzilor înregistrate la vioară și violoncel
-sunetele corzilor de la chitară au fost înregistrate personal
https://icons8.com/
-pentru pictogramele folosite în aplicație

