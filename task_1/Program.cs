using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размер квадратной матрицы: ");
            int r = int.Parse(Console.ReadLine());
            int[,] matrix = new int[r, r];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    Console.Write("[{0},{1}] - ", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nКвадратная матрица:");
            Print(matrix);

            int minValue = int.MinValue;
            int maxValue = int.MaxValue;
            int max = 0;
            int min = 0;
            int[] m1 = new int[r];
            int[] m2 = new int[r];
            for (int i = 0; i < r; i++)
            {
                int sum = 0;
                for (int j = 0; j < r; j++)
                {
                    sum += matrix[i, j];
                }
                if (sum > minValue)
                {
                    max = i;
                    minValue = sum;
                    for (int j = 0; j < r; j++)
                    {
                        m1[j] = matrix[i, j];
                    }
                }
                if (sum < maxValue)
                {
                    min = i;
                    maxValue = sum;
                    int j = r;
                    for (j = 0; j < r; j++)
                    {
                        m2[j] = matrix[i, j];
                    }
                }
            }
            Console.WriteLine("\nПроизведение:");
            int[] m3 = new int[r];
            for (int i = 0; i < r; i++)
            {
                m3[i] = m1[i] * m2[i];
                Console.Write(m3[i] + " ");
            }
        }
        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
