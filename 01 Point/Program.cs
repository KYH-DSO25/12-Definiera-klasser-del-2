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

using Path = _01_Point.Path;

Point3D a = new Point3D(1, 2, 3);
Console.WriteLine("Point({0})", a);     // point A

Point3D b = Point3D.Center;
Console.WriteLine("Point({0}, {1}, {2})", b.X, b.Y, b.Z);   // Punkt 0

Console.WriteLine("Distance: {0}", Distance.Calculate(a, b)); // Calculate distance

// Path of points
Path path = new Path(new Point3D(1, 1, 1), new Point3D(2, 2, 2));
path.Add(new Point3D(3, 3, 3));
path.Remove(new Point3D(1, 1, 1));
Console.WriteLine("\nPoints in path (total: {0})\n{1}", path.Count, path);

path.Clear();

// Loads new points from the file
path = PathStorage.Load("../../../input.txt");
Console.WriteLine("\nPoints in path (total: {0})\n{1}", path.Count, path);

// Saves the points in output file
PathStorage.Save(path, "../../../output.txt");

