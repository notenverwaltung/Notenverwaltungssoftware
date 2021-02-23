### Datenschutz

Ein Schutz der Daten im Notenverwaltungsprogramm ist schon damit gewährleistet, dass die Nutzer ihre Login-Daten (geheimes Passwort + Benutzername) nutzen müssen um mit dem Tool zu arbeiten. Es wird unter anderem von AUPLUS[^2] und IONOS[^2] dringend empfohlen die Daten auf einen externen Datenträger zu sichern. Auf die VMs, auf denen Datenbank und die Backups gespeichert sind, hat ausschließlich der IT-Administrator Zugriff. Um auf die VMs zugreifen zu können, wird immer ein Passwort und ein Username angefordert. Dabei gibt es zwei Benutzer:

- Domänen-Administrator(root) --> Rechte auf alles, für Konfiguration der VMs 
- Domänen-Benutzer (user) --> Keine Administrator - Berechtigung

### Datensicherheit

Da es sich bei dem Notenverwaltungstool, um ein Programm handelt kann man feststellen, dass man ausschließlich nur im Netzwerk eine Verbindung zur Datenbank und dem Anmeldeserver aufbauen kann. Es können keine externen Geräte eine Verbindung mit den VMs und damit den Datenbanken aufnehmen. Es muss sichergestellt werden, dass sich keine unbefugten Personen mit dem Netzwerk verbinden, um Zugang auf das Tool zu erhalten. Außerdem müssen die Nutzernamen und Passwörter des Grundschulpersonals und dem IT-Administrator geheimgehalten werden, damit man eine Manipulation der Software oder der Daten auszuschließen ist.  
Die Datenbankverbindung von der Notenverwaltungssoftware zum Datenbankserver wird gesichert über eine SSL-Zertifkat hergestellt. Dabei wird eine gesicherte Verbindung erzwungen.
Dafür wird folgende Verbindungszeichenkette verwendet.[^7]
```bash
Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;SslMode=Required;
```

### Datensicherung

Die Daten liegen zentralisiert auf einer MySQL-Datenbank (VM_2). Aus finanziellen Gründen wird man die Daten per Skript auf die (VM_1) auslagern. Wenn die Daten auf dem gleichen Rechner gesichert werden besteht die Gefahr nach einem Hardwaredefekt nicht mehr auf die Daten zugreifen zu können. Bei einem Diebstahl wäre die Datensicherung ebenfalls verloren. 

Dabei ist die MySQl-Datenbank ebenfalls nochmal durch einen 'user' und einen 'root-user' gesichert. Der 'user' hat dabei nur Zugriff auf die Datenbank indem die Noten hinterlegt sind. Der 'root-user' hat Berechtigung für alles.

#### Folgende Vorteile ergeben sich bei einer Datensicherung:

- Nach Hardwaredefekt/Diebstahl können Daten in wenigen Sekunden wiederhergestellt werden. (solange nicht auf dem gleichen Rechner gesichert wird, siehe oben)
- Freischaltungscodes sind darin gespeichert
- keine verlorene Arbeitszeit durch Nacherfassen der Daten
- Durchführung der Datensicherung dauert wenige Sekunden

#### Automatisierung
Für den automatisierten Ablauf der Datensicherung werden die BASH-Skripte zur Sicherung der Datenbank und der Virtuellen Maschinen in die `Cronjob`-Tabelle[^6] eingetragen. Um dies zu tun muss zunächst mit `crontab -e` eine neue `crontab` Datei erstellt werden. Im Folgenden Beispiel wird ein festgelegtes Skript eingetragen, was täglich um 1:00 Uhr ausgeführt wird.
```bash
* 1 * * * [Pfad zum Skript]
```

#### Sicherung der Datenbank
Aufgrund der überschaubaren Datenmenge des Notenverwaltungstools, ist die MySQL-Datenbank täglich zu sichern. Dafür ist vorauszusetzen, dass der Datenbankserver auf der Virtuellen Maschine aktiv ist und auch zu dieser Zeit läuft. Es wird davon ausgegangen, dass die Server ununterbrochen ausgeführt sind.

Zur Sicherung einer MySQL Datenbank wird das Kommandozeilen-Tool `mysqldump`[^5] benötigt. 
Es wird standardmäßig zusammen mit dem MySQL Server(normalerweise unter */usr/local/mysql/bin*) installiert und wie folgt aufgerufen[^3]:
```bash
mysqldump --user=[Benutzername] --password=[Passwort] [Datenbank] > [SQL-Datei]
```

