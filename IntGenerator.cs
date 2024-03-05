namespace hw3{
    class BoolGenerator: IGenerator<bool>
    {
         private static Random rnd = new Random();
          public bool GenerateRandom()
          {
            bool input = false;
            int n = rnd.Next(0, 2);
            if (n == 1)
            {
                input = true;
            }
        return input;
          }
    }
}