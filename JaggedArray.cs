namespace hw3{

public sealed class JuggedArray<T> : BaseArray {

     private T[][] _arr3;
     private IGenerator<T> _Generator;
        public JuggedArray(IGenerator<T> ElementGenerator, T[][] array, int rows, int cols, bool userFilled = false){
            _arr3 = array;

             _arr3 = new T[rows][];
        for (int i = 0; i < rows; i++)
        {
            _arr3[i] = new T[cols];
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
                _arr3[i][j] = _Generator.GenerateRandom();
            }
        }
    }

    public override  void FillArrayByUser()
    {
        for (int i = 0; i < _arr3.Length; i++)
        {

             Console.WriteLine("Введите размер массива");
            int size = int.Parse(Console.ReadLine());
            _arr3[i] = new T[size];
            
            Console.WriteLine($"Введите элементы массива через пробел ( {typeof(T)})");
           string input = Console.ReadLine();
            string[] ArrayInput = input.Split();
            for (int j = 0; j < _arr3[i].Length; j++)
            {
                T inputToType = (T)Convert.ChangeType(ArrayInput[j], typeof(T));
                _arr3[i][j] = inputToType;
            }
         }
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