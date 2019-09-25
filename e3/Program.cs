/*
 * Creado por SharpDevelop.
 * Usuario: CBN
 * Fecha: 25/09/2019
 * Hora: 8:53
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace e3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite numero N");
			int n=int.Parse(Console.ReadLine());
			int numero=0;
			int contpos=0;
			int contnega=0;
			for (int i=1;i<=n;i++){
				Console.WriteLine("Digite numero ");
				numero=int.Parse(Console.ReadLine());
				if (numero>0)
					contpos++;
				else if (numero<0)
					contnega++;
			}
			Console.WriteLine("Positivos son: "+contpos);
			Console.WriteLine("negativos son: "+contnega);
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}