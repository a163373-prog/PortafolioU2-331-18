using System;
namespace CS5
{
    class Program
    {
        static void Main(string[] args)
        {
            // sesion 12
            // instruccion while
            //sintaxis
            //while (exprecion)
            //{
            //  bloque de ist
            //  iterador;
            //}
            //siclo acendedente
            int m =1;
            while(m<=3)
            {
                //bloque inst
                Console.WriteLine($"m:{m}");
                m+=1; //iterador
            }
            //ejercitacion
            //1 definir un cilco para imprimir tu nombre 5 veces (para exprecion utilizar operador <)
            // ciclo acendente
            int d =1;
            while(d<6)
            {
                Console.WriteLine($"Ignacio Lastra");
                d+=1;
            }
            // ciclo decendente
            int e =3;
            while(e>=1)
            {
                Console.WriteLine($"e:{e}");
                e-=1;
            }
            // incrementos (ciclo ascendente)
            //secuencoaa 3 6 9 12 15 18
            int i=3;
            while(i<=18)
            {
                Console.WriteLine($"i:{i}");
                i+=3;
            }
            //ejercitacion
            //definir ciclo para imprimir 331 8 veces
            //para la solucion difinir con decrementos de 2 unidades
            int u=16;
            while(u>=1)
            {
                Console.WriteLine($"331");
                u-=2;
            }
            // actiividad 1
            //ciclo infinito
            //def un cilo infinito acendiente
            // def un cilco infnito decendiente
            //para la solucion utilizar el operador de diferencia (decendiente)
            double a=9.9979;
            while(a>1)
            {
                Console.WriteLine($"a:{a}");
                a+=1;
            }
            //decendiente
            double x=9.8845;
            while(x!=1)
            {
                Console.WriteLine($"x{x}");
                x-=1;
            }
        }
    }
}