using csharp_shop_3;

using System.Diagnostics.Metrics;

Console.OutputEncoding = System.Text.Encoding.Unicode;

Product LavatriceSamsung = new Product("Lavatrice Samsung SE4000", "Lavatrice ultra performante in classe A", 999.99f, "elettrodomestico");
Water AcquaSantAnna = new Water("Acqua", "Frizzante", 2f, "Alimentari", "Sant'Anna", 2.5f, 2f, 7f, "Vinadio");
Fruit Limone = new Fruit("Limone", "Limone grande", 0.5f, "Alimentari", "Sicilia", "Agrume");
Fruit Mela1 = new Fruit("Mela verde", "Mela rosso", 0.2f, "mela", "Roma", "frutta");
Fruit Mela2 = new Fruit("Mela gialla", "Mela gialla", 0.2f, "mela", "Roma", "frutta");


Fruit MelaSacchetto1 = new Fruit("Mela verde", "Mela verde", 0.2f, "mela", "Roma", "frutta");
Fruit MelaSacchetto2 = new Fruit("Mela verde", "Mela verde", 0.2f, "mela", "Roma", "frutta");
BagOfFruits sacchettoDiMele = new BagOfFruits("Il mio sacchetto di frutta", "Contiente 2 mele verdi", 0.02f, "frutta", "biodegradibile", 8);

Console.WriteLine("I prodotti attualmente generati sono: " + Product.GetTotalGeneratedProducts());

sacchettoDiMele.AddListOfFruitInbag(new List<Fruit> { MelaSacchetto1, MelaSacchetto2 });
try
{
	AcquaSantAnna.Drink(3.5f);
}catch (Exception e)
{
	Console.WriteLine("Si è generato un problema durante il metodo Drink:");
	Console.WriteLine(e.Message);
}

PhisicalShopCart mioCarrelloDellaSpesa = new PhisicalShopCart(20);
mioCarrelloDellaSpesa.AddProduct(sacchettoDiMele);
mioCarrelloDellaSpesa.AddProduct(Limone);
mioCarrelloDellaSpesa.AddProduct(AcquaSantAnna);

List<PhisicalShopCart> carrelliSpesaCreati = new List<PhisicalShopCart>();
carrelliSpesaCreati.Add(mioCarrelloDellaSpesa);
Console.WriteLine("I Carrelli della spesa attualmente generati sono: " + PhisicalShopCart.GetTotalGeneratedCarts());

/*
	foreach (PhisicalShopCart CarrelloScansionato in carrelliSpesaCreati)
	{
		Console.WriteLine(CarrelloScansionato);
	}
*/

/*	
	Console.WriteLine("STAMPIAMO IL CARRELLO");
	Console.WriteLine(mioCarrelloDellaSpesa.ToString());
*/