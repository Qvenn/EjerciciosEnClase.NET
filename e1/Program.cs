/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 25/09/2019
 * Hora: 8:10
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace e1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int n,contador=0;
			
			Console.WriteLine("Ingresar n numeros");
			n=int.Parse(Console.ReadLine());
			int i=1; //inicializa la variable del ciclo
			while(i<=n){ //Condicion para el ciclo
			contador=contador+i; 
			Console.Write(" "+i);
			i=i+1; //Incremento de la variable
			}
			Console.WriteLine(" ");
			Console.WriteLine("La suma de los primeros "+n+" numeros es: "+contador);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}