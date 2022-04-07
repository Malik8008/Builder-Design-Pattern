using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Design_Practic
{
    internal class Car:IBuilderable
    {
        public string BrandName;
        private Product product;
        public Car(string brand)
        {
            product = new Product();
            BrandName = brand;
        }

        public void AddHeadlights()
        {
            product.Add("2 headlights are added");
        }

        public void BuildBody()
        {
            product.Add("Korpusun yigilmasi");
        }

        public void EndOperations()
        {
            Console.WriteLine("Process Finished");
        }

        public Product GetVehicle()
        {
            return product;
        }

        public void InsertWhile()
        {
            product.Add("4 wheels are added");
        }

        public void StartUpOperations()
        {
            product.Add(string.Format($"Car Model Brand:{BrandName}"));
        }
    }
}
