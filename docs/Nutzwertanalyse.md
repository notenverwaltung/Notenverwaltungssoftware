### Zieldefinition
Für das Speichern und Verwalten der Daten wird ein Datenbankmanagementsystem (DBMS) genutzt. Um die Entscheidungsfindung für ein System zu erleichtern wird eine Nutzwertanalyse vorgenommen. Dabei werden verschiedene Softwareprodukte miteinander verglichen. Das Ziel der Analyse ist, ein geeignetes Datenbankmanagementsystem für unser Projekt zu finden.

### Ausschluss- und Auswahlkriterien
Zunächst erfolgt die Festlegung der Ausschlusskriterien. Diese Kriterien fließen nicht in die Nutzwertanalyse ein, sondern führen zum sofortigen Ausschluss einer Alternative.
Da zusätzliche Kosten von Drittanbietern, wie Lizenzgebühren oder Einmalkosten nicht zulässig sind, erfolgt eine sofortige Ausschließung von kostenpflichtigen Datenbankmanagementsystemen. Außerdem wird wegen eng bemessenen Zeiträumen zur Entwicklung und Bereitstellung auf komplexe und uns unbekannten Systeme verzichtet.

Nun werden die Auswahlkriterien definiert. Diese sind qualitativ und quantitativ erfassbar und lassen sich leicht recherchieren. Der Gerätebedarf sollte möglichst gering sein, Neuanschaffungen von z. B. Servern oder Computern sollten bei Einführung eines DBMS nicht infrage kommen. Das System muss mit der aktuell vorhandenen Hardware auskommen. Das System sollte die Fähigkeit besitzen, die Leistung durch das Hinzufügen von Ressourcen – z. B. weiterer Hardware oder Software in einem definierten Bereich proportional bzw. linear zu steigern. Dies ist vor allem für zukünftige Veränderungen wichtig, jedoch bei der Projekteinführung irrelevant. Ein weiteres wichtiges Kriterium ist die Verringerung bzw. Vermeidung von Schnittstellen. Der Aufwand, das Datenbankmanagementsystem einzubinden sollte möglichst gering sein, um in keine Zeitverzüge zu kommen. Da die Grundschule keinen IT-Administrator angestellt hat, der sich um die Verwaltung des Datenbankmanagementsystems kümmern könnte, muss eine externe Firma bzw. der Auftragnehmer selbst damit beauftragt werden. Um solche, in Zukunft weiteren Kosten zu vermeiden, soll der Administrationsbedarf gering sein. Mit der Kompatibilität, ist die Verträglichkeit des Systems mit verschiedenen Softwareprodukten gemeint. Die Auswahl an eingesetzten Softwareprodukten ist überschaubar, daher ist die Kompatibilität wichtig aber nicht erheblich und hat damit die niedrigste Priorität. Die Sicherheit ist das wichtigste Kriterium, da Datenschutz oberste Priorität hat. Noten sowie Personendaten sollen nicht abgefangen oder von außerhalb verändert werden können. Außerdem muss das System stabil sein, denn wie bereits im Punkt Administrationsbedarf aufgeführt, stellen alle weiteren Verwaltungsarbeiten zusätzliche Kosten dar. Das System muss stabil über mehrere Monate und Jahre laufen können. Abstürze und Datenverlust währen fatal.

Zusammengefasst lassen sich diese Kriterien ableiten;
- Hardwarebedarf
- Skalierbarkeit
- Integrationsaufwand 
- Administrationsbedarf 
- Kompatibilität
- Sicherheit 
- Stabilität 

### Gewichtung der Ziele (Kriterien)
Der zentrale Analyseschritt bei der Erstellung der Nutzwertanalyse ist die Gewichtung der zuvor festgelegten Auswahlkriterien. Die Gewichtungsfaktoren geben die Wichtigkeit der einzelnen Kriterien an. Die Gewichtungen sind, unabhängig von der verwendeten Methode, rein subjektiv. Damit die Nutzwertanalyse und die Entscheidungsfindung transparent bleiben, sollten die Gewichtungen methodisch erfolgen. Dazu benutzen wir die *Direct Ranking* Methode, das Gewicht wird dabei direkt zugeordnet.

