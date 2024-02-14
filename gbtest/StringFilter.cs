namespace gbtest
{
    internal class StringFilter
    {
        public static string[] FilterStrings(string[] array)
        {
            string[] result = new string[array.Length];
            int count = 0;
            foreach (string str in array)
            {
                if (str.Length <= 3)
                {
                    result[count] = str;
                    count++;
                }
            }
            Array.Resize(ref result, count);
            return result;
        }
    }
}
