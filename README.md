LA_1100
# Projekt-Dokumentation

 Damian Müller

| Datum | Version | Zusammenfassung                                              |
| ----- | ------- | ------------------------------------------------------------ |
|  23.8.22     | 0.0.1   | Heute habe ich geplant wie ich meinen Zahlengenerator programmiere.  |
|30.8.22     | 0.0.2     | Heute habe ich den Zahlen generator fast beendet ich muss nur noch ein paar Details ändern.  |
|  6.9.22     | 0.0.3   |  Heute habe ich zum Zahlengenerator noch eine Stoppuhr dazu programmiert, der Code funktioniert jetzt ohne Probleme. |
|13.9.22|1.0.0| Heute habe ich die Projektdokumentation beendet.|
## 1 Informieren

### 1.1 Ihr Projekt

Wir müssen einen random number guesser programmieren.

### 1.2 User Stories

| US-№ | Verbindlichkeit | Typ  | Beschreibung                       |
| ---- | --------------- | ---- | ---------------------------------- |
| 1    |   muss          |   Q  | Als Informatiker möchte ich ein Programm das funktioniert, damit viele Spieler mein Spiel spielen |                       
| 2    |   muss          |  F   | Als Informatiker möchte ich ein Programm programmieren, damit eine zufällige Zahl generiert werden kann | 
| 3    |   kann          |   Q  | Als Informatiker möchte ich ein einfaches spiel, damit das Spiel viele Spieler spielen können |
|  4   |   muss          |  F   | Als Spieler möchte ich ein spannendes Spiel, damit ich meine Zeit vertreiben kann |
|  5   |   muss          |    Q | Als Spieler möchte ich nicht das die Zufallszahl veraten wird, damit das Spiel auch spass macht |
|  6   |   muss          |    F | Als Spieler möchte ich das die herausgefundene Zahl in der nächsten Runde nicht vorkommt, damit nicht immer die gleiche Zahl ist| 
| 7    |   muss          |   F  | Als Spieler möchte ich wissen ob die generierte Zahl grösser oder kleiner ist, damit ich näher an die generierte Zahl komme |
| 8    |muss                 | F| Als Spieler möchte ich eine Stopuhr im Spiel, damit ich weiss wie lange ich gebraucht habe die Zahl herauszufinden|               


### 1.3 Testfälle

| TC-№ | Ausgangslage | Eingabe | Erwartete Ausgabe |
| ---- | ------------ | ------- | ----------------- |
| 1.1  |  Programm wird gestartet | drücke auf Start|Programm öffnet sich|
| 3.2  | Programm wählt random Zahl |Zahl generieren |Zahl wird gespeichert |
|1.3   | Spieler gibt zu grosse Zahl ein | Zahl| Zahl ist zu gross |
|1.4   |Spieler gibt richtige Zahl ein | Zahl| diese Zahl ist richtig|
|1.5   | Spieler gibt Zahl höher als 100 ein| Zahl > 100| Diese Zahl ist nicht erlaubt|
|1.6| Spieler gibt zu kleine Zahl ein |Zahl| diese Zahl ist zu klein|

 

### 1.4 Diagramme
![number guesser](https://user-images.githubusercontent.com/110892840/188601917-2062f32c-3ba7-4bdb-b12e-35ae1f841b40.png)

 

## 2 Planen

| AP-№ | Frist | Zuständig | Beschreibung | geplante Zeit |
| ---- | ----- | --------- | ------------ | ------------- |
| 2.A  |  6.9.22     | Ich       |Random zahl Generator programmieren|50min |
| 8.A     | 6.9.22      | Ich       |Stopuhr programmieren              |    60min |
| 6.A      | 6.9.22     |Ich        |Zahl speichern damit sie nicht in der nächsten Runde vorkommt| 50 min|
|7.A|     6.9.22|Ich | Anzeigen ob Zahl grösser oder kleiner ist |30min|
Total: 

 
 
## 3 Entscheiden
genügend Zeit nehmen

## 4 Realisieren

| AP-№ | Datum | Zuständig | geplante Zeit | tatsächliche Zeit |
| ---- | ----- | --------- | ------------- | ----------------- |
| 2.A  |  30.08.22     | Ich|  20min             |   70min                |
| 8.A  |       | Ich          | 60min              |   50min                |
|6.A|          | Ich | 50min| 50min |
 |7.a|         |ich |30min|35min|

## 5 Kontrollieren

### 5.1 Testprotokoll

| TC-№ | Datum | Resultat | Tester |
| ---- | ----- | -------- | ------ |
| 1.1  | 13.9.22  |  true |   Ich     |
| 3.2  | 13.9.22      |    true      |Ich        |
|1.3| 13.9.22| true|ich|
|1.4|13.9.22|true|ich |
|1.5|13.9.22|diese Zahl ist zu gross|ich|
|1.6|13.9.22|true|ich |

✍️ Vergessen Sie nicht, ein Fazit hinzuzufügen, welches das Test-Ergebnis einordnet.

### 5.2 Exploratives Testen

| BR-№ | Ausgangslage | Eingabe | Erwartete Ausgabe | Tatsächliche Ausgabe |
| ---- | ------------ | ------- | ----------------- | -------------------- |
| I    | Zahl zwischen 1-100 eingeben  |  Buchstaben     | nicht möglich  | Programm abgestürzt    |
| II  |   Zahl zwischen 1-100 eingeben | Zahl mit Punkt     |Zahl nicht möglich |Programm abgestürzt|
|III|  Zahl zwischen 1-100 eingeben   |Zahl mit ,| Zahl nicht möglich| Programm abgestürzt|


✍️ Verwenden Sie römische Ziffern für Ihre Bug Reports, also I, II, III, IV etc.

## 6 Auswerten

 
