
!!! note
    Die folgende Seite befindet sich noch in Planung und wird im Laufe der Projektarbeit vervollständigt.
    Wir bitten um Geduld.
    
   ### Installieren von MySQL unter CentOS 8
   MySQL ist ein Open-Source-Datenbankmanagementsystem, welches das relationale Modell und die Structured Query Language (SQL) zur Verwaltung und Abfrage von Daten  implementiert.
   
 In dem folgenden Befehl wird das Paket mysql-server und eine Reihe seiner Abhängigkeiten installiert:
 
```
    sudo dnf install mysql-server
```
Das installierte MySQL ist noch nicht betriebsbereit. Damit man MySQL verwenden kann, müssen Sie es mit dem Befehl systemctl starten:

```
sudo systemctl start mysqld.service
```

Wurde MySQL erfolgreich gestartet, zeigt die Ausgabe im Active-Status (running). Um diesen Output zu gelangen führt man folgenden Befehl aus:

```
sudo systemctl status mysqld
```
Damit MySQL bei jedem Hochfahren des Servers startet, führt man anschließend mit folgendem Befehl aus:
```
    sudo systemctl enable mysqld
```


MySQL ist nun installiert, wird ausgeführt und ist auf Ihrem Server aktiviert. Als Nächstes wird die Sicherheit der Datenbank mit einem Shell-Skript, das mit Ihrer MySQL-Instanz vorinstalliert wurde, erhöht. Es wurde sich an der Website [digitalocean.com](https://www.digitalocean.com/community/tutorials/how-to-install-mysql-on-centos-8-de) orientiert. Dort sind meherere Schritte zur Konmfiguration von MySQL beschrieben.
   
   ### Installation & Konfiguration des Active Directorys (FreeIPA)
   
   
Als Erstes wird ein qualifizierten Hostnamen in dem System eingerichtet. 

```
hostnamectl set-hostname freeipa.mydomain10.com
```

Als Nächstes wird etc/hosts Datei geändert und die Server IP und den Hostnamen hinzugefügt. 
```

nano /etc/hosts
45.58.43.185 freeipa.mydomain10.com
```

Danach wird die Datei gespeichert und geschlossen.



#### FreeIPA Server installieren
Standardmäßig ist das FreeIPA-Paket nicht im CentOS-Standard-Repository verfügbar. Daher muss das idm:DL1-Repository in dem System aktiviert werden.
Das wird mit dem folgenden Befehl aktiviert:

```
dnf module enable idm:DL1
```

Als nächstes synchronisiert man das Repository mit dem folgenden Befehl:

```
dnf distro-sync
```

Der folgende Schritt dient zur Installation des FreeIPA Server auf dem System.

```
dnf install ipa-server ipa-server-dns -y
```

Wenn die Installation abgeschlossen ist, kann mit der Einrichtung begonnen werden.



Es wurde sich an der Website [howtoforge.com](https://www.howtoforge.com/tutorial/install-and-configure-freeipa-server-on-centos-8/) orientiert und die Einrichtung, Konfiguration sowie den Zugang angepasst. 


