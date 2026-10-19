# Lernjournal-IPT1

## Learnsession 1

> Einstieg

---

### Wichtige Begriffe 

**Objekt:** Ein Objekt ist ein konkretes Exemplar einer Klasse, das einen eigenen Zustand besitzt und bestimmte Aktionen ausführen kann.

**Attribut:** Ein Attribut ist eine Eigenschaft oder ein Merkmal eines Objekts, das dessen Daten oder Zustand speichert.

**Ereignis:** Ein Ereignis ist ein Signal oder Vorkommnis (z. B. ein Mausklick), das eine bestimmte Reaktion oder Aktion im Programm auslöst.

**Verhalten:** Das Verhalten beschreibt die Aktionen oder Methoden, die ein Objekt als Reaktion auf Befehle oder Ereignisse ausführen kann.

**Variable:** Eine Variable ist ein benannter Speicherbereich im Programm, der Werte aufnehmen und während der Laufzeit verändern kann.

---

### Aufgabe Scratch

[Scratch Projekt](Scratch-Projekt.sb3)

---

## Lernsession 2

> **Git & GitHub**

---
### Befehle GitHub

| Befehl | Aufgabe |
|---|---|
| `git status` | Zeigt den aktuellen Zustand des Repositories und geänderte Dateien an. |
| `git add` | Wählt bearbeitete Dateien für den nächsten Speicherpunkt aus. |
| `git branch` | Erstellt einen neuen Branch. |
| `git log` | Zeigt die Liste aller bisherigen Speicherungen an. |
| `git clone` | Lädt ein Repository von GitHub herunter, um lokal damit zu arbeiten. |
| `git commit -m "..."` | Speichert die ausgewählten Dateien lokal mit einer kurzen Nachricht. |
| `git push` | Lädt gespeicherte Commits auf GitHub hoch. |
| `git pull` | Aktualisiert das lokale Projekt mit neuen Änderungen von GitHub. |
| `git merge` | Verbindet die Änderungen aus einem Branch mit dem Hauptzweig. |
| `git checkout` | Wechselt zwischen verschiedenen Bereichen (Branches). |
| `git init` | Erstellt ein neues Git-Repository in einem vorhandenen Ordner. |

---

### Begriffe Git und GitHub

* **Git** - ein lokales, verteiltes Versionsverwaltungssystem (VCS). Es verfolgt Code-Änderungen offline, speichert die Projekthistorie in Commits und ermöglicht das Arbeiten mit Branches.
* **GitHub** - eine cloudbasierte Hosting-Plattform für Git-Repositories. Sie bietet eine Weboberfläche und Tools für die Teamarbeit (z. B. Pull Requests, Issues, CI/CD).
  
**Vergleich: Git vs. GitHub**
  
| Kriterium | Git | GitHub |
| --- | --- | --- |
| Typ | Software (VCS) | Cloud-Dienst / Plattform |
| Ort | Lokal (auf dem PC) | Online (Cloud-Server) |
| Internet | Offline nutzbar | Internet erforderlich |
| Interface | Befehlszeile (CLI) | Weboberfläche (GUI) |
| Fokus | Code-Versionierung | Teamarbeit & Projektmanagement |

