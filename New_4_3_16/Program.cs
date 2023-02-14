namespace New_4_3_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = { { -5, 6, 9, 1, 2, -3 }, { -8, 8, 1, 1, 2, -3 } };
            int quantity = 0;
            // С использованием цикла for
            for (int i = 0; i <= arr.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arr.GetUpperBound(1); j++)
                {
                    if (arr[i,j] > 0)
                    {
                        quantity++;
                    }
                }
            }
            Console.Write("Количество положительных чисел в массиве(for): " + quantity);

            // С использованием цикла foreach

            int quan = 0;
            foreach (var item in arr)
            {
                if (item < 0)
                    quan++;
            }
            Console.Write("\nКоличество отрицательных чисел в массиве(foreach): " + quan);
            Console.ReadKey();
        }
    }
}