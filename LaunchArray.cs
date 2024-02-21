namespace hw3
{

    interface IPrint{

        public void Print();

    }

    interface IArray{
         public double Average();
         public void FillArrayByUser();
         public void FillRandomly();

         public void Print();

    }


    public abstract class BaseArray : IPrint, IArray
    {
        public abstract void Print();
         public abstract  double Average();
         public abstract void FillArrayByUser();
         public abstract void FillRandomly();
    }
}