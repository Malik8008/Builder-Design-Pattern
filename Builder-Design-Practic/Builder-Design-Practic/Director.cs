using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_Design_Practic
{
    internal class Director
    {
        IBuilderable builder;

        public void Construct(IBuilderable Builder)
        {
            builder = Builder;
            builder.StartUpOperations();
            builder.BuildBody();
            builder.InsertWhile();
            builder.AddHeadlights();
            builder.EndOperations();          
        }
    }
}
