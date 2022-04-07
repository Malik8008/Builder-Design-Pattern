using System;
using System.Collections.Generic;

namespace Builder_Design_Practic
{
    public class Product
    {
        private List<string> parts;

        public Product()
        {
            parts = new List<string>();
        }
        public void Add(string part)
        {
            parts.Add(part);    
        }

        public void ShowInfo()
        {
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
        }
    }
}