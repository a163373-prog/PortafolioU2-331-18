using System;

namespace CS7
{
    class Program
    {
        static void Main(string[] args)
        {
//función: instrucciones para realizar una tarea específica que se ejecuta únicamente cuando es invocado el bloque de instrucciones
//parámetros:variables para la funcion
//sintaxis de una función:
//tipo de dato devuelto: identificador_funcion(parametros)
//bloque de instrucciones
// los parámetros se definen con el tipo de dato,incluso con tipo de dato

//nota 2
//los parámetros van separados por comas
//argumento:valor del parametro
//sintaxis de la función:
//identificador_funcion(argumentos)
//ejemplo1: funcion vacia sin parametros
void saludar()
{
	Console.WriteLine($"hola 331");
}
saludar();

//ejercitacion para imprimir lista con nombre clave y salon sin parametros
void Ejercicio() 
{ 
    string nombre = "ignacio"; 
    int salon = 331; 
    int clave = 18; 
    
    Console.WriteLine($"{nombre}, {salon}- {clave}"); 
}
Ejercicio();

//ejercicio 2 definir e invocar una función para despegar el horario de hoy y materias función //sin parámetros

void HorarioMateria()
{
	Console.WriteLine($"7:00-7:45 | cálculo");
	Console.WriteLine($"7:50-8:35 | formacion humana");
	Console.WriteLine($"8:40-9:30 | programacion");
	Console.WriteLine($"9:50-10:35 | psicologia");
	Console.WriteLine($"10:40-11:30 | idiomas");
	Console.WriteLine($"11:50-12:35 | dibujo tecnico");
	Console.WriteLine($"12:40-1:30 | dibujo tecnico");
}
HorarioMateria();

// palabra reservada para terminar una funcipn y devolver una exprecion
//ejemplo 1
int CalcularDoble(int numero)
{
    int resultado=2*numero;
    return resultado;
}
//invocacion
int devolucion;
devolucion=CalcularDoble(5);
Console.WriteLine($"Devolucion:(devolucion)");
//ejercitacion
//definir e invocar una funcion que devuelva la evaluacion de la siguiente exprecion f(x)= 4x-7/5
        double X = 3;
        double resultado = EvaluarExpresion(X);

        Console.WriteLine($"El resultado de f({X}) es: {resultado}");

    // Definición de la función
    static double EvaluarExpresion(double x)
    {
        return 4 * x - 7.0 / 5.0;
    }
        }
    }
}