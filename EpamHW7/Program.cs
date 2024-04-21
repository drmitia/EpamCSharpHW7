namespace EpamHW7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Automobile[] automobiles =
            {
                new Car ("car1", 200, 4),
                new Vehicle ("vehicle1", 150, 5)
            };
            Console.WriteLine("має бiльшу швидкiсть -->");


            automobiles[0].CompareSpeed(automobiles[1]).ShowMoreInfo();
            //FindMaxSpeed(automobiles).ShowMoreInfo(); //2 спосіб 
        }
               
        /*static Automobile FindMaxSpeed(Automobile[] array) // 2спосіб
        {
            Automobile max = array[0];
            for (int i = 1; i < array.Length; i++)
                {
                    if (array[i].MaxSpeed >= max.MaxSpeed)
                    {
                        max = array[i];
                    }
                }
            return max;
        }*/
    }
}