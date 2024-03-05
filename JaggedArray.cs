namespace hw3{

public sealed class JuggedArray<T> : BaseArray {

     private int[][] _arr3;
        public JuggedArray(int[][] array, int rows, int cols, bool userFilled = false){
            _arr3 = array;

             _arr3 = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            _arr3[i] = new int[cols];
        }
        if (userFilled)
        {
            FillArrayByUser();
        }
        else
        {
            FillRandomly();
        }
    }

    public override void FillRandomly()
    {
        Random random = new Random();
        for (int i = 0; i < _arr3.Length; i++)
        {
            for (int j = 0; j < _arr3[i].Length; j++)
            {
                _arr3[i][j] = random.Next(100);
            }
        }
    }

    public override  void FillArrayByUser()
    {
        for (int i = 0; i < _arr3.Length; i++)
        {
            Console.WriteLine($"Введите {_arr3[i].Length} элемента для строки {i + 1}:");
            for (int j = 0; j < _arr3[i].Length; j++)
            {
                _arr3[i][j] = int.Parse(Console.ReadLine());
            }
        }
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

    public override void Print(){
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