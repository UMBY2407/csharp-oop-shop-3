using csharp_oop_shop_3;
using csharp_shop_3;

using System.Diagnostics.Metrics;

try
{
	Console.OutputEncoding = System.Text.Encoding.Unicode;

	Product LavatriceSamsung = new Product("Lavatrice Samsung SE4000", "Lavatrice ultra performante in classe A", 999.99f, "elettrodomestico");
	Water AcquaSantAnna = new Water("Acqua", "Frizzante", 2f, "Alimentari", "Sant'Anna", 2.5f, 2f, 7f, "Vinadio");
	Fruit Limone = new Fruit("Limone", "Limone grande", 0.5f, "Alimentari", "Sicilia", "Agrume");
	Fruit Mela1 = new Fruit("Mela verde", "Mela rosso", 0.2f, "mela", "Roma", "frutta");
	Fruit Mela2 = new Fruit("Mela gialla", "Mela gialla", 0.2f, "mela", "Roma", "frutta");


	Fruit MelaSacchetto1 = new Fruit("Mela verde", "Mela verde", 0.2f, "mela", "Roma", "frutta");
	Fruit MelaSacchetto2 = new Fruit("Mela verde", "Mela verde", 0.2f, "mela", "Roma", "frutta");
	BagOfFruits sacchettoDiMele = new BagOfFruits("Il mio sacchetto di frutta", "Contiente 2 mele verdi", 0.02f, "frutta", "biodegradibile", 8);
	sacchettoDiMele.AddListOfFruitInbag(new List<Fruit> { MelaSacchetto1, MelaSacchetto2 });

	Console.WriteLine("I prodotti attualmente generati sono: " + Product.GetTotalGeneratedProducts());

	Convertitore.convertiInGalloni(3.5);

	try
	{
		AcquaSantAnna.Drink(0.5f);
	}
	catch (Exception e)
	{
		Console.WriteLine("Si è generato un problema mentre si beveva la bottiglia:");
		Console.WriteLine(e.Message);
	}

	try
	{
		AcquaSantAnna.Fill(0.7f);
	}
	catch (Exception e)
	{
		Console.WriteLine("Si è generato un problema mentre si riempiva la bottiglia:");
		Console.WriteLine(e.Message);
	}

	PhisicalShopCart mioCarrelloDellaSpesa1 = new PhisicalShopCart(20);
	mioCarrelloDellaSpesa1.AddProduct(sacchettoDiMele);
	mioCarrelloDellaSpesa1.AddProduct(Limone);
	mioCarrelloDellaSpesa1.AddProduct(AcquaSantAnna);

	PhisicalShopCart mioCarrelloDellaSpesa2 = new PhisicalShopCart(20);
	mioCarrelloDellaSpesa1.AddProduct(sacchettoDiMele);
	mioCarrelloDellaSpesa1.AddProduct(AcquaSantAnna);

	List<PhisicalShopCart> carrelliSpesaCreati = new List<PhisicalShopCart>();
	carrelliSpesaCreati.Add(mioCarrelloDellaSpesa1);
	carrelliSpesaCreati.Add(mioCarrelloDellaSpesa2);
	Console.WriteLine("I Carrelli della spesa attualmente generati sono: " + PhisicalShopCart.GetTotalGeneratedCarts());

}catch(Exception e)
{
	Console.WriteLine("Qualcosa è andato storto...");
	Console.WriteLine(e.Message);
}