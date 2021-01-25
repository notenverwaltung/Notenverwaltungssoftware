### Datensicherheit

Eine Schutz der Daten im Notenverwaltungsprogramm ist schon damit gewährleistet, dass die Nutzer ihre Login-Daten (geheimes Passwort + Benutzername) nutzen müssen um mit dem Tool zu arbeiten. Es wird unter anderem von AUPLUS[^¹] und IONOS[^²] dringend empfohlen die Daten auf einen externen Datenträger zu sichern. Auf die VMs, auf denen Datenbank und die Backups gespeichert sind, hat ausschließlich der IT-Administrator Zugriff. Um auf die VMs zugreifen zu können, wird immer ein Passwort und ein Username angefordert. Dabei gibt es zwei Benutzer:

- Domänen-Administrator(root) --> Rechte auf alles, für Konfiguration der VMs 
- Domänen-Benutzer (user) --> Keine Administrator - Berechtigung
