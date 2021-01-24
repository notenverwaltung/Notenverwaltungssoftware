Der Netzwerkplan dient dazu das Verwaltungsnetzwerk der Grundschule für alle Mitarbeiter visualisiert darstellen zu können.        

Dadurch lassen sich Probleme und konkrete Vorstellungen besser umsetzen, erkennen und erklären. Außerdem wird durch Angabe der IP-Adressen die möglichen Netzwerkbereiche und deren Verbindungen innerhalb des Netzes dargestellt. 

<a href="https://raw.githubusercontent.com/notenverwaltung/Notenverwaltungssoftware/master/Bilder/Netzwerkplan_new2.png" data-toggle="lightbox" data-title="Netzwerkplan" data-footer="Verwaltungsnetz der Grundschule Waltersdorf">
    <img src="https://raw.githubusercontent.com/notenverwaltung/Notenverwaltungssoftware/master/Bilder/Netzwerkplan_new2.png" class="img-fluid">
    <figcaption>Abbildung 7: Der Netzwerkplan</figcaption>
</a>

### Dienste für Netzwerk und Applikationsschicht mit Sockets
| Software / Dienst         | Dienst                                   | Server (Port) | Client (Port)                                               | Transportprotokoll | Server-IP   | Client-IP                   |
|---------------------------|------------------------------------------|---------------|-------------------------------------------------------------|--------------------|-------------|-----------------------------|
| FreeIPA (http)            | http                                     | 80            | 80                                                          | TCP                | 192.168.1.2 | 192.168.1.10 - 192.168.1.20 |
| FreeIPA (https)           | https                                    | 443           | 443                                                         | TCP                | 192.168.1.2 | 192.168.1.10 - 192.168.1.20 |
| FreeIPA (ldap)            | ldap                                     | 389           | 389                                                         | TCP                | 192.168.1.2 | 192.168.1.10 - 192.168.1.20 |
| FreeIPA (ldaps)           | ldaps                                    | 636           | 636                                                         | TCP                | 192.168.1.2 | 192.168.1.10 - 192.168.1.20 |
| FreeIPA (kerberos)        | kerberos                                 | 88            | 88                                                          | UDP/TCP            | 192.168.1.2 | 192.168.1.10 - 192.168.1.20 |
| FreeIPA (kpasswd)         | kpasswd                                  | 464           | 464                                                         | UDP/TCP            | 192.168.1.2 | 192.168.1.10 - 192.168.1.20 |
| FreeIPA (Dogtag instance) | seperate Dogtag intance - used on RHEL 6 | 7389          | 7389                                                        | UDP/TCP            | 192.168.1.2 | 192.168.1.10 - 192.168.1.20 |
| FreeIPA (DHCP)            | DHCP                                     | 67,68         | Automatische Zuweisung von registrierten Ports (1024-49151) | UDP                | 192.168.1.2 | 192.168.1.10 - 192.168.1.20 |
| FreeIPA (DNS)             | DNS                                      | 53            | Automatische Zuweisung von registrierten Ports (1024-49151) | UDP/TCP            | 192.168.1.2 | 192.168.1.10 - 192.168.1.20 |
| MySQL                     | MySQL protocol                           | 3306          | 3306                                                        | TCP                | 192.168.1.3 | 192.168.1.10 - 192.168.1.20 |

[^1]


[^1]: https://www.freeipa.org/page/V4/Replica_Conncheck (20.01.2021)
