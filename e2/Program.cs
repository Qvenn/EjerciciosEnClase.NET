/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 25/09/2019
 * Hora: 8:36
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace e2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite numero N");
			int n=int.Parse(Console.ReadLine());
			int suma=0;
			for (int i=1;i<=n;i++){
				suma=suma+i;
				Console.Write(" "+i);
			}
			Console.WriteLine("");
			Console.WriteLine("La sumas de los primero "+n+" numeros es: "+suma);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}