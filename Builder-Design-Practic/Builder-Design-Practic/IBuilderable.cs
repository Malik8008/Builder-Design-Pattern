using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Design_Practic
{
    internal interface IBuilderable
    {
        public void StartUpOperations();
        public void BuildBody();
        public void InsertWhile();
        public void AddHeadlights();
        public void EndOperations();

        Product GetVehicle();
    }
}
