Der Netzwerkplan dient dazu das Verwaltungsnetzwerk der Grundschule inkl. Versuchsaufbau für alle Mitarbeiter visualisiert darstellen zu können. 

Der Netzwerkplan entspricht im gröbsten der Stern-Topolgie, da alle Teilnehmer über einen zentralen Teilnehmer miteinander verbunden sind. In unserem Fall ist dies der physische Server (PC-50-18).

Dadurch lassen sich Probleme und konkrete Vorstellungen besser umsetzen, erkennen und erklären. Außerdem wird durch Angabe der IP-Adressen die möglichen Netzwerkbereiche und deren Verbindungen innerhalb des Netzes dargestellt. 

<a href="https://raw.githubusercontent.com/notenverwaltung/Notenverwaltungssoftware/master/Bilder/Netzwerkplan_new4.png" data-toggle="lightbox" data-title="Netzwerkplan" data-footer="Verwaltungsnetz der Grundschule Waltersdorf">
    <img src="https://raw.githubusercontent.com/notenverwaltung/Notenverwaltungssoftware/master/Bilder/Netzwerkplan_new4.png" class="img-fluid"> </a>
    <figcaption>Abbildung 2: Der Netzwerkplan</figcaption>

### Dienste für Netzwerk und Applikationsschicht mit Sockets
| Software / Dienst         | Dienst                                   | Server (Port) | Client (Port)                                               | Transportprotokoll | Server-IP   | Client-IP                   |
|---------------------------|------------------------------------------|---------------|-------------------------------------------------------------|--------------------|-------------|-----------------------------|
| FreeIPA (http)[^1]      | http                                     | 80            | 80                                                          | TCP                | 192.168.1.1 | 10.1.50.1 - 10.1.50.10 |
| FreeIPA (https)[^1]         | https                                    | 443           | 443                                                         | TCP                | 192.168.1.1 | 10.1.50.1 - 10.1.50.10 |
| FreeIPA (ldap)[^1]         | ldap                                     | 389           | 389                                                         | TCP                | 192.168.1.1 | 10.1.50.1 - 10.1.50.10 |
| FreeIPA (ldaps)[^1]        | ldaps                                    | 636           | 636                                                         | TCP                | 192.168.1.1 | 10.1.50.1 - 10.1.50.10 |
| FreeIPA (kerberos)[^1]        | kerberos                                 | 88            | 88                                                          | UDP/TCP            | 192.168.1.1 | 10.1.50.1 - 10.1.50.10 |
| FreeIPA (kpasswd)[^1]         | kpasswd                                  | 464           | 464                                                         | UDP/TCP            | 192.168.1.1 | 10.1.50.1 - 10.1.50.10 |
| FreeIPA (Dogtag instance)[^1] | seperate Dogtag intance - used on RHEL 6 | 7389          | 7389                                                        | UDP/TCP            | 192.168.1.1 | 10.1.50.1 - 10.1.50.10 |
| FreeIPA (DHCP)            | DHCP                                     | 67,68         | Automatische Zuweisung von registrierten Ports (1024-49151) | UDP                | 192.168.1.1 | 10.1.50.1 - 10.1.50.10 |
| FreeIPA (DNS)             | DNS                                      | 53            | Automatische Zuweisung von registrierten Ports (1024-49151) | UDP/TCP            | 192.168.1.1 | 10.1.50.1 - 10.1.50.10 |
| MySQL [^2]                     | MySQL protocol                           | 3306          | 3306                                                        | TCP                | 192.168.1.2 | 10.1.50.1 - 10.1.50.10 |

<figcaption>Tabelle 1: Dienste für Netzwerk und Applikationsschicht</figcaption>


###Aufbau des Netzwerkplans

Den Server beim Versuchsaufbau bildet ein physischer Schul-PC (PC-50-18) aus dem Raum B3. Die Clients laufen ebenfalls physisch auf den Schul-PCs (PC-50-01 - PC-50-10), jedoch wird die Versuchsdurchführung vorraussichtlich erstmal nur auf einen Client erfolgen, aus zeitlichen Gründen. Es wurden nichtdestotrotz erstmal 10 Clients hinterlegt, da diese im Lastenheft verlangt werden. 

Der Server bildet mit VirtualBox als Hypervisor zwei Virtuelle Maschinen ab. Die zwei Virtuellen Maschinen bilden dann das Verwaltungsnetz der Grundschule Waltersdorf. Beide Virtuelle Maschinen sind mit CentOS 8 als Betriebssystem aufgesetzt. Die eine Virtuelle Maschine bildet dabei die ActiveDirectory mit FreeIPA als Anmeldedienst. FreeIPA übernimmt dank der integrierten Dienste auch gleich den DHCP sowie DNS-Dienst. Auf der zweiten Virutellen Maschine ist MySQL, als Datenbank aufgesetzt. Auf die Datenbank greift die Notenverwaltungssoftware zu, um die Daten persistens anzubieten und zu hinterlegen. 

Die Netzwerkkarten der beiden virtuellen Maschinen laufen im Network Address Translation Service (NATS). Dies heißt das beide virtuellen Maschinen ein NAT-Netzwerk abbilden, jedoch auch untereinander kommunizieren können, siehe Bild [^3]. Dies ist notwendig, da die Datenbank auch im Verwaltungsnetz erreichbar sein muss.

<img src="https://github.com/notenverwaltung/Notenverwaltungssoftware/blob/master/Bilder/Virtualbox_networks.png?raw=true">
    <figcaption>Abbildung 3: VirtualBox Netzwerkkonfiguration</figcaption>

Die Notenverwaltungssoftware hingegegen wird lokal auf den physischen Client PCs installiert, es besteht jedoch natürlich auch die Möglichkeit diese auf einer virtuellen Maschine zu installieren. Das Netzwerk der Grundschule Waltersdorf ist im NAT-Modus jedoch nicht vom Schulnetz des BSZET aus erreichbar, dafür müssen die Ports von FreeIPA und MySQl weitergeleitet werden, damit die Notenverwaltungssoftware vom Schulnetz des BSZET aus auf den Anmeldedienst und die Datenbank zugreifen kann.

Die Lehrer, sowie Administratoren melden sich dann mit ihren Anmeldedaten an der Notenverwaltungssoftware an, welche auf FreeIPA zugreift. Wo die die Anmeldedaten inklusive Rechtezuweisung hinterlegt ist.


[^1]: https://www.freeipa.org/page/V4/Replica_Conncheck (20.01.2021)
[^2]: https://dev.mysql.com/doc/mysql-port-reference/en/mysql-ports-reference-tables.html#:~:text=Port%203306%20is%20the%20default,such%20as%20mysqldump%20and%20mysqlpump.
[^3]: https://www.thomas-krenn.com/de/wiki/Netzwerkkonfiguration_in_VirtualBox
