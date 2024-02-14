namespace gbtest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputArray = { "aboba", "cat", "dog", "2", "ninja", "fox" };

            string[] filteredArray = StringFilter.FilterStrings(inputArray);
            Console.WriteLine("Массив из строк, длина которых меньше или равна 3 символам:");
            foreach (string str in filteredArray)
            {
                Console.WriteLine(str);
            }
        }
    }
}
