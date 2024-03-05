
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
     
    arr[0] = new OneDimensionalArray( array1, length, obj );      
    arr[1] = new TwoDimensionalArray(array2, rows, columns, obj); 
    arr[2]= new JuggedArray(array3, row, cols, obj); 
   
 
    for (int i = 0; i < arr.Length; i++) { 
      arr[i].Print(); 
      arr[i].Average(); 
    } 
 
   }
 }
}