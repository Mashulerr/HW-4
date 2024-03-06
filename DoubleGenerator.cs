namespace hw3{
    class DoubleGenerator: IGenerator<double>
    {
         private static readonly Random rnd = new Random();
          public double GenerateRandom(){
            return rnd.Next();

          }
    }
}