Die Skalierung der Erfüllungsgrade und der Gewichtungsfaktoren erfolgt dabei zwischen 1 und 5;

- für **unbefriedigend** der Punkt **1**,

- für **mangelhaft** der Punkt **2**,

- für **befriedigend** der Punkt **3**,

- für **gut** der Punkt **4** und

- für **sehr gut** der Punkt **5**.
 
 Nun wurde den Kriterien eine subjektiv eingeschätzte Gewichtung zugeordnet;
  
| Kriterium                | Gewichtung |
| -------------------------|----------- |
| Hardwarebedarf           | 10% |
| Skalierbarkeit           | 10% |
| Integrationsaufwand      | 15% |
| Administrationsbedarf    | 15% |
| Kompatibilität           | 5% |
| Sicherheit               | 30% |
| Stabilität               | 15% |

Tabelle 5: Kriterium für die Nutzwertanalyse
### Definition der Alternativen
Nun werden die verschiedene Alternativen definiert. Die aktuelle Null-Alternative beschreibt den aktuellen Ist-Zustand und diese baut auf kein Datenbankmanagementsystem auf. Zur Notenverwaltung werden derzeit Microsoft Excel Tabellen erstellt und benutzt. Daraus lässt sich schließen, dass jede Alternative einen höheren Nutzen aufweist, als der aktuelle Zustand. Aufgrund der vorher festgelegten Ausschlusskriterien bleiben nur wenige Produkte übrig;
- MySQL
- PostgreSQL
- MariaDB

### Bewertung der Alternativen
Nachdem den Kriterien Gewichte zugeordnet wurden und verschiedene Alternativen existieren, müssen jetzt die Kriterien der verschiedenen Alternativen bewertet werden.

| Kriterium              | Gewichtung | MariaDB | PostgreSQL | MYSQL |
| -----------------------|----------- | ------- | ---------- | ----- |
| Hardwarebedarf         | 10%        | 4 | 4 | 5 |
| Skalierbarkeit         | 10%        | 4 | 5 | 4 |
| Integrationsaufwand    | 15%        | 5 | 5 | 5 |
| Administrationsbedarf  | 15%        | 3 | 4 | 4 |
| Kompatibilität         | 5%         | 5 | 5 | 5 |
| Sicherheit             | 30%        | 4 | 4 | 4 |
| Stabilität             | 15%        | 4 | 3 | 5 | 
| **Summe**              | **100%** |

Tabelle 6: Kriterien für die Bewertung der Datenbanken
### Nutzwertberechnung
Nun werden die einzelnen Lösungs- oder Angebotsmöglichkeiten Zeile für Zeile abgearbeitet. Jedem Kriterium wird seine Erfüllung und die jeweilige Gewichtung mit Punktwerten zugewiesen und die ganze Zeile am Ende ausmultipliziert. Das Ergebnis pro Zeile ergibt direkt die ermittelte Attraktivität einer Lösung. Dabei erhält man folgendes Ergebnis:

| Kriterium             | MariaDB  | PostgreSQL | MYSQL   |
| ----------------------| -------- | ---------- | ------- |
| Hardwarebedarf        | 0,4      | 0,4        | 0,5     |
| Skalierbarkeit        | 0,4      | 0,5        | 0,4     |
| Integrationsaufwand   | 0,75     | 0,75       | 0,75    |
| Administrationsbedarf | 0,45     | 0,75       | 0,75    |
| Kompatibilität        | 0,25     | 0,25       | 0,25    |
| Sicherheit            | 1,2      | 1,2        | 1,2     |
| Stabilität            | 0,6      | 0,45       | 0,75    | 
| **Summe**             | **4,05** | **4,3**    | **4,6** |

Tabelle 7: Bewertung der Datenbanken

Bei der Nutzwertberechnung wurde festgestellt, dass das relationale Datenbankverwaltungssystem MySQL am besten für unsere Zwecke geeignet ist. Es ist sehr zuverlässig, schnell sowie weitverbreitet. Das Betriebssystem, welches für den Server notwendig ist, ist Linux kompatibel. Der MySQL-Server ist standardmäßig mit einer AES 128 Bit Schlüssel gesichert. Man kann diesen jedoch beliebig auf eine bessere Verschlüsselung (192 oder 256 Bit) umschalten.
