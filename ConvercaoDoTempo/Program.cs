using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {
        int N, horas, resto, minutos, segundos;

        Console.WriteLine("Digite os segundo que serão convertidos");

        N = int.Parse(Console.ReadLine());

        horas = N / 3600;
        resto = N % 3600;

        minutos = resto / 60;
        segundos = resto % 60;

        Console.WriteLine(horas + " H : " + minutos + " min : " + segundos + " seg ");

        Console.ReadLine();





    }

}