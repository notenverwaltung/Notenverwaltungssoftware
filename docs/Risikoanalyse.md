## Definition
Risiken sind reale oder virtuelle Ereignisse die einen realen Schaden anrichten. Der Schaden kann sich im Projektmanagement auf einen oder mehrere der Faktoren Zeit, Kosten und Qualität auswirken.
Aus der Sicht der Projektbeteiligten bedeutet ein Risiko vor allem Unsicherheit – und Unsicherheiten und Variablen sind der Erzfeind einer jeden Planung. Daher werden innerhalb des Risikomanagements alle möglichen Risiken aufgelistet und bereits im Vorfeld in die Planung einbezogen, um mögliche negative Überraschungen mitten im Projektverlauf möglichst zu vermeiden.[^1] 

**Risiko = Schaden x Eintrittswahrscheinlichkeit**

### (DIN) Normen & Co
Im Projektmanagement Norm ISO 31000: 2009: „Risikomanagement & Risikoanalyse“, (Guidelines on Principles and Implementation of Risk Management) wird die Risikoanalyse als Managementaufgabe gesehen, in der die Risiken eines Projektes identifiziert und gleichzeitig analysiert sowie bewertet werden müssen. Dabei stellt die Din Norm die Grundsätze und internationale Richtlinien für die Umsetzung des Risikomanagements und Risikoanalyse zur Verfügung.[^2] 

## Prozessablauf
<a href="https://raw.githubusercontent.com/notenverwaltung/Notenverwaltungssoftware/master/Bilder/risikoanalyse-prozessablauf.png" data-toggle="lightbox" data-title="risikoanalyse-prozessablauf" data-footer="risikoanalyse-prozessablauf">
    <img src="https://raw.githubusercontent.com/notenverwaltung/Notenverwaltungssoftware/master/Bilder/risikoanalyse-prozessablauf.png" class="img-fluid">
    <figcaption>Abbildung 1: Der Prozessablauf</figcaption>
</a>
## Identifizierung der Risiken
### Externe Risiken
#### Definition
Unter externen Risiken werden meist Risiken verstanden, welche von extern (also von außen) auf das Projekt einwirken.

* Gesetzlicher Rahmen / Rechtsprechung
  * Datenschutz
    * Zustimmung der Schüler, Eltern
    * Trennung der Schulnetze in Verwaltungs- und Arbeitsnetz
* Höhere Gewalt
  * Katastrophale Naturereignisse
  * Verlust von Räumlichkeiten (z.B. durch Brand, Wasserschaden)

### Interne Risiken
#### Definition

Im Gegensatz zu externen Risiken, können interne Risiken (mehr oder weniger) vom Projektteam gesteuert und beeinflusst werden.

* IT-Infrastruktur	
  * Ausfallsicherheit
    * Stromausfall in der Schule
  * Datenverlust
    * Bugs, Fehler
  * Kompatibilität
  * Vorsätzliche Angriffe
    * Sicherheitslücken
  * Datensicherheit
  * Verlust der Hardware
  * Ausfall der Stromversorgung
  * Wartungsmöglichkeiten
* Fachliche Risiken
  * Fachliche Fehler im Programm
    * Menschliche Fehlhandlung
* Planerische Risiken
  * Fehler im Projektstrukturplan, Projektablaufplan
    * Unterschätzung des Aufwandes
  * Krankheit/Ausfall eines Mitarbeiters
  * Zu viele Änderungen -> zu starke Komplizierung
    * Ungenaue Prioritäten
* Kommunikation
  * Missverständnisse bei Anforderungen
  * Fehlende Dokumentation
    * Falsche Handhabung der Software
* Zeitlicher Rahmen
  * Zeitdruck
    * Technische Schuld

## Risiken bewerten
### Mögliche aufzutretende Risiken
In der unten aufgeführten Tabelle werden Risiken und dessen Ursachen mit ihren Auswirkungen bewertet. Dabei wurden Eintrittswahrscheinlichkeit und Auswirkungen mit dem individuellen Punkteschema vergeben. 

