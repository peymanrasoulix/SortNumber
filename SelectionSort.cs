namespace Interface1.classes
{
    class SelectionSort : Isort
    {
        int n, minIndex;
        public void Sort(int[] x)
        {
            n = x.Length;
            for (int i = 0; i < n; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (x[j] < x[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = x[minIndex];
                x[minIndex] = x[i];
                x[i] = temp;

                Console.Write(temp + " ");
            }
        }
    }
}


