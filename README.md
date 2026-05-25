# DevSecOps Demo

Dieses Repository ist Teil unserer Präsentation über Secure DevOps.

Das Projekt zeigt ein kleines Beispiel für SQL-Injection in C#. Dabei wird eine unsichere SQL-Abfrage mit einer sicheren Variante verglichen.

In der unsicheren Variante wird die Benutzereingabe direkt in den SQL-Befehl eingefügt. Dadurch könnte ein Angreifer eigenen SQL-Code einschleusen.

In der sicheren Variante wird ein Parameter verwendet. Die Eingabe wird dadurch nicht als SQL-Code ausgeführt, sondern nur als Wert behandelt.

Zusätzlich enthält das Repository eine GitHub-Actions-Pipeline. Diese startet automatisch bei einem Push oder Pull Request und prüft, ob das Projekt gebaut werden kann.

Die Demo zeigt damit den Grundgedanken von DevSecOps: Sicherheit soll früh im Entwicklungsprozess berücksichtigt und möglichst automatisch geprüft werden.