| #                        | Risiko                        | Ursache                                                                                      | Auswirkungen                                                                       | EW<br>(1-5)| Ausw<br>(1-4) |
| ------------------------ | ----------------------------- | -------------------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | - | - |
| 1                        | Gesetzlicher Rahmen           | Vertrauchliche Nutzung der Daten von Schülern, Lehrern, Erziehungsberechtigten. Aufbau des Schulnetzes, sodass sichergestellt werden kann, dass kein Zugriff durch Dritte erfolgt. | Rechtsklage, Abbruch des Projektes, Schüler oder Dritte haben Zugriff auf personenbezogene Daten oder Daten, welche der Person nicht zur Verfügung stehen sollte.                                                 | 2 | 4 |
| 2                        | Höhere Gewalt                 | katastrophale Naturereignisse, Verlust von Räumlichkeiten (durch Brand, Wasserschaden). Wie kann garantiert werden, das der Verlust der Hardware kein Verlust der Notendaten bedeutet?       | Verlust der Hardware, darausfolgt auch Aufsall der IT-Infrasturktur der Grundschule.                                                               | 1 | 4 |
| 3                        | Ausfallsicherheit             | Vermeidung von Abstrürzen, Wartungs-/Kompatibilitätsfehler in der Infrastruktur. Wie wird sichergestellt, dass das Netzwerk der Schule bei Einbindungder Notenverwaltungssoftware weiterhin eine hohe Ausfallsicherheit garantiert.                                       | Ausfälle in der Software, Unbenutzbarkeit der Software, Fehleranfälligkeit der Software. Software muss Stabilität gewähren, damit diese bei den Lehrern auch als nützlich angesehen wird.                             | 2 | 3 |
| 4                        | Datenverlust                  | Bei unerwarteten Abstürzen verlust der hinterlegten Daten. Wie kann garantiert werden, das bei unerwarteten Ausfall der IT-Infrastruktur der Schule kein Verlust der Daten der Notenverwaltungssoftware vorliegt?                                                 | Verlust der Daten, wäre gleich Verlust der Noten, darausfolgt keine Sicherheit auf Korrektheit der hinterlegten Daten = unbrauchbar.                                   | 2 | 4 |
| 5                        | Kompatibilität                | Unterstützung und Bedienbarkeit verschiedener Schnittstellen untereinander. Wie wird sichergestellt, das es zu keinen Komplikationen zwischen Domain-Controller, DNS-, DHCP-, Datenbankserver und der Notenverwaltungssoftware kommt.                   | Fehleranfälligkeit in der Infrastruktur, geringe Ausfallsicherheit.                             | 2 | 3 |
| 6                        | Vorsätzliche Angriffe         | Angriffe auf die Software, durch möglicherweise Ausnutzung von Sicherheitslücken. Wie lassen sich die Angriffsmöglichkeiten durch Schüler oder Dritte eliminieren bzw. auf ein geringes Risiko reduieren?             | Keine Verlässlichkeit der Daten auf Korrektheit.                                    | 1 | 3 |
| 7                        | Verlust der Hardware          | Ausfall der Hardware durch technisches Versagen. Wie wird sichergestellt, dass die Daten nicht verloren gehen?                                              | Ausfall der Software. Totalausverfall keine Nutzung der Notenverwaltung möglich.                                                               | 1 | 4 |
| 8                        | Ausfall der Stromversorgung   | Ausfall der Hardware durch äußere Einflüsse. Möglichkeit der Absicherung gegen äußere Einflüsse?                                                  | Ausfall der Software. Mögliche Schäden der Infrastruktur durch unerwartetes Herunterfahren der Geräte.                                                               | 1 | 4 |
| 9                        | Wartungsmöglichkeiten         | Einfache Möglichkeit der Wartbarkeit (Sicherheitsupdates). Wie kann die Bereitstellung von Updates schnell und sicher zur Verfügung gestellt werden?                                    | Software möglichst aktuell halten um hohe Sicherheit zu garantieren.                | 3 | 2 |
| 10                       | Fachliche Fehler              | Bugs, Fehler durch menschliches Versagen. Wie lassen sich Fachliche Fehler auf einem minimum halten?                                                     | geringe Ausfallsicherheit der Software, Fehler im Programm bei der Berechnung etc. | 4 | 2 |
| 11                       | Fehler in der Projektstruktur | Keine genaue Regelung der Terminzeiten. Wie können diese im Nachhinein möglichst schnell behoben werden?                                                       | Missverständnisse bei den Anforderungen.                                            | 4 | 2 |
| 12                       | Ausfall eines Mitarbeiters    | Krankheit, andere Zwischenfälle. Wie wird sichergestellt, dass beim Ausfall eines Mitarbeiters, jemand anderes einspringen kann.                                                              | Bei ungenügender Absprache. Missverständnisse bei den Zuständigkeiten              | 3 | 2 |
| 13                       | Zu viele Änderungen           | Ständige Änderung der Projektanforderungen. Wie lässt sich die Planung möglichst konkretisieren, um möglichst viele Änderungen zu verhindern.                                                  | Verkomplizierung des Projektes, führt zu Zeitdruck.                                                     | 4 | 2 |
| 14                       | Fehlende Dokumentation        | Durch Zeitdruck, mangel an Kapazitäten, leidet die Dokumentation. Wie lässt sich die Fertigstellung der Software, sowie eine gute Dokumentation miteinander vereinbaren.                             | Bei Wartung oder Handhabung der Software fehlt die entsprechende Dokumentation bzw. ist unzureichend.     | 3 | 3 |
| 15                       | Zeitdruck                     | Zu hoher Projektaufwand, falsche Einschätzung des Zeitaufwands. Wie kann man den Terminplan möglichst genau einhalten?                               | technische Schuld, Software Zuverlässigkeit leidet unter dem Zeitdruck.             | 4 | 3 |

