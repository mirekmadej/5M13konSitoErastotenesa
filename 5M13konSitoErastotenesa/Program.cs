namespace _5M13konSitoErastotenesa
{
    /*
     * Sito Erastotenesa
     * zadelklaruj tablice 100 elementów typu bool, 
     * w polu o indeksie i będzie T lub F w zależności od 
     * tego czy liczba i jest / nie jest liczbą pierwszą
     * 
     * utrudnienie - tablica ma byc zadeklarowana w main 
     * do wypełniania tablicy musi być napisana funkcja
     */

    internal class Program
    {
        private const int N = 100;
        
        static void Main(string[] args)
        {
            bool[] pierwsze = new bool[N+1];
            wypelnijTablice(pierwsze);
            Console.Write("podaj liczbę: ");
            int n = int.Parse(Console.ReadLine());
            if(n<0 || n>N)
            {
                Console.WriteLine("za duża/mała liczba");
                return;
            }
            if (pierwsze[n])
                Console.WriteLine("to jest liczba pierwsza");
            else
                Console.WriteLine("to nie jest liczba pierwsza");
        }
        private static void wypelnijTablice(bool[] t)
        {
            t[0] = t[1] = false;
            for (int i = 2; i <= N; i++)
                t[i] = true;
            for (int i = 2; i <= N; i++)
            {
                if(t[i])
                    for(int j = i*2;  j <= N; j = j+i)
                        t[j] = false;
            }
        }
             
    }
}
