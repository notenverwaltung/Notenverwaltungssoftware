### Durchführung der Datensicherung

Eine komplette Sicherung der Daten wird im Programm unter dem Menüpunkt 'Optionen' vorgenommen. In der Zeile 'Datensicherung nach Pfad' kann man einen festen Pfad hinterlegen wohin die Daten gesichert werden sollen. Es wird unter anderem von AUPLUS¹ dringend empfohlen die Daten auf einen externen Datenträger zu sichern. **Deshalb werden bei der Notenverwaltung zwei Festplatten (je 256 GB) zur Datenspiegelung (RAID-Level 1) verwendet, um eine oder mehrere identische Kopien der Daten bereitzuhalten.** Die Daten liegen zentralisiert auf einer MySQL-Datenbank (VM_2). Diese lässt sich über den „mysqldump“ - Befehl sichern. Aus finanziellen Gründen wird man die Daten per Skript auf die (VM_1) auslagern. Wenn die Daten auf dem gleichen Rechner gesichert werden besteht die Gefahr nach einem Hardwaredefekt nicht mehr auf die Daten zugreifen zu können. Bei einem Diebstahl wäre die Datensicherung ebenfalls verloren. 

Es kann auch erinnert werden, wenn eine Datensicherung nach einem freiwählbaren Intervall (z.B. 7 Tage nach der letzten Datensicherung) vorgenommen werden soll. Alternativ kann man einstellen, dass nach dem eingestellten Intervall beim Beenden des Programms eine Datensicherung durchgeführt werden soll. Es wird empfohlen diese Option zu aktivieren, um eine regelmäßige und unkomplizierte  Sicherung der Daten zu gewährleisten.


#### Folgende Vorteile ergeben sich bei einer Datensicherung:

 - Nach Hardwaredefekt/Diebstahl können Daten in wenigen Sekunden wiederhergestellt werden. (solange nicht auf dem gleichen Rechner gesichert wird, siehe oben)
-  Freischaltungscodes sind darin gespeichert
-   keine verlorene Arbeitszeit durch Nacherfassen der Daten
-   Durchführung der Datensicherung dauert wenige Sekunden

   



Zur Sicherung einer MySQL Datenbank wird das Kommandozeilen-Tool [mysqldump](http://dev.mysql.com/doc/refman/5.1/en/mysqldump.html) benötigt. 
Es wird standardmäßig zusammen mit dem MySQL Server installiert und wie folgt aufgerufen:
```bash 
mysqldump -u<Benutzername> -p<Passwort> <Datenbank> > <SQL-Datei>
```

### MySQL Datenbank wiederherstellen
Die Syntax zum Wiederherstellen einer Datenbank lautet wie folgt:

    
    mysql -u<Benutzername> –p<Passwort> <Datenbank> < <SQL-Datei>

Zur Sicherung der Datenbanken kann das folgende Bashscript verwendet werden. Die Datenbank wird in eine separate SQL-Datei gesichert. Das ausgeführte Script überschreibt jedes mal die alten Datensicherungen. 

    ```
     #! /bin/bash
	BACKUPDIR=<Sicherungsordner>
	USERNAME=<Benutzername>
	PASSWORD=<Passwort>

	if [ -d $BACKUPDIR ]; then
	    rm -r $BACKUPDIR
	fi

	mkdir $BACKUPDIR
	cd $BACKUPDIR

	DATABASES=`mysql -u$USERNAME -p$PASSWORD -Bse 'show databases'`
	for DATABASE in $DATABASES; do
	    if [ "$DATABASE" != "information_schema" ]; then
	        mysqldump -u$USERNAME -p$PASSWORD $DATABASE > ${DATABASE}.sql
	    fi
	done

Als Erstes werden die Variablen definiert, die das Sicherungsverzeichnis und die nötigen Anmeldedaten beinhalten. Als Nächstes wird abgefragt, ob ein Directory vorhanden ist bzw. eingetragen wurde. Wenn ja dann wird die Variable $BACKUPDIR gelöscht. Dann wird ein Verzeichnis erstellt mit der Variable $BACKUPDIR und navigiert in dieses Verzeichnis. Danach wird die 'DATABASE' Variable mit dem Syntax zur Wiederherstellung einer Datenbank gefüllt und eine For-Schleife definiert. Diese Schleife durchläuft die existierenden Datenbanken und für jede Datenbank soll folgendes abgefragt werden: Wenn die Datenbank nicht den Namen "information_schema" trägt soll die Datenbank mit dem mysqldump - Befehl in dem angegebenden Verzeichnis mit dem Namen  ${DATABASE}.sql  gespeichert werden. "information_schema" ist eine Datenbank, die eine Liste aller Tabellen und aller Felder  enthält, die in einer Tabelle enthalten sind. 

    
```
[¹]: https://www.auplus.de/faq/artikel/datensicherung-und-ruecksicherung.page202.html
[²]: https://www.patrick-gotthard.de/mysql-datenbanken-sichern-und-wiederherstellen/#:~:text=Zur%20Sicherung%20aller%20Datenbanken%20eines,also%20noch%20weiter%20verarbeitet%20werden.
```