Tabelle 1: Bewertung der Risiken nach Ursache und Auswirkung
### Risikomatrix
<a href="https://raw.githubusercontent.com/notenverwaltung/Notenverwaltungssoftware/master/Bilder/Risiko-Matrix.png" data-toggle="lightbox" data-title="Risiko-Matrix" data-footer="Risiko-Matrix">
    <img src="https://raw.githubusercontent.com/notenverwaltung/Notenverwaltungssoftware/master/Bilder/Risiko-Matrix.png" class="img-fluid">
    <figcaption>Abbildung 2: Die Risikomatrix</figcaption>
</a>


### Punkteschema
| Eintrittswahrscheinlichkeit = EW |   %   | Auswirkung = Ausw |        Erklärungen          |
| -------------------------------- | ----- | ----------------- | --------------------------- |
| 5                                | \>90% | 4                 | Show Stopper                |
| 4                                | \>70% | 3                 | gefährdet den Projekterfolg |
| 3                                | \>40% | 2                 | mindert den Projekterfolg   |
| 2                                | \>20% | 1                 | stört den Projekterfolg     |
| 1                                | \>5%  |                   |                             |

Tabelle 2: Punkteschema nach dem die Bewertung der Risiken erfolgt
## Linderungsmaßnahme (Gegenmaßnahme, Mitigationsmaßnahmen)
### Risikovermeidung
### Definition
**Risikovermeidung**
Ziel der Risikovermeidung ist es, jedes noch so kleine Risiko nicht eintreten zu lassen. Die Suggerierung von maximaler Sicherheit durch sehr starke Differenzierung und eine hohe Kontrolle geht zu Lasten von freien Prozessen. 
**Risikoverringerung**
Durch diverse Maßnahmen im Bereich der Personalorganisation und Arbeitsplatzorganisation wird versucht, die spezifischen Eintrittswahrscheinlichkeiten der Risiken zu klein wie nur möglich zu halten. 

### Präventive Maßnahmen
Gegenmaßnahmen und Maßnahmen zur Vorbeugung für die Risiken mit der höchsten Eintrittswahrscheinlichkeit und Auswirkung.


