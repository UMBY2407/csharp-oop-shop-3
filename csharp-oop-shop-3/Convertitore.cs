using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_3
{
	public static class Convertitore
	{
		public static void convertiInGalloni(double litri)
		{
			const double galloniLitro = 3.785;
			double galloni = litri * galloniLitro;
			Console.WriteLine($"{litri} litri = {galloni} galloni");
		}
	}
}
