namespace hw3{

    public sealed class TwoDimensionalArray : Array {

         private int[,] _arr2;
        public TwoDimensionalArray(int[,] array, int rows, int columns, bool userFilled = false){
            _arr2 = array;

            _arr2 = new int[rows, columns];
        if (userFilled)
        {
            FillArrayByUser();
        }
        else
        {
            FillRandomly();
        }
    }
    public override void FillArrayByUser()
    {
        for (int i = 0; i < _arr2.GetLength(0); i++)
        {
            for (int j = 0; j < _arr2.GetLength(1); j++)
            {
                Console.Write($"Введите числа с индексами [{i},{j}]: ");
                _arr2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

    public override void FillRandomly()
    {
        Random rnd = new Random();
        for (int i = 0; i < _arr2.GetLength(0); i++)
        {
            for (int j = 0; j < _arr2.GetLength(1); j++)
            {
                _arr2[i, j] = rnd.Next(1, 100);
            }
        }
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

     

    public override void Print(){
        Console.WriteLine("Массив:");
        for(int i = 0; i < _arr2.GetLength(0); i++){
            for(int j = 0; j < _arr2.GetLength(1); j++)
            {
                Console.WriteLine(_arr2[i, j] + " ");
            }
        }
    }
    }
}