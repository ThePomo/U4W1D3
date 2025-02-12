using System;

class ContoCorrente
{
    private string titolare;
    private string numeroConto;
    private double saldo;
    private bool aperto;

   
    public ContoCorrente(string titolare, string numeroConto)
    {
        this.titolare = titolare;
        this.numeroConto = numeroConto;
        this.saldo = 0;
        this.aperto = false;
    }

    
    public void ApriConto(double depositoIniziale)
    {
        if (aperto)
        {
            Console.WriteLine("Il conto è già stato aperto.");
            return;
        }

        if (depositoIniziale < 1000)
        {
            Console.WriteLine("Errore: Il deposito iniziale deve essere almeno di 1000 euro.");
            return;
        }

        saldo = depositoIniziale;
        aperto = true;
        Console.WriteLine($"Conto aperto con successo! Saldo iniziale: {saldo} euro");
    }

   
    public void Versa(double importo)
    {
        if (!aperto)
        {
            Console.WriteLine("Errore: Il conto non è ancora stato aperto.");
            return;
        }

        if (importo <= 0)
        {
            Console.WriteLine("Errore: L'importo del versamento deve essere positivo.");
            return;
        }

        saldo += importo;
        Console.WriteLine($"Versamento di {importo} euro effettuato con successo. Saldo attuale: {saldo} euro.");
    }

   
    public void Preleva(double importo)
    {
        if (!aperto)
        {
            Console.WriteLine("Errore: Il conto non è ancora stato aperto.");
            return;
        }

        if (importo <= 0)
        {
            Console.WriteLine("Errore: L'importo del prelievo deve essere positivo.");
            return;
        }

        if (importo > saldo)
        {
            Console.WriteLine("Errore: Saldo insufficiente.");
            return;
        }

        saldo -= importo;
        Console.WriteLine($"Prelievo di {importo} euro effettuato con successo. Saldo attuale: {saldo} euro.");
    }

    
    public void MostraSaldo()
    {
        Console.WriteLine($"Saldo attuale: {saldo} euro.");
    }
}