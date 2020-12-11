## Aktuell
Zu der derzeit vorhandenen Hardware der Schule zählen 10 Lehrer-PCs mit dem Betriebssystem Windows 10 und dem Microsoft Office 2019 Standartpaket. Zudem besitzt die Schule einen Server mit dem Betriebssystem Microsoft Server 2019 mit Anmelde-, DNS-, DHCP-, Datei- und Druckdiensten.

## Lehrer-PC´s
Benötigt werden, schätzungsweise 8 GB Arbeitsspeicher. 4 GB sind bereits belegt durch Windows 10, 2 GB für Office Nutzung. An Festplattenspeicher wird mindestens 70 GB freier Speicherplatz benötigt. Für Windows 10 wird allein 50 GB benötigt und für eventuelle Reserven und Office sind 20 GB vorgesehen.

## Server
Der Server benötigt mindestens 8 GB Arbeitsspeicher. Die MySQL Workbench benötigt ein Minimun an Systemressourcen, damit ein reibungsloser Ablauf stattfinden kann, diese sind;[^1]

* CPU: Intel Core oder Xeon 3GHz (oder Dual Core 2GHz) oder ähnlich AMD CPU
* Cores: Single (Dual/Quad Core empfohlen)
* RAM: 4 GB (6 GB empfohlen)
* Grafiktreiber: Nvidia oder ATI(OpenGL >=  v. 1.5)
* Bildschirmauflösung: 1280×1024 is recommended, 1024×768 is minimum.

4 bis 6 GB Arbeitsspeicher sind allein für MySQL-Datenbank und Umgebung. Das lässt sich aus folgendene Informationen ableiten; Für ein Backup haben wir uns für ein RAID 1 entschieden, somit werden 2 Festplatten benötigt. Um sicher zu gehen, planen wir mit einer Speicherkapazität von 256GB je Festplatte.

[^1]: http://download.nust.na/pub6/mysql/doc/workbench/en/wb-requirements-hardware.html (11.12.2020)
