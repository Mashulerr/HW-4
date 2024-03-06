namespace hw3{

    public sealed class OneDimensionalArray<T> : BaseArray {

        private T[] _arr1;
        private IGenerator<T> _Generator;
        public OneDimensionalArray(IGenerator<T> ElementGenerator,T[] array, int length, bool userFilled = false){
            _arr1 = array;
            
            _arr1 = new T[length];
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
         Console.WriteLine($"Введите элементы массива через пробел ( {typeof(T)})");
        string input = Console.ReadLine();
        string[] ArrayInput = input.Split();
        for (int i = 0; i< ArrayInput.Length; i++)
        {
           T ChangeInput = (T)Convert.ChangeType(ArrayInput[i], typeof(T));
           _arr1[i] = ChangeInput;
        }
    }

    public override void FillRandomly()
    {

        for (int i = 0; i < _arr1.Length; i++)
        {
            _arr1[i] = IGenerator.GenerateRandom();
        }
    }


    public override void Print(){
        Console.WriteLine("Массив:");
        for (int i = 0; i < _arr1.Length; i++)
        {
            Console.WriteLine(_arr1[i]);
        }
    }

      
    }
}