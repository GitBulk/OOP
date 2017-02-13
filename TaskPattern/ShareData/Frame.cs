using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPattern.ShareData
{
    class Frame
    {
        public static void Run()
        {
            object lockObject = new object();
            var bankAccount = new BankAccount();
            List<Task> taks = new List<Task>();
            for (int i = 0; i < 5; i++)
            {
                taks.Add(Task.Factory.StartNew(() =>
                {
                    for (int j = 0; j < 1000; j++)
                    {
                        bankAccount.Balance = bankAccount.Balance + 1;

                        //lock (lockObject)
                        //{
                        //    bankAccount.Balance = bankAccount.Balance + 1;
                        //}
                    }
                }));
            }
            Task.WaitAll(taks.ToArray());
            Console.WriteLine("Expected value 5000, actual value " + bankAccount.Balance);
        }

        class BankAccount
        {
            public int Balance { get; set; }
        }
    }
}
