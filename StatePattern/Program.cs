using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample1.Program.Excute();
        }
    }

    abstract class AA
    {
        protected abstract void Do();
    }


    enum GameActionState
    {
        Explore, Found, Kill
    }

    interface IGameActionState
    {
        void Update(GameObject gameObject);
        void Excute();
    }

    class ExploringState : IGameActionState
    {
        public void Excute()
        {
            Console.WriteLine("Explore");
        }

        public void Update(GameObject gameObject)
        {
            gameObject.State = new FoundState();
        }
    }

    class FoundState : IGameActionState
    {
        public void Excute()
        {
            Console.WriteLine("Found enemy");
        }

        public void Update(GameObject gameObject)
        {
            gameObject.State = new KillState();
        }
    }

    class KillState : IGameActionState
    {
        public void Excute()
        {
            Console.WriteLine("Kill enemy");
        }

        public void Update(GameObject gameObject)
        {
            gameObject.State = new ExploringState();
        }
    }

    class GameObject
    {
        public IGameActionState State { get; set; }
        public GameObject()
        {
            this.State = new ExploringState();
        }

        public void Excute()
        {
            this.State.Excute();
        }

        public void Update()
        {
            this.State.Update(this);
        }

    }
}
