using System;
using System.Collections.Generic;

namespace cs_lab02
{
    class Program
    {
    static void Main(string[] args)
    {
        //Krok1();
        Krok2();
    }
    static void Krok2(){
        var lista = new List<Pracownik>();
        lista.Add( new Pracownik("CCC", new DateTime(2010, 10, 02), 1050 ) );
        lista.Add( new Pracownik("AAA", new DateTime(2010, 10, 01), 100 ) );
        lista.Add( new Pracownik("DDD", new DateTime(2010, 10, 03), 2000 ) );
        lista.Add( new Pracownik("AAA", new DateTime(2011, 10, 01), 1000 ) );
        lista.Add( new Pracownik("BBB", new DateTime(2010, 10, 01), 1050 ) );

        Console.WriteLine("-- Wariant 1 --");
        foreach( var pracownik in lista )
        Console.WriteLine( pracownik );

        Console.WriteLine("-- Wariant 2 --");
        lista.ForEach( (p) => {Console.Write(p + ",");} );
        Console.WriteLine(   );

        Console.WriteLine("-- Wariant 3 --");
        Console.WriteLine( string.Join('\n', lista) );

        lista.Sort(); //zadziała, jeśli klasa Pracownik implementuje IComparable<Pracownik>

        Console.WriteLine("Po posortowaniu:");
        foreach( var pracownik in lista )
            Console.WriteLine( pracownik );
    }
    static void Krok1()
    {
        Console.WriteLine("--- Sprawdzenie poprawności tworzenia obiektu ---");
        Pracownik p = new Pracownik("Kowalski", new DateTime(2010, 10, 1), 1_000);
        Console.WriteLine(p);

        Console.WriteLine("--- Sprawdzenie równości obiektów ---");
        Pracownik p1 = new Pracownik("Nowak", new DateTime(2010, 10, 1), 1_000);
        Pracownik p2 = new Pracownik("Nowak", new DateTime(2010, 10, 1), 1_000);
        Pracownik p3 = new Pracownik("Kowalski", new DateTime(2010, 10, 1), 1_000);
        Pracownik p4 = p1;
        Console.WriteLine($"p1: {p1} hashCode: {p1.GetHashCode()}");
        Console.WriteLine($"p2: {p2} hashCode: {p2.GetHashCode()}");
        Console.WriteLine($"p3: {p3} hashCode: {p3.GetHashCode()}");
        Console.WriteLine($"p4: {p4} hashCode: {p4.GetHashCode()}");
        Console.WriteLine();

        Console.WriteLine($"--- Równość dla p1 oraz p2 -");
        Console.WriteLine($"Object.ReferenceEquals(p1, p2): {Object.ReferenceEquals(p1, p2)}");
        Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}");
        Console.WriteLine($"p1 == p2: {p1 == p2}");
        Console.WriteLine();

        Console.WriteLine($"--- Równość dla p1 oraz p3 -");
        Console.WriteLine($"Object.ReferenceEquals(p1, p3): {Object.ReferenceEquals(p1, p3)}");
        Console.WriteLine($"p1.Equals(p3): {p1.Equals(p3)}");
        Console.WriteLine($"p1 == p3: {p1 == p3}");
        Console.WriteLine();

        Console.WriteLine($"--- Równość dla p1 oraz p4 -");
        Console.WriteLine($"Object.ReferenceEquals(p1, p4): {Object.ReferenceEquals(p1, p4)}");
        Console.WriteLine($"p1.Equals(p3): {p1.Equals(p4)}");
        Console.WriteLine($"p1 == p4: {p1 == p4}");
    }
    }
}
