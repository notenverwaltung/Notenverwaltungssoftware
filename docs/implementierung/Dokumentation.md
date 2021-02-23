
!!! note
    Die folgende Seite befindet sich noch in Planung und wird im Laufe der Projektarbeit vervollständigt.
    Wir bitten um Geduld.
    
   ### LDAP-Einrichtung
   
   
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



Es wurde sich an der Website [howtoforge.com](https://www.howtoforge.com/tutorial/install-and-configure-freeipa-server-on-centos-8/) orientiert und die Einrichtung, Konfiguration sowie den Zugang angepasst. [^1]



[^1]: http://slashdot.org


