using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть розмір масиву: ");
        if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
        {
            double[] array = new double[N];
            Random random = new Random();
            double sumOfNegatives = 0;
            double minValue = double.MaxValue;
            int maxIndex = 0;
            double maxAbsoluteValue = 0;
            double sumOfPositiveIndices = 0;
            int integerCount = 0;



            Console.WriteLine("Елементи масиву:");
            for (int i = 0; i < N; i++)
            {
                array[i] = (random.NextDouble() * 20) - 10;
                Console.Write($"{ array[i]}\n");

                if (array[i] < 0)
                {
                    sumOfNegatives += array[i];
                }

                if (array[i] < minValue)
                {
                    minValue = array[i];
                }

               
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }

                if (Math.Abs(array[i]) > maxAbsoluteValue)
                {
                    maxAbsoluteValue = Math.Abs(array[i]);
                }

                
                if (array[i] > 0)
                {
                    sumOfPositiveIndices += i;
                }

                
                if (array[i] % 1 == 0)
                {
                    integerCount++;
                }


            }
            Console.WriteLine($"\nСума від'ємних елементів: {sumOfNegatives}");
            Console.WriteLine($"Мінімальний елемент: {minValue}");
            Console.WriteLine($"Номер (індекс) максимального елемента: {maxIndex}");
            Console.WriteLine($"Максимальний за модулем елемент: {maxAbsoluteValue}");
            Console.WriteLine($"Сума індексів додатних елементів: {sumOfPositiveIndices}");
            Console.WriteLine($"Кількість цілих чисел: {integerCount}");

        }
        else
        {
            Console.WriteLine("Введено некоректне значення для розміру масиву.");
        }
    }
}
