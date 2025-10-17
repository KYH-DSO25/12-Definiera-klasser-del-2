/*
* 1.  Skapa en struct Color3D som innehåller tre färgkomponenter {R, G, B}.
*   Alla värden ska vara av typen byte.
*   Implementera metoden ToString() för att kunna skriva ut färgen i formatet:
*   "R = 255, G = 128, B = 0"
*   *
* 2.  Lägg till tre statiska readonly-fält för de vanligaste färgerna:
*   Red   = (255, 0, 0)
*   Green = (0, 255, 0)
*   Blue  = (0, 0, 255)
*   *
* 3.  Lägg till en statisk metod GetDefault() som returnerar färgen svart (0, 0, 0).
*   *
* 4.* Skapa en klass Palette som kan hålla en lista av Color3D-objekt.
*   Lägg till metoder för att lägga till färger och skriva ut alla färger i listan.
*   Skapa en statisk klass PaletteStorage med statiska metoder för att
*   spara och hämta data i en textfil. Bestäm själv filformatet.
*
*/

using _01b_Color_i_3D;

var färg = new Color3D(100, 100, 100);
Console.WriteLine("Färg: {0}", färg);

var röd = Color3D.Red;
var grön = Color3D.Green;
var blå = Color3D.Blue;
Console.WriteLine("röd: {0}", röd);

var standardFärg = Color3D.Default;         // Snyggare (?)
Console.WriteLine("Standardfärg via egenskap: {0}", standardFärg);
standardFärg = Color3D.GetDefault();
Console.WriteLine("Standardfärg via metod: {0}", standardFärg);

// Palett av färger
Palette palett = new Palette(färg, röd, grön, blå);
palett.Add(standardFärg);
palett.Remove(röd);

Console.WriteLine("\nFärger i paletten: (antal: {0})\n{1}", palett.Count, palett);





Console.Write("\n\nTryck på en tangent");
Console.ReadKey();
