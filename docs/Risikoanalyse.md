## Definition
Risiken sind reale oder virtuelle Ereignisse die einen realen Schaden anrichten. Der Schaden kann sich im Projektmanagement auf einen oder mehrere der Faktoren Zeit, Kosten und Qualität auswirken.
Aus der Sicht der Projektbeteiligten bedeutet ein Risiko vor allem Unsicherheit – und Unsicherheiten und Variablen sind der Erzfeind einer jeden Planung. Daher werden innerhalb des Risikomanagements alle möglichen Risiken aufgelistet und bereits im Vorfeld in die Planung einbezogen, um mögliche negative Überraschungen mitten im Projektverlauf möglichst zu vermeiden.[^1] 

**Risiko = Schaden x Eintrittswahrscheinlichkeit**

### (DIN) Normen & Co
Im Projektmanagement Norm ISO 31000: 2009: „Risikomanagement & Risikoanalyse“, (Guidelines on Principles and Implementation of Risk Management) wird die Risikoanalyse als Managementaufgabe gesehen, in der die Risiken eines Projektes identifiziert und gleichzeitig analysiert sowie bewertet werden müssen. Dabei stellt die Din Norm die Grundsätze und internationale Richtlinien für die Umsetzung des Risikomanagements und Risikoanalyse zur Verfügung.[^2] 

## Prozessablauf
<figure>
  <img src="https://raw.githubusercontent.com/notenverwaltung/Notenverwaltungssoftware/master/Bilder/risikoanalyse-prozessablauf.png#zoom">
  <figcaption>Abbildung 1: Der Prozessablauf</figcaption>
</figure>
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
| 1                        | Gesetzlicher Rahmen           | Datenschutz + vertrauchliche Nutzung der Daten von Schülern, Lehrern, Erziehungsberechtigten | Rechtsklage, Abbruch des Projektes                                                 | 2 | 4 |
| 2                        | Höhere Gewalt                 | katastrophale Naturereignisse, Verlust von Räumlichkeiten (durch Brand, Wasserschaden)       | Verlust der Hardware                                                               | 1 | 4 |
| 3                        | Ausfallsicherheit             | Vermeidung von Abstrürzen, Fehler in der Infrastruktur                                       | Ausfälle in der Software, Unbenutzbarkeit der Software                             | 2 | 3 |
| 4                        | Datenverlust                  | Bei Abstürzen verlust der hinterlegten Daten                                                 | Verlust der Daten, wäre gleich Verlust der Noten                                   | 2 | 4 |
| 5                        | Kompatibilität                | Unterstützung und Bedienbarkeit verschiedener Schnittstellen untereinander                   | Fehler in der Infrastruktur, geringe Ausfallsicherheit                             | 2 | 3 |
| 6                        | Vorsätzliche Angriffe         | Angriffe auf die Software, durch möglicherweise Ausnutzung von Sicherheitslücken             | Keine Verlässlichkeit der Daten auf Korrektheit                                    | 1 | 3 |
| 7                        | Verlust der Hardware          | Ausfall der Hardware durch technisches Versagen                                              | Ausfall der Software                                                               | 1 | 4 |
| 8                        | Ausfall der Stromversorgung   | Ausfall der Hardware durch äußere Einflüsse                                                  | Ausfall der Software                                                               | 1 | 4 |
| 9                        | Wartungsmöglichkeiten         | Einfache Möglichkeit der Wartbarkeit (Sicherheitsupdates)                                    | Software möglichst aktuell halten um hohe Sicherheit zu garantieren                | 3 | 2 |
| 10                       | Fachliche Fehler              | Bugs, Fehler durch menschliches Versagen                                                     | geringe Ausfallsicherheit der Software, Fehler im Programm bei der Berechnung etc. | 4 | 2 |
| 11                       | Fehler in der Projektstruktur | Keine genaue Regelung der Terminzeiten                                                       | Missverständnisse bei den Anforderungen                                            | 4 | 2 |
| 12                       | Ausfall eines Mitarbeiters    | Krankheit, andere Zwischenfälle                                                              | Bei ungenügender Absprache. Missverständnisse bei den Zuständigkeiten              | 3 | 2 |
| 13                       | Zu viele Änderungen           | Ständige Änderung der Projektanforderungen                                                   | Verkomplizierung des Projektes                                                     | 4 | 2 |
| 14                       | Fehlende Dokumentation        | Durch Zeitdruck, mangel an Kapazitäten, leidet die Dokumentation                             | Bei Wartung oder Handhabung der Software fehlt die entsprechende Dokumentation     | 3 | 3 |
| 15                       | Zeitdruck                     | Zu hoher Projektaufwand, falsche Einschätzung des Zeitaufwands                               | technische Schuld, Software Zuverlässigkeit leidet unter dem Zeitdruck             | 4 | 3 |

