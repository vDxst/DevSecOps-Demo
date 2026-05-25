<<<<<<< HEAD
# DevSecOps C# Demo

Dieses Repository gehört zu einer Präsentation über **Secure DevOps / DevSecOps**.

Es zeigt anhand eines kleinen C#-Konsolenprogramms, wie eine SQL-Injection entstehen kann und wie man sie mit einer parametrisierten Abfrage verhindert.

## Ziel der Demo

Die Demo zeigt zwei Varianten:

### 1. Unsichere Variante

```csharp
string query = "SELECT * FROM Users WHERE ID = " + input;
```

Hier wird die Benutzereingabe direkt an den SQL-Befehl angehängt.

Wenn ein Angreifer zum Beispiel Folgendes eingibt:

```text
1 OR 1=1
```

entsteht daraus:

```sql
SELECT * FROM Users WHERE ID = 1 OR 1=1
```

Das ist gefährlich, weil `OR 1=1` immer wahr ist.

### 2. Sichere Variante

```csharp
string query = "SELECT * FROM Users WHERE ID = @id";
```

Die Eingabe wird nicht direkt in den SQL-Befehl eingefügt, sondern als Parameter behandelt.

Dadurch bleibt die SQL-Abfrage fest, und die Eingabe wird nicht als SQL-Code interpretiert.

## Projekt lokal starten

Voraussetzung:

- Visual Studio Code
- .NET SDK
- Git, falls das Projekt auf GitHub hochgeladen werden soll

Projekt starten:

```bash
dotnet run
```

Beispiel-Eingabe:

```text
1 OR 1=1
```

## Erwartete Ausgabe

Das Programm zeigt zuerst die unsichere SQL-Abfrage:

```sql
SELECT * FROM Users WHERE ID = 1 OR 1=1
```

Danach zeigt es die sichere Variante:

```sql
SELECT * FROM Users WHERE ID = @id
```

Zusätzlich wird angezeigt, dass der eingegebene Wert nur als Parameter behandelt wird:

```text
@id = "1 OR 1=1"
```

## DevSecOps-Bezug

Dieses Projekt zeigt den DevSecOps-Gedanken anhand von zwei Punkten:

1. Sichere Programmierung direkt im Code
2. Automatische Prüfung durch GitHub Actions

Die Pipeline befindet sich unter:

```text
.github/workflows/security-scan.yml
```

Bei jedem Push oder Pull Request wird automatisch geprüft:

- ob das Projekt gebaut werden kann
- ob bekannte Schwachstellen in NuGet-Paketen vorhanden sind
- ob das Demo-Programm ausführbar ist

## Präsentationsidee

In der Präsentation kann man zuerst `Program.cs` in VS Code zeigen und danach im Terminal ausführen:

```bash
dotnet run
```

Als Eingabe verwendet man:

```text
1 OR 1=1
```

Danach wird im GitHub-Repository der Tab **Actions** geöffnet, um zu zeigen, dass der Sicherheitscheck automatisch läuft.
=======
# DevSecOps-Demo
Secure DevOps Demo
>>>>>>> 13a49e01b5c4101003327606840ee1cc3438b87b
