using System;

namespace Builder_Design_Practic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            IBuilderable carBuilder = new Car("BMW");            
            IBuilderable motoBuilder = new MotoByker("Ducatti");

            Console.WriteLine("Masinin butun hisselerinin yigilmasi ucun muraciet:\n");
            director.Construct(carBuilder);
            Product carproduct = carBuilder.GetVehicle();
            carproduct.ShowInfo();

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Motoskiletin texniki baxisdan kecib yigilmasi:\n");
            Console.WriteLine("");
            director.Construct(motoBuilder);
            Product motoProduct = motoBuilder.GetVehicle();
            motoProduct.ShowInfo();
        }
    }
}
