namespace ExtensionMethod
{
    internal static class Extended
    {
        public static int SquareOfNumber(this int number)
        {
            int result = number * number;
            return result;
        }
        public static int ListIndexerMultiply(this List<int> objInt)
        {
           int result = objInt[0] * objInt[1];
            return result;
        }
    }
}
