using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Design_Practic
{
    internal class MotoByker:IBuilderable
    {
        public string BrandName;
        private Product product;


        public MotoByker(string name)
        {
            product = new Product();
            BrandName = name;
        }

        public void AddHeadlights()
        {
            product.Add("1 headlight is added");
        }

        public void BuildBody()
        {
            product.Add("Enginee is ready");
        }

        public void EndOperations()
        {
            Console.WriteLine("MotoByke completed");
        }

        public Product GetVehicle()
        {
            return product;
        }

        public void InsertWhile()
        {
            product.Add("2 whiles are added");
        }

        public void StartUpOperations()
        {
            product.Add(string.Format($"MotorName:{BrandName}"));
        }
    }
}