* **Repository** - der Speicherort eines Projekts, der alle Dateien, Ordner und die gesamte Git-Historie enthält.
* **Branch** - eine Arbeitskopie des Projekts, um neue Features oder Fixes unabhängig vom Hauptcode zu entwickeln.
* **`main`-Branch** - die Hauptversion des Projekts, in die alle geprüften Änderungen zusammengeführt werden.
* **Markdown** - eine einfache Textformatierungssprache, mit der man Texte mit Symbolen (wie # oder *) strukturiert, um Dokumentationen wie die README.md schnell und leicht lesbar zu gestalten.
* **GitHub-Flavored Markdown (GFM)** - eine von GitHub erweiterte Version von Markdown, die zusätzliche Funktionen wie Tabellen, Tasklisten und die Verlinkung von Issues bietet.
*  **Issue** - eine strukturierte Aufgaben- oder Problemmeldung im Projekt-Repository, die alle relevanten Informationen, Diskussionen und den aktuellen Status eines Tasks zusammenfasst, damit Anpassungen am Projekt nachvollziehbar bearbeitet werden können.
* **Commit** - eine gespeicherte Code-Änderung, die einen konkreten Entwicklungsstand im Repository sicher festhält und über eine eindeutige ID nachvollziehbar macht.
* **Commit-Nachricht** - ein erklärender Text zu einem Commit.
* **Pull Request** - eine Anfrage, die Commits aus einem Arbeits-Branch nach einer Überprüfung im Team (Code Review) in einen anderen Branch (wie main) zusammenzuführen (mergen).
* **Review** - die systematische Prüfung von Code-Änderungen durch andere Teammitglieder, um Fehler frühzeitig zu erkennen und eine hohe Code-Qualität sicherzustellen.
* **Merge** - das Zusammenführen von Code-Änderungen aus einem Branch in einen anderen, um zwei Entwicklungsstände zu vereinen.

---
## Learnsession 3

> Markdown

### Markdown: Zeichnen

| Syntax | Wirkung auf den Text |
|---|---|
| `# / ## / ###` | Erstellt eine Überschrift (Ebene 1, 2 oder 3). |
| `**text**` | Macht den Text fett. |
| `*text*` oder `_text_` | Macht den Text kursiv. |
| `~~text~~` | Durschstreicht den Text. |
| `---` | Fügt eine horizontale Trennlinie ein. |
| `>` | Formatiert den Text als Zitat (Blockquote). |
| `[Titel](URL)` | Erstellt einen klickbaren Link. |
| `![Alt-Text](URL)` | Bindet ein Bild ein. |
| `-` oder `*` | Erstellt einen Aufzählungspunkt (Liste). |
| `1.` / `2.` | Erstellt eine nummerierte Liste. |
| \`...` | Formatiert den Text als Inline-Code |
| ` ```...``` ` | Erstellt einen mehrzeiligen Code-Block. |
| `[ ] / [x]` | Erstellt eine interaktive Checkbox (Aufgabenliste). |
| `<br>` | Erzwingt einen einfachen Zeilenumbruch. |
| `\|` | Mit dem macht man die Tabelle |

---
## Learnsession 4

> Vom Problem zur Lösung

---

### Wie man das Problem löst?

1. **Problem & Ziel definieren:** Das aktuelle Problem und das gewünschte Ziel neutral beschreiben.   
2. **Anforderungen festlegen:** Bestimmen, was das Programm leisten muss (Eingabe, Verarbeitung, Ausgabe).   
3. **Akzeptanzkriterien setzen:** Klare Prüfregeln definieren, um zu testen, ob das Ziel erreicht wurde.   
4. **Testen & Anpassen:** Den Ablauf (Trockenlauf und Fremdtest) durchspielen und bei Unklarheiten verbessern.

---

### Wichtige Begriffe

* **Problem:** Beschreibt den aktuellen, fehlerhaften oder schwierigen Zustand, der verbessert werden soll.
* **Ziel:** Beschreibt den gewünschten Endergebnis- oder Wunschzustand, der erreicht werden soll.
* **Lösung:** Beschreibt die konkreten technischen Schritte oder Umsetzungen, wie dieses Ziel erreicht werden soll

* **Problemstatement:** Eine klare, lösungsneutrale Beschreibung des aktuellen Problems oder Fehlers.
* **Zielbild:** Ein überprüfbares Ziel, das beschreibt, wie der gewünschte Zustand nach der Lösung aussehen soll.
* **Funktionale Anforderung:** Eine konkrete Beschreibung dessen, was das Programm leisten oder können muss.
* **Akzeptanzkriterium:** Eine klare Bedingung oder Testregel, mit der eine fremde Person eindeutig entscheiden kann (erfüllt oder nicht erfüllt), ob eine Anforderung erfolgreich umgesetzt wurde.

---

### Dokumente
[Praxisfall_Mensa](./LS4_Arbeitsblatt_Praxisfall_Mensa.pdf)

---
## Learningsession 5

> Algorithmus und EVA in C#

---

### EVA - Modell

Eingabe – Verarbeitung – Ausgabe

* **Eingabe (E):** Daten werden in ein System eingegebe
* **Verarbeitung (V):** Das System verarbeitet die eingegebenen Daten nach bestimmten Regeln.
* **Ausgabe (A):** Das Ergebnis der Verarbeitung wird an den Nutzer oder ein anderes Gerät weitergegeben.

---

### Algorithmus EVA in lineare Programm C#

```
//Eingabe. Benutzer gibt Artikelname an.
Console.WriteLine("Artikelname: "); 
string artikelname = Console.ReadLine(); 

//Eingabe. Benutzer gibt Einzelpreis an.
Console.WriteLine("Einzelpreis: ");
string einzelpreis = Console.ReadLine();

//Verarbeitung. Programm waldet Variable 'string' in 'decimal' um.
decimal einzelpreisdec = decimal.Parse(einzelpreis); 

//Eingabe. Benutzer gibt Menge an.
Console.WriteLine("Menge: "); 
string menge = Console.ReadLine();

//Verarbeitung. Programm waldet Variable 'string' in 'int' um.
int mengeint = int.Parse(menge); 

//Verarbeitung. Programm rechnet Gesamtpreis.
decimal gesamtpreis = einzelpreisdec * mengeint; 

//Ausgabe. Programm gibt Artikelname an. 
Console.WriteLine("Artikelname: " + artikelname); 

//Ausgabe. Programm gibt Einzelname an. 
Console.WriteLine("Einzelpreis: " + einzelpreisdec + " CHF");

//Ausgabe. Programm gibt Menge an. 
Console.WriteLine("Menge: " + mengeint); 

//Ausgabe. Programm gibt Gesamtpreis an. 
Console.WriteLine("Gesamtpreis: " + gesamtpreis + " CHF"); 
```
---

### Programm C#
[Programm_Mensa.cs](./Programm_Mensa.cs)
