### Anwendungsfälle zu den Diensten
Das Use-Case-Diagramm der Notenverwaltung stellt grafisch Anwendungsfälle mit deren Beziehungen dar, welches die Organisation der Noten für die Klassenstufe 3 und 4 abdeckt.
Hier werden alle Zusammenhänge der Nutzerrollen aufgezeigt.

Der Funktionsumfang im Schulnetz ist in der folgenden Abbildung sichtbar:

<figure>
  <img src="https://raw.githubusercontent.com/notenverwaltung/Notenverwaltungssoftware/master/Bilder/notenverwaltung.png">
  <figcaption>Abbildung 3: Anwendungsfälle zu den Diensten</figcaption>
</figure>

Der übliche Anwendungsfall im Verwaltungsnetz sieht vor, dass sich ein Benutzer mithilfe eines Clients am Schulnetzwerk anmeldet. Dies kann der Schulleiter, Fachlehrer, Klassenlehrer oder ein Verwaltungslehrer sein. Die Notenverwaltung wird danach vom Benutzer gestartet. Dabei müssen die Anmeldedaten von der Notenverwaltung und dem Schulnetzwerk übereinstimmen. Berechtigungen und Masken werden benutzerspezifisch geladen. Danach kann der Benutzer seine Änderungen vornehmen.  Abschließend beendet der Benutzer das Programm und meldet sich vom Schulnetzwerk ab.

Für den ersten Prototypen der Notenverwaltung sind sämtliche weiteren Funktionen im folgenden Anwendungsfalldiagramm sichtbar:

<figure>
  <img src="https://raw.githubusercontent.com/notenverwaltung/Notenverwaltungssoftware/master/Bilder/use-case-verwaltungsnetz.png">
  <figcaption>Abbildung 4: Verhaltensdiagramm </figcaption>
</figure>

### Rollenspezifizierung
Für die Umsetzung des Projektes wurde sich auf die erforderlichen Rollen Fachlehrer, Schulleiter, Verwaltungslehrer und Klassenlehrer konzentriert. Diese sind für den Betrieb einer zentralen Notenverwaltungssoftware essentiell zu entwickeln und zu implementieren. Die Implementierung eines Rechtesystems erfordert die Umsetzung von Maßnahmen, welche Authentifikation, Integrität und Verbindlichkeit garantieren. Darum stehen hohe Qualitätsanforderungen an die Korrektheit und Zuverlässigkeit der Software. Des Weiteren ist sicherzustellen, dass die Daten bei gleichzeitigem Schreibzugriff mehrerer Personen in der Notenanwendung konsistent bleiben.

Ein Klassenlehrer darf Endnoten und Notendichte fach- und klassenbezogen anzeigen und drucken. Der Fachlehrer kann nach Klassen und Schülern suchen und sich eine Klassenübersicht fach- und lehrerbezogen anzeigen und ausdrucken lassen. Einzelne Noten und Endnoten kann der Fachlehrer eintragen und ändern. 
Die Schulleitung darf Endnoten und Notendichte fach-, lehrer- und klassenbezogen anzeigen und drucken. Des Weiteren können durch den Schulleiter die Namen von Lehrern, Schülern
und Klassen geändert sowie auch Schüler gelöscht werden.
Letztere Funktionen können auch von dem Verwaltungslehrer ausgeführt werden, die als
Administrator fungieren. Sie werden zudem in der Lage sein, Klassen, Fächer, Schüler und Lehrer
aufzunehmen und sie einander zuzuordnen.
Dieses Muss-Kriterium erfordert eine Parallelitätskonflikterkennung und -behandlung im Kontext der elektronischen Datenverarbeitung.

### notwendige Basisdienste für die Verwaltung
Die Notenverwaltung ist softwareabhängig, weil die Anwendung für Windows programmiert und getestet wird.
Die Client-PC müssen für das Ausführen der Anwendung die Windows Frameworks installiert haben. Folgende Dienste und Software werden softwareseitig- und clientseitig genutzt für diese Auftrag verwendet:

grundsätzliche Software:
 -CentOS 8 Betriebssystem von Linux

notwendige Dienste:
- DNS
- DHCP
- Domaincontroller (FreeIPA)
- Windows (inklusive .NET Framework, .NET Standard, ...)

Dienste für die Notenverwaltung:
- Datenbankserver (MYSQL auf Docker-Container)

Alle Dienste werden in einem Container mithilfe von Docker auf CentOS 8 umgesetzt. CentOS 8 wird auf einer virtuellen Maschine aufgesetzt.
