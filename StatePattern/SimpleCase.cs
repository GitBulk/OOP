using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class SimpleCase
    {
        void ProcessOrder(string state)
        {
            switch (state)
            {
                case "Inserted":
                    // do insert order
                    break;
                case "Rejected":
                    // do reject order
                    break;
                case "Resolved":
                    // do resolve orde
                    break;
            }
        }
    }
}
