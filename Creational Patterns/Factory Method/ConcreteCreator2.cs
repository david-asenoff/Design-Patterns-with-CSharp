using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_Method
{
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
