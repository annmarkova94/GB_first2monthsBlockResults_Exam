/* Напишите программу, которая из имеющегося массива строк формирует массив из строк, длина которых <= 3 символам
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами */


namespace GB_BlockResults_Exam
{
    class Program
    {
        public static void Main()
        {
            TextColorDarkGreen();

            Console.Write("Введите набор слов, разделенных пробелами: ");
            string userWords = Console.ReadLine();
            string[] userWordsArray = userWords.Split(' ');
            string[] userWordsArray3LessChars = GetItemsOf3AndLessChars(userWordsArray);

            Console.WriteLine("Первоначальный массив:");
            Array.ForEach(userWordsArray, element => Console.Write($"{element} "));

            Console.WriteLine($"\n\nНовый массив со элементами, содержащими <= 3 символа: ");
            Array.ForEach(userWordsArray3LessChars, element => Console.Write($"{element} "));

            Console.ResetColor();
        }

        public static string[] GetItemsOf3AndLessChars(string[] initialArray)
        {
            string[] resultArray = new string[0];
            for (int i = 0; i < initialArray.Length; i++)
            {
                if (initialArray[i].Length <= 3)
                {
                    Array.Resize(ref resultArray, resultArray.Length + 1);
                    resultArray[resultArray.Length - 1] = initialArray[i];
                }
            }
            return resultArray;
        }
        public static void TextColorDarkGreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
    }
}