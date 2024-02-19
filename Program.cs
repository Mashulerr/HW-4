
namespace hw3{
    public static class Program
    {
        public static void Main(string[] args)
        {
            OneDimensionalArray arr1 = new OneDimensionalArray (new int[] { 5, 12, 13, 16 });
            arr1.Print();
            Console.WriteLine("Среднее значение в одномерном массиве: " + arr1.Average());

            TwoDimensionalArray arr2 = new TwoDimensionalArray(new int[,] { { 5, 12, 13, 16 }, { 5, 12, 13, 16} });
            arr2.Print();
            Console.WriteLine("Среднее значение в двумерном массиве: " + arr2.Average());

            JuggedArray arr3 = new JuggedArray(new int[][] {new int[] { 15, 19 }, new int[] { 17, 18 }, new int[] { 18, 19, 35, 34 }});
            arr3.Print();
            Console.WriteLine("Среднее значение в зубчатом массиве: " + arr3.Average());

            WeekArray daysOfWeek = new WeekArray();
            daysOfWeek.Print();

    
        }
    }
}