|     Risiko                             |     Risiko Minderung                                                                                                                                                                                                                                                                                                                                                                                                                                      |     Auswirkung                                                                                                                                                                                                                              |
|----------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|     Zeitdruck                          | In der Planungsphase erstellen eines Gantt-Diagramms mit Zuweisung der Arbeitspakete an jeden Mitarbeiter, sodass es zu keinen Ungereimtheiten kommt in der Integrationsphase.  Mitarbeiter 1 kümmert sich um die Einrichtung der VMs, Mitarbeiter 2 erledigt die Integration und Programmierung der Notenverwaltungssoftware, Mitarbeiter 3 kümmert sich um die Dokumentation + Rechte der Nutzerrollen (Schulleiter, Lehrer)**    |     Zuerst die wichtigen   Features erledigen, dann um die Erweiterung und nebensächliches Kümmern.     (Pareto-Prinzip)           Feste Zeitplanung, sorgt   für besser Kalkulierbarkeit bzw. Einschätzung des Aufwands für das Projekt    |
|     Fachliche Fehler                   |     Debuggen, Kontrolle durch die   anderen Mitarbeiter. Da die Programmierung über den netzbasierten Dienst GitHub erfolgt. Benötigt es der Zustimmung der anderen Mitarbeiter, um den Code ins Projekt zu ,,mergen''. Dadurch wird eine doppelte Absicherung gewährleistet. Zudem erfolgt nach der Fertigstellung der Software ein umfassenden Test, um mögliche Fehler noch festzustellen und anschließend zu beheben.                                                                                                                                                                                                                                                                                                                                                                                                  |     Gegenseitige Absicherung zur   Minderung des Risikos, durch Projektarbeit über GitHub. Zusätzliche Absicherung durch umfassenden Test nach der Programmierung.                                                                                                                                                                                   |
|     Fehler in der   Projektstruktur    |     Genaue Absprache und Kommunikation des Projektablaufes. Die Erstellung eines Zeitplans mit Hilfe eines Gantt-Diagramms soll einen festen Rahmen bilden, an den sich die Mitarbeiter halten können und sollen. Dabei sind jedem Mitarbeiter feste Arbeitspakete zugewiesen wurden, sowie ein fester Zeitrahmen.                                                                                                                                                                                                                                                                                                                                                                                              |     Durch konkrete Kommunikation und Zuweisung der Arbeitspakete an die Mitarbeiter, wird ausgeschlossen, dass die Mitarbeiter im Unklaren sind über ihren Arbeitsaufwand                                                            |
|     Zu viele Änderungen                |     Schließt sich an den Zeitdruck und an eine genaue Projektstruktur an. Durch genaue Einteilung der Arbeitspakete, soll zusätzlicher Aufwand verhindert werden. Des Weiteren wurde ein Netzwerkplan erstellt, um auch eine Vorgabe bzgl. des Netzwerkaufbaus zu haben an die man sich halten soll.                                                                                                     | Durch genaue Arbeitsteilung und einen festen Projektablauf, können zu viele Änderungen im laufe des Projektes verhindert werden.
|     Fehlende Dokumentation             |     Bei der Entwicklung haben wir uns darauf geeignet, dass sich jederzeit 1 Person um die Dokumentation des Projektes kümmert, während die anderen an der Programmierung beschäftigt sind, damit es nach hinten raus noch genug zeitlich Puffer gibt.                                                                                                                                                                                                                                                                                                                                                                             |     Bei ausreichender Planung   bleibt die Dokumentation nicht hinten liegen, sodass genug Zeit für die   Bearbeitung bleibt                                                                                                                |
|     Datenverlust                       |     Die Daten liegen zentralisiert auf einer MySQL-Datenbank (VM_2). Diese lässt sich über den „mysqldump“ - Befehl sichern, um einen Totalverlust zu vermeiden bestehe die Möglichkeit die Backup-Datei auf einen NAS auszulagern, welches über ein RAID-System gesichert ist. Aus finanziellen Gründen könnte man sonst möglicherweise die Datei per Skript auf die (VM_1) auslagern.                                                                                                                                                                                                                                                                                                                                                                                                                                               |     Durch regelmäßige Backups bleibt die Gefahr bei Datenverlust gering. Lässt sich jedoch nie komplett ausschließen.                                                                                                                                                                  |
|     Vorsätzliche Angriffe              |     Regelmäßige Aktualisierung der verwendeten Software. Durch Anwendung eines Skripts z.B. (apt-get update, apt-get upgrade) könnte man täglich/wöchentlich prüfen, ob es für die verwendeten Programme ein Update gibt und diese aktualisieren.                                                                                                                                                                                                                                                                                                                                                                                                 |     Durch Nutzung der aktuellen Versionen verringert sich die Gefahr auf mögliche Sicherheitsrisiken, da dadurch Sicherheitslücken schnellstmöglich geschlossen werden.                                                                                                                                |
|     Kompatibilität                     |     Während der Planungsphase fand in der Dienstanalyse, sowie in der Nutzwertanalyse auch eine Auswahl der Software statt. Dabei wurde auf die Kompatibilität, sowie Sicherheit und Stabilität mehrerer Programme geachtet und anschließend eine Auswahl getroffen.  Wir verlassen uns dabei auf die Angaben des Herstellers, dass eine Kompatibilität gewährleistet ist.                                                                                                                                                                                                                                                                                                                                                                                              |   Eine hohe Kompatibilität der Programme untereinander sorgt für eine hohe Ausfallsicherheit, sowie ein stabiles System.                                                                                                                                                                                                                                          |
|     Ausfall eines Mitarbeiters                     |     Das Risiko schließt sich an viele anderen Risiken an. Im Gantt-Diagramm ist geregelt, welcher Mitarbeiter welches Arbeitspaket zu erledigen hat, sollte es zu einem längeren Ausfall kommen, müssen die Arbeitspakete auf die anderen Mitarbeiter aufgeteilt werden.                                                                                                                                                                                                                                                                                                                                                                                             |   Dadurch wird das Risiko natürlich nicht komplett verhindert, jedoch können Unsicherheiten rausgenommen werden.                                                                                                                                                                                                                                         |
|     Ausfallsicherheit                   |     Die Ausfallsicherheit knüpft an die Kompatibilität an. Während der Planungsphase fand in der Dienstanalyse, sowie in der Nutzwertanalyse auch eine Auswahl der Software statt. Dabei wurde auf die Kompatibilität, sowie Sicherheit und Stabilität mehrerer Programme geachtet und anschließend eine Auswahl getroffen.                                                                                                                                                                                                                                                                                                                                                                                            |   Eine hohe Ausfallsicherheit ist bei Personenbezogenen Daten ist sehr wichtig, damit es zu keinen Fehlern bei der Eingabe kommt.                                                                                                                                                                                                                                       |
|     Wartungsmöglichkeiten                   |   Regelmäßige Aktualisierung der verwendeten Software.  Durch Anwendung eines Skripts z.B. (apt-get update, apt-get upgrade). Die Software lässt sich über folgende Möglichkeit aktualisieren: Der integrierte Updater lädt eine XML-Datei mit den Aktualisierungsinformationen vom Server herunter. Diese XML-Datei wird verwendet, um Informationen zur neuesten Version der Software abzurufen. Wenn die neueste Version der Software höher ist als die aktuelle Version der auf dem PC des Benutzers installierten Software, zeigt der Updater dem Benutzer den Aktualisierungsdialog an. Wenn der Benutzer auf die Schaltfläche "Aktualisieren" klickt, um die Software zu aktualisieren, wird die Aktualisierungsdatei (Installationsprogramm) von der in der XML-Datei angegebenen URL heruntergeladen und die gerade heruntergeladene Installationsdatei ausgeführt. Nach diesem Zeitpunkt ist es Aufgabe des Installateurs, das Update durchzuführen.                                                                                                                                                                                                                                                                                                                                                                                       |   Es besteht damit die Möglichkeit Features, Sicherheitsupdates und andere Änderungen auch nach Deployment noch hinzuzufügen.                                                                                                                                                                                                                                       |
|     Datenschutz                   |   Das Schulnetzwerk ist immer in zwei Bereiche unterteilt. Dem Schulnetzwerk und dem Verwaltungsnetzwerk, diese müssen physisch voneinander getrennt sein, (rechtliche Vorgabe) dies erfolgt bspw. durch V-LANs.                                                                                                                                                                                                                                                                                                                                                                               |   Datenschutzrechtlich fehlt uns die Expertise. Wir versuchen uns aber an die vorgegebenen rechtlichen Vorgaben zu halten.                                                                                                                                                                                                                                      |