Tabelle 1: Bewertung der Risiken nach Ursache und Auswirkung
### Risikomatrix
<figure>
  <img src="https://raw.githubusercontent.com/notenverwaltung/Notenverwaltungssoftware/master/Bilder/Risiko-Matrix.png">
  <figcaption>Abbildung 2: Die Risikomatrix</figcaption>
</figure>


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
|     Zeitdruck                          |     In der     Planungsphase erstellen   eines Gantt-Diagramms mit Zuweisung der Arbeitspakete an jeden Mitarbeiter,   sodass es zu keinen Ungereimtheiten kommt in der Integrationsphase.        Mitarbeiter 1 kümmert sich um die Einrichtung der VMs, Mitarbeiter 2 erledigt   die Integration und Programmierung der Notenverwaltungssoftware, Mitarbeiter   3 kümmert sich um die Dokumentation + Rechte der Nutzerrollen (Schulleiter,   Lehrer)    |     Zuerst die wichtigen   Features erledigen, dann um die Erweiterung und nebensächliches Kümmern.     (Pareto-Prinzip)           Feste Zeitplanung, sorgt   für besser Kalkulierbarkeit bzw. Einschätzung des Aufwands für das Projekt    |
|     Fachliche Fehler                   |     Debuggen, Kontrolle durch die   anderen Mitarbeiter                                                                                                                                                                                                                                                                                                                                                                                                   |     Gegenseitige Absicherung zur   Minderung des Risikos                                                                                                                                                                                    |
|     Fehler in der   Projektstruktur    |     Genaue Absprache und   Kommunikation des Projektablaufes                                                                                                                                                                                                                                                                                                                                                                                              |     Durch konkrete   Kommunikation und Zuweisung der Arbeitspakete an die Mitarbeiter, wird   ausgeschlossen, dass die Mitarbeiter im Unklaren sind über ihren   Arbeitsaufwand                                                             |
|     Zu viele Änderungen                |     Schließt sich an den Zeitdruck und   and eine genaue Projektsturktur an                                                                                                                                                                                                                                                                                                                                                                               |     Durch genaue Arbeitsteilung und   einen festen Projektablauf, können zu viele Änderungen im laufe des Projektes   verhindert werden                                                                                                     |
|     Fehlende Dokumentation             |     Arbeitsplanung muss Zeit   und Planung für die Dokumentation übrig lassen                                                                                                                                                                                                                                                                                                                                                                             |     Bei ausreichender Planung   bleibt die Dokumentation nicht hinten liegen, sodass genug Zeit für die   Bearbeitung bleibt                                                                                                                |
|     Datenverlust                       |     Backups                                                                                                                                                                                                                                                                                                                                                                                                                                               |     Durch regelmäßige Backups bleibt die   Gefahr bei Datenverlust gering                                                                                                                                                                   |
|     Vorsätzliche Angriffe              |     Regelmäßige Aktualisierung   der verwendeten Software                                                                                                                                                                                                                                                                                                                                                                                                 |     Durch Nutzung der   aktuellsten Versionen verringert sich die Gefahr auf mögliche   Sicherheitsrisiken                                                                                                                                  |
|     Kompatibilität                     |     Bevor der Einrichtung. Überprüfung   der verschiedenen                                                                                                                                                                                                                                                                                                                                                                                                |                                                                                                                                                                                                                                             |

Tabelle 3: Präventive Maßnahmen zur Risiko Minderung
###	Risikodelegation und Risikoübernahme
Auf Grund der Möglichkeiten die in diesem Projekt zur Verfügung stehen, kommt keine Risikodelegationen in Frage, das heißt eine Absicherung durch Dritte bzw. Versicherungen wird in unserem Fall ausgeschlossen.
Risiken bei den keine Möglichkeit der Prävention besteht werden, somit übernommen, da der potentielle Schaden zu kostfällig ausfällt.

|     Risiko       |     Risiko Minderung                                                                                                                                                                                        |     Auswirkung                                                                                         |
|------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------|
|     Zeitdruck    |     Pareto-Prinzip, genaue   Einteilung der Arbeitspakete. In der           Planungsphase erstellen eines   Gantt-Diagramms mit Zuweisung der Arbeitspakete an jeden Mitarbeiter, sodass   es zu keinen     |     Zuerst die wichtigen   Features erledigen, dann um die Erweiterung und nebensächliches Kümmern.    |

Tabelle 4: Risikodelegation und Risikoübernahme für Risiken

[^1]: http://projektmanagement-manufaktur.de/risikoanalyse-projektmanagement (25.11.2020)
[^2]: http://projektmanagement-manufaktur.de/risikoanalyse-projektmanagement (25.11.2020)
