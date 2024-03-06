namespace hw3{
    class StringGenerator: IGenerator<string>
    {

        int num_letters = int.TryParse(Console.ReadLine());
          int num_words = int.TryParse(Console.ReadLine());

    
      char[] letters = "ёйцукенгшщзхъфывапролджэячсмитьбю".ToCharArray();
         private static readonly Random _rnd = new Random();
          public string GenerateRandom(){


            Random rand = new Random();

    
    for (int i = 1; i <= num_words; i++)
    {
        
        string word = "";
        for (int j = 1; j <= num_letters; j++)
        {
           
            int letter_num = rand.Next(0, letters.Length - 1);

            
            word += letters[letter_num];
        }
            
          }
    }
}
}