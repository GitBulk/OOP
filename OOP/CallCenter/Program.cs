using System;
using System.Collections.Generic;
using System.Threading;

namespace OOP.CallCenter
{
    class Program
    {
        public static void Excute()
        {
            List<Call> calls = new List<Call>();
            for (int i = 0; i < 10; i++)
            {
                calls.Add(new Call
                {
                    Customer = new Customer
                    {
                        PhoneNumber = Guid.NewGuid().ToString()
                    },
                    Handler = null
                });
            }

            CallHandler callHandler = new CallHandler();
            foreach (var item in calls)
            {
                callHandler.DispatchCall(item);
                Thread.Sleep(600);
            }

        }
    }
}
