Eine Sicherung der Daten im Notenverwaltungsprogramm ist schon damit gewährleistet, dass die Nutzer ihre Login-Daten (geheimes Passwort + Benutzername) nutzen müssen um mit dem Tool zu arbeiten. Es wird unter anderem von AUPLUS[^¹] und IONOS[^²] dringend empfohlen die Daten auf einen externen Datenträger zu sichern. Auf die VMs hat ausschließlich der IT-Administrator Zugriff. Um auf die VMs zugreifen zu können, wird immer ein Passwort und ein Username angefordert. Dabei gibt es zwei Benutzer:

- Mysql-root --> Rechte auf alles, für Konfiguration der VMs 
- Mysql-user --> Rechte nur auf Datenbank Notenverwaltung lesen und schreiben

Die Daten liegen zentralisiert auf einer MySQL-Datenbank (VM_2). Diese lässt sich über den `mysqldump`[^5] - Befehl sichern. Aus finanziellen Gründen wird man die Daten per Skript auf die (VM_1) auslagern. Wenn die Daten auf dem gleichen Rechner gesichert werden besteht die Gefahr nach einem Hardwaredefekt nicht mehr auf die Daten zugreifen zu können. Bei einem Diebstahl wäre die Datensicherung ebenfalls verloren. 

#### Folgende Vorteile ergeben sich bei einer Datensicherung:

- Nach Hardwaredefekt/Diebstahl können Daten in wenigen Sekunden wiederhergestellt werden. (solange nicht auf dem gleichen Rechner gesichert wird, siehe oben)
- Freischaltungscodes sind darin gespeichert
- keine verlorene Arbeitszeit durch Nacherfassen der Daten
- Durchführung der Datensicherung dauert wenige Sekunden

Für den automatisierten Ablauf der Datensicherung werden die BASH-Skripte zur Sicherung der Datenbank und der Virtuellen Maschinen in die `Cronjob`-Tabelle eingetragen. Um dies zu tun muss zunächst mit `crontab -e` eine neue `crontab` Datei erstellt werden. Im Folgenden Beispiel wird ein festgelegtes Skript täglich um 1:00 Uhr ausgeführt.
```bash
* 1 * * * [Pfad zum Skript]
```

#### Sicherung der Datenbank
Aufgrund der überschaubaren Datenmenge des Notenverwaltungstools, ist die MySQL-Datenbank täglich zu sichern. Dafür ist vorauszusetzen, dass der Datenbankserver auf der Virtuellen Maschine aktiv ist und auch zu dieser Zeit laufen. Es wird davon ausgegangen, dass die Server ununterbrochen ausgeführt sind.

Zur Sicherung einer MySQL Datenbank wird das Kommandozeilen-Tool `mysqldump`[^5] benötigt. 
Es wird standardmäßig zusammen mit dem MySQL Server(normalerweise unter *C:\Program Files\MySQL\bin*) installiert und wie folgt aufgerufen[^³]:
```bash
mysqldump --user=[Benutzername] --password=[Passwort] [Datenbank] > [SQL-Datei]
```

Die Syntax zum Wiederherstellen einer Datenbank lautet wie folgt[^³]:
``` bash
mysql --user=[Benutzername] --password=[Passwort] [Datenbank] < [SQL-Datei]
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

#### Sicherung der VMs

Als Zweites wird ein Backup der VMs vorgenommen. Während der Laufzeit wird dabei ein Abbild der Virtuellen Maschine gesichert.


Folgendes zum Script für den Ablauf der Sicherung der VMs[^⁴]:

```bash
VMNAME=[VM-Name]
NOW=$(date +'%d-%m-%Y %H %M %S')

VBoxManage snapshot "$VMNAME" take "$VMNAME-$NOW"
```

`VBoxManage.exe` befindet sich im Installationsverzeichnis von VirtualBox(normalerweise unter *C:\Program Files\Oracle\VirtualBox*) und erlaubt das Verwalten der Virtuellen Maschine über die Kommandozeile. 
Der Sicherungsordner für die Snapshots muss einmalig in der Virtual Box Manager Software geändert werden unter Einstellungen > Allgemein > Erweitert > Snapshots-Zielordner.
Als Erstes werden die Variablen definiert, die den Namen der Virtuellen Maschine und das aktuelle Datum beinhalten. Somit hat man gleich verschiedene Stände der virtuellen Maschine, zu denen man im Bedarfsfall wechseln kann.


[^¹]: https://www.auplus.de/faq/artikel/datensicherung-und-ruecksicherung.page202.html (19.01.2021)
[^²]: https://www.ionos.de/digitalguide/server/sicherheit/datensicherung-von-datenbanken/ (19.01.2021)
[^³]: https://dev.mysql.com/doc/refman/8.0/en/mysqldump.html (19.01.2021)
[^⁴]: https://andydunkel.net/2019/03/16/virtualbox-backup-im-laufenden-betrieb-durchfuehren/ (19.01.2021)
[^5]: http://dev.mysql.com/doc/refman/5.1/en/mysqldump.html (19.01.2021)
