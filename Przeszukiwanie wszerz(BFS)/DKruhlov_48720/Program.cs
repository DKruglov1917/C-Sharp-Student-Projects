using System;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;

namespace DKruhlov_48720
{
    class Program
    {
        static void Main(string[] args)
        {
            Process dkprocess = Process.GetCurrentProcess();
            long dkmemoryAmount = dkprocess.WorkingSet64;
            Stopwatch dkstopWatch = new Stopwatch();            
            Random dkrand = new Random();
            Queue<int> dkq = new Queue<int>();    //Kolejka, która przechowuje numery wierzchołków
            string dkexit = "";
            int dku;
            do
            {
                Console.WriteLine("Ustawić rozmiar tablicy samodzielnie? (y/n) ");
                if (Console.ReadLine() == "y")
                { 
                    Console.WriteLine("Wprowadź rozmiar:");
                    dku = Convert.ToInt32(Console.ReadLine()) - 1;
                    dkstopWatch.Start();
                    if (dku < 3)
                    {
                        Console.WriteLine("Wprowadziłeś nieprawidłowy rozmiar tabeli. Program automatycznie zastąpił rozmiar");
                        dku = dkrand.Next(3, 5);
                    }
                }
                else
                    dku = dkrand.Next(3, 5);
                dkstopWatch.Start();
                bool[] used = new bool[dku + 1];  //masyw zaznaczający odwiedzane wierzchołki
                int[][] g = new int[dku + 1][];   //tablica zawierająca wpisy sąsiednich wierzchołków

                for (int i = 0; i < dku + 1; i++)
                {
                    g[i] = new int[dku + 1];
                    Console.Write("\n({0}) wierzchołek -->[", i + 1);
                    for (int j = 0; j < dku + 1; j++)
                    {
                        g[i][j] = dkrand.Next(0, 2);
                    }
                    g[i][i] = 0;
                    foreach (var item in g[i])
                    {
                        Console.Write(" {0}", item);
                    }
                    Console.Write("]\n");

                }


                used[dku] = true;     //tablica przechowująca stan wierzchołka(odwiedzaliśmy go lub nie)

                dkq.Enqueue(dku);
                Console.WriteLine("Rozpoczynamy przechodzenie od {0} wierzchołka", dku + 1);
                while (dkq.Count != 0)
                {
                    dku = dkq.Peek();
                    dkq.Dequeue();
                    Console.WriteLine("Przeszliśmy do węzła {0}", dku + 1);

                    for (int i = 0; i < g.Length; i++)
                    {
                        if (Convert.ToBoolean(g[dku][i]))
                        {
                            if (!used[i])
                            {
                                used[i] = true;
                                dkq.Enqueue(i);
                                Console.WriteLine("Dodaliśmy do kolejki węzeł {0}", i + 1);
                            }
                        }
                    }
                }
                dkstopWatch.Stop();
                TimeSpan ts = dkstopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);

                Console.WriteLine("Czas: " + elapsedTime);     
                Console.WriteLine("Ilość pamięci bieżącego procesu (w bajtach): " + dkmemoryAmount);
                Console.WriteLine("Zakończyć program? (y/n)");

                dkexit = Console.ReadLine();
                Console.Clear();
            } while (dkexit != "y");
            Console.ReadKey();
        }
    }
}
