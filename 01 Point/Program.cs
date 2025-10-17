/*
*   1.  Skapa en struct Point3D som innehåller 3D koordinater {X, Y, Z} för
*       en punkt. Implementera metoden ToString() för att kunna skriva ut
*       en 3D punkt
*   
*   2.  Lägg till ett statiskt fält som endast kan läsas för att hålla starten av
*       koordinatsystemet punkten origo {0, 0, 0}. Lägg till en statisk
*       metod som returnerar punkten origo.
*       
*   3.  Skriv en statisk klass med en statisk metod som beräknar avståndet
*       mellan två punkter i 3D rymden (TIPS: det är en variant på Pythagoras
*       sats)
*       Avstånd mellan två punkter:
•           https://www.matteboken.se/lektioner/matte-2/geometri/avstandsformeln
•           https://www.naturvetenskap.org/matematik/geometri/avstandsformeln/
*   
*   4.* Skapa en klass Path som håller en sekvens av punkter i 3D rymden.
*       Skapa en statisk klass PathStorage med statiska metoder för att
*       spara och hämta data i en textfil. Bestäm själv filformatet.
*/

using _01_Point;

Point3D a = new Point3D(1, 2, 3);
Console.WriteLine("Point({0})", a);     // point A

Point3D b = Point3D.Center;
Console.WriteLine("Point({0}, {1}, {2})", b.X, b.Y, b.Z);   // Punkt 0