Zur Sicherung der Datenbanken wird das folgende Bashscript verwendet werden. Die Datenbank-Sicherung wird in einer separaten SQL-Datei, in einem Sicherungsordner gespeichert.
```bash
BACKUPDIR=[Sicherungsordner]
USERNAME=[Benutzername]
PASSWORD=[Passwort]
DATABASE=[Datenbank]
NOW=$(date +'%d-%m-%Y %H %M %S')

mkdir $BACKUPDIR
cd $BACKUPDIR

mysqldump --user=$USERNAME --password=$PASSWORD $DATABASE > $DATABASE-$NOW.sql
``` 

Als Erstes werden die Variablen definiert, die das Sicherungsverzeichnis, das aktuelle Datum, den Datenbanknamen sowie die nötigen Anmeldedaten beinhalten. Als Nächstes wird abgefragt, ob der Sicherungsordner bereits vorhanden ist. Wenn dieser noch nicht besteht, wird das Verzeichnis erstellt und dorthin gewechselt. Mit dem `mysqldump`[^5] - Befehl wird nun im Sicherungsverzeichnis ein Backup, in Form einer SQL-Datei erstellt, die den Namen der Datenbank inlusive des derzeitiges Datums enthält.

#### Rücksicherung der Datenbank
Die Syntax zum Wiederherstellen einer Datenbank lautet wie folgt[^3]:
``` bash
mysql --user=[Benutzername] --password=[Passwort] [Datenbank] < [SQL-Datei]
``` 


#### Sicherung der Virtuellen Maschinen

Als Zweites wird ein Backup der Virtuellen Maschinen vorgenommen. Während der Laufzeit wird dabei ein Abbild der Virtuellen Maschine gesichert.

Folgendes Script wird für die Sicherung der VMs genutzt[^4]:

```bash
"c:\Program Files\Oracle\VirtualBox\vboxmanage.exe" controlvm UbuntuServer savestate
xcopy "C:\Users\da\VirtualBox VMs\UbuntuServer\*" e:\backup_vm\%date%\* /Y /S
"c:\Program Files\Oracle\VirtualBox\vboxmanage.exe" startvm UbuntuServer
```
Im ersten Schritt wird die virtuelle Maschine angehalten und der aktuelle Zustand gespeichert:

“UbuntuServer” ist hierbei der Name der VM, wie er auch in der Manager Software angezeigt wird.

`VBoxManage.exe` befindet sich im Installationsverzeichnis von VirtualBox(normalerweise unter *C:\Program Files\Oracle\VirtualBox*) und erlaubt das Verwalten der Virtuellen Maschine über die Kommandozeile. [^4]

Die zweite Zeile kopiert die VM in das Backup-Verzeichnis. Der Parameter /S nimmt hierbei auch die Unterverzeichnisse mit, /Y überschreibt eventuelle Dateien mit gleichen Namen ohne Rückfrage. Mittels %date% wird für jeden Tag ein neuer Ordner angelegt, so dass normalerweise keine Dateien überschrieben werden sollten, sondern jeweils ein eigenes Verzeichnis angelegt werden. Somit hat man gleich auch verschiedene Stände der virtuellen Maschine, zu denen man im Bedarfsfall wechseln kann.[^4]

Die Batch-Datei kann man nun noch zeitgesteuert starten und ausführen lassen, so dass z.B. nachts automatisch ein Backup erzeugt wird. Je nach Größe der virtuellen Maschine und des Backupsspeichers, sollte man alte Backups löschen, da diese sonst sehr viel Platz einnehmen.[^4]

####  Rücksicherung der Virtuellen Maschinen
Zur Rücksicherung muss man die .vdi - Datei aus dem Backup-Ordner der jeweiligen Maschine einfach starten und die VM sollte wieder laufen, da in unserem Fall eine komplette Sicherung der Virtuelle Maschine erfolgt ist. Dies heißt es besteht eine 1 zu 1 Kopie der Virtuellen Maschine.


[^1]: https://www.auplus.de/faq/artikel/datensicherung-und-ruecksicherung.page202.html (19.01.2021)
[^2]: https://www.ionos.de/digitalguide/server/sicherheit/datensicherung-von-datenbanken/ (19.01.2021)
[^3]: https://dev.mysql.com/doc/refman/8.0/en/mysqldump.html (19.01.2021)
[^4]: https://andydunkel.net/2019/03/16/virtualbox-backup-im-laufenden-betrieb-durchfuehren/ (19.01.2021)
[^5]: http://dev.mysql.com/doc/refman/5.1/en/mysqldump.html (19.01.2021)
[^6]: https://www.stetic.com/developer/cronjob-linux-tutorial-und-crontab-syntax/ (25.01.2021)
[^7]: https://www.connectionstrings.com/mysql/ (25.01.2021)
