using System;

namespace CS6
{
    class Program
    {
        static void Main(string[] Args)
        {
            // ciclo for para la siguiente secuencia -33 -34 -35 -36 -37 -38 -39
int n= 33 ;
while (n<= 39)
{
    Console.WriteLine($"n:{n*-1}");
    n++;
}

//1
int r=9;
Console.WriteLine($"area:{4/3*(Math.PI*r*r)}");

// secuencia 599 pajias
int p=2;
while (p!=599)
{
    p++;
}
if (p==599)
{
Console.WriteLine($"p:{p}");
}
     }
    }
}