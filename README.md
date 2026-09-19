# Lernjournal-IPT1
> **Git, GitHub, Markdown**

---

## Befehle GitHub

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

## Markdown

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
| ` | Formatiert den Text als Inline-Code |
| ` ```...``` ` | Erstellt einen mehrzeiligen Code-Block. |
| `[ ] / [x]` | Erstellt eine interaktive Checkbox (Aufgabenliste). |
| `<br>` | Erzwingt einen einfachen Zeilenumbruch. |

---

## Begriffe Git und GitHub

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
