using System;
class Program
 {
    static void Main(string[] args)
    {
        int positivos = 0; int contar = 0; int numero;
        Console.WriteLine("Introduce número ");
        numero = Int32.Parse(Console.ReadLine());
        while (numero != 999)
        { 
            contar = contar + 1;
            if (numero > 0) positivos = positivos + 1;
            Console.WriteLine("Introduce otro número ");
            numero = Int32.Parse(Console.ReadLine());}
        Console.WriteLine("Has introducido la cantidad de numeros {0} y son positivos {1}", contar, positivos);
        //Console.WriteLine(contar);
        //Console.WriteLine("La cantidad de positivos es ");
        //Console.WriteLine(positivos);

    }
 }