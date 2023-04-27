using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_shop_3
{
	public class Water : Product
	{
		//ATTRIBUTES
		private string brand;
		private float maxCapacity;
		private float litersInTheBottle;
		private float pH;
		private string source;

		//CONSTRUCTOR
		public Water(string name, string description, float price, string categoryName, string brand, float maxCapacity, float initialLiters, float pH, string source, int tax = 22) : base(name, description, price, categoryName, tax)
		{
			this.brand = brand;
			this.maxCapacity = maxCapacity;
			this.litersInTheBottle = initialLiters;
			this.pH = pH;
				if (pH < 0 || pH > 10)
				{
					throw new ArgumentException("Il valore inserito non rispetta i limiti del valore del Ph!", "pH");
				}
			this.source = source;
		}



		//GETTERS
		
		public string GetBrand()
		{
			return this.brand;
		}

		public float GetMaxCapacity()
		{
			return this.maxCapacity;
		}

		public float GetLitersInBottle()
		{
			return this.litersInTheBottle;
		}

		public float GetpH()
		{
			return this.pH;
		}

		public string GetSource()
		{
			return this.source;
		}

		//SETTERS
		public void SetBrand(string newBrand)
		{
			this.brand = newBrand;
		}

		//METHODS
		public void Drink(float litersToDrink)
		{
			if (litersToDrink < this.maxCapacity && litersToDrink < litersInTheBottle)
			{
				this.litersInTheBottle = this.litersInTheBottle - litersToDrink;
				Console.WriteLine("Hai bevuto: " + litersToDrink + "L" + " ora ne rimangono " + this.litersInTheBottle);
			}
			else
			{
				litersInTheBottle = 0;
				throw new ArgumentException("I litri da bere superano i litri nella bottiglia!", "litersToDrink");
			}

			if(litersInTheBottle == 0)
			{
				throw new Exception("Non puoi più bere, la bottiglia è vuota!");
			}
		}

		public void Fill(float litersToPutIntoBottle)
		{
			if(litersToPutIntoBottle < 0)
			{
				throw new ArgumentException("La quantità di litri da riempire risulta negativa!", "litersToPutIntoBottle");
			}

			if ((litersToPutIntoBottle + litersInTheBottle) <= this.maxCapacity)
			{
				this.litersInTheBottle += litersToPutIntoBottle;
				Console.WriteLine("Hai aggiunto: " + litersToPutIntoBottle + "L" + " ora ci sono " + this.litersInTheBottle);
			}
			else
			{
				litersInTheBottle = maxCapacity;
				throw new ArgumentException("La nuova capienza supera la Capienza massima!", "litersToPutIntoBottle");
			}
		}

		public void EmptyBottle()
		{
			litersInTheBottle = 0;
		}

		public override string ToString()
		{
			string infoProduct =
			$"Nome: {this.GetName()} \n" +
			$"Marca: {this.brand} \n" +
			$"pH: {this.pH} \n" +
			$"Descrizione: {this.GetDescription()} \n" +
			$"Codice: {this.code} \n" +
			$"Prezzo: {this.GetPrice()} \n" +
			$"Categoria: \n";

			return infoProduct;
		}
	}
}