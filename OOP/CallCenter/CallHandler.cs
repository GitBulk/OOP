using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP.CallCenter
{
    class CallHandler
    {
        static List<Employee> Employees = new List<Employee>();
        static Queue<Call> QueueCalls = new Queue<Call>();
        static Queue<Employee> BusyEmps = new Queue<Employee>();
        static CallHandler()
        {
            // fresher
            for (int i = 0; i < 3; i++)
            {
                Employees.Add(new Fresher
                {
                    Id = Guid.NewGuid(),
                    Free = true,
                    FullName = "Fresher " + i
                });
            }

            // tech lead
            Employees.Add(new TechLead
            {
                FullName = "Techlead 0",
                Free = true,
                Id = Guid.NewGuid()
            });

            Employees.Add(new TechLead
            {
                FullName = "Techlead 1",
                Free = true,
                Id = Guid.NewGuid()
            });

            // PM
            Employees.Add(new ProjectManager
            {
                FullName = "PM 0",
                Free = true,
                Id = Guid.NewGuid()
            });
        }

        public void DispatchCall(Call call)
        {
            Employee handler = GetHandler();

            if (handler == null)
            {
                Console.WriteLine("Please wait");
                QueueCalls.Enqueue(call);
            }
            else
            {
                Console.WriteLine($"{handler.Id} - {handler.FullName} accepts this call at {DateTime.Now.ToLongTimeString()}");
                call.Handler = handler;
                call.Handler.Free = false;

                //Thread thread = new Thread(Talk);
                //thread.Start(handler);

                BusyEmps.Enqueue(call.Handler);
                //Thread thred = new Thread(() =>
                //{
                //    Thread.Sleep(5000);
                    
                //    BusyEmps.Dequeue();
                //});
                Thread thread = new Thread(Talk);
                thread.Start(handler);
            }
        }

        private static void Talk(object handler)
        {
            var emp = handler as Employee;
            //Thread.Sleep(5000);
            Thread.Sleep(5000);
            BusyEmps.Dequeue();
            emp.Free = true;
        }

        private static Employee GetHandler()
        {
            var ranks = Enum.GetValues(typeof(Rank));
            foreach (Rank rank in ranks)
            {
                var empsOfLevel = GetFreeEmployeeOfLevel(rank);
                //foreach (var emp in empsOfLevel)
                //{
                //    if (emp.Free)
                //    {
                //        return emp;
                //    }
                //}
                if (empsOfLevel != null && empsOfLevel.Count() > 0)
                {
                    return empsOfLevel.ElementAt(0);
                }
            }
            return null;
        }

        private static IEnumerable<Employee> GetFreeEmployeeOfLevel(Rank rank)
        {
            return Employees.Where(e => e.Rank == rank && e.Free);
        }
    }
}
