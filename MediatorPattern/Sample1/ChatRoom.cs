using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern.Sample1
{
    class ChatRoom : IMediator
    {
        private List<User> users = new List<User>();
        public List<User> User
        {
            get
            {
                return users;
            }
        }

        public void DistributeMessage(User sender, string message)
        {
            foreach (var user in this.users)
            {
                if (user != sender)
                {
                    user.ReceiveMessage(message);
                }
            }
        }

        public void Register(User user)
        {
            this.users.Add(user);
        }
    }

    class ConcreteBuilder : IBuilder
    {
        private Product product = new Product();
        public void BuildPart1()
        {
            product.Part1 = "Part 1";
        }

        public void BuildPart2()
        {
            product.Part2 = "Part 2";
        }

        public void BuildPart3()
        {
            product.Part3 = "Part 3";
        }

        public Product GetProduct()
        {
            return product;
        }
    }
}
