/*
*   5.  Skriv en generisk klass GenericList<T> som håller en lista av
*       element av någon typ T. Hantera listans element som en array av fast
*       storlek. Storleken anges som en parameter i konstruktorn.
*       Implementera metoder för att lägga till element, hämta element per
*       index, ta bort element per index, sätta in element vid given position,
*       rensa listan, hitta element enligt dess värde och ToString ().
*       Kontrollera alla inparametrar för att förhindra åtkomst av ogiltiga
*       positioner
*   
*   6.  Implementera funktionalitet för att listan automatiskt växer: när den
*       interna arrayen är full, skapa en ny array av dubbla storleken och
*       flytta alla element dit.
*       
*   7.  Skapa generiska metoder Min<T>() och Max<T>() för att hitta det
*       största och minsta elementet i GenericList<T>. Du kan behöva lägga
*       till generiska constraints (begränsningar) för typen T.
*/

using Generic;

GenericList<int> elements = new GenericList<int>();

// Empty list
Console.WriteLine(elements);
Console.WriteLine("Count: {0}", elements.Count);
Console.WriteLine("Capacity: {0}", elements.Capacity);

// Auto-grow functionality
elements = new GenericList<int>(3);
elements.Add(1);
elements.Add(2);
elements.Add(3);
elements.Add(4);

Console.WriteLine("\n" + elements);
Console.WriteLine("Count: {0}", elements.Count);
Console.WriteLine("Capacity: {0}", elements.Capacity);

// Insert, RemoveAt
elements.Clear();

elements.Insert(0, 4);
elements.Insert(0, 3);
elements.Insert(0, 2);
elements.Insert(0, 1);

elements.RemoveAt(0);
elements.RemoveAt(elements.Count - 1);

Console.WriteLine("\n" + elements);
Console.WriteLine("Count: {0}", elements.Count);
Console.WriteLine("Capacity: {0}", elements.Capacity);

// Contains, IndexOf
Console.WriteLine("\nContain element 2: {0}", elements.Contains(2));
Console.WriteLine("Index of element 3: {0}", elements.IndexOf(3));

// Max, Min
Console.WriteLine("\nMin: {0}", elements.Min());
Console.WriteLine("Max: {0}", elements.Max());
