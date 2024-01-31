namespace hw3{

    public sealed class TwoDimensionalArray : Array {

         private int[,] _arr2;
        public TwoDimensionalArray(int[,] array){
            _arr2 = array;
        }
        public override double Average(){
             double sum = 0;
        int count = 0;
        for (int i = 0; i < _arr2.GetLength(0); i++)
        {
            for (int j = 0; j < _arr2.GetLength(1); j++)
            {
                sum += _arr2[i, j];
                count++;
            }
        }
        return sum / count;
    }

    public override void PrintArray(){
        Console.WriteLine("Массив:");
        for(int i = 0; i < _arr2.GetLength(0); i++){
            for(int j = 0; j < _arr2.GetLength(1); j++){
                Console.WriteLine(_arr2[i, j] + " ");
            }
        }
    }
 }
} 