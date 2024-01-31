namespace hw3{

public sealed class JuggedArray : Array {

     private int[][] _arr3;
        public JuggedArray(int[][] array){
            _arr3 = array;
        }
    public override double Average(){
        int sum = 0;
        int count = 0;
        for (int i = 0; i < _arr3.Length; i++)
        {
            for (int j = 0; j < _arr3[i].Length; j++)
            {
                sum += _arr3[i][j];
                count++;
            }
        }
        return sum/count;
    }

    public override void PrintArray(){
        Console.WriteLine("Зубчатый массив:");
        for (int i = 0; i < _arr3.Length; i++)
        {
            for (int j = 0; j < _arr3[i].Length; j++)
            {
                Console.Write(_arr3[i][j] + " ");
            }
            Console.WriteLine();
    }

  }
 }
}