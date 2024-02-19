namespace hw3{

    public sealed class WeekArray : Array {

         private string[] days;
        public WeekArray(string[] days){
           
            private static string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

    public override void Print()
     {
        Console.WriteLine("Дни недели:");
        foreach (string el in days)
        {
            Console.WriteLine(el);
        }
     }
   }
 }
}