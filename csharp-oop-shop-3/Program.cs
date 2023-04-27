using csharp_shop_3;
​
using System.Diagnostics.Metrics;

Console.OutputEncoding = System.Text.Encoding.Unicode;
/*
Shop Eurospin = new Shop("Eurospin", "Roma", "Via Paolo", "42");
Water AcquaSantAnna = new Water("Acqua", "Frizzante", 2f, "Alimentari", "Sant'Anna", 2.5f, 2f, 7f, "Vinadio");
Eurospin.AddNewProductToShopList(AcquaSantAnna);
​
SellingBag Busta1 = new SellingBag("Busta", "Plastica", 0.2f, "Contenitori", "Plastica", 5);
Fruit Limone = new Fruit("Limone", "Limone grande", 0.5f, "Alimentari", "Sicilia", "Agrume");
Busta1.AddFruitInBag(Limone);
Eurospin.AddNewProductToShopList(Busta1);
​
Fruit Mela = new Fruit("Mela", "Mela rosso", 0.2f, "mela", "Roma", "frutta");
​
Console.WriteLine(Mela.ToString("newline"));
Busta1.AddFruitInBag(Mela);
​
Console.WriteLine(Eurospin.ToString());
​
​
float numero = 0f;
*/
​
Console.WriteLine("I prodotti attualmente generati sono: " + Product.GetTotalGeneratedProducts());
​
Product LavatriceSamsung = new Product("Lavatrice Samsung SE4000", "Lavatrice ultra performante in classe A", 999.99f, "elettrodomestico");
Water AcquaSantAnna = new Water("Acqua", "Frizzante", 2f, "Alimentari", "Sant'Anna", 2.5f, 2f, 7f, "Vinadio");
Fruit Limone = new Fruit("Limone", "Limone grande", 0.5f, "Alimentari", "Sicilia", "Agrume");
Fruit Mela1 = new Fruit("Mela verde", "Mela rosso", 0.2f, "mela", "Roma", "frutta");
Fruit Mela2 = new Fruit("Mela gialla", "Mela gialla", 0.2f, "mela", "Roma", "frutta");
​
​
Fruit MelaSacchetto1 = new Fruit("Mela verde", "Mela verde", 0.2f, "mela", "Roma", "frutta");
Fruit MelaSacchetto2 = new Fruit("Mela verde", "Mela verde", 0.2f, "mela", "Roma", "frutta");
BagOfFruits sacchettoDiMele = new BagOfFruits("Il mio sacchetto di frutta", "Contiente 2 mele verdi", 0.02f, "frutta", "biodegradibile", 8);
​
Console.WriteLine("I prodotti attualmente generati sono: " + Product.GetTotalGeneratedProducts());
​
sacchettoDiMele.AddListOfFruitInbag(new List<Fruit> { MelaSacchetto1, MelaSacchetto2 });
​
Console.WriteLine(LavatriceSamsung.GetDescription());
Console.WriteLine(LavatriceSamsung.ToString());
​
Console.WriteLine(AcquaSantAnna.GetLitersInBottle());
AcquaSantAnna.Drink(0.5f);
Console.WriteLine(AcquaSantAnna.GetLitersInBottle());
Console.WriteLine(AcquaSantAnna.GetDescription());
Console.WriteLine(AcquaSantAnna.ToString());
​
Console.WriteLine(Limone.GetOrigin());

Console.WriteLine(sacchettoDiMele.ToString());​

/*
List<Product> mieiProdottiInCasa = new List<Product> { LavatriceSamsung, AcquaSantAnna, Limone, Mela1, Mela2, sacchettoDiMele };
​
Console.WriteLine("--- HO CREATO LA LISTA DI PRODOTTI IN CASA E ORA TE LA STAMPO: -----");
foreach(Product prodottoScansionato in mieiProdottiInCasa)
{
	Console.WriteLine("------- PRODOTTO ---------");
	Console.WriteLine(prodottoScansionato.ToString());
	Console.WriteLine("---------------------------");
	Console.WriteLine();
​
	prodottoScansionato.Drink()
}
*/

PhisicalShopCart mioCarrelloDellaSpesa = new PhisicalShopCart(20);
mioCarrelloDellaSpesa.AddProduct(sacchettoDiMele);
mioCarrelloDellaSpesa.AddProduct(Limone);
mioCarrelloDellaSpesa.AddProduct(AcquaSantAnna);
​
Console.WriteLine("STAMPIAMO IL CARRELLO");
Console.WriteLine(mioCarrelloDellaSpesa.ToString());​