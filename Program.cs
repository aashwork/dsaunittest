namespace DSAUnitTestExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class ArrayUtils
    {
        public static int ArraySum(int[] arr)
        {
            int sum = 0;
            foreach (int num in arr)
                sum += num;
            return sum;
        }
    }
}