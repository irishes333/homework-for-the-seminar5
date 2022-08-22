// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите количество элементов в массиве:");

            Random rnd = new Random();
            int j = 0;

            bool numberCheck = int.TryParse(Console.ReadLine(),out int j_size);
            if (numberCheck)
            {
                int[] j_array = new int[j_size];
                for (int i = 0; i < j_size; i++)
                {
                    j_array[i] = rnd.Next(100, 999);
                    if (j_array[i] % 2 == 0) j++;
                }
                Console.WriteLine("[" + String.Join(", ", j_array) + "] -> " + j);

            }
            else Console.WriteLine("не число");
