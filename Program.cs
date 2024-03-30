
namespace hw3{
    public static class Program
    {
        public static void Main(string[] args)
        {

          int length = 3;
          int[] array1 = new int[length];
          int rows = 4;
          int columns = 6;  
          int[,] array2 = new int[rows, columns];
          int cols = 5;
          int row = 3;
          int[][] array3 = new int[row][];
          for (int i = 0; i < row; i++)
        {
            array3[i] = new int[cols];
        }
           
            IArray[] arr  = new IArray[3]; 
     
    Console.WriteLine("Введите false, если хотите рандомный ввод или введите true"); 
 
 
    bool obj = bool.Parse(Console.ReadLine()); 
     
        IPrint[] printer = new IPrint[4];
        IGenerator<string> stringGenerator = new StringGenerator();
        IGenerator<bool> boolGenerator = new BoolGenerator();
        IGenerator<int> intGenerator = new IntGenerator();
        IGenerator<double> doubleGenerator = new DoubleGenerator();
        printer[0] = new OneDimensionalArray<int>(intGenerator,  length, obj);
        printer[1] = new TwoDimensionalArray<bool>(boolGenerator,  rows,  columns,  obj);
        printer[2] = new JuggedArray<double>(doubleGenerator,  array,  row, cols, obj);
        printer[3] = new TwoDimensionalArray<string>(stringGenerator,  rows,  columns,  obj);
        Console.WriteLine();
        for (int i =0; i < printer.Length; i++)
        {
            printer[i].Print();
        }
    
 
   }
 }
}