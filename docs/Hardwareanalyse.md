## Aktuell
Zu der aktuell vorhandenen Hardware der Schule zählen 10 Lehrer-PCs mit dem Betriebssystem Windows 10 und dem Microsoft Office 2019 Standardpaket. Zudem besitzt die Schule einen Server mit dem Betriebssystem Microsoft Server 2019 mit Anmelde-, DNS-, DHCP-, Datei- und Druckdiensten.

## Lehrer-PC´s
Für die Nutzung von Windows 10 sind folgende Mindestvoraussetzung vorgesehen;[^1]

* CPU: 1 GHz or faster processor or SoC
* RAM: 32 Bit: 1 GB/ 64 Bit: 2 GB
* Hard disk space: 16 GB for 32-bit OS or 20 GB for 64-bit OS
* Graphics card: DirectX 9 or later with WDDM 1.0 driver
* Bildschirmauflösung: 800 x 600

Daraus lässt sich schließen, dass mindestens 1 GB Arbeitsspeicher und 16 GB Festplattenspeicher bereits durch Windows 10 belegt sind. Da Microsoft Office 2019 weitherhin benutzt wird sind folgende Mindestvoraussetzung vorgesehen;[^2] 

* CPU:	1,6 GHz Dual Core (32- oder 64-Bit)
* RAM:	32 Bit: 2 GB/ 64 Bit: 4 GB
* Festplattenspeicher	4 GB
* Grafik:	1280 x 768 Pixel, DirectX 9 mit WDDM 2.0
* Browser:	Firefox, Chrome, Internet Explorer oder Microsoft Edge
* Software:	.NET Framework 3.5 oder 4.6

Daraus ergibt sich eine Nutzng des Arbeitsspeichers von etwa 4GB und eine Festplattennutzung von rund 4GB.

Aus zuvorgehender Analyse lässt sich ableiten, dass schätzungsweise 8 GB Arbeitsspeicher und 100 GB Festplattenspeicher benötigt werden. Für eventuelle Reserven ist noch genug Platz.

## Server
Die MySQL Workbench benötigt ein Minimun an Systemressourcen, damit ein reibungsloser Ablauf stattfinden kann, diese sind;[^3]

* CPU: Intel Core oder Xeon 3GHz (oder Dual Core 2GHz) oder ähnlich AMD CPU
* Cores: Single (Dual/Quad Core empfohlen)
* RAM: 4 GB (6 GB empfohlen)
* Grafiktreiber: Nvidia oder ATI(OpenGL >=  v. 1.5)
* Bildschirmauflösung: 1280×1024 is recommended, 1024×768 is minimum.

Daher benötigt der Server mindestens 8 GB Arbeitsspeicher.
Für ein Backup haben wir uns für ein RAID 1 entschieden, somit werden 2 Festplatten benötigt. Um sicher zu gehen, planen wir mit einer Speicherkapazität von 256GB je Festplatte.


[^1]: https://support.microsoft.com/en-us/windows/windows-10-system-requirements-6d4e9a79-66bf-7950-467c-795cf0386715 (11.12.2020)
[^2]: https://www.giga.de/downloads/microsoft-office-2019/specials/office-2019-systemvoraussetzungen-fuer-windows-und-mac/ (11.12.2020)
[^3]: http://download.nust.na/pub6/mysql/doc/workbench/en/wb-requirements-hardware.html (11.12.2020)
