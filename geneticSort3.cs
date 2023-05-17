using Interface1;
using System.Diagnostics;

namespace Interface1.classes
{
    class geneticSort3 : Isort
    {
        public void Sort(int[] x)
        {
            int populationSize = 100;
            int numberOfGenerations = 1;
            int[] sortedArray = GeneticSort(x, populationSize, numberOfGenerations);
            Console.WriteLine($"\nSorted array: [ {string.Join(", ", sortedArray)} ]");
        }
        static int[] GeneticSort(int[] inputArray, int populationSize, int numberOfGenerations)
        {
            int FitnessFunction(int[] chromosome)
            {
                int difference = 0;
                for (int i = 0; i < chromosome.Length - 1; i++)
                {
                    difference += Math.Abs(chromosome[i] - chromosome[i + 1]);
                }
                return difference;
            }
            Random random = new Random();

            List<int[]> population = new List<int[]>();
            for (int i = 0; i < populationSize; i++)
            {
                int[] chromosome = inputArray.OrderBy(x => random.Next()).ToArray();
                population.Add(chromosome);
            }

            for (int i = 0; i < numberOfGenerations; i++)
            {
                population = population.OrderBy(x => FitnessFunction(x)).ToList();
                int[] bestChromosome = population.First();
                List<int[]> newPopulation = new List<int[]>();
                for (int j = 0; j < populationSize; j++)
                {
                    int[] parent1 = population[random.Next(population.Count)];
                    int[] parent2 = population[random.Next(population.Count)];

                    int[] child = new int[inputArray.Length];
                    for (int k = 0; k < inputArray.Length; k++)
                    {
                        child[k] = random.NextDouble() < 0.5 ? parent1[k] : parent2[k];
                    }

                    newPopulation.Add(child);
                }
                population = newPopulation;
                population[0] = bestChromosome;
            }
            return population.First().OrderBy(x => x).ToArray();

        }
    }
}

