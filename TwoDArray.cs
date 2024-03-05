using System.Runtime.CompilerServices;

namespace hw3{

    public sealed class TwoDimensionalArray<T> : BaseArray {

        private T[,]  _arr2;
        private IGenerator<T> _Generator;
        public TwoDimensionalArray(IGenerator<T> ElementGenerator, T[,] array, int rows, int columns, bool userFilled = false){
            _arr2 = array;

            _arr2 = new T[rows, columns];
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
        Console.WriteLine($"Введите элементы массива через пробел ({typeof(T)})");
            string input = Console.ReadLine();
            string[] ArrayInput = input.Split();
            for (int j = 0; j < _arr2.GetLength(1); j++){
        
                Console.Write($"Введите числа с индексами [{i},{j}]: ");
                T ChangeInput = (T) Convert.ChangeType(ArrayInput[ j], typeof(T));
                 _arr2[i, j] = ChangeInput;
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