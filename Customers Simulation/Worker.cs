using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers_Simulation
{
    class Worker
    {
        public int Finished;

        public Worker()
        {
            Finished = 0;
        }

        public void Work(int Started,int ServiceTime){
            Finished = Started + ServiceTime;
        }

        public bool isBusy(int Arrival)
        {
            if (Arrival<Finished)return true ;
            return false;
        }
    }
}
