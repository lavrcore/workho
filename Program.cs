//using System;

//class Program
//{
//    static void Main()
//    {
//        // Задание 1
//        double[] A = new double[5];
//        double[,] B = new double[3, 4];
//        Random rand = new Random();

//        // Заполнение массива A
//        Console.WriteLine("Введите 5 элементов массива A:");
//        for (int i = 0; i < A.Length; i++)
//        {
//            A[i] = Convert.ToDouble(Console.ReadLine());
//        }

//        // Заполнение массива B случайными числами
//        for (int i = 0; i < B.GetLength(0); i++)
//        {
//            for (int j = 0; j < B.GetLength(1); j++)
//            {
//                B[i, j] = rand.NextDouble() * 100; // случайные дробные числа
//            }
//        }

//        // Вывод массивов
//        Console.WriteLine("Массив A:");
//        foreach (var item in A)
//        {
//            Console.Write(item + " ");
//        }

//        Console.WriteLine("\nМассив B:");
//        for (int i = 0; i < B.GetLength(0); i++)
//        {
//            for (int j = 0; j < B.GetLength(1); j++)
//            {
//                Console.Write(B[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }

//        // Общие статистики
//        double maxA = A[0], minA = A[0], sumA = A[0], Anum = A[0];
//        double maxB = B[0, 0], minB = B[0, 0], sumB = B[0, 0], Bnum = B[0, 0];

//        // Метрики для массива A
//        for (int i = 1; i < A.Length; i++)
//        {
//            sumA += A[i];
//            Anum *= A[i];
//            if (A[i] > maxA) maxA = A[i];
//            if (A[i] < minA) minA = A[i];
//        }

//        // Метрики для массива B
//        for (int i = 0; i < B.GetLength(0); i++)
//        {
//            for (int j = 0; j < B.GetLength(1); j++)
//            {
//                sumB += B[i, j];
//                Bnum *= B[i, j];
//                if (B[i, j] > maxB) maxB = B[i, j];
//                if (B[i, j] < minB) minB = B[i, j];
//            }
//        }

//        // Итоговая статистика
//        double max = Math.Max(maxA, maxB);
//        double min = Math.Min(minA, minB);
//        double totalSum = sumA + sumB;
//        double totalProduct = Anum * Bnum;

//        // Сумма четных элементов массива A
//        double evenSumA = 0;
//        foreach (var item in A)
//        {
//            if (item % 2 == 0) evenSumA += item;
//        }

//        // Сумма нечетных столбцов массива B
//        double oddColumnsSumB = 0;
//        for (int j = 1; j < B.GetLength(1); j += 2)
//        {
//            for (int i = 0; i < B.GetLength(0); i++)
//            {
//                oddColumnsSumB += B[i, j];
//            }
//        }

//        // Вывод результата
//        Console.WriteLine($"Общий максимальный элемент: {max}");
//        Console.WriteLine($"Общий минимальный элемент: {min}");
//        Console.WriteLine($"Общая сумма всех элементов: {totalSum}");
//        Console.WriteLine($"Общее произведение всех элементов: {totalProduct}");
//        Console.WriteLine($"Сумма четных элементов массива A: {evenSumA}");
//        Console.WriteLine($"Сумма нечетных столбцов массива B: {oddColumnsSumB}");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Задание 2
//        Random rand = new Random();
//        int[,] matrix = new int[5, 5];
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                matrix[i, j] = rand.Next(-100, 101);
//            }
//        }
//        Console.WriteLine("Матрица:");
//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }

//        // Поиск минимума и максимума
//        int minValue = matrix[0, 0], maxValue = matrix[0, 0];
//        int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;

//        for (int i = 0; i < 5; i++)
//        {
//            for (int j = 0; j < 5; j++)
//            {
//                if (matrix[i, j] < minValue)
//                {
//                    minValue = matrix[i, j];
//                    minRow = i;
//                    minCol = j;
//                }
//                if (matrix[i, j] > maxValue)
//                {
//                    maxValue = matrix[i, j];
//                    maxRow = i;
//                    maxCol = j;
//                }
//            }
//        }

//        // Сумма между элементами
//        int sum = 0;
//        int startX = Math.Min(minRow, maxRow);
//        int endX = Math.Max(minRow, maxRow);
//        int startY = Math.Min(minCol, maxCol);
//        int endY = Math.Max(minCol, maxCol);

//        for (int i = startX; i <= endX; i++)
//        {
//            for (int j = startY; j <= endY; j++)
//            {
//                sum += matrix[i, j];
//            }
//        }

//        // Вывод результата
//        Console.WriteLine($"Сумма элементов между минимальным ({minValue}) и максимальным ({maxValue}) элементами: {sum}");
//    }
//}


