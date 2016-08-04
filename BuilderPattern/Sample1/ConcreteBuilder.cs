using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Sample1
{
    class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();
        public void BuildPart1()
        {
            product.Part1 = "Part 1";
        }

        public void BuildPart2()
        {
            product.Part1 = "Part 2";
        }

        public void BuildPart3()
        {
            product.Part1 = "Part 3";
        }

        public Product GetProduct()
        {
            return product;
        }
    }
}
