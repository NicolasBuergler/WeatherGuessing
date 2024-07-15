namespace WeatherGuessingBackend
{
    public static class Extensions
    {
        public static void Shuffle<T>(this T[] array)
        {
            Random random = new Random();
            int n = array.Length;
            for (int i = n - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}
