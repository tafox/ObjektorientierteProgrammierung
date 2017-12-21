using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjektorientierteProgrammierung.Kapitel3
{
    class Kapitel3
    {
        /*
         *
         *
         * Kapital 3
         * Die Prinzipien des objektorientierten Entwurfs
         *
         *
         */

        /* Definitionen */
        //
        // Modul - ein überschaubarer, eigenständiger Teil des Programms
        //

        /* Prinzip 1: Prinzip einer einzigen Verantwortung */
        //
        // Jedes Modul soll genau eine Verantwortung haben, und umgekehrt soll jede Verantwortung 
        // einem Modul zugeordnet werden.
        //
        // Regel 1: Kohäsion maximieren
        // Ein Modul soll zusammenhängend sein. Alle Teile eines Moduls sollten voneinander abhängig sein.
        //
        // Regel 2: Kopplung minimieren
        // Wenn mehrere Module zusammenarbeiten müssen, um eine Aufgabe zu auszuführen, dann bestehen
        // Abhängigkeiten zwischen diesen Modulen. Die Module sind dann gekoppelt. Wir wollen die Kopplung
        // möglichst gering halten.
        //

        /* Prinzip 2: Trennung der Anliegen */
        //
        // Ein in einer Anwendung identifizierbares Anliegen soll durch ein Modul repräsentiert werden. Ein
        // Anliegen soll nicht über mehrere Module verstreut sein.
        //

        /* Prinzip einer einzigen Verantwortung vs. Trennung der Anliegen */
        //
        // Eine Verantwortung heißt, dass ein Modul nur einen Grund hat, warum es geändert werden muss.
        //
        // Trennung der Anliegen heißt, dass alle Funktion in einem Programm abhängig voneinander sind.
        //

        /* Prinzip 3: Wiederholung vermeiden */
        //
        // Eine identifizierbare Funktionalität eines Programms sollte innerhalb des Programms nur einmal
        // umgesetzt sein.
        //
        // Wenn sich ein Stück Quelltext wiederholt, ist es oft ein Indiz dafür, dass Funktionalität vorliegt,
        // die zu einem Modul zusammengefasst werden sollte.
        //

        /* Prinzip 4: Offen für Erweiterung geschlossen für Änderung */
        //
        // Ein Modul soll für Erweiterungen offen sein.
        // Das bedeutet, dass sich durch die Verwendung des Moduls zusammen mit Erweiterungsmodulen die ursprüngliche
        // Funktionalität des Moduls anpassen lässt. Dabei enthalten die Erweiterungsmodule nur die Abweichungen der 
        // gewünschten von der ursprünlichen Funktionalität.
        //
        // Ein Modul soll für Änderungen geschlossen sein.
        // Das bedeutet, dass keine Änderungen des Moduls nötig sind, um er erweitern zu können. Das Modul soll also
        // definierte Erweiterungspunkte bieten, an die sich die Erweiterungsmodule anknüpfen lassen.
        //
    }
}
