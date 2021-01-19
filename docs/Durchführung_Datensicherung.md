### Durchführung der Datensicherung

Eine komplette Sicherung der Daten wird im Programm unter dem Menüpunkt 'Optionen' vorgenommen. In der Zeile 'Datensicherung nach Pfad' kann man einen festen Pfad hinterlegen wohin die Daten gesichert werden sollen. Es wird unter anderem von AUPLUS[^1] und IONOS[^2] dringend empfohlen die Daten auf einen externen Datenträger zu sichern. Die Daten liegen zentralisiert auf einer MySQL-Datenbank (VM_2). Diese lässt sich über den „mysqldump“ - Befehl sichern. Aus finanziellen Gründen wird man die Daten per Skript auf die (VM_1) auslagern. Wenn die Daten auf dem gleichen Rechner gesichert werden besteht die Gefahr nach einem Hardwaredefekt nicht mehr auf die Daten zugreifen zu können. Bei einem Diebstahl wäre die Datensicherung ebenfalls verloren. 

#### Folgende Vorteile ergeben sich bei einer Datensicherung:

 - Nach Hardwaredefekt/Diebstahl können Daten in wenigen Sekunden wiederhergestellt werden. (solange nicht auf dem gleichen Rechner gesichert wird, siehe oben)
-  Freischaltungscodes sind darin gespeichert
-   keine verlorene Arbeitszeit durch Nacherfassen der Daten
-   Durchführung der Datensicherung dauert wenige Sekunden


Aufgrund der überschaubaren Datenmenge des Notenverwaltungstools, ist die MySQL-Datenbank täglich zu sichern (täglich von 0:00 Uhr bis 1:00 Uhr). Hierfür wird auf eine minimierte BAT-Datei mit dem hinterlegten Sicherungscript einer MySQL-Datenbank in der Aufgabenplanung ausgeführt. Dafür ist vorauszusetzen, dass der Server auf denen die VMs aktiv sind auch zu dieser Zeit laufen. Es wird davon ausgegangen, dass die Server ununterbrochen ausgeführt sind.



Zur Sicherung einer MySQL Datenbank wird das Kommandozeilen-Tool [mysqldump](http://dev.mysql.com/doc/refman/5.1/en/mysqldump.html) benötigt. 
Es wird standardmäßig zusammen mit dem MySQL Server installiert und wie folgt aufgerufen[^3]:
``` 
mysqldump -u<Benutzername> -p<Passwort> <Datenbank> > <SQL-Datei>
```

#### MySQL Datenbank wiederherstellen

Die Syntax zum Wiederherstellen einer Datenbank lautet wie folgt[^3]:

    
    mysql -u<Benutzername> –p<Passwort> <Datenbank> < <SQL-Datei>

Zur Sicherung der Datenbanken kann das folgende Bashscript verwendet werden. Die Datenbank wird in eine separate SQL-Datei gesichert. Das ausgeführte Script überschreibt jedes mal die alten Datensicherungen auf der VM_2[^3]. 

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
	```
Als Erstes werden die Variablen definiert, die das Sicherungsverzeichnis und die nötigen Anmeldedaten beinhalten. Als Nächstes wird abgefragt, ob ein Directory vorhanden ist bzw. eingetragen wurde. Wenn ja dann wird die Variable $BACKUPDIR gelöscht. Dann wird ein Verzeichnis erstellt mit der Variable $BACKUPDIR und navigiert in dieses Verzeichnis. Danach wird die 'DATABASE' Variable mit dem Syntax zur Wiederherstellung einer Datenbank gefüllt und eine For-Schleife definiert. Diese Schleife durchläuft die existierenden Datenbanken und für jede Datenbank soll folgendes abgefragt werden: Wenn die Datenbank nicht den Namen "information_schema" trägt soll die Datenbank mit dem mysqldump - Befehl in dem angegebenden Verzeichnis mit dem Namen  ${DATABASE}.sql  gespeichert werden. "information_schema" ist eine Datenbank, die eine Liste aller Tabellen und aller Felder  enthält, die in einer Tabelle enthalten sind. 

    
#### Sicherung der VMs

Als Zweites wird ein Backup der VMs vorgenommen. Die VMs werden angehalten, der aktuelle Zustand der virtuellen Maschinen  gespeichert, kopiert und anschließend wieder gestartet. Dies startet von um 1:00 Uhr - 2:00 Uhr in der Aufgabenplanung als BATCH-Script.


Folgendes zum Script für den Ablauf der Sicherung der VMs[^4]:

``` 
"VERZEICHNIS:\vboxmanage.exe" controlvm <CENTOSServer> savestate
xcopy "VERZEICHNIS:\Users\da\VirtualBox VMs\UbuntuServer\*" VERZEICHNIS:\backup_vm\%date%\* /Y /S
"VERZEICHNIS:\Program Files\Oracle\VirtualBox\vboxmanage.exe" startvm <CENTOSServer>
```

'vboxmanage.exe' befindet sich im Programmverzeichnis und erlaubt das Steuern der VM. 

Der Parameter /S nimmt hierbei auch die Unterverzeichnisse mit, /Y überschreibt eventuelle Dateien mit gleichen Namen ohne Rückfrage. Mittels %date% wird für jeden Tag ein neuer Ordner angelegt, so dass normalerweise keine Dateien überschrieben werden sollten, sondern jeweils ein eigenes Verzeichnis angelegt werden. Somit hat man gleich auch verschiedene Stände der virtuellen Maschine, zu denen man im Bedarfsfall wechseln kann.


[^1]: https://www.auplus.de/faq/artikel/datensicherung-und-ruecksicherung.page202.html
[^2]: https://www.ionos.de/digitalguide/server/sicherheit/datensicherung-von-datenbanken/
[^3]: https://www.patrick-gotthard.de/mysql-datenbanken-sichern-und-wiederherstellen/#:~:text=Zur%20Sicherung%20aller%20Datenbanken%20eines,also%20noch%20weiter%20verarbeitet%20werden.
[^4]:https://andydunkel.net/2018/02/18/backup-von-virtualbox-vms-automatisieren/

