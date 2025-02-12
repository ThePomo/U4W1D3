

#region Esercizio1
ContoCorrente conto = new ContoCorrente("Giuseppe Pomo", "IT123456789");
conto.ApriConto(1200);
conto.Versa(500);
conto.Preleva(300);
conto.MostraSaldo();
#endregion

#region Esercizio2
Console.WriteLine("scrivi i nomi che vuoi inserire nella lista");
string nomi = Console.ReadLine();
string[] arr = nomi.Split(' ');
Console.WriteLine("Che nome vuoi cercare?");
string nome = Console.ReadLine();
if (arr.Contains(nome))
{
    Console.WriteLine("Nome presente nella lista.");
}
else
{
    Console.WriteLine("il nome che cerchi non è presente nella lista.");
}
#endregion

#region Esercizio3
Console.Write("Inserisci la dimensione dell'array: ");
int dimensione;


while (!int.TryParse(Console.ReadLine(), out dimensione) || dimensione <= 0)
{
    Console.WriteLine("Errore: Inserisci un numero intero positivo.");
    Console.Write("Inserisci la dimensione dell'array: ");
}

int[] numeri = new int[dimensione];

for (int i = 0; i < dimensione; i++)
{
    Console.Write($"Inserisci il numero {i + 1}: ");
    while (!int.TryParse(Console.ReadLine(), out numeri[i]))
    {
        Console.WriteLine("Errore: Inserisci un numero intero valido.");
        Console.Write($"Inserisci il numero {i + 1}: ");
    }
}


int somma = numeri.Sum();


double media = (double)somma / dimensione;


Console.WriteLine($"La somma di tutti i numeri è: {somma}");
Console.WriteLine($"La media aritmetica è: {media:F2}");

#endregion