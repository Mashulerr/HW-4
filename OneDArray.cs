namespace hw3{

    public sealed class OneDimensionalArray : Array {

        private int[] _arr1;
        public OneDimensionalArray(int[] array){
            _arr1 = array;

        }
        public override double Average()
        {double sum = 0;
        for (int i = 0; i < _arr1.Length; i++)
        {
            sum += _arr1[i];
        }
        return sum / _arr1.Length;
    }  
 
        public override void PrintArray(){
        
        Console.WriteLine("Массив:");
        for (int i = 0; i < _arr1.Length; i++)
        {
            Console.WriteLine(_arr1[i]);
        }
    }
}       
}