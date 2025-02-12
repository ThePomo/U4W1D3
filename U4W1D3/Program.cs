//esercizio 1

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



#endregion