Tabelle 3: Präventive Maßnahmen zur Risiko Minderung
###	Risikodelegation und Risikoübernahme
Auf Grund der Möglichkeiten die in diesem Projekt zur Verfügung stehen, kommt keine Risikodelegationen in Frage, das heißt eine Absicherung durch Dritte bzw. Versicherungen wird in unserem Fall ausgeschlossen.
Risiken bei den keine Möglichkeit der Prävention besteht werden, somit übernommen, da der potentielle Schaden zu kostfällig ausfällt.

|     Risiko       |     Risiko Minderung                                                                                                                                                                                        |     Auswirkung                                                                                         |
|------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------|
|     Höhere Gewalt   |     Aus finanziellen Gründen fehlt uns hier die Möglichkeit, solchen Risiken entgegen zu wirken. Dies wäre bspw. durch Versicherungen möglich.     |     Das Risiko wird übernommen, da uns die Möglichkeiten fehlen, da entgegen zu wirken.    |
|     Verlust der Hardware    |     Aus finanziellen Gründen fehlt uns hier die Möglichkeit, solchen Risiken entgegen zu wirken. Dies wäre bspw. durch Versicherungen möglich. Falls es zu Verlust bzw. Ausfall von Hardware käme müsse sich  die Schule drum kümmern.|    Das Risiko wird übernommen, da uns die Möglichkeiten fehlen, da entgegen zu wirken.    |
|     Ausfall der Stromversorgung    |     Aus finanziellen Gründen fehlt uns hier die Möglichkeit, solchen Risiken entgegen zu wirken. Es bestehe die Möglichkeit des Einsatzes einer USV um beim Stromausfall. Den Ausfall der Hardware zu verhindern. Für den Einsatz einer USV müsste aber die Schule aufkommen.  | Das Risiko wird übernommen, da uns die Möglichkeiten fehlen, da entgegen zu wirken. 


Tabelle 4: Risikodelegation und Risikoübernahme für Risiken

[^1]: http://projektmanagement-manufaktur.de/risikoanalyse-projektmanagement (25.11.2020)
[^2]: http://projektmanagement-manufaktur.de/risikoanalyse-projektmanagement (25.11.2020)
