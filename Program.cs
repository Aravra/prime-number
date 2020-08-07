using System;

namespace priemgetallen
{
    class Program
    {

        static void Main()
        {        int getallen = 2;
                 int checker = 2;
                 int totaal = 0;
            while (getallen < 1001)
            {
                if (getallen % checker == 0)
                {

                    if (getallen == checker)
                    {
                        Console.WriteLine(getallen);
                        totaal += 1;
                        getallen += 1;
                        checker = 2;

                    }
                    else if (getallen == 1000)
                    {
                        Console.WriteLine("Done!");
                        Console.WriteLine("Aantal priemgetallen: " + totaal);
                        getallen += 1;
                        checker = 2;
                    }
                    else
                    {
                        checker = 2;
                        getallen += 1;

                    }

                }
                else
                {
                    checker += 1;
                }

            }
        }

    }
}
