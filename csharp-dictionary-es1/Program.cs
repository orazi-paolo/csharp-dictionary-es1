// dichiaro la variabile dictionary e la inizializzo con un nuovo oggetto Dictionary<string, int>
var dictionary = new Dictionary<string, int>();
// aggiungo elementi al dizionario
dictionary.Add("Mario", 25);
dictionary.Add("Luca", 22);
dictionary.Add("Sara", 24);

// rimuovo un elemento dal dizionario
dictionary.Remove("Luca");

// stampo il contenuto del dizionario aggiornato
Console.WriteLine("Studenti e le loro età:");
foreach (var item in dictionary)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}