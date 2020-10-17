using System;

namespace CreditoResiduo
{
    class Program
    {
        static void Main(string[] args)
        {
            double credito, spesa, contspesa = 0, spesadafare;
            Console.WriteLine("inserisci il tuo saldo iniziale);
            credito = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("inserisci il numero di spese che vuoi effettuare");
            spesadafare = Convert.ToDouble(Console.ReadLine());
            while (contspesa < spesadafare) ;
            {
                Console.WriteLine("inserisci l'importo della spesa");
                spesa = Convert.ToDouble(Console.ReadLine());
                if (spesa > credito) ;
                {
                    Console.WriteLine("LA TUA SPESA E' MAGGIORE DEL CREDITO TOTALE");
                    break;
                }
                else
                {
                    credito = credito - spesa;
                    Console.WriteLine($"il credito rimasto dopo la tua spesa è {credito}");
                }
                contspesa++;
            }
            Console.WriteLine($"hai eseguito {contspesa} spese, e il credito finale è {credito}");
            
        }
    }
}
