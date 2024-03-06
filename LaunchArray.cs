namespace hw3
{

    interface IGenerator< out T>
    {
         T GenerateRandom();
    }
    
    interface IPrint{

        public void Print();

    }

    interface IArray{
         
         public void FillArrayByUser();
         public void FillRandomly();


    }


    public abstract class BaseArray : IPrint, IArray
    {
        public abstract void Print();
         public abstract void FillArrayByUser();
         public abstract void FillRandomly();
    }
}