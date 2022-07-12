using System;

namespace Ejercicio1DeSofiaMarani
{
    	class ejercicio1desofiamarani {

		static void Main(string[] args) {
			double multiplicacion1;
			double numero1;
			double resultado;
			Console.Write("Ingrese los dolares: ");
			numero1 = Double.Parse(Console.ReadLine());
			multiplicacion1 = numero1*230;
			Console.WriteLine("Cantidad de pesos en el mercado oficial: "+multiplicacion1);
			multiplicacion1 = numero1*280;
			Console.WriteLine("Cantidad de pesos en el mercado paralelo: "+multiplicacion1);
			resultado = multiplicacion1*1.17;
			Console.WriteLine("Cantidad de euros: "+resultado);
		}

	}

}