using System;

namespace ProjektNr2_Kruhlov48720
{
    class dk_Sortowanie
    {
        public static int dk_Licznik = 0;

        /*=====================================================================================================*/
        // Implementujemy Radix Sort

        public int dk_getMax(int[] dk_arr, int dk_n)
        {
            int dk_max = dk_arr[0];
            for (int dk_i = 1; dk_i < dk_n; dk_i++)
                if (dk_arr[dk_i] > dk_max)
                    dk_max = dk_arr[dk_i];
            return dk_max;
        }
        // Funkcja obliczająca sortowanie arr [] według cyfry reprezentowanej przez exp.
        public void dk_countSort(int[] dk_arr, int dk_n, int dk_exp)
        {
            int[] dk_output = new int[dk_n]; // Tablica wyjściowa
            int dk_i;
            int[] dk_count = new int[10];

            // Inicjalizacja wszystkich elementów count do 0
            for (dk_i = 0; dk_i < 10; dk_i++)
            {
                dk_count[dk_i] = 0;
            }

            // Przechowujemy liczbę wystąpień w count []
            for (dk_i = 0; dk_i < dk_n; dk_i++)
                dk_count[(dk_arr[dk_i] / dk_exp) % 10]++;

            // Zmieniamy count[i] tak, aby count[i] zawierał teraz rzeczywistą pozycję tej cyfry na output[]
            for (dk_i = 1; dk_i < 10; dk_i++)
                dk_count[dk_i] += dk_count[dk_i - 1];

            // Zbuduj tablicę wyjściową
            for (dk_i = dk_n - 1; dk_i >= 0; dk_i--)
            {
                dk_output[dk_count[(dk_arr[dk_i] / dk_exp) % 10] - 1] = dk_arr[dk_i];
                dk_count[(dk_arr[dk_i] / dk_exp) % 10]--;
            }

            // Kopiujemy tablicę wyjściową do arr[], aby arr[] zawierał teraz posortowane liczby zgodnie z bieżącą cyfrą
            for (dk_i = 0; dk_i < dk_n; dk_i++)
            {
                dk_arr[dk_i] = dk_output[dk_i];
            }

        }

        // Główna funkcja sortuje arr[] o rozmiarze n przy użyciu
        public int dk_RadixSort(ref int[] dk_arr, int dk_n, int dk_l)
        {

            // Znajdziemy maksymalną liczbę, aby poznać liczbę cyfr
            int dk_m = dk_getMax(dk_arr, dk_n);

            // Sortujemy licząc dla każdej cyfry
            for (int dk_exp = 1; dk_m / dk_exp > 0; dk_exp *= 100)
            {
                dk_Licznik++;
                dk_countSort(dk_arr, dk_n, dk_exp);
            }
            return dk_Licznik;
        }


        /*=====================================================================================================*/
        // Implementujemy Library Sort

        static int GetNextGap(int gap)
        {
            gap = (gap * 10) / 13;
            if (gap < 1)
            {
                return 1;
            }
            return gap;
        }

        public int dk_LibrarySort(ref int[] array, int l)
        {
            // Ustawiamy licznik operacji dominujących na zero
            dk_Licznik = 0;

            int gap = array.Length;

            // Inicjalizujemy tego boola jako prawdziwe, aby wejść do pętli while
            bool swapped = true;

            while (gap != 1 || swapped == true)
            {
                gap = GetNextGap(gap);

                // Ustawiamy swapped na false, zamieni się na true jak dwie wartości się zamienią (swap)
                swapped = false;

                // Porównuje elementy
                for (int i = 0; i < l - gap; i++)
                {
                    dk_Licznik++;

                    if (array[i] > array[i + gap])
                    {
                        //Swap-ujemy
                        int temp = array[i];
                        array[i] = array[i + gap];
                        array[i + gap] = temp;

                        swapped = true;
                    }
                }
            }
            return dk_Licznik;
        }
    }

}