// задание 3 не получилось

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Задание 4
//        Console.WriteLine("Введите размер матрицы A (строк и столбцов):");
//        int rows = int.Parse(Console.ReadLine());
//        int cols = int.Parse(Console.ReadLine());

//        int[,] matrixA = new int[rows, cols];
//        int[,] matrixB = new int[rows, cols];
//        Random rand = new Random();

//        // Заполнение матриц случайными числами
//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                matrixA[i, j] = rand.Next(1, 10);
//                matrixB[i, j] = rand.Next(1, 10);
//            }
//        }

//        Console.WriteLine("Матрица A:");
//        PrintMatrix(matrixA);

//        Console.WriteLine("Матрица B:");
//        PrintMatrix(matrixB);

//        // Сложение матриц
//        Console.WriteLine("Сумма матриц:");
//        PrintMatrix(AddMatrices(matrixA, matrixB));

//        // Умножение матрицы на число
//        Console.WriteLine("Умножение матрицы A на число 2:");
//        PrintMatrix(MultiplyMatrixByNumber(matrixA, 2));

//        // Произведение матриц
//        Console.WriteLine("Произведение матриц:");
//        PrintMatrix(MultiplyMatrices(matrixA, matrixB));
//    }

//    static void PrintMatrix(int[,] matrix)
//    {
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write(matrix[i, j] + "\t");
//            }
//            Console.WriteLine();
//        }
//    }

//    static int[,] AddMatrices(int[,] A, int[,] B)
//    {
//        int rows = A.GetLength(0);
//        int cols = A.GetLength(1);
//        int[,] result = new int[rows, cols];

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                result[i, j] = A[i, j] + B[i, j];
//            }
//        }
//        return result;
//    }

//    static int[,] MultiplyMatrixByNumber(int[,] matrix, int number)
//    {
//        int rows = matrix.GetLength(0);

//        int cols = matrix.GetLength(1);
//        int[,] result = new int[rows, cols];

//        for (int i = 0; i < rows; i++)
//        {
//            for (int j = 0; j < cols; j++)
//            {
//                result[i, j] = matrix[i, j] * number;
//            }
//        }
//        return result;
//    }

//    static int[,] MultiplyMatrices(int[,] A, int[,] B)
//    {
//        int rowsA = A.GetLength(0);
//        int colsA = A.GetLength(1);
//        int rowsB = B.GetLength(0);
//        int colsB = B.GetLength(1);
//        int[,] result = new int[rowsA, colsB];

//        if (colsA != rowsB)
//        {
//            throw new ArgumentException("Невозможно перемножить матрицы: количество столбцов первой матрицы должно быть равно количеству строк второй матрицы.");
//        }

//        for (int i = 0; i < rowsA; i++)
//        {
//            for (int j = 0; j < colsB; j++)
//            {
//                result[i, j] = 0;
//                for (int k = 0; k < colsA; k++)
//                {
//                    result[i, j] += A[i, k] * B[k, j];
//                }
//            }
//        }
//        return result;
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Задание 5
//        Console.WriteLine("Введите арифметическое выражение (только + и -):");
//        string input = Console.ReadLine();

//        int result = EvaluateExpression(input);
//        Console.WriteLine($"Результат: {result}");
//    }

//    static int EvaluateExpression(string expression)
//    {
//        string[] tokens = expression.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//        int sum = 0;
//        int current = 0;

//        foreach (string token in tokens)
//        {
//            if (int.TryParse(token, out current))
//            {
//                sum += current;
//            }
//            else
//            {
//                if (token == "-")
//                {
//                    sum -= current;
//                }
//            }
//        }
//        return sum;
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Задание 6
//        Console.WriteLine("Введите текст:");
//        string input = Console.ReadLine();

//        string output = ChangeFirstLetterToUppercase(input);
//        Console.WriteLine(output);
//    }

//    static string ChangeFirstLetterToUppercase(string text)
//    {
//        string[] sentences = text.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
//        for (int i = 0; i < sentences.Length; i++)
//        {
//            sentences[i] = sentences[i].Trim();
//            if (sentences[i].Length > 0)
//            {
//                sentences[i] = char.ToUpper(sentences[i][0]) + sentences[i].Substring(1);
//            }
//        }
//        return string.Join(". ", sentences);
//    }
//}

using System;

class Program
{
    static void Main()
    {
        // Задание 7
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        string censoredText = CensorBadWords(input, new[] { "die" });
        Console.WriteLine($"Результат: {censoredText}");
    }

    static string CensorBadWords(string text, string[] badWords)
    {
        foreach (var word in badWords)
        {
            text = text.Replace(word, new string('*', word.Length));
        }
        return text;
    }
}