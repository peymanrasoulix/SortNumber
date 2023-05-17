using Interface1;
using System.Diagnostics;

namespace Interface1.classes
{
    class geneticSort2 : Isort
    {
        public void Sort(int[] x)
        {
            int n = x.Length;
            int[] result = new int[n];
            Dictionary<int, bool> dict = new Dictionary<int, bool>();

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (x[j] > x[j + 1])
                    {
                        int temp = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = temp;
                    }
                }

                if (!dict.ContainsKey(x[n - i - 1]))
                {
                    dict.Add(x[n - i - 1], true);
                    result[i] = x[n - i - 1];
                }
            }

            if (!dict.ContainsKey(x[0]))
            {
                result[n - 1] = x[0];
            }

            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
    }
}

