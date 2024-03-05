namespace hw3{

    class IntGenerator : IGenerator<int>
{
    
    private static readonly Random rnd = new Random();

    public int GenerateRandom(){
         return rnd.Next(0, 100);
    }
}
}